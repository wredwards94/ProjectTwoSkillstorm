using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities;

namespace Repository
{
    public class UserDeviceRepository : RepositoryBase<UserDevice>, IUserDeviceRepository
    {
        public UserDeviceRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
    
}
