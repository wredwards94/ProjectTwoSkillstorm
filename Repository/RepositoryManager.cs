using Contracts;
using Entities;
using Microsoft.AspNetCore.Identity;

namespace Repository;

public class RepositoryManager : IRepositoryManager
{
    private readonly RepositoryContext _repositoryContext;
    private readonly Lazy<IDeviceRepository> _deviceRepository;
    private readonly Lazy<IPhonePlanRepository> _phonePlanRepository;
    private readonly Lazy<IUserDeviceRepository> _userDeviceRepository;
    private readonly Lazy<IUserPlanRepository> _userPlanRepository;
    private readonly Lazy<IUserRepository> _userRepository;
    private readonly Lazy<IBillingRepository> _billingRepository;

    public RepositoryManager(RepositoryContext repositoryContext)
    {
        _repositoryContext = repositoryContext;
        _deviceRepository = new Lazy<IDeviceRepository>(() => new DeviceRepository(_repositoryContext));
        _userRepository = new Lazy<IUserRepository>(() => new UserRepository(_repositoryContext));
        _phonePlanRepository = new Lazy<IPhonePlanRepository>(() => new PhonePlanRepository(_repositoryContext));
        _userDeviceRepository = new Lazy<IUserDeviceRepository>(() => new UserDeviceRepository(_repositoryContext));
        _userPlanRepository = new Lazy<IUserPlanRepository>(() => new UserPlanRepository(_repositoryContext));
        _billingRepository = new Lazy<IBillingRepository>(() => new BillingRepository(_repositoryContext));
    }
    
    public IDeviceRepository Device => _deviceRepository.Value;
    public IPhonePlanRepository PhonePlan => _phonePlanRepository.Value;
    public IUserRepository User => _userRepository.Value;
    public IUserDeviceRepository UserDevice => _userDeviceRepository.Value;
    public IUserPlanRepository UserPlan => _userPlanRepository.Value;
    public IBillingRepository Billing => _billingRepository.Value;
    public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
}