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
using Microsoft.AspNetCore.Identity;

namespace Service
{
    public class UserPlanService : IUserPlanService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly ServiceHelperMethods _serviceHelperMethods;


        public UserPlanService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper,
            UserManager<User> userManager)
        {
            _repositoryManager = repositoryManager;
            _logger = logger;
            _mapper = mapper;
            _userManager = userManager;
            _serviceHelperMethods = new ServiceHelperMethods(repositoryManager);
        }

        public async Task<UserPlanResponseDto> CreateUserPlan(string userId, Guid planId, bool trackChanges)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) throw new UserNotFoundException(userId);

            var plan = await _serviceHelperMethods.CheckPhonePlanExists(planId, trackChanges);

            var userPlanToSave = new UserPlan
            {
                UserId = userId,
                PlanId = planId,
            };

            _repositoryManager.UserPlan.CreateUserPlan(userPlanToSave);
            await _repositoryManager.SaveAsync();
            
            var bill = new Billing
            {
                UserPlanId = userPlanToSave.Id,
                UserId = userId,
                TotalAmount = plan.Price,
                IsPaid = false,
                BillingDate = DateTime.Now.Date,
                DueDate = DateTime.Now.Date.AddDays(30)
            };
            _repositoryManager.Billing.CreateBill(bill);
            await _repositoryManager.SaveAsync();
            
            Console.WriteLine(userPlanToSave.Id);

            return _mapper.Map<UserPlanResponseDto>(userPlanToSave);
        }

        public async Task DeleteUserPlan(string userId, Guid userPlanId, bool trackChanges)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) throw new UserNotFoundException(userId);

            var userPlan = await _serviceHelperMethods.CheckUserPlanExists(userPlanId, trackChanges);
            userPlan.Bills = (ICollection<Billing>)await _repositoryManager.Billing.GetAllBillsByUserPlanId(userPlanId, trackChanges);
            
            // loop through bills and check if any are unpaid
            double sum = 0;
            foreach (var bill in userPlan.Bills)
            {
                if (!bill.IsPaid) sum += (double)bill.TotalAmount;
            }
            if (sum > 0) throw new NotAuthorizedException($"User has an outstanding balance of {sum}. Unpaid balances must be resolved before deactivating the plan.");

            foreach (var bill in userPlan.Bills)
            {
                _repositoryManager.Billing.DeleteUserPlanBill(bill);
            }
            await _repositoryManager.SaveAsync();

            userPlan.Devices = (ICollection<UserDevice>)await _repositoryManager.UserDevice.GetUserPlanDevicesByPlanId(userPlanId, trackChanges);
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
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) throw new UserNotFoundException(userId);

            var userPlan = await _serviceHelperMethods.CheckUserPlanExists(userPlanId, trackChanges);

            userPlan.Plan = await _repositoryManager.PhonePlan.GetPhonePlan(userPlan.PlanId, trackChanges);

            var userPlanResponse = _mapper.Map<UserPlanResponseDto>(userPlan);

            // userPlan.Devices = (ICollection<UserDevice>?)await _repositoryManager.UserDevice.GetUserPlanDevices(id, trackChanges);
            return userPlanResponse;
        }

        public async Task<IEnumerable<UserPlanResponseDto>> GetUserPlans(string userId, bool trackChanges)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) throw new UserNotFoundException(userId);

            var userPlans = await _repositoryManager.UserPlan.GetUserPlans(userId, trackChanges);
            foreach (var userPlan in userPlans)
            {
                userPlan.Plan = await _repositoryManager.PhonePlan.GetPhonePlan(userPlan.PlanId, trackChanges);
            }

            var userPlansResponse = _mapper.Map<IEnumerable<UserPlanResponseDto>>(userPlans);
            return userPlansResponse;
        }
    }
}