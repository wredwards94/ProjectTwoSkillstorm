using Contracts;
using Entities;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class UserPlanService : IUserPlanService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;

        public UserPlanService(IRepositoryManager repositoryManager, ILoggerManager logger)
        {
            _repositoryManager = repositoryManager;
            _logger = logger;
        }

        public async void DeleteUserPlan(Guid userId, Guid planId, bool trackChanges)
        {
            var userPlan = await _repositoryManager.UserPlan.GetUserPlan(userId, planId, trackChanges);
            _repositoryManager.UserPlan.DeleteUserPlan(userPlan);
            await _repositoryManager.SaveAsync();
        }

        public async Task<UserPlan> GetUserPlan(Guid userId, Guid id, bool trackChanges)
        {
            var userPlan = await _repositoryManager.UserPlan.GetUserPlan(userId, id, trackChanges);
            userPlan.Plan = await _repositoryManager.PhonePlan.GetPhonePlan(userPlan.PlanId, trackChanges);
            userPlan.Devices = (ICollection<UserDevice>?)await _repositoryManager.UserDevice.GetUserPlanDevices(id, trackChanges);
            return userPlan;
        }

        public async Task<IEnumerable<UserPlan>> GetUserPlans(Guid userId, bool trackChanges)
        {
            var userPlans = await _repositoryManager.UserPlan.GetUserPlans(userId, trackChanges);
            return userPlans;
        }
    }
}
