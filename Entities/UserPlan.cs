using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class UserPlan
    {
        public Guid Id { get; set; }

        [ForeignKey(nameof(User))]
        public string? UserId { get; set; }

        [ForeignKey(nameof(Plan))]
        public Guid PlanId { get; set; }
        //[ForeignKey(nameof(UserDevice))]
        //public string? DeviceId { get; set; }
        public User? User { get; set; }
        public PhonePlan? Plan { get; set; }
        public ICollection<UserDevice>? Devices { get; set; }

        // Collection for billing
        public ICollection<Billing>? Bills { get; set; }

    }
}