namespace Entities
{
    public class UserPlan
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid PlanId { get; set; }
        public User? User { get; set; }
        //public PhonePlan? Plan { get; set; }

    }
}
