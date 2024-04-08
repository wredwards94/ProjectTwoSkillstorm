using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace ProjectTwoGroup3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeviceController : ControllerBase
    {
        private readonly IDeviceService _deviceService;

        public DeviceController(IServiceManager serviceManager) => _deviceService = serviceManager.Device;

        [HttpGet]
        public async Task<IActionResult> GetAllDevices(bool trackChanges)
        {
            var devices = await _deviceService.GetAllDevices(trackChanges);

            return Ok(devices);
        }
    }
}
