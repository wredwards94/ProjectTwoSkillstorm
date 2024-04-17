namespace Shared.UpdateDtos;

public record DevicePhoneNumSwapDto(Guid Id, Guid DeviceId, Guid UserPlanId, string PhoneNumber);