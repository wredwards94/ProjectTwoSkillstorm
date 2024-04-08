using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectTwoGroup3.Migrations
{
    /// <inheritdoc />
    public partial class TelecomDatabase2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "UserPlanID",
                table: "UserDevices",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "DeviceID",
                table: "UserDevices",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "UserDevices",
                keyColumn: "Id",
                keyValue: new Guid("022ae233-4d11-40d3-8170-1b034022eb57"),
                columns: new[] { "DeviceID", "UserPlanID" },
                values: new object[] { new Guid("f5222ea1-947e-45c1-a59a-a5a6e296b902"), new Guid("d1e5f1d3-d768-403c-9431-564e9cbe84bf") });

            migrationBuilder.UpdateData(
                table: "UserDevices",
                keyColumn: "Id",
                keyValue: new Guid("0cf43dcb-563d-4707-b2b3-7f6ff4d69f7f"),
                columns: new[] { "DeviceID", "UserPlanID" },
                values: new object[] { new Guid("4f05e337-e657-4848-9efe-8b291bf18f1f"), new Guid("f512ba58-cc89-49f5-8489-367865917a8b") });

            migrationBuilder.UpdateData(
                table: "UserDevices",
                keyColumn: "Id",
                keyValue: new Guid("18d346f8-edcc-4700-ab34-4518cd044674"),
                columns: new[] { "DeviceID", "UserPlanID" },
                values: new object[] { new Guid("7b483b60-90e2-4c89-836c-4ad8946b8aa7"), new Guid("d1e5f1d3-d768-403c-9431-564e9cbe84bf") });

            migrationBuilder.UpdateData(
                table: "UserDevices",
                keyColumn: "Id",
                keyValue: new Guid("5c38b804-3093-4c05-95c9-79caae650e15"),
                columns: new[] { "DeviceID", "UserPlanID" },
                values: new object[] { new Guid("97a612e4-13d6-43c0-805b-30fafa1ae05a"), new Guid("f512ba58-cc89-49f5-8489-367865917a8b") });

            migrationBuilder.UpdateData(
                table: "UserDevices",
                keyColumn: "Id",
                keyValue: new Guid("ac3f3dc7-ebb4-4f8d-907b-c45f71a8d9a5"),
                columns: new[] { "DeviceID", "UserPlanID" },
                values: new object[] { new Guid("cde3cf86-46fb-40b3-bd45-e64171469e9b"), new Guid("93e289fa-ffa4-484b-b66e-7df8078f9ed5") });

            migrationBuilder.UpdateData(
                table: "UserDevices",
                keyColumn: "Id",
                keyValue: new Guid("d80449d6-cabf-4bae-b7b8-1888ac1caab9"),
                columns: new[] { "DeviceID", "UserPlanID" },
                values: new object[] { new Guid("88ca3741-b8f4-44f6-baef-059389a34907"), new Guid("f512ba58-cc89-49f5-8489-367865917a8b") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserPlanID",
                table: "UserDevices",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeviceID",
                table: "UserDevices",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "UserDevices",
                keyColumn: "Id",
                keyValue: new Guid("022ae233-4d11-40d3-8170-1b034022eb57"),
                columns: new[] { "DeviceID", "UserPlanID" },
                values: new object[] { "f5222ea1-947e-45c1-a59a-a5a6e296b902", "d1e5f1d3-d768-403c-9431-564e9cbe84bf" });

            migrationBuilder.UpdateData(
                table: "UserDevices",
                keyColumn: "Id",
                keyValue: new Guid("0cf43dcb-563d-4707-b2b3-7f6ff4d69f7f"),
                columns: new[] { "DeviceID", "UserPlanID" },
                values: new object[] { "4f05e337-e657-4848-9efe-8b291bf18f1f", "f512ba58-cc89-49f5-8489-367865917a8b" });

            migrationBuilder.UpdateData(
                table: "UserDevices",
                keyColumn: "Id",
                keyValue: new Guid("18d346f8-edcc-4700-ab34-4518cd044674"),
                columns: new[] { "DeviceID", "UserPlanID" },
                values: new object[] { "7b483b60-90e2-4c89-836c-4ad8946b8aa7", "d1e5f1d3-d768-403c-9431-564e9cbe84bf" });

            migrationBuilder.UpdateData(
                table: "UserDevices",
                keyColumn: "Id",
                keyValue: new Guid("5c38b804-3093-4c05-95c9-79caae650e15"),
                columns: new[] { "DeviceID", "UserPlanID" },
                values: new object[] { "97a612e4-13d6-43c0-805b-30fafa1ae05a", "f512ba58-cc89-49f5-8489-367865917a8b" });

            migrationBuilder.UpdateData(
                table: "UserDevices",
                keyColumn: "Id",
                keyValue: new Guid("ac3f3dc7-ebb4-4f8d-907b-c45f71a8d9a5"),
                columns: new[] { "DeviceID", "UserPlanID" },
                values: new object[] { "cde3cf86-46fb-40b3-bd45-e64171469e9b", "93e289fa-ffa4-484b-b66e-7df8078f9ed5" });

            migrationBuilder.UpdateData(
                table: "UserDevices",
                keyColumn: "Id",
                keyValue: new Guid("d80449d6-cabf-4bae-b7b8-1888ac1caab9"),
                columns: new[] { "DeviceID", "UserPlanID" },
                values: new object[] { "88ca3741-b8f4-44f6-baef-059389a34907", "f512ba58-cc89-49f5-8489-367865917a8b" });
        }
    }
}
