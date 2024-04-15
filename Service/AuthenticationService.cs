using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Service.Contracts;
using Shared;
using System.IdentityModel.Tokens.Jwt;
using Entities.Exceptions;
using Microsoft.IdentityModel.Tokens;
using Shared.AuthenticationDtos;

namespace Service;

public class AuthenticationService : IAuthenticationService
{
    private readonly UserManager<User> _userManager;
    private readonly IOptions<JwtConfiguration> _configuration;
    private readonly JwtConfiguration _jwtConfiguration;
    private User? _user;

    public AuthenticationService(UserManager<User> userManager, IOptions<JwtConfiguration> config)
    {
        _userManager = userManager;
        _userManager = userManager;
        _configuration = config;
        _jwtConfiguration = config.Value;
    }


    public async Task<IdentityResult> RegisterUser(UserRegistrationDto userForRegistration)
    {
        
        var user = new User
        {
            UserName = userForRegistration.UserName,
            Email = userForRegistration.Email,
            FirstName = userForRegistration.FirstName,
            LastName = userForRegistration.LastName
        };
        
        var result = await _userManager.CreateAsync(user, userForRegistration.Password);

        if (result.Succeeded)
            await _userManager.AddToRolesAsync(user, ["User"]);

        return result;
    }
    
    public async Task<bool> ValidateUser(UserAuthenticationDto userForAuthentication)
    {
        _user = await _userManager.FindByNameAsync(userForAuthentication.UserName);
        var result = _user != null && await _userManager.CheckPasswordAsync(_user, userForAuthentication.Password);
        // if (!result)
        //     _logger.LogWarn($"{nameof(ValidateUser)}: Authentication failed. Wrong username or password.");

        return result;
    }

    public async Task<TokenDto> CreateToken(UserAuthenticationDto userForAuthentication, bool populateExp)
    {
        var signingCredentials = GetSigningCredentials();
        var claims = await GetClaims();
        var tokenOptions = GenerateTokenOptions(signingCredentials, claims);
        _user = await _userManager.FindByNameAsync(userForAuthentication.UserName);

        var refreshToken = GenerateRefreshToken();

        _user.RefreshToken = refreshToken;

        if (populateExp)
            _user.RefreshTokenExpiryTime = DateTime.Now.AddDays(1);

        await _userManager.UpdateAsync(_user);

        var accessToken = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

        return new TokenDto(_user.Id, accessToken, refreshToken);
    }

    // public async Task<TokenDto> RefreshToken(TokenDto tokenDto)
    // {
    //     var principal = GetPrincipalFromExpiredToken(tokenDto.AccessToken);
    //     var user = await _userManager.FindByNameAsync(principal.Identity.Name);
    //     if (user == null || user.RefreshToken != tokenDto.RefreshToken
    //                      || user.RefreshTokenExpiryTime <= DateTime.Now)
    //         throw new RefreshTokenBadRequest();
    //
    //     // _user = user;
    //     var userAuthDto = new UserAuthenticationDto
    //     {
    //         UserName = user.UserName,
    //         Password = user.PasswordHash
    //     };
    //     
    //     return await CreateToken(populateExp: false);
    // }
    
    private SigningCredentials GetSigningCredentials()
        {
            var key = Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("SECRET"));
            var secret = new SymmetricSecurityKey(key);

            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }

        private async Task<List<Claim>> GetClaims()
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, _user.UserName)
            };

            var roles = await _userManager.GetRolesAsync(_user);
            
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            return claims;
        }

        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {
            var tokenOptions = new JwtSecurityToken
            (
                issuer: _jwtConfiguration.ValidIssuer,
                audience: _jwtConfiguration.ValidAudience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(_jwtConfiguration.Expires)),
                signingCredentials: signingCredentials
            );

            return tokenOptions;
        }

        private string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }

        private ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
        {
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = true,
                ValidateIssuer = true,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("SECRET"))),
                ValidateLifetime = true,
                ValidIssuer = _jwtConfiguration.ValidIssuer,
                ValidAudience = _jwtConfiguration.ValidAudience,
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken;
            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out securityToken);

            var jwtSecurityToken = securityToken as JwtSecurityToken;
            if (jwtSecurityToken == null ||
                !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256,
                    StringComparison.InvariantCultureIgnoreCase))
            {
                throw new SecurityTokenException("Invalid token");
            }

            return principal;
        }
}