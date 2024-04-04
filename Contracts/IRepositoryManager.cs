using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManager
    {
        IDeviceRepository Device { get; }
        IPhonePlanRepository PhonePlan { get; }
        IUserDeviceRepository UserDevice { get; }
        IUserPlanRepository UserPlan { get; }
        IUserRepository User { get; }
        void Save();
        Task SaveAsync();
    }
}
