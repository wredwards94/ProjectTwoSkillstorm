using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Shared.ResponseDtos;

namespace Service.Contracts
{
    public interface IUserPlanService
    {
        Task<IEnumerable<UserPlanResponseDto>> GetUserPlans(string userId, bool trackChanges);
        Task<UserPlanResponseDto> GetUserPlan(string userId, Guid id, bool trackChanges);
        Task DeleteUserPlan(string userId, Guid planId, bool trackChanges);
        Task<UserPlanResponseDto> CreateUserPlan(string userId, Guid planId, bool trackChanges);
    }
}
