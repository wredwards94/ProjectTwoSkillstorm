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
                new Device
                {
                    Id = new Guid("cde3cf86-46fb-40b3-bd45-e64171469e9b"),
                    Manufacturer = "Apple",
                    Model = "iPhone 15 Plus",
                    Storage = "64GB",
                    Color = "Black",
                    PictureUrl = "https://ss7.vzw.com/is/image/VerizonWireless/apple-iphone-15-plus-128gb-black-mtxr3ll-a-a?wid=930&hei=930&fmt=webp"
                },

                new Device
                {
                    Id = new Guid("7b483b60-90e2-4c89-836c-4ad8946b8aa7"),
                    Manufacturer = "Samsung",
                    Model = "Galaxy S24 Ultra",
                    Storage = "128GB",
                    Color = "Titanium Grey",
                    PictureUrl = "https://ss7.vzw.com/is/image/VerizonWireless/samsung-eureka-e3-titaniumgray?wid=930&hei=930&fmt=webp"
                },

                new Device
                {
                    Id = new Guid("f5222ea1-947e-45c1-a59a-a5a6e296b902"),
                    Manufacturer = "Apple",
                    Model = "iPhone 15",
                    Storage = "256GB",
                    Color = "Blue",
                    PictureUrl = "https://ss7.vzw.com/is/image/VerizonWireless/apple-iphone-15-128gb-blue-prepaid-mtpm3ll-a-a?wid=930&hei=930&fmt=webp"
                },

                new Device
                {
                    Id = new Guid("97a612e4-13d6-43c0-805b-30fafa1ae05a"),
                    Manufacturer = "Google",
                    Model = "Pixel 8 Pro",
                    Storage = "128GB",
                    Color = "Bay",
                    PictureUrl = "https://ss7.vzw.com/is/image/VerizonWireless/google-husky-bay-2023?wid=930&hei=930&fmt=webp"
                },

                new Device
                {
                    Id = new Guid("4f05e337-e657-4848-9efe-8b291bf18f1f"),
                    Manufacturer = "Google",
                    Model = "Pixel 7",
                    Storage = "256GB",
                    Color = "Lemongrass",
                    PictureUrl = "https://ss7.vzw.com/is/image/VerizonWireless/google-pixel-7-lemongrass-128-gb-ga03543-us?wid=930&hei=930&fmt=webp"
                },

                new Device
                {
                    Id = new Guid("88ca3741-b8f4-44f6-baef-059389a34907"),
                    Manufacturer = "Apple",
                    Model = "iPhone 13",
                    Storage = "64GB",
                    Color = "Starlight",
                    PictureUrl = "https://ss7.vzw.com/is/image/VerizonWireless/apple-iphone-13-starlight-09142021?wid=930&hei=930&fmt=webp"
                },

                new Device
                {
                    Id = new Guid("6488bdee-e52c-442a-b754-8a8f6c0e5ce0"), //PhoneNumber = "5418064868", 
                    Manufacturer = "Motorola",
                    Model = "Razr Plus",
                    Storage = "128GB",
                    Color = "Magenta",
                    PictureUrl = "https://cdn.tmobile.com/content/dam/t-mobile/en-p/cell-phones/Motorola/Motorola-razr-" +
                                 "Plus-2023/Viva-Magenta/Motorola-razr-Plus-2023-Viva-Magenta-frontimage.png"
                },

                new Device
                {
                    Id = new Guid("86a2e9d1-881f-4aba-ba25-e563b460a97a"), //PhoneNumber = "2105176786", 
                    Manufacturer = "Samsung",
                    Model = "iPhone 15 Plus",
                    Storage = "128GB",
                    Color = "Blue",
                    PictureUrl = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6525/6525390_sd.jpg;maxHeight=640;maxWidth=550"
                },

                new Device
                {
                    Id = new Guid("913cdb0e-2618-4c30-b760-0a78857eb0dd"), //PhoneNumber = "5127710406", 
                    Manufacturer = "Apple",
                    Model = "iPhone 12",
                    Storage = "128GB",
                    Color = "Blue",
                    PictureUrl = "https://ss7.vzw.com/is/image/VerizonWireless/apple-iphone-12-blue-10132020?wid=930&hei=930&fmt=webp"
                },

                new Device
                {
                    Id = new Guid("baf6fd9a-ee78-4512-b298-03bd824f3fbd"), //PhoneNumber = "2197287862", 
                    Manufacturer = "Samsung",
                    Model = "Galaxy S21+",
                    Storage = "512GB",
                    Color = "Purple",
                    PictureUrl = "https://www.backmarket.com/cdn-cgi/image/format%3Dauto%2Cquality%3D75%2Cwidth%3D640/" +
                                 "https://d2e6ccujb3mkqf.cloudfront.net/375691a8-f3d2-40ab-9bb8-7a187fa42f13-1_3230d8e7-e02d-4da1-bf4b-b3d2d1c889b9.jpg"
                }

            );
        }
    }
}
