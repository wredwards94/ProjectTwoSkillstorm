using Entities;

namespace Shared.ResponseDtos;

public record UserDeviceResponseDto(Guid Id, Guid DeviceId, string UserId, string PhoneNumber, Guid UserPlanId, DeviceResponseDto device, DateTime ActivationDate);