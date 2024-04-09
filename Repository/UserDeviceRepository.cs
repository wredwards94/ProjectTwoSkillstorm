using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class UserDeviceRepository : RepositoryBase<UserDevice>, IUserDeviceRepository
    {
        public UserDeviceRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        { }

        public async Task<UserDevice> GetUserDevice(Guid userDeviceId, bool trackChanges) =>
            await FindByCondition(ud => ud.Id.Equals(userDeviceId), trackChanges).SingleOrDefaultAsync();

        public async Task<IEnumerable<UserDevice>> GetUserPlanDevices(Guid userPlanId, bool trackChanges) =>
            await FindByCondition(ud => ud.UserPlanID.Equals(userPlanId), trackChanges).ToListAsync();
    }

}
