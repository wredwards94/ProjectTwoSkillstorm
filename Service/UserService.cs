using AutoMapper;
using Contracts;
using Entities;
using Service.Contracts;
using Shared.CreationDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class UserService : IUserService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public UserService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<User> CreateUserAsync(UserCreationDto user)
        {
            var userEntity = _mapper.Map<User>(user);
            _repositoryManager.User.CreateUser(userEntity);
            await _repositoryManager.SaveAsync();
            return userEntity;
        }

        public async Task<User> GetUser(Guid userId, bool trackChanges)
        {
            var user = await _repositoryManager.User.GetUser(userId, trackChanges);
            user.UserPlans = await _repositoryManager.UserPlan.GetUserPlans(userId, trackChanges);
            return user;
        }
    }
}
