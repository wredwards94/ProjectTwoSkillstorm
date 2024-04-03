using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class UserPlan
    {
        public Guid Id { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        [ForeignKey(nameof(Plan))]
        public Guid PlanId { get; set; }
        public User? User { get; set; }
        public PhonePlan? Plan { get; set; }
    }
}