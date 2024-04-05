using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities;

namespace Entities;

public class UserDevice
{
    public Guid Id { get; set; }

    [ForeignKey(nameof(Device))]
    public Guid? DeviceID { get; set; }

    [ForeignKey(nameof(UserPlan))]
    public Guid? UserPlanID { get; set; }

    [DataType(DataType.Date)]
    public DateTime? ActivationDate { get; set; }

    // Add any additional properties or methods here
}