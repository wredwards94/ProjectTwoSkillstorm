namespace Shared.ResponseDtos;

public record BillingResponseDto
{
    public Guid Id { get; init; }
    public Guid UserPlanId { get; init; }
    public string? UserId { get; init; }
    public decimal TotalAmount { get; init; }
    public DateTime BillingDate { get; init; }
    public DateTime DueDate { get; init; }
    public bool IsPaid { get; init; }
    public string? PaymentMethod { get; init; }
    public PhonePlanResponseDto PlanDetails { get; init; }
    // public UserPlanBillResponseDto UserPlan { get; init; }
}