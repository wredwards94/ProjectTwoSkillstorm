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
using Microsoft.AspNetCore.Identity;

namespace Service
{
    public class UserDeviceService : IUserDeviceService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;
        private readonly ServiceHelperMethods _serviceHelperMethods;
        private readonly UserManager<User> _userManager;

        public UserDeviceService(IRepositoryManager repositoryManager, ILoggerManager logger, UserManager<User> userManager)
        {
            _repositoryManager = repositoryManager;
            _logger = logger;
            _userManager = userManager;
            _serviceHelperMethods = new ServiceHelperMethods(repositoryManager);
        }

        public async Task<UserDevice> AddUserDevice(Guid planId, Guid deviceId, bool trackChanges)
        {
            var userPlan = await _serviceHelperMethods.CheckUserPlanExists(planId, trackChanges);
            await _serviceHelperMethods.CheckDeviceExists(deviceId, trackChanges);

            userPlan.Plan = await _repositoryManager.PhonePlan.GetPhonePlan(userPlan.PlanId, trackChanges);

            userPlan.Devices = (ICollection<UserDevice>)await _repositoryManager.UserDevice.GetUserPlanDevices(userPlan.Id, trackChanges);

            if (userPlan.Devices.Count == userPlan.Plan.DeviceLimit) throw new DeviceLimitExceededException(userPlan.Id);

            var userDevice = new UserDevice
            {
                UserPlanId = userPlan.Id,
                DeviceId = deviceId,
                PhoneNumber = GenerateRandomPhoneNumber(),
                ActivationDate = DateTime.Now.Date,
            };

            _repositoryManager.UserDevice.CreateUserDevice(userDevice);
            await _repositoryManager.SaveAsync();
            return userDevice;
        }

        public async Task<UserDevice[]> SwapPhoneNumbers(Guid planId, Guid userDeviceId1, Guid userDeviceId2, bool trackChanges)
        {
            await _serviceHelperMethods.CheckUserPlanExists(planId, trackChanges);
            
            var userDevice1 = await _serviceHelperMethods.CheckUserDeviceExists(userDeviceId1, trackChanges);
            var userDevice2 = await _serviceHelperMethods.CheckUserDeviceExists(userDeviceId2, trackChanges);
            
            (userDevice1.PhoneNumber, userDevice2.PhoneNumber) = (userDevice2.PhoneNumber, userDevice1.PhoneNumber);
            
            _repositoryManager.UserDevice.UpdateUserDevice(userDevice1);
            _repositoryManager.UserDevice.UpdateUserDevice(userDevice2);
            await _repositoryManager.SaveAsync();
            
            return [userDevice1, userDevice2];
        }

        public async Task<UserDevice> GetUserDevice(string userId, Guid userDeviceId, bool trackChanges)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) throw new UserNotFoundException(userId);
            
            var userDevice = await _serviceHelperMethods.CheckUserDeviceExists(userDeviceId, trackChanges);
            
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
