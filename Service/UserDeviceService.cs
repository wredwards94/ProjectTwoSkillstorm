using Contracts;
using Entities;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class UserDeviceService : IUserDeviceService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;

        public UserDeviceService(IRepositoryManager repositoryManager, ILoggerManager logger)
        {
            _repositoryManager = repositoryManager;
            _logger = logger;
        }

        public async Task<UserDevice> GetUserDevice(Guid userDeviceId, bool trackChanges)
        {
            UserDevice userDevice = await _repositoryManager.UserDevice.GetUserDevice(userDeviceId, trackChanges);
            return userDevice;
        }

        public async Task<IEnumerable<UserDevice>> GetUserPlanDevices(Guid userPlanId, bool trackChanges)
        {
            var userDevices = await _repositoryManager.UserDevice.GetUserPlanDevices(userPlanId, trackChanges);
            return userDevices;
        }
    }
}
