using System.ComponentModel.DataAnnotations;

namespace Shared.AuthenticationDtos;

public record UserRegistrationDto
{
    [Required(ErrorMessage = "First name is required")]
    public string? FirstName { get; init; }

    [Required(ErrorMessage = "Last name is required")]
    public string? LastName { get; init; }

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress]
    [DataType(DataType.EmailAddress)]
    public string? Email { get; init; }

    [Required(ErrorMessage = "Username is required")]
    public string? UserName { get; init; }

    [Required(ErrorMessage = "Password is required")]
    [DataType(DataType.Password)]
    public string? Password { get; init; }
}