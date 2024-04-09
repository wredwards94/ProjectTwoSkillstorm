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
        Task<IEnumerable<UserPlan>> GetUserPlans(Guid userId, bool trackChanges);
        Task<UserPlan> GetUserPlan(Guid userId, Guid id, bool trackChanges);
        void DeleteUserPlan(UserPlan userPlan);
    }
}
