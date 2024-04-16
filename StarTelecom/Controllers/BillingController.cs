using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.ResponseDtos;

namespace StarTelecom.Controllers;

[Route("user/{userId}/[controller]")]
public class BillingController : ControllerBase
{
    private readonly IServiceManager _service;

    public BillingController(IServiceManager serviceManager) => _service = serviceManager;

    [HttpGet("{userPlanId:guid}")]
    public async Task<IEnumerable<BillingResponseDto>> GetUserPlanBills(string userId, Guid userPlanId)
    {
        return await _service.Billing.GetUserPlanBills(userId, userPlanId, trackChanges: false);
    }
}