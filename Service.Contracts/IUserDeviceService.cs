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
        Task<IEnumerable<UserDevice>> GetUserPlanDevices(Guid userPlanId, bool trackChanges);
        Task<UserDevice> GetUserDevice(Guid userDeviceId, bool trackChanges);
    }
}
