using System.ComponentModel.DataAnnotations;

namespace Shared.AuthenticationDtos;

public record UserAuthenticationDto
{
    [Required(ErrorMessage = "Username is required")]
    public string? UserName { get; set; }
    
    [Required(ErrorMessage = "Password is required")]
    [DataType(DataType.Password)]
    public string? Password { get; set; }
}