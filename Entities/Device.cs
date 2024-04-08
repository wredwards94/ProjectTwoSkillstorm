using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Device
    {
        [Column("DeviceId")]
        public Guid Id { get; set; }
        //public string? PhoneNumber {get; set; }
        public string? Manufacturer { get; set; }
        public string? Model { get; set; }
        public string? Storage { get; set; }
        public string? Color { get; set; }

    }
}