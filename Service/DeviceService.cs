using Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Entities.Exceptions;
using Shared.ResponseDtos;

namespace Service
{
    public class DeviceService : IDeviceService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly ServiceHelperMethods _serviceHelperMethods;

        public DeviceService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _logger = logger;
            _mapper = mapper;
            _serviceHelperMethods = new ServiceHelperMethods(repositoryManager); // Initialize ServiceHelperMethods
        }

        public async Task<IEnumerable<DeviceResponseDto>> GetAllDevices(bool trackChanges)
        {
            var devices = await _repositoryManager.Device.GetAllDevices(trackChanges);

            return _mapper.Map<IEnumerable<DeviceResponseDto>>(devices);
        }

        public async Task<DeviceResponseDto> GetDevice(Guid id, bool trackChanges)
        {
            var device = await _serviceHelperMethods.CheckDeviceExists(id, trackChanges);
            // if (device == null) throw new DeviceNotFoundException(id);
            
            var deviceDto = _mapper.Map<DeviceResponseDto>(device);
            return deviceDto;
        }
    }
}
