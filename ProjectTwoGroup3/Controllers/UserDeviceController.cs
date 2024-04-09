using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace ProjectTwoGroup3.Controllers
{
    [ApiController]
    [Route("user/{userId:guid}/[controller]")]
    public class UserDeviceController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public UserDeviceController(IServiceManager serviceManager) => _serviceManager = serviceManager;

        [HttpGet("plan/{userPlanId:guid}")]
        public async Task<IActionResult> GetUserPlanDevices(Guid userPlanId, bool trackChanges) =>
            Ok(await _serviceManager.UserDevice.GetUserPlanDevices(userPlanId, trackChanges));

        [HttpGet("device/{userDeviceId:guid}")]
        public async Task<IActionResult> GetUserDevice(Guid userDeviceId, bool trackChanges) =>
            Ok(await _serviceManager.UserDevice.GetUserDevice(userDeviceId, trackChanges));
    }
}
