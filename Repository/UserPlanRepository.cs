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

        public void DeleteUserPlan(UserPlan userPlan) => Delete(userPlan);

        public async Task<UserPlan> GetUserPlan(Guid userId, Guid id, bool trackChanges) =>
            await FindByCondition(u => u.UserId.Equals(userId) && u.Id.Equals(id), trackChanges).SingleOrDefaultAsync();

        public async Task<IEnumerable<UserPlan>> GetUserPlans(Guid userId, bool trackChanges) =>
            await FindByCondition(p => p.UserId.Equals(userId), trackChanges).ToListAsync();
    }
}
