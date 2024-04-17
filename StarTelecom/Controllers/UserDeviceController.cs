using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.CreationDtos;
using Shared.ResponseDtos;
using Shared.UpdateDtos;

namespace StarTelecom.Controllers
{
    [ApiController]
    [Route("user/{userId}/[controller]")]
    [Produces("application/json")]
    [Authorize]
    public class UserDeviceController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public UserDeviceController(IServiceManager serviceManager) => _serviceManager = serviceManager;

        /// <summary>
        /// Gets all user devices for the specified user plan in the database
        /// </summary>
        /// <returns>A list of all the user devices</returns>
        /// <response code="200">Returns a list of user devices</response>
        /// <response code="404">If the user is not found</response>
        [HttpGet("plan/{userPlanId:guid}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<IEnumerable<UserDeviceResponseDto>> GetUserPlanDevicesByUserPlanId(string userId,
            Guid userPlanId) =>
            await _serviceManager.UserDevice.GetUserDevicesByUserPlanId(userId, userPlanId, trackChanges: false);

        /// <summary>
        /// Gets all user devices for the specified user in the database
        /// </summary>
        /// <returns>A list of all the user devices</returns>
        /// <response code="200">Returns a list of user devices</response>
        /// <response code="404">If the user is not found</response>
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<IEnumerable<UserDeviceResponseDto>> GetUserDevicesByUserId(string userId) =>
            await _serviceManager.UserDevice.GetUserDevicesByUserId(userId, trackChanges: false);

        /// <summary>
        /// Gets a single user device using the device's id
        /// </summary>
        /// <param name="userId">GUID that identifies the user record</param>
        /// <param name="userDeviceId">GUID that identifies the user device record</param>
        /// <returns>A single user device object</returns>
        /// <response code="200">Returns the device object</response>
        /// <response code="404">If the device object is not found</response>
        /// <response code="404">If the user is not found</response>
        /// <response code="404">If the user device is not found</response>
        [HttpGet("device/{userDeviceId:guid}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<UserDeviceResponseDto> GetUserDevice(string userId, Guid userDeviceId) =>
            await _serviceManager.UserDevice.GetUserDevice(userId, userDeviceId, trackChanges: false);

        /// <summary>
        /// Adds a new user device in the database
        /// </summary>
        /// <param name="planId">GUID that identifies the user plan record</param>
        /// <param name="deviceToAdd">A user device object containing user plan id and device id</param>
        /// <returns>The newly registered user device object</returns>
        /// <response code="201">Returns the newly registered user device object</response>
        /// <response code="404">If the device object is not found</response>
        /// <response code="404">If the user device is not found</response>
        [HttpPost("add/{planId:guid}")]
        [ProducesResponseType(201)]
        [ProducesResponseType(404)]
        // [ProducesResponseType(422)]
        public async Task<IActionResult> AddUserDevice(Guid planId, [FromBody] DeviceToAddDto deviceToAdd)
        {
            if (!ModelState.IsValid)
            {
                return UnprocessableEntity(ModelState);
            }

            var userDevice = await _serviceManager.UserDevice.AddUserDevice(planId, deviceToAdd, trackChanges: true);
            return Created("", userDevice);
        }
        /// <summary>
        /// Removes a single user device from their account
        /// </summary>
        /// <param name="userId">GUID that identifies the user record</param>
        /// <param name="userDeviceId">GUID that identifies the user device</param>
        /// <returns>No content</returns>
        /// <response code="204">Returns 204 status if successfully deleted</response>
        /// <response code="404">If the user is not found</response>
        /// <response code="404">If the user device is not found</response>
        [HttpDelete("delete/{userDeviceId:guid}")]
        public async Task<IActionResult> DeleteUserDevice(string userId, Guid userDeviceId)
        {
            await _serviceManager.UserDevice.DeleteUserDevice(userId, new UserDevice { Id = userDeviceId }, trackChanges: true);
            return NoContent();
        }

        /// <summary>
        /// Swaps the phone numbers of two user devices
        /// </summary>
        /// <param name="userId">GUID that identifies the user plan record</param>
        /// <param name="numSwapDtos">Array of two user device objects</param>
        /// <returns>List of user devices with updated phone numbers</returns>
        /// <response code="200">List of user devices with updated phone numbers</response>
        /// <response code="404">If the device object is not found</response>
        /// <response code="404">If the user device is not found</response>
        [HttpPut("swapphonenumbers")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<IEnumerable<UserDeviceResponseDto>> SwapPhoneNumbers(string userId, [FromBody] List<DevicePhoneNumSwapDto> numSwapDtos)
        {
            // if (!ModelState.IsValid)
            // {
            //     return UnprocessableEntity(ModelState);
            // }

            return await _serviceManager.UserDevice
                .SwapPhoneNumbers(userId, numSwapDtos, trackChanges: true);
        }
    }
}
