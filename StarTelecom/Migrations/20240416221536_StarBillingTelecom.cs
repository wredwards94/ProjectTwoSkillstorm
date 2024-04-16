using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StarTelecom.Migrations
{
    /// <inheritdoc />
    public partial class StarBillingTelecom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bcd74094-922c-482d-a170-ce1fe37ce19e");

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: new Guid("03a46987-ca2d-4db5-afac-b75e55e26e8d"));

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: new Guid("04d98fe7-3a15-4d6d-b6b9-f0365347137d"));

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: new Guid("1964f20f-317d-4d55-8b3b-a6e4b381da50"));

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: new Guid("30ba3b0b-1537-451c-b10f-3e5f7994a110"));

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: new Guid("950c69a3-4078-488a-b557-5d6c51f41ffa"));

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: new Guid("9f1ddd83-4a01-4285-86d0-2f6faaa903dd"));

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: new Guid("9f66c87a-f25f-45c9-a1c3-fa76d6c47fba"));

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: new Guid("e8fb2631-73a3-4ed2-8f7e-03a3664282a1"));

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: new Guid("e922d604-93d2-4fad-a704-d5ac633419ab"));

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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "838cb215-63f4-4880-bc9e-f0367316183a", 0, "1270 Main St", "59e35dd7-1ac4-4a37-a014-f54bd46ae6f1", "sample@sample.com", false, "Wesley", "Edwards", false, null, null, null, "Govols94!@", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c05af392-1841-455d-8846-24998bc0c45e", false, "wredwards" });

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
                    { new Guid("60c8acae-a4ad-4d9e-9008-022196d76c14"), new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Credit Card", 29.99m, "25f87c58-9061-4bb7-aa3a-4a05177481d2", new Guid("93e289fa-ffa4-484b-b66e-7df8078f9ed5") },
                    { new Guid("8ecf2ad6-ca90-4f00-969d-e23c91d27d29"), new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Credit Card", 69.99m, "538091ec-802c-460d-a56e-8ce2414782b2", new Guid("d1e5f1d3-d768-403c-9431-564e9cbe84bf") },
                    { new Guid("e4ec02e7-863c-4391-8837-b274a7b0dab7"), new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "ACH", 99.99m, "3f86cc51-c688-42de-aa44-d35c5db73bc4", new Guid("f512ba58-cc89-49f5-8489-367865917a8b") },
                    { new Guid("f97cc391-35f9-4ef1-bce2-f97084d7a407"), new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "ACH", 99.99m, "3f86cc51-c688-42de-aa44-d35c5db73bc4", new Guid("f512ba58-cc89-49f5-8489-367865917a8b") }
                });

            migrationBuilder.InsertData(
                table: "UserPlans",
                columns: new[] { "Id", "PlanId", "UserId" },
                values: new object[] { new Guid("d80449d6-cabf-4bae-b7b8-1888ac1caab9"), new Guid("f6daf5fa-75fc-485a-8b6d-388e4132cfcc"), "838cb215-63f4-4880-bc9e-f0367316183a" });

            migrationBuilder.InsertData(
                table: "Billing",
                columns: new[] { "Id", "BillingDate", "DueDate", "IsPaid", "PaymentMethod", "TotalAmount", "UserId", "UserPlanId" },
                values: new object[,]
                {
                    { new Guid("51d76a4b-ea95-4818-bca2-f823405d3f25"), new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "ACH", 29.99m, "838cb215-63f4-4880-bc9e-f0367316183a", new Guid("d80449d6-cabf-4bae-b7b8-1888ac1caab9") },
                    { new Guid("634d6f78-3b97-4d36-9788-ad26a5bfc160"), new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Debit card", 29.99m, "838cb215-63f4-4880-bc9e-f0367316183a", new Guid("d80449d6-cabf-4bae-b7b8-1888ac1caab9") },
                    { new Guid("eb29004f-0362-4c62-aaf7-2c91bdf8522d"), new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "ACH", 29.99m, "838cb215-63f4-4880-bc9e-f0367316183a", new Guid("d80449d6-cabf-4bae-b7b8-1888ac1caab9") }
                });

            migrationBuilder.InsertData(
                table: "UserDevices",
                columns: new[] { "Id", "ActivationDate", "DeviceId", "PhoneNumber", "UserPlanId" },
                values: new object[] { new Guid("50629e1f-f9bc-42c0-9904-1f7ceeb9595b"), new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("88ca3741-b8f4-44f6-baef-059389a34907"), "5556869009", new Guid("d80449d6-cabf-4bae-b7b8-1888ac1caab9") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "UserPlans",
                keyColumn: "Id",
                keyValue: new Guid("d80449d6-cabf-4bae-b7b8-1888ac1caab9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "838cb215-63f4-4880-bc9e-f0367316183a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bcd74094-922c-482d-a170-ce1fe37ce19e", null, "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25f87c58-9061-4bb7-aa3a-4a05177481d2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5d8036d6-9ed8-4bf9-ab8e-e2c9de605930", "a9dffaa0-ac0a-4efe-ac81-c83597dddae6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f86cc51-c688-42de-aa44-d35c5db73bc4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8aa6a54b-a5dd-4c0d-8c66-1cde3a63ece0", "160e501d-3d04-4a2b-8079-9639642e7834" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "538091ec-802c-460d-a56e-8ce2414782b2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e0a96ba5-8ad6-4e29-927c-1931347de2a7", "bf66dbc5-9106-468d-8e9e-3f218c527617" });

            migrationBuilder.InsertData(
                table: "Billing",
                columns: new[] { "Id", "BillingDate", "DueDate", "IsPaid", "PaymentMethod", "TotalAmount", "UserId", "UserPlanId" },
                values: new object[,]
                {
                    { new Guid("03a46987-ca2d-4db5-afac-b75e55e26e8d"), new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Credit Card", 29.99m, "25f87c58-9061-4bb7-aa3a-4a05177481d2", new Guid("93e289fa-ffa4-484b-b66e-7df8078f9ed5") },
                    { new Guid("04d98fe7-3a15-4d6d-b6b9-f0365347137d"), new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Credit Card", 29.99m, "25f87c58-9061-4bb7-aa3a-4a05177481d2", new Guid("93e289fa-ffa4-484b-b66e-7df8078f9ed5") },
                    { new Guid("1964f20f-317d-4d55-8b3b-a6e4b381da50"), new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Credit Card", 69.99m, "538091ec-802c-460d-a56e-8ce2414782b2", new Guid("d1e5f1d3-d768-403c-9431-564e9cbe84bf") },
                    { new Guid("30ba3b0b-1537-451c-b10f-3e5f7994a110"), new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Credit Card", 29.99m, "25f87c58-9061-4bb7-aa3a-4a05177481d2", new Guid("93e289fa-ffa4-484b-b66e-7df8078f9ed5") },
                    { new Guid("950c69a3-4078-488a-b557-5d6c51f41ffa"), new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "ACH", 99.99m, "3f86cc51-c688-42de-aa44-d35c5db73bc4", new Guid("f512ba58-cc89-49f5-8489-367865917a8b") },
                    { new Guid("9f1ddd83-4a01-4285-86d0-2f6faaa903dd"), new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "ACH", 99.99m, "3f86cc51-c688-42de-aa44-d35c5db73bc4", new Guid("f512ba58-cc89-49f5-8489-367865917a8b") },
                    { new Guid("9f66c87a-f25f-45c9-a1c3-fa76d6c47fba"), new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "ACH", 69.99m, "538091ec-802c-460d-a56e-8ce2414782b2", new Guid("d1e5f1d3-d768-403c-9431-564e9cbe84bf") },
                    { new Guid("e8fb2631-73a3-4ed2-8f7e-03a3664282a1"), new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Debit Card", 69.99m, "538091ec-802c-460d-a56e-8ce2414782b2", new Guid("d1e5f1d3-d768-403c-9431-564e9cbe84bf") },
                    { new Guid("e922d604-93d2-4fad-a704-d5ac633419ab"), new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "ACH", 99.99m, "3f86cc51-c688-42de-aa44-d35c5db73bc4", new Guid("f512ba58-cc89-49f5-8489-367865917a8b") }
                });
        }
    }
}
