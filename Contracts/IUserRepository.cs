using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Contracts
{
    public interface IUserRepository
    {
        Task<User> GetUser(Guid userId, bool trackChanges);
        void CreateUser(User user);
    }
}
