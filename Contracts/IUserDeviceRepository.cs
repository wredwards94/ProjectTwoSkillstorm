using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Contracts
{
    public interface IUserDeviceRepository
    {
        Task<IEnumerable<UserDevice>> GetUserPlanDevicesByPlanId(Guid userPlanId, bool trackChanges);
        Task<IEnumerable<UserDevice>> GetUserDevicesByUserId(string userId, bool trackChanges);
        Task<UserDevice> GetUserDevice(Guid userDeviceId, bool trackChanges);
        void CreateUserDevice(UserDevice userDevice);
        void DeleteUserDevice(UserDevice userDevice);
        void UpdateUserDevice(UserDevice userDevice);
    }
}
