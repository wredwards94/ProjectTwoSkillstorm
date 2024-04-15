using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class DeviceLimitExceededException : NotAuthorizedException
    {
        public DeviceLimitExceededException(Guid id) : base($"Plan with id {id} has exceeded the number of devices allowed.")
        {

        }
    }
}
