using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class PhonePlanNotFoundException : NotFoundException
    {
        public PhonePlanNotFoundException(Guid id) : base($"Phone plan with id {id} was not found.")
        {

        }
    }
}
