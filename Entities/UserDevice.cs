using System;
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
        public string? UserPlanID {get ; set;}
        public int ActivationDate { get; set; }
        // Add any additional properties or methods here
    }
}