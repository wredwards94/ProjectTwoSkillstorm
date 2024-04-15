using AutoMapper;
using Contracts;
using Entities;
using Service.Contracts;
using Shared.ResponseDtos;
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
        private readonly IMapper _mapper;
        private readonly ServiceHelperMethods _serviceHelperMethods;


        public PhonePlanService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _logger = logger;
            _mapper = mapper;
            _serviceHelperMethods = new ServiceHelperMethods(repositoryManager);
        }

        public async Task<PhonePlanResponseDto> GetPhonePlan(Guid id, bool trackChanges)
        {
            var phonePlan = await _serviceHelperMethods.CheckPhonePlanExists(id, trackChanges);
            return _mapper.Map<PhonePlanResponseDto>(phonePlan);
        }

        public async Task<IEnumerable<PhonePlanResponseDto>> GetPhonePlans(bool trackChanges)
        {
            var phonePlans = await _repositoryManager.PhonePlan.GetPhonePlansAsync(trackChanges);
            return _mapper.Map<IEnumerable<PhonePlanResponseDto>>(phonePlans);
        }
    }
}
