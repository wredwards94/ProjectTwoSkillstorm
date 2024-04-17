using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Identity;

namespace Entities;

public class User : IdentityUser
{
    [Required]
    public string? FirstName { get; set; }
    
    [Required]
    public string? LastName { get; set; }
    
    
    public string? Address { get; set; }
    public string? RefreshToken { get; set; }
    public DateTime RefreshTokenExpiryTime { get; set; }
    
    //Collection Property for phone plan
    public IEnumerable<UserPlan>? UserPlans { get; set; }
}