using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities;

namespace ProjectTwoSkillstorm.Entities
{
    public class UserDevice
    {
        public Guid Id { get; set; }

        [ForeignKey(nameof(Device))]
        public string? DeviceID { get; set; }

        [ForeignKey(nameof(UserPlan))]
        public string? UserPlanID { get; set; }
<<<<<<< HEAD
        public int ActivationDate { get; set; }
=======
        [DataType(DataType.Date)]
        public DateTime? ActivationDate { get; set; }
>>>>>>> origin/main
        // Add any additional properties or methods here
    }
}