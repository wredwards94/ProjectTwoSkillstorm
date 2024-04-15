using Microsoft.AspNetCore.Identity;
using Shared;
using Shared.AuthenticationDtos;

namespace Service.Contracts;

public interface IAuthenticationService
{
    Task<IdentityResult> RegisterUser(UserRegistrationDto userForRegistration);
    Task<bool> ValidateUser(UserAuthenticationDto userForAuthentication);
    Task<TokenDto> CreateToken(UserAuthenticationDto userForAuthentication, bool populateExp);
    // Task<TokenDto> RefreshToken(TokenDto tokenDto);
}