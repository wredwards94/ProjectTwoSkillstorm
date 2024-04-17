using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Entities;
using Entities.Exceptions;
using Microsoft.AspNetCore.Identity;
using Service.Contracts;
using Shared.ResponseDtos;

namespace Service
{
    public class BillingService : IBillingService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly ServiceHelperMethods _serviceHelperMethods;
        
        public BillingService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper, UserManager<User> userManager)
        {
            _repositoryManager = repositoryManager;
            _logger = logger;
            _mapper = mapper;
            _userManager = userManager;
            _serviceHelperMethods = new ServiceHelperMethods(repositoryManager);
        }

        public async Task<IEnumerable<BillingResponseDto>> GetUserPlanBills(string userId, Guid userPlanId,
            bool trackChanges)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) throw new UserNotFoundException(userId);

            // var userPlan = await _repositoryManager.UserPlan.GetUserPlanById(userPlanId, trackChanges);
            // if (userPlan == null) throw new UserPlanNotFoundException(userPlanId);

            var bills = await _repositoryManager.Billing.GetAllBillsByUserPlanId(userPlanId, trackChanges);
            return _mapper.Map<IEnumerable<BillingResponseDto>>(bills);
        }

        public async Task<BillingResponseDto> GetUserPlanBillById(string userId, Guid userPlanId, Guid billId, bool trackChanges)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) throw new UserNotFoundException(userId);
            
            // var userPlan = await _repositoryManager.UserPlan.GetUserPlanById(userPlanId, trackChanges);
            // if (userPlan == null) throw new UserPlanNotFoundException(userPlanId);
            
            var bill = await _repositoryManager.Billing.GetBillById(billId, trackChanges);
            return _mapper.Map<BillingResponseDto>(bill);
        }
    }
}
