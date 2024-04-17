using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.ResponseDtos;

namespace StarTelecom.Controllers;

[ApiController]
[Route("user/{userId}/[controller]/{userPlanId:guid}")]
[Produces("application/json")]
[Authorize]
public class BillingController : ControllerBase
{
    private readonly IServiceManager _service;

    public BillingController(IServiceManager serviceManager) => _service = serviceManager;

    /// <summary>
    /// Gets all bills for a user plan
    /// </summary>
    /// <param name="userId">GUID that identifies the device record</param>
    /// <param name="userPlanId">GUID that identifies the device record</param>
    /// <returns>An array of bill objects for the specified user plan</returns>
    /// <response code="200">Array of user plan bill objects</response>
    /// <response code="404">If the user is not found</response>
    [HttpGet]
    [ProducesResponseType(200)]
    [ProducesResponseType(404)]
    public async Task<IEnumerable<BillingResponseDto>> GetUserPlanBills(string userId, Guid userPlanId) => 
        await _service.Billing.GetUserPlanBills(userId, userPlanId, trackChanges: false);

    /// <summary>
    /// Gets a single bill for a user plan
    /// </summary>
    /// <param name="userId">GUID that identifies the device record</param>
    /// <param name="billId">GUID that identifies the bill record</param>
    /// <param name="userPlanId">GUID that identifies the device record</param>
    /// <returns>A single bill object for the specified user plan</returns>
    /// <response code="200">User plan bill object</response>
    /// <response code="404">If the user is not found</response>
    [HttpGet("{billId:guid}")]
    [ProducesResponseType(200)]
    [ProducesResponseType(404)]
    public async Task<BillingResponseDto> GetBillById(string userId, Guid userPlanId, Guid billId) => 
        await _service.Billing.GetUserPlanBillById(userId, userPlanId, billId, trackChanges: false);
}