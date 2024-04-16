namespace Service.Contracts;

public interface IServiceManager
{
    IDeviceService Device { get; }
    IPhonePlanService PhonePlan { get; }
    IUserDeviceService UserDevice { get; }
    IUserService User { get; }
    IUserPlanService UserPlan { get; }
    IBillingService Billing { get; }
    IAuthenticationService Authentication { get; }
}
