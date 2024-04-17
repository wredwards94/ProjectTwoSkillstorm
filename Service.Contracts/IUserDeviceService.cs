using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Shared.CreationDtos;
using Shared.ResponseDtos;
using Shared.UpdateDtos;

namespace Service.Contracts
{
    public interface IUserDeviceService
    {
        Task<IEnumerable<UserDevice>> GetUserPlanDevices(string userId, Guid userPlanId, bool trackChanges);
        Task<UserDevice> GetUserDevice(string userId, Guid userDeviceId, bool trackChanges);
        Task<UserDeviceResponseDto> AddUserDevice(Guid planId, DeviceToAddDto deviceToAdd, bool trackChanges);
        Task<UserDeviceResponseDto[]> SwapPhoneNumbers(Guid planId, DevicePhoneNumSwapDto[] numSwapDtos, bool trackChanges);
    }
}
