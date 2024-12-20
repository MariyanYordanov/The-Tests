using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheTests.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TestFixFunc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58d80376-d03a-4c06-af55-ea2dfc7d1fb4", "AQAAAAIAAYagAAAAEJ82Y6PLeJviHnpJpzfL/RNjJlzLGjM0+6Bhw9XmzXApOzD2CjmPC5cfTazI6psElA==", "250347a3-a6c7-468b-bf48-997e5d859acd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db50cbeb-5102-4263-8084-0a3de85df3b2", "AQAAAAIAAYagAAAAEJK/3dDwcTmtDQA+8iOLyIsigwV1e4dt1coYLDzpMaIIIpr7R0xSfr92Ph6tDb3GXQ==", "73d696a0-9eae-47e0-aa8a-a044d4fb3c2e" });

            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedAt",
                value: new DateTime(2024, 12, 20, 10, 17, 50, 916, DateTimeKind.Utc).AddTicks(1609));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e0c4816-8f16-4942-91f4-bb58e8ef304b", "AQAAAAIAAYagAAAAEC1qAQIijU3Jy5/RFjpHVjxjVs/ajjDkyDw5GHx9g7BmBNmvguiG3H5nJzhn7A5k+w==", "44ca5d3a-60fe-45bb-9534-19d7ae15163f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ada36ec5-9124-45aa-853c-ada952eb4fe7", "AQAAAAIAAYagAAAAEBekRk8PNVk3o7+bRAV5mthOmarMgyEjHGWWzbvnX3XA2BwVm6oOPmD69TL5j5dkTA==", "95b1656d-c8fd-4724-9d59-68f9d7de9bfd" });

            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedAt",
                value: new DateTime(2024, 12, 20, 5, 23, 0, 930, DateTimeKind.Utc).AddTicks(8895));
        }
    }
}
