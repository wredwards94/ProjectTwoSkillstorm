using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IServiceManager
    {
        IDeviceService Device { get; }
        IPhonePlanService PhonePlan { get; }
        IUserDeviceService UserDevice { get; }
        IUserService User { get; }
        IUserPlanService UserPlan { get; }
    }
}
