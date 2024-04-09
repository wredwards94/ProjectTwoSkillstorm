using Entities;
using Microsoft.AspNetCore.Mvc;
using Service;
using Service.Contracts;
using Shared.CreationDtos;

namespace ProjectTwoGroup3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public UserController(IServiceManager serviceManager) => _serviceManager = serviceManager;

        [HttpGet("{userId}", Name = "UserById")]
        public async Task<IActionResult> GetUser(Guid userId, bool trackChanges) =>
            Ok(await _serviceManager.User.GetUser(userId, trackChanges: false));

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] UserCreationDto user)
        {
            var createdUser = await _serviceManager.User.CreateUserAsync(user);
            return CreatedAtRoute("UserById", new { id = createdUser.Id }, createdUser);
        }

    }
}
