using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Shared.ResponseDtos
{
    public record UserPlanResponseDto
    {
        public Guid Id { get; init; }
        public Guid PlanId { get; init; }
        public string? UserId { get; init; }
    }
}
