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
    public class DeviceConfiguration : IEntityTypeConfiguration<Device>
    {
        public void Configure(EntityTypeBuilder<Device> builder)
        {
            
            builder.HasData(
                new Device { Id = new Guid("cde3cf86-46fb-40b3-bd45-e64171469e9b"), PhoneNumber = "2629423847", 
                            Manufacturer = "Apple", Model =  "iPhone 15 Plus", Storage = "64GB",Color = "Black" },

                new Device { Id = new Guid("7b483b60-90e2-4c89-836c-4ad8946b8aa7"), PhoneNumber = "7187624769", 
                            Manufacturer = "Samsung", Model = "Galaxy S24 Ultra", Storage = "128GB", Color = "Grey" },

                new Device { Id = new Guid("f5222ea1-947e-45c1-a59a-a5a6e296b902"), PhoneNumber = "3036313605", 
                            Manufacturer = "Apple", Model = "iPhone 15", Storage = "256GB", Color = "Blue" },

                new Device { Id = new Guid("97a612e4-13d6-43c0-805b-30fafa1ae05a"), PhoneNumber = "8472898809", 
                            Manufacturer = "Google", Model = "Pixel 8 Pro", Storage = "128GB", Color = "Mint Blue" },

                new Device { Id = new Guid("4f05e337-e657-4848-9efe-8b291bf18f1f"), PhoneNumber = "2085544516", 
                            Manufacturer = "Google", Model = "Pixel 7", Storage = "256GB", Color = "Violet" },

                new Device { Id = new Guid("88ca3741-b8f4-44f6-baef-059389a34907"), PhoneNumber = "7712780071", 
                            Manufacturer = "Apple", Model = "iPhone 13", Storage = "64GB", Color = "White" },

                new Device { Id = new Guid("6488bdee-e52c-442a-b754-8a8f6c0e5ce0"), PhoneNumber = "5418064868", 
                            Manufacturer = "Motorola", Model = "Razr Plus", Storage = "128GB", Color = "Red" },

                new Device { Id = new Guid("86a2e9d1-881f-4aba-ba25-e563b460a97a"), PhoneNumber = "2105176786", 
                            Manufacturer = "Samsung", Model = "iPhone 15 Plus", Storage = "128GB", Color = "Blue" },

                new Device { Id = new Guid("913cdb0e-2618-4c30-b760-0a78857eb0dd"), PhoneNumber = "5127710406", 
                            Manufacturer = "Apple", Model = "iPhone 12", Storage = "128GB", Color = "Blue" },

                new Device { Id = new Guid("baf6fd9a-ee78-4512-b298-03bd824f3fbd"), PhoneNumber = "2197287862", 
                            Manufacturer = "Samsung", Model = "Galaxy S21+", Storage = "512GB", Color = "Purple" }

            );
        }
    }
}
