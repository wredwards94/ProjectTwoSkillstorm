using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.ResponseDtos
{
    public class PhonePlanResponseDto
    {
        public Guid Id { get; set; }

        public string? Title { get; set; }

        public int DeviceLimit { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}
