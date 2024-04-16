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
    }
}
