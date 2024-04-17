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
        Task<IEnumerable<UserDeviceResponseDto>> GetUserDevicesByUserPlanId(string userId, Guid userPlanId, bool trackChanges);
        Task<IEnumerable<UserDeviceResponseDto>> GetUserDevicesByUserId(string userId, bool trackChanges);
        Task<UserDeviceResponseDto> GetUserDevice(string userId, Guid userDeviceId, bool trackChanges);
        Task<UserDeviceResponseDto> AddUserDevice(Guid planId, DeviceToAddDto deviceToAdd, bool trackChanges);
        Task<IEnumerable<UserDeviceResponseDto>> SwapPhoneNumbers(string userID, List<DevicePhoneNumSwapDto> numSwapDtos, bool trackChanges);
        Task DeleteUserDevice(string userId, UserDevice device, bool trackChanges);

    }
}
