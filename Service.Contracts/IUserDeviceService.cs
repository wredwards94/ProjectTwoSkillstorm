using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Service.Contracts
{
    public interface IUserDeviceService
    {
        Task<IEnumerable<UserDevice>> GetUserPlanDevices(string userId, Guid userPlanId, bool trackChanges);
        Task<UserDevice> GetUserDevice(string userId, Guid userDeviceId, bool trackChanges);

        Task<UserDevice> AddUserDevice(Guid planId, Guid deviceId, bool trackChanges);
        Task<UserDevice[]> SwapPhoneNumbers(Guid planId, Guid userDeviceId1, Guid userDeviceId2, bool trackChanges);
    }
}
