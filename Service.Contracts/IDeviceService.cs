using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.ResponseDtos;

namespace Service.Contracts
{
    public interface IDeviceService
    {
        Task<IEnumerable<DeviceResponseDto>> GetAllDevices(bool trackChanges);
        Task<DeviceResponseDto> GetDevice(Guid id, bool trackChanges);
    }
}
