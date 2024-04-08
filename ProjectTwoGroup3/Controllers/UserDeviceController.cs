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
    }
}
