using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.ResponseDtos;

namespace StarTelecom.Controllers;

[ApiController]
[Route("user/{userId}/[controller]")]
[Produces("application/json")]
[Authorize]
public class BillingController : ControllerBase
{
    private readonly IServiceManager _service;

    public BillingController(IServiceManager serviceManager) => _service = serviceManager;

    [HttpGet("{userPlanId:guid}")]
    public async Task<IEnumerable<BillingResponseDto>> GetUserPlanBills(string userId, Guid userPlanId)
    {
        return await _service.Billing.GetUserPlanBills(userId, userPlanId, trackChanges: false);
    }
    
    [HttpGet("{userPlanId:guid}/{billId:guid}")]
    public async Task<BillingResponseDto> GetBillById(string userId, Guid userPlanId, Guid billId)
    {
        return await _service.Billing.GetUserPlanBillById(userId, userPlanId, billId, trackChanges: false);
    }
}