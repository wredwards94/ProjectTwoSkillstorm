using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Contracts
{
    public interface IBillingRepository
    {
        Task<IEnumerable<Billing>> GetAllBillsByUserPlanId(Guid userPlanId, bool trackChanges);
        Task<Billing> GetBillById(Guid billId, bool trackChanges);
        Task<IEnumerable<Billing>> GetBillsByUserId(string userId);
    }
}
