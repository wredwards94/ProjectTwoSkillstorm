using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.ResponseDtos;

namespace StarTelecom.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class DeviceController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public DeviceController(IServiceManager serviceManager) => _serviceManager = serviceManager;

        /// <summary>
        /// Gets all devices in the database
        /// </summary>
        /// <returns>A list of all the devices</returns>
        /// <response code="200">Returns a list of devices</response>
        [HttpGet]
        [ProducesResponseType(200)]
        public async Task<IEnumerable<DeviceResponseDto>> GetAllDevices() => await _serviceManager.Device.GetAllDevices(trackChanges: false);

        /// <summary>
        /// Gets a single device using the device's id
        /// </summary>
        /// <param name="id">GUID that identifies the device record</param>
        /// <returns>A single device object</returns>
        /// <response code="200">Returns the device object</response>
        /// <response code="404">If the device object is not found</response>
        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<DeviceResponseDto> GetDevice(Guid id) => await _serviceManager.Device.GetDevice(id, trackChanges: false);
    }
}
