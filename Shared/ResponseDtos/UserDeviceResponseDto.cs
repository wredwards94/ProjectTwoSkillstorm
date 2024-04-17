namespace Shared.ResponseDtos;

public record UserDeviceResponseDto(Guid Id, Guid DeviceId, string PhoneNumber, Guid UserPlanId);