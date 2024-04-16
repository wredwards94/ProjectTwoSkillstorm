using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StarTelecom.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    DeviceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Storage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    UserPlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BillingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Billing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Billing_UserPlans_UserPlanId",
                        column: x => x.UserPlanId,
                        principalTable: "UserPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                values: new object[] { "2f36135b-36cd-4874-9ee2-a34f4355d157", null, "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "25f87c58-9061-4bb7-aa3a-4a05177481d2", 0, "123 Main St", "8d909e99-6048-4c7f-b6a3-94935a9b55f9", "john.doe@example.com", false, "John", "Doe", false, null, null, null, "password1", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f8b513fc-fe70-4361-a30a-21e511be3902", false, "johndoe" },
                    { "3f86cc51-c688-42de-aa44-d35c5db73bc4", 0, "789 Loon St", "7c915618-fb06-4dde-ac5a-4e7f6cf0b2df", "elmer.fudd@example.com", false, "Elmer", "Fudd", false, null, null, null, "password3", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4f9cb157-c972-40ea-b130-98ae79ca43f4", false, "elmerfudd" },
                    { "538091ec-802c-460d-a56e-8ce2414782b2", 0, "456 Elm St", "30bcc623-a3cc-4b5d-995e-7a9a2bea42da", "jane.smith@example.com", false, "Jane", "Smith", false, null, null, null, "password2", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "56fcd3cd-4460-494f-b812-f22364fc0b72", false, "janesmith" }
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "DeviceId", "Color", "Manufacturer", "Model", "PictureUrl", "Storage" },
                values: new object[,]
                {
                    { new Guid("4f05e337-e657-4848-9efe-8b291bf18f1f"), "Lemongrass", "Google", "Pixel 7", "https://ss7.vzw.com/is/image/VerizonWireless/google-pixel-7-lemongrass-128-gb-ga03543-us?wid=930&hei=930&fmt=webp", "256GB" },
                    { new Guid("6488bdee-e52c-442a-b754-8a8f6c0e5ce0"), "Magenta", "Motorola", "Razr Plus", "https://cdn.tmobile.com/content/dam/t-mobile/en-p/cell-phones/Motorola/Motorola-razr-Plus-2023/Viva-Magenta/Motorola-razr-Plus-2023-Viva-Magenta-frontimage.png", "128GB" },
                    { new Guid("7b483b60-90e2-4c89-836c-4ad8946b8aa7"), "Titanium Grey", "Samsung", "Galaxy S24 Ultra", "https://ss7.vzw.com/is/image/VerizonWireless/samsung-eureka-e3-titaniumgray?wid=930&hei=930&fmt=webp", "128GB" },
                    { new Guid("86a2e9d1-881f-4aba-ba25-e563b460a97a"), "Blue", "Samsung", "iPhone 15 Plus", "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6525/6525390_sd.jpg;maxHeight=640;maxWidth=550", "128GB" },
                    { new Guid("88ca3741-b8f4-44f6-baef-059389a34907"), "Starlight", "Apple", "iPhone 13", "https://ss7.vzw.com/is/image/VerizonWireless/apple-iphone-13-starlight-09142021?wid=930&hei=930&fmt=webp", "64GB" },
                    { new Guid("913cdb0e-2618-4c30-b760-0a78857eb0dd"), "Blue", "Apple", "iPhone 12", "https://ss7.vzw.com/is/image/VerizonWireless/apple-iphone-12-blue-10132020?wid=930&hei=930&fmt=webp", "128GB" },
                    { new Guid("97a612e4-13d6-43c0-805b-30fafa1ae05a"), "Bay", "Google", "Pixel 8 Pro", "https://ss7.vzw.com/is/image/VerizonWireless/google-husky-bay-2023?wid=930&hei=930&fmt=webp", "128GB" },
                    { new Guid("baf6fd9a-ee78-4512-b298-03bd824f3fbd"), "Purple", "Samsung", "Galaxy S21+", "https://www.backmarket.com/cdn-cgi/image/format%3Dauto%2Cquality%3D75%2Cwidth%3D640/https://d2e6ccujb3mkqf.cloudfront.net/375691a8-f3d2-40ab-9bb8-7a187fa42f13-1_3230d8e7-e02d-4da1-bf4b-b3d2d1c889b9.jpg", "512GB" },
                    { new Guid("cde3cf86-46fb-40b3-bd45-e64171469e9b"), "Black", "Apple", "iPhone 15 Plus", "https://ss7.vzw.com/is/image/VerizonWireless/apple-iphone-15-plus-128gb-black-mtxr3ll-a-a?wid=930&hei=930&fmt=webp", "64GB" },
                    { new Guid("f5222ea1-947e-45c1-a59a-a5a6e296b902"), "Blue", "Apple", "iPhone 15", "https://ss7.vzw.com/is/image/VerizonWireless/apple-iphone-15-128gb-blue-prepaid-mtpm3ll-a-a?wid=930&hei=930&fmt=webp", "256GB" }
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
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Billing");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "UserDevices");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "UserPlans");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "PhonePlans");
        }
    }
}
