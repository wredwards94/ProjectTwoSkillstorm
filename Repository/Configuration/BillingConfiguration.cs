using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class BillingConfiguration : IEntityTypeConfiguration<Billing>
{
    public void Configure(EntityTypeBuilder<Billing> builder)
    {
        builder.HasData(
            new Billing // 29.99
            {
                Id = Guid.NewGuid(),
                UserPlanId = new Guid("93e289fa-ffa4-484b-b66e-7df8078f9ed5"),
                UserId = new string("25f87c58-9061-4bb7-aa3a-4a05177481d2"),
                TotalAmount = new decimal(29.99),
                BillingDate = new DateTime(2024, 2, 6).Date,
                DueDate = new DateTime(2024, 2, 27).Date,
                IsPaid = true,
                PaymentMethod = new string("Credit Card")
            },
            new Billing // 29.99
            {
                Id = Guid.NewGuid(),
                UserPlanId = new Guid("93e289fa-ffa4-484b-b66e-7df8078f9ed5"),
                UserId = new string("25f87c58-9061-4bb7-aa3a-4a05177481d2"),
                TotalAmount = new decimal(29.99),
                BillingDate = new DateTime(2024, 3, 6).Date,
                DueDate = new DateTime(2024, 3, 27).Date,
                IsPaid = true,
                PaymentMethod = new string("Credit Card")
            },
            new Billing // 29.99
            {
                Id = Guid.NewGuid(),
                UserPlanId = new Guid("93e289fa-ffa4-484b-b66e-7df8078f9ed5"),
                UserId = new string("25f87c58-9061-4bb7-aa3a-4a05177481d2"),
                TotalAmount = new decimal(29.99),
                BillingDate = new DateTime(2024, 4, 6).Date,
                DueDate = new DateTime(2024, 4, 27).Date,
                IsPaid = false,
                PaymentMethod = new string("Credit Card")
            },
            new Billing // 69.99
            {
                Id = Guid.NewGuid(),
                UserPlanId = new Guid("d1e5f1d3-d768-403c-9431-564e9cbe84bf"),
                UserId = new string("538091ec-802c-460d-a56e-8ce2414782b2"),
                TotalAmount = new decimal(69.99),
                BillingDate = new DateTime(2024, 2, 6).Date,
                DueDate = new DateTime(2024, 2, 27).Date,
                IsPaid = true,
                PaymentMethod = new string("ACH")
            },
            new Billing // 69.99
            {
                Id = Guid.NewGuid(),
                UserPlanId = new Guid("d1e5f1d3-d768-403c-9431-564e9cbe84bf"),
                UserId = new string("538091ec-802c-460d-a56e-8ce2414782b2"),
                TotalAmount = new decimal(69.99),
                BillingDate = new DateTime(2024, 3, 6).Date,
                DueDate = new DateTime(2024, 3, 27).Date,
                IsPaid = true,
                PaymentMethod = new string("Credit Card")
            },
            new Billing // 69.99
            {
                Id = Guid.NewGuid(),
                UserPlanId = new Guid("d1e5f1d3-d768-403c-9431-564e9cbe84bf"),
                UserId = new string("538091ec-802c-460d-a56e-8ce2414782b2"),
                TotalAmount = new decimal(69.99),
                BillingDate = new DateTime(2024, 4, 6).Date,
                DueDate = new DateTime(2024, 4, 27).Date,
                IsPaid = true,
                PaymentMethod = new string("Debit Card")
            },
            new Billing // 99.99
            {
                Id = Guid.NewGuid(),
                UserPlanId = new Guid("f512ba58-cc89-49f5-8489-367865917a8b"),
                UserId = new string("3f86cc51-c688-42de-aa44-d35c5db73bc4"),
                TotalAmount = new decimal(99.99),
                BillingDate = new DateTime(2024, 2, 6).Date,
                DueDate = new DateTime(2024, 2, 27).Date,
                IsPaid = true,
                PaymentMethod = new string("ACH")
            },
            new Billing // 99.99
            {
                Id = Guid.NewGuid(),
                UserPlanId = new Guid("f512ba58-cc89-49f5-8489-367865917a8b"),
                UserId = new string("3f86cc51-c688-42de-aa44-d35c5db73bc4"),
                TotalAmount = new decimal(99.99),
                BillingDate = new DateTime(2024, 3, 6).Date,
                DueDate = new DateTime(2024, 3, 27).Date,
                IsPaid = true,
                PaymentMethod = new string("ACH")
            },
            new Billing // 99.99
            {
                Id = Guid.NewGuid(),
                UserPlanId = new Guid("f512ba58-cc89-49f5-8489-367865917a8b"),
                UserId = new string("3f86cc51-c688-42de-aa44-d35c5db73bc4"),
                TotalAmount = new decimal(99.99),
                BillingDate = new DateTime(2024, 4, 6).Date,
                DueDate = new DateTime(2024, 4, 27).Date,
                IsPaid = false,
                PaymentMethod = new string("ACH")
            }
        );
    }
}