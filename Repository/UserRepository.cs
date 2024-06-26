﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Contracts;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        { }

        public void CreateUser(User user) => Create(user);

        public async Task<User> GetUser(string userId, bool trackChanges) =>
            await FindByCondition(u => u.Id.Equals(userId), trackChanges).SingleOrDefaultAsync();
    }
}
