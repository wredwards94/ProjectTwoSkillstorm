namespace Shared.AuthenticationDtos;

public record TokenDto(string UserId, string AccessToken, string RefreshToken);