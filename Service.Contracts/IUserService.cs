using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Shared.CreationDtos;

namespace Service.Contracts
{
    public interface IUserService
    {
        Task<User> GetUser(Guid userId, bool trackChanges);

        Task<User> CreateUserAsync(UserCreationDto user);
    }
}
