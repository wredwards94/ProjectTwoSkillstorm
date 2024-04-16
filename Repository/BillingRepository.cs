using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class BillingRepository : RepositoryBase<Billing>, IBillingRepository
    {
        public BillingRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        public async Task<IEnumerable<Billing>> GetAllBillsByUserPlanId(Guid userPlanId, bool trackChanges) => 
            await FindByCondition(b => b.UserPlanId.Equals(userPlanId), trackChanges).ToListAsync();

        public async Task<Billing> GetBillById(Guid billId, bool trackChanges) => 
            throw new NotImplementedException();

        public async Task<IEnumerable<Billing>> GetBillsByUserId(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
