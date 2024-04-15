using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.ResponseDtos;

namespace StarTelecom.Controllers
{
    [ApiController]
    [Route("user/{userId}/[controller]")]
    [Produces("application/json")]
    [Authorize]
    public class UserPlanController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public UserPlanController(IServiceManager serviceManager) => _serviceManager = serviceManager;

        /// <summary>
        /// Gets all user devices for the specified user plan in the database
        /// </summary>
        /// <returns>A list of all the user plans</returns>
        /// <response code="200">Returns a list of user plans</response>
        /// <response code="404">If the user is not found</response>
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<IEnumerable<UserPlanResponseDto>> GetUserPlans(string userId)
        {
            var userPlans = await _serviceManager.UserPlan.GetUserPlans(userId, trackChanges: false);
            //return Ok(userPlans);
            return userPlans;
        }

        /// <summary>
        /// Gets a single user plan using the user plan's id
        /// </summary>
        /// <param name="userId">GUID that identifies the user record</param>
        /// <param name="userPlanId">GUID that identifies the user plan record</param>
        /// <returns>A single user plan object</returns>
        /// <response code="200">Returns the user plan object</response>
        /// <response code="404">If the user is not found</response>
        /// <response code="404">If the user plan is not found</response>
        [HttpGet("{userPlanId:guid}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<UserPlanResponseDto> GetUserPlan(string userId, Guid userPlanId)
        {
            return await _serviceManager.UserPlan.GetUserPlan(userId, userPlanId, trackChanges: false);
            //return Ok(userPlan);
            //return userPlan;
        }
        
        /// <summary>
        /// Adds a new user plan in the database
        /// </summary>
        /// <param name="userId">GUID that identifies the user record</param>
        /// <param name="planId">GUID that identifies the plan record</param>
        /// <returns>The newly registered user plan object</returns>
        /// <response code="201">Returns the newly registered user plan object</response>
        /// <response code="404">If the user is not found</response>
        /// <response code="404">If the plan is not found</response>
        [HttpPost("add/{planId:guid}")]
        public async Task<IActionResult> CreateUserPlan(string userId, Guid planId)
        {
            var userPlan = await _serviceManager.UserPlan.CreateUserPlan(userId, planId, trackChanges: true);
            return Created("", userPlan);
        }
        
        /// <summary>
        /// Deletes a single user plan and related user devices using the user plan's id
        /// </summary>
        /// <param name="userId">GUID that identifies the user record</param>
        /// <param name="userPlanId">GUID that identifies the user plan record</param>
        /// <returns>A single user plan object</returns>
        /// <response code="204">Returns 204 status if successfully deleted</response>
        /// <response code="404">If the user is not found</response>
        /// <response code="404">If the user plan is not found</response>
        [HttpDelete("delete/{userPlanId:guid}")]
        public async Task<IActionResult> DeleteUserPlan(string userId, Guid userPlanId)
        {
            await _serviceManager.UserPlan.DeleteUserPlan(userId, userPlanId, trackChanges: true);
            return NoContent();
        }
    }
}
