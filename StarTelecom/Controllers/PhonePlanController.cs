using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.ResponseDtos;

namespace StarTelecom.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class PhonePlanController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public PhonePlanController(IServiceManager serviceManager) => _serviceManager = serviceManager;

        /// <summary>
        /// Gets all phone plans in the database
        /// </summary>
        /// <returns>A list of all the phone plans</returns>
        /// <response code="200">Returns a list of phone plans</response>
        [HttpGet]
        [ProducesResponseType(200)]
        public async Task<IEnumerable<PhonePlanResponseDto>> GetPhonePlans()
        {
            var phonePlans = await _serviceManager.PhonePlan.GetPhonePlans(trackChanges: false);
            return phonePlans;
        }

        /// <summary>
        /// Gets a single phone plan using the phone plan's id
        /// </summary>
        /// <param name="id">GUID that identifies the phone plan record</param>
        /// <returns>A single phone plan object</returns>
        /// <response code="200">Returns the phone plan object</response>
        /// <response code="404">If the phone plan object is not found</response>
        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<PhonePlanResponseDto> GetPhonePlan(Guid id)
        {
            var phonePlan = await _serviceManager.PhonePlan.GetPhonePlan(id, trackChanges: false);
            return phonePlan;
        }
    }
}