using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Service.Contracts;
using Shared.AuthenticationDtos;

namespace ProjectTwoGroup3.Controllers
{
    public class AuthenticationController : ControllerBase
    {
        private readonly IServiceManager _service;

        public AuthenticationController(IServiceManager serviceManager) => _service = serviceManager;

        [HttpPost]
        public async Task<IActionResult> RegisterUser([FromBody] UserForRegistrationDto userForRegistration)
        {
            var result = await _service.Authentication.RegisterUser(userForRegistration);

            if (!result.Succeeded)
            {
                foreach(var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }
            return Created();
        }
        [HttpPost("login")]
        public async Task<IActionResult> Authenticate([FromBody] UserForAuthenticationDto userForAuthentication)
        {
            if(!await _service.Authentication.ValidateUser(userForAuthentication))
            {
                return Unauthorized();
            }
            return Ok(new { token = await _service.Authentication.CreateToken() });
        }
    }
}
