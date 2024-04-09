using Contracts;
using Entities;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class PhonePlanService : IPhonePlanService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;

        public PhonePlanService(IRepositoryManager repositoryManager, ILoggerManager logger)
        {
            _repositoryManager = repositoryManager;
            _logger = logger;
        }

        public async Task<PhonePlan> GetPhonePlan(Guid id, bool trackChanges)
        {
            var phonePlan = await _repositoryManager.PhonePlan.GetPhonePlan(id, trackChanges);
            return phonePlan;
        }

        public async Task<IEnumerable<PhonePlan>> GetPhonePlans(bool trackChanges)
        {
            var phonePlans = await _repositoryManager.PhonePlan.GetPhonePlansAsync(trackChanges);
            return phonePlans;
        }
    }
}
