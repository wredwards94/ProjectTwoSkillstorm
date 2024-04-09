using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Service.Contracts
{
    public interface IUserPlanService
    {
        Task<IEnumerable<UserPlan>> GetUserPlans(Guid userId, bool trackChanges);
        Task<UserPlan> GetUserPlan(Guid userId, Guid id, bool trackChanges);
        void DeleteUserPlan(Guid userId, Guid planId, bool trackChanges);
    }
}
