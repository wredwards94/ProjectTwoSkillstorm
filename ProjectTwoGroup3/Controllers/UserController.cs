using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace ProjectTwoGroup3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public UserController(IServiceManager serviceManager) => _serviceManager = serviceManager;

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUser(Guid userId, bool trackChanges) =>
            Ok(await _serviceManager.User.GetUser(userId, trackChanges: false));
    }
}
