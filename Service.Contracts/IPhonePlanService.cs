using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Service.Contracts
{
    public interface IPhonePlanService
    {
        Task<IEnumerable<PhonePlan>> GetPhonePlans(bool trackChanges);
    }
}
