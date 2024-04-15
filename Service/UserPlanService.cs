using AutoMapper;
using Contracts;
using Entities;
using Entities.Exceptions;
using Service.Contracts;
using Shared.ResponseDtos;
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
        private readonly IMapper _mapper;
        private readonly ServiceHelperMethods _serviceHelperMethods;


        public UserPlanService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _logger = logger;
            _mapper = mapper;
            _serviceHelperMethods = new ServiceHelperMethods(repositoryManager);
        }

        public async Task<UserPlan> CreateUserPlan(string userId, Guid planId, bool trackChanges)
        {
            // var plan = await _repositoryManager.PhonePlan.GetPhonePlan(planId, trackChanges);
            // if (plan == null) throw new PhonePlanNotFoundException(planId);
            //
            // var user = await _repositoryManager.User.GetUser(userId, trackChanges);
            // if (user == null) throw new UserNotFoundException(userId);
            
            await _serviceHelperMethods.CheckPhonePlanExists(planId, trackChanges);
            await _serviceHelperMethods.CheckUserExists(userId, trackChanges);
            
            var userPlanToSave = new UserPlan
            {
                UserId = userId,
                PlanId = planId,
            };

            _repositoryManager.UserPlan.CreateUserPlan(userPlanToSave);
            await _repositoryManager.SaveAsync();

            return userPlanToSave;
        }

        public async Task DeleteUserPlan(string userId, Guid userPlanId, bool trackChanges)
        {
            // var user = await _repositoryManager.User.GetUser(userId, trackChanges);
            // if (user == null) throw new UserNotFoundException(userId);
            //
            // var userPlan = await _repositoryManager.UserPlan.GetUserPlanById(userPlanId, trackChanges);
            // if (userPlan == null) throw new UserPlanNotFoundException(userPlanId);
            
            await _serviceHelperMethods.CheckUserExists(userId, trackChanges);
            var userPlan = await _serviceHelperMethods.CheckUserPlanExists(userPlanId, trackChanges);

            userPlan.Devices = (ICollection<UserDevice>)await _repositoryManager.UserDevice.GetUserPlanDevices(userPlanId, trackChanges);
            foreach (var device in userPlan.Devices)
            {
                _repositoryManager.UserDevice.DeleteUserDevice(device);
            }
            await _repositoryManager.SaveAsync();

            _repositoryManager.UserPlan.DeleteUserPlan(userPlan);
            await _repositoryManager.SaveAsync();
        }

        public async Task<UserPlanResponseDto> GetUserPlan(string userId, Guid userPlanId, bool trackChanges)
        {
            // var user = await _repositoryManager.User.GetUser(userId, trackChanges);
            // if (user == null) throw new UserNotFoundException(userId);
            //
            // var userPlan = await _repositoryManager.UserPlan.GetUserPlanById(userPlanId, trackChanges);
            // if (userPlan == null) throw new UserPlanNotFoundException(userPlanId);
            
            await _serviceHelperMethods.CheckUserExists(userId, trackChanges);
            var userPlan = await _serviceHelperMethods.CheckUserPlanExists(userPlanId, trackChanges);

            //userPlan.Plan = await _repositoryManager.PhonePlan.GetPhonePlan(userPlan.PlanId, trackChanges);

            var userPlanResponse = _mapper.Map<UserPlanResponseDto>(userPlan);

            // userPlan.Devices = (ICollection<UserDevice>?)await _repositoryManager.UserDevice.GetUserPlanDevices(id, trackChanges);
            return userPlanResponse;
        }

        public async Task<IEnumerable<UserPlanResponseDto>> GetUserPlans(string userId, bool trackChanges)
        {
            // var user = await _repositoryManager.User.GetUser(userId, trackChanges);
            // if (user == null) throw new UserNotFoundException(userId);
            
            await _serviceHelperMethods.CheckUserExists(userId, trackChanges);
            
            var userPlans = await _repositoryManager.UserPlan.GetUserPlans(userId, trackChanges);

            var userPlansResponse = _mapper.Map<IEnumerable<UserPlanResponseDto>>(userPlans);
            return userPlansResponse;
        }
    }
}
