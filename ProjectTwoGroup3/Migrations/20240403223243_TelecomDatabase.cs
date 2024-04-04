using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectTwoGroup3.Migrations
{
    /// <inheritdoc />
    public partial class TelecomDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    DeviceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Storage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "UserDevices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeviceID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPlanID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActivationDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDevices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserPlans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPlans_PhonePlans_PlanId",
                        column: x => x.PlanId,
                        principalTable: "PhonePlans",
                        principalColumn: "PlanId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPlans_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "DeviceId", "Color", "Manufacturer", "Model", "PhoneNumber", "Storage" },
                values: new object[,]
                {
                    { new Guid("4f05e337-e657-4848-9efe-8b291bf18f1f"), "Violet", "Google", "Pixel 7", "2085544516", "256GB" },
                    { new Guid("6488bdee-e52c-442a-b754-8a8f6c0e5ce0"), "Red", "Motorola", "Razr Plus", "5418064868", "128GB" },
                    { new Guid("7b483b60-90e2-4c89-836c-4ad8946b8aa7"), "Grey", "Samsung", "Galaxy S24 Ultra", "7187624769", "128GB" },
                    { new Guid("86a2e9d1-881f-4aba-ba25-e563b460a97a"), "Blue", "Samsung", "iPhone 15 Plus", "2105176786", "128GB" },
                    { new Guid("88ca3741-b8f4-44f6-baef-059389a34907"), "White", "Apple", "iPhone 13", "7712780071", "64GB" },
                    { new Guid("913cdb0e-2618-4c30-b760-0a78857eb0dd"), "Blue", "Apple", "iPhone 12", "5127710406", "128GB" },
                    { new Guid("97a612e4-13d6-43c0-805b-30fafa1ae05a"), "Mint Blue", "Google", "Pixel 8 Pro", "8472898809", "128GB" },
                    { new Guid("baf6fd9a-ee78-4512-b298-03bd824f3fbd"), "Purple", "Samsung", "Galaxy S21+", "2197287862", "512GB" },
                    { new Guid("cde3cf86-46fb-40b3-bd45-e64171469e9b"), "Black", "Apple", "iPhone 15 Plus", "2629423847", "64GB" },
                    { new Guid("f5222ea1-947e-45c1-a59a-a5a6e296b902"), "Blue", "Apple", "iPhone 15", "3036313605", "256GB" }
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
                table: "UserDevices",
                columns: new[] { "Id", "ActivationDate", "DeviceID", "UserPlanID" },
                values: new object[,]
                {
                    { new Guid("022ae233-4d11-40d3-8170-1b034022eb57"), new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "f5222ea1-947e-45c1-a59a-a5a6e296b902", "d1e5f1d3-d768-403c-9431-564e9cbe84bf" },
                    { new Guid("0cf43dcb-563d-4707-b2b3-7f6ff4d69f7f"), new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "4f05e337-e657-4848-9efe-8b291bf18f1f", "f512ba58-cc89-49f5-8489-367865917a8b" },
                    { new Guid("18d346f8-edcc-4700-ab34-4518cd044674"), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7b483b60-90e2-4c89-836c-4ad8946b8aa7", "d1e5f1d3-d768-403c-9431-564e9cbe84bf" },
                    { new Guid("5c38b804-3093-4c05-95c9-79caae650e15"), new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "97a612e4-13d6-43c0-805b-30fafa1ae05a", "f512ba58-cc89-49f5-8489-367865917a8b" },
                    { new Guid("ac3f3dc7-ebb4-4f8d-907b-c45f71a8d9a5"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "cde3cf86-46fb-40b3-bd45-e64171469e9b", "93e289fa-ffa4-484b-b66e-7df8078f9ed5" },
                    { new Guid("d80449d6-cabf-4bae-b7b8-1888ac1caab9"), new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "88ca3741-b8f4-44f6-baef-059389a34907", "f512ba58-cc89-49f5-8489-367865917a8b" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Email", "FirstName", "LastName", "Password", "Username" },
                values: new object[,]
                {
                    { new Guid("25f87c58-9061-4bb7-aa3a-4a05177481d2"), "123 Main St", "john.doe@example.com", "John", "Doe", "password1", "johndoe" },
                    { new Guid("3f86cc51-c688-42de-aa44-d35c5db73bc4"), "789 Loon St", "elmer.fudd@example.com", "Elmer", "Fudd", "password3", "elmerfudd" },
                    { new Guid("538091ec-802c-460d-a56e-8ce2414782b2"), "456 Elm St", "jane.smith@example.com", "Jane", "Smith", "password2", "janesmith" }
                });

            migrationBuilder.InsertData(
                table: "UserPlans",
                columns: new[] { "Id", "PlanId", "UserId" },
                values: new object[,]
                {
                    { new Guid("93e289fa-ffa4-484b-b66e-7df8078f9ed5"), new Guid("f6daf5fa-75fc-485a-8b6d-388e4132cfcc"), new Guid("25f87c58-9061-4bb7-aa3a-4a05177481d2") },
                    { new Guid("d1e5f1d3-d768-403c-9431-564e9cbe84bf"), new Guid("23d7dc69-ff2f-42e9-92d5-20aebbb0747f"), new Guid("538091ec-802c-460d-a56e-8ce2414782b2") },
                    { new Guid("f512ba58-cc89-49f5-8489-367865917a8b"), new Guid("1d5cc690-684b-4dc4-b4ac-1bdf90c97839"), new Guid("3f86cc51-c688-42de-aa44-d35c5db73bc4") }
                });

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
                name: "Devices");

            migrationBuilder.DropTable(
                name: "UserDevices");

            migrationBuilder.DropTable(
                name: "UserPlans");

            migrationBuilder.DropTable(
                name: "PhonePlans");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
