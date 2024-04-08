using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectTwoGroup3.Migrations
{
    /// <inheritdoc />
    public partial class Telecom3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Devices");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "UserDevices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "UserDevices",
                keyColumn: "Id",
                keyValue: new Guid("022ae233-4d11-40d3-8170-1b034022eb57"),
                column: "PhoneNumber",
                value: "3036313605");

            migrationBuilder.UpdateData(
                table: "UserDevices",
                keyColumn: "Id",
                keyValue: new Guid("0cf43dcb-563d-4707-b2b3-7f6ff4d69f7f"),
                column: "PhoneNumber",
                value: "2085544516");

            migrationBuilder.UpdateData(
                table: "UserDevices",
                keyColumn: "Id",
                keyValue: new Guid("18d346f8-edcc-4700-ab34-4518cd044674"),
                column: "PhoneNumber",
                value: "7187624769");

            migrationBuilder.UpdateData(
                table: "UserDevices",
                keyColumn: "Id",
                keyValue: new Guid("5c38b804-3093-4c05-95c9-79caae650e15"),
                column: "PhoneNumber",
                value: "8472898809");

            migrationBuilder.UpdateData(
                table: "UserDevices",
                keyColumn: "Id",
                keyValue: new Guid("ac3f3dc7-ebb4-4f8d-907b-c45f71a8d9a5"),
                column: "PhoneNumber",
                value: "2629423847");

            migrationBuilder.UpdateData(
                table: "UserDevices",
                keyColumn: "Id",
                keyValue: new Guid("d80449d6-cabf-4bae-b7b8-1888ac1caab9"),
                column: "PhoneNumber",
                value: "7712780071");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "UserDevices");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Devices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("4f05e337-e657-4848-9efe-8b291bf18f1f"),
                column: "PhoneNumber",
                value: "2085544516");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("6488bdee-e52c-442a-b754-8a8f6c0e5ce0"),
                column: "PhoneNumber",
                value: "5418064868");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("7b483b60-90e2-4c89-836c-4ad8946b8aa7"),
                column: "PhoneNumber",
                value: "7187624769");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("86a2e9d1-881f-4aba-ba25-e563b460a97a"),
                column: "PhoneNumber",
                value: "2105176786");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("88ca3741-b8f4-44f6-baef-059389a34907"),
                column: "PhoneNumber",
                value: "7712780071");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("913cdb0e-2618-4c30-b760-0a78857eb0dd"),
                column: "PhoneNumber",
                value: "5127710406");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("97a612e4-13d6-43c0-805b-30fafa1ae05a"),
                column: "PhoneNumber",
                value: "8472898809");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("baf6fd9a-ee78-4512-b298-03bd824f3fbd"),
                column: "PhoneNumber",
                value: "2197287862");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("cde3cf86-46fb-40b3-bd45-e64171469e9b"),
                column: "PhoneNumber",
                value: "2629423847");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("f5222ea1-947e-45c1-a59a-a5a6e296b902"),
                column: "PhoneNumber",
                value: "3036313605");
        }
    }
}
