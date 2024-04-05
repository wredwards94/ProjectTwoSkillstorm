using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Contracts;

namespace Repository
{
    public class PhonePlanRepository : RepositoryBase<PhonePlan>, IPhonePlanRepository
    {
        public PhonePlanRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
