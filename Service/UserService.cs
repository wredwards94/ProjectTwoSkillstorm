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
using Microsoft.AspNetCore.Identity;
using Shared.AuthenticationDtos;

namespace Service
{
    public class UserService : IUserService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper; 
        private readonly UserManager<User> _userManager;

        public UserService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper, UserManager<User> userManager)
        {
            _repositoryManager = repositoryManager;
            _logger = logger;
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<UserResponseDto> GetUser(string userId, bool trackChanges)
        {
            
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) throw new UserNotFoundException(userId);
        
            user.UserPlans = (ICollection<UserPlan>?)await _repositoryManager.UserPlan.GetUserPlans(userId, trackChanges);
        
            var userDto = _mapper.Map<UserResponseDto>(user);
        
            return userDto;
        }
    }
}
