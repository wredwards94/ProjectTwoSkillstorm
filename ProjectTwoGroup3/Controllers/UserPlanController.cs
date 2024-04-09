using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace ProjectTwoGroup3.Controllers
{
    [ApiController]
    [Route("user/{userId:guid}/[controller]")]
    public class UserPlanController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public UserPlanController(IServiceManager serviceManager) => _serviceManager = serviceManager;

        [HttpGet]
        public async Task<IActionResult> GetUserPlans(Guid userId, bool trackChanges)
        {
            var userPlans = await _serviceManager.UserPlan.GetUserPlans(userId, trackChanges: false);
            return Ok(userPlans);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetUserPlan(Guid userId, Guid id, bool trackChanges)
        {
            var userPlan = await _serviceManager.UserPlan.GetUserPlan(userId, id, trackChanges: false);
            return Ok(userPlan);
        }
    }
}
