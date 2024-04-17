using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.ResponseDtos;

namespace StarTelecom.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public UserController(IServiceManager serviceManager) => _serviceManager = serviceManager;

        /// <summary>
        /// Gets a single user using the user's id
        /// </summary>
        /// <param name="id">GUID that identifies the user record</param>
        /// <returns>A single user object</returns>
        /// <response code="200">Returns the user object</response>
        /// <response code="404">If the user object is not found</response>
        [HttpGet("{userId}", Name = "UserById")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<UserResponseDto> GetUser(string userId) => await _serviceManager.User.GetUser(userId, trackChanges: false);
    }
}
