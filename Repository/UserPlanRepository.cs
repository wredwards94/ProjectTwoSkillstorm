using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Contracts;

namespace Repository
{
    public class UserPlanRepository : RepositoryBase<UserPlan>, IUserPlanRepository
    {
        public UserPlanRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            
        }
    }
}
