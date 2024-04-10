using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Entities;
using Entities.ConfigurationModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Service.Contracts;

namespace Service
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IDeviceService> _deviceService;
        private readonly Lazy<IPhonePlanService> _phonePlanService;
        private readonly Lazy<IUserDeviceService> _userDeviceService;
        private readonly Lazy<IUserPlanService> _userPlanService;
        private readonly Lazy<IUserService> _userService;
        private readonly Lazy<IAuthenticationService> _authenticationService;

        public ServiceManager(
            IRepositoryManager repositoryManager, 
            ILoggerManager logger, 
            IMapper mapper, 
            UserManager<User> userManager,
            IOptions<JwtConfiguration> configuration)
        {
            _deviceService = new Lazy<IDeviceService>(() => new DeviceService(repositoryManager, logger, mapper));
            _phonePlanService = new Lazy<IPhonePlanService>(() => new PhonePlanService(repositoryManager, logger));
            _userDeviceService = new Lazy<IUserDeviceService>(() => new UserDeviceService(repositoryManager, logger));
            _userPlanService = new Lazy<IUserPlanService>(() => new UserPlanService(repositoryManager, logger));
            _userService = new Lazy<IUserService>(() => new UserService(repositoryManager, logger, mapper));
            _authenticationService = new Lazy<IAuthenticationService>(() => new AuthenticationService(logger, mapper, userManager, configuration));
        }
        public IDeviceService Device => _deviceService.Value;
        public IPhonePlanService PhonePlan => _phonePlanService.Value;
        public IUserDeviceService UserDevice => _userDeviceService.Value;
        public IUserPlanService UserPlan => _userPlanService.Value;
        public IUserService User => _userService.Value;
        public IAuthenticationService Authentication => _authenticationService.Value;
    }
}
