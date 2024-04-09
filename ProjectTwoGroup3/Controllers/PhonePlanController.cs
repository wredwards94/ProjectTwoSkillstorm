using Entities;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace ProjectTwoGroup3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PhonePlanController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public PhonePlanController(IServiceManager serviceManager) => _serviceManager = serviceManager;

        [HttpGet]
        public async Task<IEnumerable<PhonePlan>> GetPhonePlans()
        {
            var phonePlans = await _serviceManager.PhonePlan.GetPhonePlans(trackChanges: false);
            return phonePlans;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPhonePlan(Guid id)
        {
            var phonePlan = await _serviceManager.PhonePlan.GetPhonePlan(id, trackChanges: false);
            return Ok(phonePlan);
        }
    }
}
