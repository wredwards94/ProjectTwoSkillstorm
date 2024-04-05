using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;

namespace Repository
{
    public class RepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;

        private readonly Lazy<IDeviceRepository> _deviceRepository;
        private readonly Lazy<IPhonePlanRepository> _phonePlanRepository;
        private readonly Lazy<IUserRepository> _userRepository;
        private readonly Lazy<IUserDeviceRepository> _userDeviceRepository;
        private readonly Lazy<IUserPlanRepository> _userPlanRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _deviceRepository = new Lazy<IDeviceRepository>(() => new DeviceRepository(_repositoryContext));
            _phonePlanRepository = new Lazy<IPhonePlanRepository>(() => new PhonePlanRepository(_repositoryContext));
            _userRepository = new Lazy<IUserRepository>(() => new UserRepository(_repositoryContext));
            _userDeviceRepository = new Lazy<IUserDeviceRepository>(() => new UserDeviceRepository(_repositoryContext));
            _userPlanRepository = new Lazy<IUserPlanRepository>(() => new UserPlanRepository(_repositoryContext));
        }

        public IDeviceRepository Device => _deviceRepository.Value;
        public IPhonePlanRepository PhonePlan => _phonePlanRepository.Value;
        public IUserRepository User => _userRepository.Value;
        public IUserDeviceRepository UserDevice => _userDeviceRepository.Value;
        public IUserPlanRepository UserPlan => _userPlanRepository.Value;

        public void Save() => _repositoryContext.SaveChanges();

        public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();

    }
}
