using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.ResponseDtos
{
    public class DeviceDto
    {
        public Guid Id { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Manufacturer { get; set; }
        public string? Model { get; set; }
        public string? Storage { get; set; }
        public string? Color { get; set; }
    }
}
