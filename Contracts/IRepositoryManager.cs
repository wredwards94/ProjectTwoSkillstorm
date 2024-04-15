namespace Contracts;

public interface IRepositoryManager
{
    IDeviceRepository Device { get; }
    IPhonePlanRepository PhonePlan { get; }
    IUserDeviceRepository UserDevice { get; }
    IUserPlanRepository UserPlan { get; }
    IUserRepository User { get; }
    Task SaveAsync();
}