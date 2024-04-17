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
        public UserDeviceRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }

        public void CreateUserDevice(UserDevice userDevice) => Create(userDevice);

        public void DeleteUserDevice(UserDevice userDevice) => Delete(userDevice);

        public async Task<UserDevice> GetUserDevice(Guid userDeviceId, bool trackChanges) =>
            await FindByCondition(ud => ud.Id.Equals(userDeviceId), trackChanges).SingleOrDefaultAsync();

        public async Task<IEnumerable<UserDevice>> GetUserPlanDevicesByPlanId(Guid userPlanId, bool trackChanges) =>
            await FindByCondition(ud => ud.UserPlanId.Equals(userPlanId), trackChanges).ToListAsync();
        
       public async Task<IEnumerable<UserDevice>> GetUserDevicesByUserId(string userId, bool trackChanges) =>
            await FindByCondition(ud => ud.UserId.Equals(userId), trackChanges).ToListAsync();
        
        public void UpdateUserDevice(UserDevice userDevice) => Update(userDevice);
    }

}
