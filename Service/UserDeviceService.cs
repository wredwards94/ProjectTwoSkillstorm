using Contracts;
using Entities;
using Entities.Exceptions;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Shared.CreationDtos;
using Shared.ResponseDtos;
using Shared.UpdateDtos;

namespace Service
{
    public class UserDeviceService : IUserDeviceService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly ServiceHelperMethods _serviceHelperMethods;
        private readonly UserManager<User> _userManager;

        public UserDeviceService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper, UserManager<User> userManager)
        {
            _repositoryManager = repositoryManager;
            _logger = logger;
            _mapper = mapper;
            _userManager = userManager;
            _serviceHelperMethods = new ServiceHelperMethods(repositoryManager);
        }

        public async Task<UserDeviceResponseDto> AddUserDevice(Guid planId, DeviceToAddDto deviceToAdd, bool trackChanges)
        {
            var userPlan = await _serviceHelperMethods.CheckUserPlanExists(planId, trackChanges);
            await _serviceHelperMethods.CheckDeviceExists(deviceToAdd.DeviceId, trackChanges);

            userPlan.Plan = await _repositoryManager.PhonePlan.GetPhonePlan(userPlan.PlanId, trackChanges);

            userPlan.Devices = (ICollection<UserDevice>)await _repositoryManager.UserDevice.GetUserPlanDevices(userPlan.Id, trackChanges);

            if (userPlan.Devices.Count == userPlan.Plan.DeviceLimit) throw new DeviceLimitExceededException(userPlan.Id);

            var userDevice = new UserDevice
            {
                UserPlanId = userPlan.Id,
                DeviceId = deviceToAdd.DeviceId,
                PhoneNumber = GenerateRandomPhoneNumber(),
                ActivationDate = DateTime.Now.Date,
            };

            _repositoryManager.UserDevice.CreateUserDevice(userDevice);
            await _repositoryManager.SaveAsync();
            
            return _mapper.Map<UserDeviceResponseDto>(userDevice);
        }

        public async Task<UserDeviceResponseDto[]> SwapPhoneNumbers(Guid planId, DevicePhoneNumSwapDto[] numSwapDtos, bool trackChanges)
        {
            await _serviceHelperMethods.CheckUserPlanExists(planId, trackChanges);
            
            var deviceOne = await _serviceHelperMethods.CheckUserDeviceExists(numSwapDtos[0].Id, trackChanges);
            var deviceTwo = await _serviceHelperMethods.CheckUserDeviceExists(numSwapDtos[1].Id, trackChanges);
            
            (deviceOne.PhoneNumber, deviceTwo.PhoneNumber) = (deviceTwo.PhoneNumber, deviceOne.PhoneNumber);
            
            _repositoryManager.UserDevice.UpdateUserDevice(deviceOne);
            _repositoryManager.UserDevice.UpdateUserDevice(deviceTwo);
            await _repositoryManager.SaveAsync();
            
            return _mapper.Map<UserDeviceResponseDto[]>(new[] {deviceOne, deviceTwo});
        }

        public async Task<UserDevice> GetUserDevice(string userId, Guid userDeviceId, bool trackChanges)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) throw new UserNotFoundException(userId);
            
            var userDevice = await _serviceHelperMethods.CheckUserDeviceExists(userDeviceId, trackChanges);
            userDevice.Device = await _repositoryManager.Device.GetDevice(userDevice.DeviceId ?? Guid.Empty, trackChanges);
            
            return userDevice;
        }

        public async Task<IEnumerable<UserDevice>> GetUserPlanDevices(string userId, Guid userPlanId, bool trackChanges)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) throw new UserNotFoundException(userId);
            
            var userDevices = await _repositoryManager.UserDevice.GetUserPlanDevices(userPlanId, trackChanges);
            foreach(var userDevice in userDevices)
            {
                Guid deviceId = userDevice.DeviceId ?? Guid.Empty;
                userDevice.Device = await _repositoryManager.Device.GetDevice(deviceId, trackChanges);
            }
            return userDevices;
        }
        public async Task DeleteUserDevice(string userId, UserDevice device, bool trackChanges)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) throw new UserNotFoundException(userId);
            _repositoryManager.UserDevice.DeleteUserDevice(device);
            await _repositoryManager.SaveAsync();
        }

        private static string GenerateRandomPhoneNumber()
        {
            Random random = new Random();
            string phoneNumber = random.Next(2, 10).ToString(); // Ensure the first digit is between 2 and 9 "2" +
            for (int i = 0; i < 9; i++) // Already added 2 digits, so we only need 8 more
            {
                phoneNumber += random.Next(0, 10).ToString(); // Append each random digit
            }
            return phoneNumber;
        }
    }
}
