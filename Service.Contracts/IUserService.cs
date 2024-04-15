using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
// using Shared.CreationDtos;
using Shared.ResponseDtos;

namespace Service.Contracts
{
    public interface IUserService
    {
        Task<UserResponseDto> GetUser(string userId, bool trackChanges);

        // Task<User> CreateUser(UserForRegistrationDto user);

        //Task<User> AddPhonePlanToUser(Guid userId, PhonePlan phonePlan, bool trackChanges);
    }
}
