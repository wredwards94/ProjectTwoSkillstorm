using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class UserPlanNotFoundException : NotFoundException
    {
        public UserPlanNotFoundException(Guid id) : base($"User plan with id {id} was not found.")
        {

        }
    }
}
