using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StarTelecom.Migrations
{
    /// <inheritdoc />
    public partial class StarTelecomDeviceUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "265358de-a180-4ec6-b9ab-d55cd91a36c3");

            migrationBuilder.RenameColumn(
                name: "pictureUrl",
                table: "Devices",
                newName: "PictureUrl");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4e864be8-be64-41de-8af8-6d4587b37726", null, "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25f87c58-9061-4bb7-aa3a-4a05177481d2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cac24d06-ff6a-4365-9dd6-077f39178234", "a67484c0-0aef-4dd5-a7bc-d5800773a3ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f86cc51-c688-42de-aa44-d35c5db73bc4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "90a33848-c183-4e0a-a1b7-6e3d5d3fc4e4", "212a9ed5-9846-4a52-ad21-21b350a82362" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "538091ec-802c-460d-a56e-8ce2414782b2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b7eb8028-2808-486a-aa8b-d18ebf2a49c9", "a5237076-3295-46bd-a010-6faad4b49943" });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("4f05e337-e657-4848-9efe-8b291bf18f1f"),
                columns: new[] { "Color", "PictureUrl" },
                values: new object[] { "Lemongrass", "https://ss7.vzw.com/is/image/VerizonWireless/google-pixel-7-lemongrass-128-gb-ga03543-us?wid=930&hei=930&fmt=webp" });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("6488bdee-e52c-442a-b754-8a8f6c0e5ce0"),
                columns: new[] { "Color", "PictureUrl" },
                values: new object[] { "Magenta", "https://cdn.tmobile.com/content/dam/t-mobile/en-p/cell-phones/Motorola/Motorola-razr-Plus-2023/Viva-Magenta/Motorola-razr-Plus-2023-Viva-Magenta-frontimage.png" });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("7b483b60-90e2-4c89-836c-4ad8946b8aa7"),
                columns: new[] { "Color", "PictureUrl" },
                values: new object[] { "Titanium Grey", "https://ss7.vzw.com/is/image/VerizonWireless/samsung-eureka-e3-titaniumgray?wid=930&hei=930&fmt=webp" });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("86a2e9d1-881f-4aba-ba25-e563b460a97a"),
                column: "PictureUrl",
                value: "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6525/6525390_sd.jpg;maxHeight=640;maxWidth=550");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("88ca3741-b8f4-44f6-baef-059389a34907"),
                columns: new[] { "Color", "PictureUrl" },
                values: new object[] { "Starlight", "https://ss7.vzw.com/is/image/VerizonWireless/apple-iphone-13-starlight-09142021?wid=930&hei=930&fmt=webp" });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("913cdb0e-2618-4c30-b760-0a78857eb0dd"),
                column: "PictureUrl",
                value: "https://ss7.vzw.com/is/image/VerizonWireless/apple-iphone-12-blue-10132020?wid=930&hei=930&fmt=webp");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("97a612e4-13d6-43c0-805b-30fafa1ae05a"),
                columns: new[] { "Color", "PictureUrl" },
                values: new object[] { "Bay", "https://ss7.vzw.com/is/image/VerizonWireless/google-husky-bay-2023?wid=930&hei=930&fmt=webp" });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("baf6fd9a-ee78-4512-b298-03bd824f3fbd"),
                column: "PictureUrl",
                value: "https://www.backmarket.com/cdn-cgi/image/format%3Dauto%2Cquality%3D75%2Cwidth%3D640/https://d2e6ccujb3mkqf.cloudfront.net/375691a8-f3d2-40ab-9bb8-7a187fa42f13-1_3230d8e7-e02d-4da1-bf4b-b3d2d1c889b9.jpg");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("cde3cf86-46fb-40b3-bd45-e64171469e9b"),
                column: "PictureUrl",
                value: "https://ss7.vzw.com/is/image/VerizonWireless/apple-iphone-15-plus-128gb-black-mtxr3ll-a-a?wid=930&hei=930&fmt=webp");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("f5222ea1-947e-45c1-a59a-a5a6e296b902"),
                column: "PictureUrl",
                value: "https://ss7.vzw.com/is/image/VerizonWireless/apple-iphone-15-128gb-blue-prepaid-mtpm3ll-a-a?wid=930&hei=930&fmt=webp");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e864be8-be64-41de-8af8-6d4587b37726");

            migrationBuilder.RenameColumn(
                name: "PictureUrl",
                table: "Devices",
                newName: "pictureUrl");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "265358de-a180-4ec6-b9ab-d55cd91a36c3", null, "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25f87c58-9061-4bb7-aa3a-4a05177481d2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "114759f3-465b-45db-9f5f-d823b97bb6e4", "dc72e2e4-2be0-4288-b510-4bb3635d9999" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f86cc51-c688-42de-aa44-d35c5db73bc4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "62f514cd-5704-4108-a2b2-043624a40dd6", "3dbb7a29-75bf-46b0-b88a-f9122b47377f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "538091ec-802c-460d-a56e-8ce2414782b2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8c4566c0-291e-4507-a05c-a851415fc819", "bf8b5681-8b30-4f1f-956e-e19bd873e053" });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("4f05e337-e657-4848-9efe-8b291bf18f1f"),
                columns: new[] { "Color", "pictureUrl" },
                values: new object[] { "Violet", null });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("6488bdee-e52c-442a-b754-8a8f6c0e5ce0"),
                columns: new[] { "Color", "pictureUrl" },
                values: new object[] { "Red", null });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("7b483b60-90e2-4c89-836c-4ad8946b8aa7"),
                columns: new[] { "Color", "pictureUrl" },
                values: new object[] { "Grey", null });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("86a2e9d1-881f-4aba-ba25-e563b460a97a"),
                column: "pictureUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("88ca3741-b8f4-44f6-baef-059389a34907"),
                columns: new[] { "Color", "pictureUrl" },
                values: new object[] { "White", null });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("913cdb0e-2618-4c30-b760-0a78857eb0dd"),
                column: "pictureUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("97a612e4-13d6-43c0-805b-30fafa1ae05a"),
                columns: new[] { "Color", "pictureUrl" },
                values: new object[] { "Mint Blue", null });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("baf6fd9a-ee78-4512-b298-03bd824f3fbd"),
                column: "pictureUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("cde3cf86-46fb-40b3-bd45-e64171469e9b"),
                column: "pictureUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("f5222ea1-947e-45c1-a59a-a5a6e296b902"),
                column: "pictureUrl",
                value: null);
        }
    }
}
