using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.ResponseDtos;

namespace Service.Contracts
{
    public interface IBillingService
    {
        Task<IEnumerable<BillingResponseDto>> GetUserPlanBills(string userId, Guid userPlanId, bool trackChanges);
        Task<BillingResponseDto> GetUserPlanBillById(string userId, Guid userPlanId, Guid billId, bool trackChanges);
        
        Task<IEnumerable<BillingResponseDto>> GetAllBillsForUser(string userId, bool trackChanges);
    }
}
