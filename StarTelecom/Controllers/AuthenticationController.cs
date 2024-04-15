using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared;
using Shared.AuthenticationDtos;

namespace StarTelecom.Controllers;

[ApiController]
[Route("/api/[controller]")]
[Produces("application/json")]
public class AuthenticationController : ControllerBase
{
    private readonly IServiceManager _service;

    public AuthenticationController(IServiceManager serviceManager) => _service = serviceManager;

    [HttpPost("register")]
    public async Task<IActionResult> RegisterUser([FromBody] UserRegistrationDto userForRegistration)
    {
        var result = await _service.Authentication.RegisterUser(userForRegistration);
            
        if (!result.Succeeded)
        {
            foreach (var error in result.Errors)
            {
                ModelState.TryAddModelError(error.Code, error.Description);
            }
            return BadRequest(ModelState);
        }
        return Created();
    }
    
    [HttpPost("login")]
    public async Task<IActionResult> Authenticate([FromBody] UserAuthenticationDto userForAuthentication)
    {
        if (!await _service.Authentication.ValidateUser(userForAuthentication))
        {
            return Unauthorized();
        }

        var tokenDto = await _service.Authentication.CreateToken(userForAuthentication, populateExp: true);
            
        return Ok(tokenDto);
    }
}