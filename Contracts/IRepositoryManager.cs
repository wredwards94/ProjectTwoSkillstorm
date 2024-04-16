using Entities;
using Microsoft.AspNetCore.Identity;

namespace Contracts;

public interface IRepositoryManager
{
    IDeviceRepository Device { get; }
    IPhonePlanRepository PhonePlan { get; }
    IUserDeviceRepository UserDevice { get; }
    IUserPlanRepository UserPlan { get; }
    IUserRepository User { get; }
    IBillingRepository Billing { get; }
    Task SaveAsync();
}