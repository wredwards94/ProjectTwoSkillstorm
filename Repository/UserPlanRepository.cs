using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Contracts;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class UserPlanRepository : RepositoryBase<UserPlan>, IUserPlanRepository
    {
        public UserPlanRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        public void CreateUserPlan(UserPlan userPlan) => Create(userPlan);

        public void DeleteUserPlan(UserPlan userPlan) => Delete(userPlan);

        public async Task<UserPlan> GetUserPlanById(Guid userPlanId, bool trackChanges) =>
            await FindByCondition(p => p.Id.Equals(userPlanId), trackChanges).SingleOrDefaultAsync();

        public async Task<UserPlan> GetUserPlanByUserIdAndPlanId(string userId, Guid userPlanId, bool trackChanges) =>
            await FindByCondition(u => u.UserId.Equals(userId) && u.Id.Equals(userPlanId), trackChanges).SingleOrDefaultAsync();

        public async Task<IEnumerable<UserPlan>> GetUserPlans(string userId, bool trackChanges) =>
            await FindByCondition(p => p.UserId.Equals(userId), trackChanges).ToListAsync();
    }
}
