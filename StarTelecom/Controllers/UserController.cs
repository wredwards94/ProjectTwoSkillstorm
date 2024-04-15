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
        public async Task<UserResponseDto> GetUser(string userId)
        {
            //var user = await _serviceManager.User.GetUser(userId, trackChanges: false);
            return await _serviceManager.User.GetUser(userId, trackChanges: false);
            //return Ok(user);
            //return user;
        }
        //
        // /// <summary>
        // /// Registers a new user in the database
        // /// </summary>
        // /// <param name="user">An object containing firstMidName, lastName, email, username, and password</param>
        // /// <returns>The newly registered user object</returns>
        // /// <response code="201">Returns the newly registered user object</response>
        // /// <response code="400">If the user object is null</response>
        // [HttpPost]
        // [ProducesResponseType(201)]
        // [ProducesResponseType(400)]
        // public async Task<IActionResult> CreateUser([FromBody] UserForRegistrationDto? user)
        // {
        //     if (user == null) return BadRequest("UserForRegistration object is null");
        //     
        //     var createdUser = await _serviceManager.User.CreateUser(user);
        //     // return CreatedAtRoute("UserById", new { id = createdUser.Id }, createdUser);
        //     return Created();
        // }

        //[HttpPut("{userId}/phoneplan/{planId:guid}")]
        //public async Task<IActionResult> AddPhonePlanToUser(Guid userId, [FromBody] PhonePlan phonePlan, bool trackChanges)
        //{
        //    var user = await _serviceManager.User.AddPhonePlanToUser(userId, phonePlan, trackChanges: true);
        //    return Ok(user);
        //}

    }
}
