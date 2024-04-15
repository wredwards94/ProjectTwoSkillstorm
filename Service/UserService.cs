using AutoMapper;
using Contracts;
using Entities;
using Entities.Exceptions;
using Service.Contracts;
using Shared.ResponseDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.AuthenticationDtos;

namespace Service
{
    public class UserService : IUserService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly ServiceHelperMethods _serviceHelperMethods;


        public UserService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _logger = logger;
            _mapper = mapper;
            _serviceHelperMethods = new ServiceHelperMethods(repositoryManager);
        }

        public async Task<User> CreateUser(UserRegistrationDto user)
        {
            var userEntity = _mapper.Map<User>(user);
            _repositoryManager.User.CreateUser(userEntity);
            await _repositoryManager.SaveAsync();
            return userEntity;
        }

        public async Task<UserResponseDto> GetUser(string userId, bool trackChanges)
        {
            // var user = await _repositoryManager.User.GetUser(userId, trackChanges);
            // if (user == null) throw new UserNotFoundException(userId);
            
            var user = await _serviceHelperMethods.CheckUserExists(userId, trackChanges);

            user.UserPlans = (ICollection<UserPlan>?)await _repositoryManager.UserPlan.GetUserPlans(userId, trackChanges);

            var userDto = _mapper.Map<UserResponseDto>(user);

            return userDto;
        }
    }
}
