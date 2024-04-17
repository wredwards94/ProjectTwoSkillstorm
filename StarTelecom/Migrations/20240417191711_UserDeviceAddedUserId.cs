using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StarTelecom.Migrations
{
    /// <inheritdoc />
    public partial class UserDeviceAddedUserId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "419082e7-f2a0-42b6-9bb5-dc5030018751");

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: new Guid("03c8f63d-56b1-4ea4-be9f-b19fc41b9685"));

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: new Guid("0dac34d0-b7e9-4768-beda-b7f5b9e6c264"));

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: new Guid("1834c518-ee7f-4a88-9e42-ea9eacd32873"));

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: new Guid("2ba99968-3fc5-47f8-8ddc-3d9f7d9fac05"));

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: new Guid("4f96373f-34db-419e-bf10-8b69d10461ce"));

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: new Guid("51d76a4b-ea95-4818-bca2-f823405d3f25"));

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: new Guid("60c8acae-a4ad-4d9e-9008-022196d76c14"));

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: new Guid("634d6f78-3b97-4d36-9788-ad26a5bfc160"));

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: new Guid("8ecf2ad6-ca90-4f00-969d-e23c91d27d29"));

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: new Guid("e4ec02e7-863c-4391-8837-b274a7b0dab7"));

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: new Guid("eb29004f-0362-4c62-aaf7-2c91bdf8522d"));

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: new Guid("f97cc391-35f9-4ef1-bce2-f97084d7a407"));

            migrationBuilder.DeleteData(
                table: "UserDevices",
                keyColumn: "Id",
                keyValue: new Guid("50629e1f-f9bc-42c0-9904-1f7ceeb9595b"));

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "UserDevices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "19b26bf4-8508-445d-97bc-423a5b0e357e", null, "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25f87c58-9061-4bb7-aa3a-4a05177481d2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c632f93b-a48d-4781-af4d-768537477f75", "35d112cd-99b4-42bf-a534-3ae66f6d03c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f86cc51-c688-42de-aa44-d35c5db73bc4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ec896075-8c94-4688-a8a6-0c8fe966f529", "27564a77-7fd0-4310-b8a2-cd9d7d868666" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "538091ec-802c-460d-a56e-8ce2414782b2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "76927ff1-1ab0-4037-8dcd-6283345babc1", "468d0969-b24e-465c-b228-2c55fc2c563d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "838cb215-63f4-4880-bc9e-f0367316183a",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2e13608d-4f8d-4271-94f6-917ac24e2609", "ab616d99-0a54-45dc-9ea1-bcf302d61e84" });

            migrationBuilder.InsertData(
                table: "Billing",
                columns: new[] { "Id", "BillingDate", "DueDate", "IsPaid", "PaymentMethod", "TotalAmount", "UserId", "UserPlanId" },
                values: new object[,]
                {
                    { new Guid("0d596d9b-b24d-4171-9bf3-37730511c383"), new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "ACH", 69.99m, "538091ec-802c-460d-a56e-8ce2414782b2", new Guid("d1e5f1d3-d768-403c-9431-564e9cbe84bf") },
                    { new Guid("10b9038a-55b4-4856-814c-af6b73b953a3"), new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Credit Card", 29.99m, "25f87c58-9061-4bb7-aa3a-4a05177481d2", new Guid("93e289fa-ffa4-484b-b66e-7df8078f9ed5") },
                    { new Guid("2bbd7774-7098-48b4-91a4-91f144c014ba"), new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "ACH", 99.99m, "3f86cc51-c688-42de-aa44-d35c5db73bc4", new Guid("f512ba58-cc89-49f5-8489-367865917a8b") },
                    { new Guid("37793a91-ef37-44fc-a4d2-deda54978771"), new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Credit Card", 29.99m, "25f87c58-9061-4bb7-aa3a-4a05177481d2", new Guid("93e289fa-ffa4-484b-b66e-7df8078f9ed5") },
                    { new Guid("483384d2-adf3-41cd-8a2b-2d6eb5fee892"), new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "ACH", 99.99m, "3f86cc51-c688-42de-aa44-d35c5db73bc4", new Guid("f512ba58-cc89-49f5-8489-367865917a8b") },
                    { new Guid("82923e85-6c1d-4924-b5c3-9094d6dc69c0"), new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Debit Card", 69.99m, "538091ec-802c-460d-a56e-8ce2414782b2", new Guid("d1e5f1d3-d768-403c-9431-564e9cbe84bf") },
                    { new Guid("8de7b685-c1ed-4076-86b5-2b53729125bb"), new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "ACH", 99.99m, "3f86cc51-c688-42de-aa44-d35c5db73bc4", new Guid("f512ba58-cc89-49f5-8489-367865917a8b") },
                    { new Guid("910e95c6-6ea6-476c-9b97-02fc31e01267"), new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "ACH", 29.99m, "838cb215-63f4-4880-bc9e-f0367316183a", new Guid("d80449d6-cabf-4bae-b7b8-1888ac1caab9") },
                    { new Guid("b0addc25-e209-4c25-a047-2790b6a61773"), new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Debit card", 29.99m, "838cb215-63f4-4880-bc9e-f0367316183a", new Guid("d80449d6-cabf-4bae-b7b8-1888ac1caab9") },
                    { new Guid("b7f5b338-7d47-4192-a891-c050c2f1b036"), new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Credit Card", 69.99m, "538091ec-802c-460d-a56e-8ce2414782b2", new Guid("d1e5f1d3-d768-403c-9431-564e9cbe84bf") },
                    { new Guid("de82277b-da8b-45b5-871d-31e0e122c417"), new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Credit Card", 29.99m, "25f87c58-9061-4bb7-aa3a-4a05177481d2", new Guid("93e289fa-ffa4-484b-b66e-7df8078f9ed5") },
                    { new Guid("f4174a89-990c-4215-81a8-f1443af92783"), new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "ACH", 29.99m, "838cb215-63f4-4880-bc9e-f0367316183a", new Guid("d80449d6-cabf-4bae-b7b8-1888ac1caab9") }
                });

            migrationBuilder.UpdateData(
                table: "UserDevices",
                keyColumn: "Id",
                keyValue: new Guid("022ae233-4d11-40d3-8170-1b034022eb57"),
                column: "UserId",
                value: "538091ec-802c-460d-a56e-8ce2414782b2");

            migrationBuilder.UpdateData(
                table: "UserDevices",
                keyColumn: "Id",
                keyValue: new Guid("0cf43dcb-563d-4707-b2b3-7f6ff4d69f7f"),
                column: "UserId",
                value: "3f86cc51-c688-42de-aa44-d35c5db73bc4");

            migrationBuilder.UpdateData(
                table: "UserDevices",
                keyColumn: "Id",
                keyValue: new Guid("18d346f8-edcc-4700-ab34-4518cd044674"),
                column: "UserId",
                value: "538091ec-802c-460d-a56e-8ce2414782b2");

            migrationBuilder.UpdateData(
                table: "UserDevices",
                keyColumn: "Id",
                keyValue: new Guid("5c38b804-3093-4c05-95c9-79caae650e15"),
                column: "UserId",
                value: "3f86cc51-c688-42de-aa44-d35c5db73bc4");

            migrationBuilder.UpdateData(
                table: "UserDevices",
                keyColumn: "Id",
                keyValue: new Guid("ac3f3dc7-ebb4-4f8d-907b-c45f71a8d9a5"),
                column: "UserId",
                value: "25f87c58-9061-4bb7-aa3a-4a05177481d2");

            migrationBuilder.UpdateData(
                table: "UserDevices",
                keyColumn: "Id",
                keyValue: new Guid("d80449d6-cabf-4bae-b7b8-1888ac1caab9"),
                column: "UserId",
                value: "3f86cc51-c688-42de-aa44-d35c5db73bc4");

            migrationBuilder.InsertData(
                table: "UserDevices",
                columns: new[] { "Id", "ActivationDate", "DeviceId", "PhoneNumber", "UserId", "UserPlanId" },
                values: new object[] { new Guid("a0cc4966-7605-4bc1-90db-286cfa367006"), new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("88ca3741-b8f4-44f6-baef-059389a34907"), "5556869009", "838cb215-63f4-4880-bc9e-f0367316183a", new Guid("d80449d6-cabf-4bae-b7b8-1888ac1caab9") });

            migrationBuilder.CreateIndex(
                name: "IX_UserDevices_DeviceId",
                table: "UserDevices",
                column: "DeviceId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserDevices_Devices_DeviceId",
                table: "UserDevices",
                column: "DeviceId",
                principalTable: "Devices",
                principalColumn: "DeviceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserDevices_Devices_DeviceId",
                table: "UserDevices");

            migrationBuilder.DropIndex(
                name: "IX_UserDevices_DeviceId",
                table: "UserDevices");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19b26bf4-8508-445d-97bc-423a5b0e357e");

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: new Guid("0d596d9b-b24d-4171-9bf3-37730511c383"));

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: new Guid("10b9038a-55b4-4856-814c-af6b73b953a3"));

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: new Guid("2bbd7774-7098-48b4-91a4-91f144c014ba"));

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: new Guid("37793a91-ef37-44fc-a4d2-deda54978771"));

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: new Guid("483384d2-adf3-41cd-8a2b-2d6eb5fee892"));

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: new Guid("82923e85-6c1d-4924-b5c3-9094d6dc69c0"));

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: new Guid("8de7b685-c1ed-4076-86b5-2b53729125bb"));

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: new Guid("910e95c6-6ea6-476c-9b97-02fc31e01267"));

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: new Guid("b0addc25-e209-4c25-a047-2790b6a61773"));

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: new Guid("b7f5b338-7d47-4192-a891-c050c2f1b036"));

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: new Guid("de82277b-da8b-45b5-871d-31e0e122c417"));

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: new Guid("f4174a89-990c-4215-81a8-f1443af92783"));

            migrationBuilder.DeleteData(
                table: "UserDevices",
                keyColumn: "Id",
                keyValue: new Guid("a0cc4966-7605-4bc1-90db-286cfa367006"));

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserDevices");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "419082e7-f2a0-42b6-9bb5-dc5030018751", null, "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25f87c58-9061-4bb7-aa3a-4a05177481d2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4c571dd3-3e73-495a-9ecf-e947196670a8", "6d5877c1-6562-4d3d-8afe-baab0542958a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f86cc51-c688-42de-aa44-d35c5db73bc4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "aef384dc-4814-4f9c-b319-ad81deb21dab", "feb14d1d-1a6b-482e-b708-ac2357f0a9c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "538091ec-802c-460d-a56e-8ce2414782b2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6d58025b-dfa4-4c94-884c-bfe0240ac0bf", "b1b27698-062a-44bf-bf3a-d8a55229d762" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "838cb215-63f4-4880-bc9e-f0367316183a",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "59e35dd7-1ac4-4a37-a014-f54bd46ae6f1", "c05af392-1841-455d-8846-24998bc0c45e" });

            migrationBuilder.InsertData(
                table: "Billing",
                columns: new[] { "Id", "BillingDate", "DueDate", "IsPaid", "PaymentMethod", "TotalAmount", "UserId", "UserPlanId" },
                values: new object[,]
                {
                    { new Guid("03c8f63d-56b1-4ea4-be9f-b19fc41b9685"), new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Debit Card", 69.99m, "538091ec-802c-460d-a56e-8ce2414782b2", new Guid("d1e5f1d3-d768-403c-9431-564e9cbe84bf") },
                    { new Guid("0dac34d0-b7e9-4768-beda-b7f5b9e6c264"), new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "ACH", 99.99m, "3f86cc51-c688-42de-aa44-d35c5db73bc4", new Guid("f512ba58-cc89-49f5-8489-367865917a8b") },
                    { new Guid("1834c518-ee7f-4a88-9e42-ea9eacd32873"), new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Credit Card", 29.99m, "25f87c58-9061-4bb7-aa3a-4a05177481d2", new Guid("93e289fa-ffa4-484b-b66e-7df8078f9ed5") },
                    { new Guid("2ba99968-3fc5-47f8-8ddc-3d9f7d9fac05"), new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Credit Card", 29.99m, "25f87c58-9061-4bb7-aa3a-4a05177481d2", new Guid("93e289fa-ffa4-484b-b66e-7df8078f9ed5") },
                    { new Guid("4f96373f-34db-419e-bf10-8b69d10461ce"), new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "ACH", 69.99m, "538091ec-802c-460d-a56e-8ce2414782b2", new Guid("d1e5f1d3-d768-403c-9431-564e9cbe84bf") },
                    { new Guid("51d76a4b-ea95-4818-bca2-f823405d3f25"), new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "ACH", 29.99m, "838cb215-63f4-4880-bc9e-f0367316183a", new Guid("d80449d6-cabf-4bae-b7b8-1888ac1caab9") },
                    { new Guid("60c8acae-a4ad-4d9e-9008-022196d76c14"), new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Credit Card", 29.99m, "25f87c58-9061-4bb7-aa3a-4a05177481d2", new Guid("93e289fa-ffa4-484b-b66e-7df8078f9ed5") },
                    { new Guid("634d6f78-3b97-4d36-9788-ad26a5bfc160"), new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Debit card", 29.99m, "838cb215-63f4-4880-bc9e-f0367316183a", new Guid("d80449d6-cabf-4bae-b7b8-1888ac1caab9") },
                    { new Guid("8ecf2ad6-ca90-4f00-969d-e23c91d27d29"), new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Credit Card", 69.99m, "538091ec-802c-460d-a56e-8ce2414782b2", new Guid("d1e5f1d3-d768-403c-9431-564e9cbe84bf") },
                    { new Guid("e4ec02e7-863c-4391-8837-b274a7b0dab7"), new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "ACH", 99.99m, "3f86cc51-c688-42de-aa44-d35c5db73bc4", new Guid("f512ba58-cc89-49f5-8489-367865917a8b") },
                    { new Guid("eb29004f-0362-4c62-aaf7-2c91bdf8522d"), new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "ACH", 29.99m, "838cb215-63f4-4880-bc9e-f0367316183a", new Guid("d80449d6-cabf-4bae-b7b8-1888ac1caab9") },
                    { new Guid("f97cc391-35f9-4ef1-bce2-f97084d7a407"), new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "ACH", 99.99m, "3f86cc51-c688-42de-aa44-d35c5db73bc4", new Guid("f512ba58-cc89-49f5-8489-367865917a8b") }
                });

            migrationBuilder.InsertData(
                table: "UserDevices",
                columns: new[] { "Id", "ActivationDate", "DeviceId", "PhoneNumber", "UserPlanId" },
                values: new object[] { new Guid("50629e1f-f9bc-42c0-9904-1f7ceeb9595b"), new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("88ca3741-b8f4-44f6-baef-059389a34907"), "5556869009", new Guid("d80449d6-cabf-4bae-b7b8-1888ac1caab9") });
        }
    }
}
