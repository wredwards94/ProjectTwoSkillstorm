using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Contracts
{
    public interface IUserPlanRepository
    {
        Task<IEnumerable<UserPlan>> GetUserPlans(string userId, bool trackChanges);
        Task<UserPlan> GetUserPlanByUserIdAndPlanId(string userId, Guid userPlanId, bool trackChanges);
        Task<UserPlan> GetUserPlanById(Guid userPlanId, bool trackChanges);
        void DeleteUserPlan(UserPlan userPlan);
        void CreateUserPlan(UserPlan userPlan);
    }
}
