using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StarTelecom.Migrations
{
    /// <inheritdoc />
    public partial class StarTelecomEverything : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d81e7beb-8872-43df-8d8c-b30d3d7c4c33");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    DeviceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Storage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.DeviceId);
                });

            migrationBuilder.CreateTable(
                name: "PhonePlans",
                columns: table => new
                {
                    PlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeviceLimit = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhonePlans", x => x.PlanId);
                });

            migrationBuilder.CreateTable(
                name: "UserPlans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPlans_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserPlans_PhonePlans_PlanId",
                        column: x => x.PlanId,
                        principalTable: "PhonePlans",
                        principalColumn: "PlanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Billing",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BillingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Billing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Billing_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Billing_PhonePlans_PlanId",
                        column: x => x.PlanId,
                        principalTable: "PhonePlans",
                        principalColumn: "PlanId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Billing_UserPlans_UserPlanId",
                        column: x => x.UserPlanId,
                        principalTable: "UserPlans",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserDevices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeviceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ActivationDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDevices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDevices_UserPlans_UserPlanId",
                        column: x => x.UserPlanId,
                        principalTable: "UserPlans",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "265358de-a180-4ec6-b9ab-d55cd91a36c3", null, "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "25f87c58-9061-4bb7-aa3a-4a05177481d2", 0, "123 Main St", "114759f3-465b-45db-9f5f-d823b97bb6e4", "john.doe@example.com", false, "John", "Doe", false, null, null, null, "password1", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dc72e2e4-2be0-4288-b510-4bb3635d9999", false, "johndoe" },
                    { "3f86cc51-c688-42de-aa44-d35c5db73bc4", 0, "789 Loon St", "62f514cd-5704-4108-a2b2-043624a40dd6", "elmer.fudd@example.com", false, "Elmer", "Fudd", false, null, null, null, "password3", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3dbb7a29-75bf-46b0-b88a-f9122b47377f", false, "elmerfudd" },
                    { "538091ec-802c-460d-a56e-8ce2414782b2", 0, "456 Elm St", "8c4566c0-291e-4507-a05c-a851415fc819", "jane.smith@example.com", false, "Jane", "Smith", false, null, null, null, "password2", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bf8b5681-8b30-4f1f-956e-e19bd873e053", false, "janesmith" }
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "DeviceId", "Color", "Manufacturer", "Model", "Storage", "pictureUrl" },
                values: new object[,]
                {
                    { new Guid("4f05e337-e657-4848-9efe-8b291bf18f1f"), "Violet", "Google", "Pixel 7", "256GB", null },
                    { new Guid("6488bdee-e52c-442a-b754-8a8f6c0e5ce0"), "Red", "Motorola", "Razr Plus", "128GB", null },
                    { new Guid("7b483b60-90e2-4c89-836c-4ad8946b8aa7"), "Grey", "Samsung", "Galaxy S24 Ultra", "128GB", null },
                    { new Guid("86a2e9d1-881f-4aba-ba25-e563b460a97a"), "Blue", "Samsung", "iPhone 15 Plus", "128GB", null },
                    { new Guid("88ca3741-b8f4-44f6-baef-059389a34907"), "White", "Apple", "iPhone 13", "64GB", null },
                    { new Guid("913cdb0e-2618-4c30-b760-0a78857eb0dd"), "Blue", "Apple", "iPhone 12", "128GB", null },
                    { new Guid("97a612e4-13d6-43c0-805b-30fafa1ae05a"), "Mint Blue", "Google", "Pixel 8 Pro", "128GB", null },
                    { new Guid("baf6fd9a-ee78-4512-b298-03bd824f3fbd"), "Purple", "Samsung", "Galaxy S21+", "512GB", null },
                    { new Guid("cde3cf86-46fb-40b3-bd45-e64171469e9b"), "Black", "Apple", "iPhone 15 Plus", "64GB", null },
                    { new Guid("f5222ea1-947e-45c1-a59a-a5a6e296b902"), "Blue", "Apple", "iPhone 15", "256GB", null }
                });

            migrationBuilder.InsertData(
                table: "PhonePlans",
                columns: new[] { "PlanId", "DeviceLimit", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("1d5cc690-684b-4dc4-b4ac-1bdf90c97839"), 5, 99.99m, "Family Plan" },
                    { new Guid("23d7dc69-ff2f-42e9-92d5-20aebbb0747f"), 3, 69.99m, "Premium Plan" },
                    { new Guid("f6daf5fa-75fc-485a-8b6d-388e4132cfcc"), 1, 29.99m, "Basic Plan" }
                });

            migrationBuilder.InsertData(
                table: "UserPlans",
                columns: new[] { "Id", "PlanId", "UserId" },
                values: new object[,]
                {
                    { new Guid("93e289fa-ffa4-484b-b66e-7df8078f9ed5"), new Guid("f6daf5fa-75fc-485a-8b6d-388e4132cfcc"), "25f87c58-9061-4bb7-aa3a-4a05177481d2" },
                    { new Guid("d1e5f1d3-d768-403c-9431-564e9cbe84bf"), new Guid("23d7dc69-ff2f-42e9-92d5-20aebbb0747f"), "538091ec-802c-460d-a56e-8ce2414782b2" },
                    { new Guid("f512ba58-cc89-49f5-8489-367865917a8b"), new Guid("1d5cc690-684b-4dc4-b4ac-1bdf90c97839"), "3f86cc51-c688-42de-aa44-d35c5db73bc4" }
                });

            migrationBuilder.InsertData(
                table: "UserDevices",
                columns: new[] { "Id", "ActivationDate", "DeviceId", "PhoneNumber", "UserPlanId" },
                values: new object[,]
                {
                    { new Guid("022ae233-4d11-40d3-8170-1b034022eb57"), new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f5222ea1-947e-45c1-a59a-a5a6e296b902"), "3036313605", new Guid("d1e5f1d3-d768-403c-9431-564e9cbe84bf") },
                    { new Guid("0cf43dcb-563d-4707-b2b3-7f6ff4d69f7f"), new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4f05e337-e657-4848-9efe-8b291bf18f1f"), "2085544516", new Guid("f512ba58-cc89-49f5-8489-367865917a8b") },
                    { new Guid("18d346f8-edcc-4700-ab34-4518cd044674"), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7b483b60-90e2-4c89-836c-4ad8946b8aa7"), "7187624769", new Guid("d1e5f1d3-d768-403c-9431-564e9cbe84bf") },
                    { new Guid("5c38b804-3093-4c05-95c9-79caae650e15"), new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("97a612e4-13d6-43c0-805b-30fafa1ae05a"), "8472898809", new Guid("f512ba58-cc89-49f5-8489-367865917a8b") },
                    { new Guid("ac3f3dc7-ebb4-4f8d-907b-c45f71a8d9a5"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cde3cf86-46fb-40b3-bd45-e64171469e9b"), "2629423847", new Guid("93e289fa-ffa4-484b-b66e-7df8078f9ed5") },
                    { new Guid("d80449d6-cabf-4bae-b7b8-1888ac1caab9"), new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("88ca3741-b8f4-44f6-baef-059389a34907"), "7712780071", new Guid("f512ba58-cc89-49f5-8489-367865917a8b") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Billing_PlanId",
                table: "Billing",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Billing_UserId",
                table: "Billing",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Billing_UserPlanId",
                table: "Billing",
                column: "UserPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDevices_UserPlanId",
                table: "UserDevices",
                column: "UserPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPlans_PlanId",
                table: "UserPlans",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPlans_UserId",
                table: "UserPlans",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Billing");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "UserDevices");

            migrationBuilder.DropTable(
                name: "UserPlans");

            migrationBuilder.DropTable(
                name: "PhonePlans");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "265358de-a180-4ec6-b9ab-d55cd91a36c3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25f87c58-9061-4bb7-aa3a-4a05177481d2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f86cc51-c688-42de-aa44-d35c5db73bc4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "538091ec-802c-460d-a56e-8ce2414782b2");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d81e7beb-8872-43df-8d8c-b30d3d7c4c33", null, "User", "USER" });
        }
    }
}
