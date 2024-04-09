﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Contracts
{
    public interface IUserDeviceRepository
    {
        Task<IEnumerable<UserDevice>> GetUserPlanDevices(Guid userPlanId, bool trackChanges);
        Task<UserDevice> GetUserDevice(Guid userDeviceId, bool trackChanges);
    }
}
