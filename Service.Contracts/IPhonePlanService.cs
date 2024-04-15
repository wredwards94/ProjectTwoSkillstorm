using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Shared.ResponseDtos;

namespace Service.Contracts
{
    public interface IPhonePlanService
    {
        Task<IEnumerable<PhonePlanResponseDto>> GetPhonePlans(bool trackChanges);
        Task<PhonePlanResponseDto> GetPhonePlan(Guid id, bool trackChanges);
    }
}
