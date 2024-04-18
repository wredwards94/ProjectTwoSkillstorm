namespace Shared.CreationDtos;

public record BillToPayDto(Guid Id, bool IsPaid, string PaymentMethod);