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
    }
}
