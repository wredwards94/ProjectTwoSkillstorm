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
            await FindByCondition(b => b.Id.Equals(billId), trackChanges).FirstOrDefaultAsync();

        public async Task<IEnumerable<Billing>> GetBillsByUserIdPaidFalse(string userId) => 
            await FindByCondition(b => b.UserId.Equals(userId) && b.IsPaid == false, false).ToListAsync();

        public async Task<IEnumerable<Billing>> GetBillsByUserId(string userId)
        {
            throw new NotImplementedException();
        }

        public void CreateBill(Billing bill) => Create(bill);

        public void DeleteUserPlanBill(Billing bill) => Delete(bill);
        
        public void UpdateBill(Billing bill) => Update(bill);
    }
}
