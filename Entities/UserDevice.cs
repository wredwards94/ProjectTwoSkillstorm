using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.JavaScript;
using Entities;

namespace Entities;

public class UserDevice
{
    public Guid Id { get; set; }

    [ForeignKey(nameof(Device))]
    public Guid? DeviceId { get; set; }
    public string? PhoneNumber { get; set; }

    [ForeignKey(nameof(UserPlan))]
    public Guid? UserPlanId { get; set; }

    [DataType(DataType.Date)]
    public DateTime? ActivationDate { get; set; }
    public Device? Device { get; set; }

    // Add any additional properties or methods here
}