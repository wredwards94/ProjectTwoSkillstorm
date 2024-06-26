﻿using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class DeviceRepository : RepositoryBase<Device>, IDeviceRepository
    {
        public DeviceRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Device>> GetAllDevices(bool trackChanges) => await FindAll(trackChanges)
            .OrderBy(d => d.Manufacturer).ToListAsync();

        public async Task<Device> GetDevice(Guid deviceId, bool trackChanges) =>
            await FindByCondition(d => d.Id.Equals(deviceId), trackChanges).SingleOrDefaultAsync();
    }
}
