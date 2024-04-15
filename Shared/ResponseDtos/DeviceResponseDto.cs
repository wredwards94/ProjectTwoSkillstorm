using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.ResponseDtos
{
    public record DeviceResponseDto
    {
        public Guid Id { get; init; }
        public string? Manufacturer { get; init; }
        public string? Model { get; init; }
        public string? Storage { get; init; }
        public string? Color { get; init; }
        // [DataType(DataType.ImageUrl)]
        public string? PictureUrl { get; init; }
    }
}
