using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class BillingConfiguration : IEntityTypeConfiguration<Billing>
    {
        public void Configure(EntityTypeBuilder<Billing> builder)
        {
            //builder.HasData(
            //    new PhonePlan { Id = new Guid("f6daf5fa-75fc-485a-8b6d-388e4132cfcc"), Title = "Basic Plan", DeviceLimit = 1, Price = 29.99m },
            //    new PhonePlan { Id = new Guid("23d7dc69-ff2f-42e9-92d5-20aebbb0747f"), Title = "Premium Plan", DeviceLimit = 3, Price = 69.99m },
            //    new PhonePlan { Id = new Guid("1d5cc690-684b-4dc4-b4ac-1bdf90c97839"), Title = "Family Plan", DeviceLimit = 5, Price = 99.99m }
            //);
        }
    }
}
