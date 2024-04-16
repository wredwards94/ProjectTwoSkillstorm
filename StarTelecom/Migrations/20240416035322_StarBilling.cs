using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StarTelecom.Migrations
{
    /// <inheritdoc />
    public partial class StarBilling : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f36135b-36cd-4874-9ee2-a34f4355d157");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "2f36135b-36cd-4874-9ee2-a34f4355d157", null, "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25f87c58-9061-4bb7-aa3a-4a05177481d2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8d909e99-6048-4c7f-b6a3-94935a9b55f9", "f8b513fc-fe70-4361-a30a-21e511be3902" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f86cc51-c688-42de-aa44-d35c5db73bc4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7c915618-fb06-4dde-ac5a-4e7f6cf0b2df", "4f9cb157-c972-40ea-b130-98ae79ca43f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "538091ec-802c-460d-a56e-8ce2414782b2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "30bcc623-a3cc-4b5d-995e-7a9a2bea42da", "56fcd3cd-4460-494f-b812-f22364fc0b72" });
        }
    }
}
