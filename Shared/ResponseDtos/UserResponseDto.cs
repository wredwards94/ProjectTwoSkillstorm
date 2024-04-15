using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.ResponseDtos
{
    public record UserResponseDto
    {
        public string? Id { get; init; }
        public string? FirstName { get; init; }
        public string? LastName { get; init; }
        public string? Email { get; init; }
        public string? Username { get; init; }
        public string? Address { get; init; }
        public IEnumerable<UserPlanResponseDto>? UserPlans { get; init; }
    }
}
