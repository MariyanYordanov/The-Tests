using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheTests.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixTestId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91fc0115-755a-4bfc-9125-f2e7063fa36c", "AQAAAAIAAYagAAAAEEk0bL1Ko2kMJYhewwVftDhEc6bY4s+4reM5GcorCTj9qOuxoNJdBe9Pv6RPE9LtRg==", "b770e6e2-2cea-4f2b-8881-5073c1848572" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a624027-dbc0-4f53-b732-171d8293cc8b", "AQAAAAIAAYagAAAAEKCc877yiE0scVrAiqcQCPYK2eRF2ISc5YSfhXSe13d/n0jlofwpBVVW+uCBttAfsw==", "f0ae67d1-6014-48d6-b9cc-85577085ed42" });

            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedAt",
                value: new DateTime(2024, 12, 19, 0, 39, 13, 531, DateTimeKind.Utc).AddTicks(4172));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47809187-f78c-4804-9332-c1cd20e7c548", "AQAAAAIAAYagAAAAECcg+/rMacphrK5xDR5ahZorM7QADN2oV99OJiYzAKlS+KImVaPMC+rm4Vb95rWqcA==", "15dec8f6-1854-4ae7-abab-87e3dd7e2d11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f889d262-568b-4cda-be4e-b84d05c27391", "AQAAAAIAAYagAAAAEJaYjuaPI+nzQAa0+payaSKdd7s2/gydz5puhyhKjdDhXYXmkhjY/NAx7N957/hsTg==", "0e26da49-0baf-4b8a-92f4-e282e4143dba" });

            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedAt",
                value: new DateTime(2024, 12, 19, 0, 29, 13, 519, DateTimeKind.Utc).AddTicks(6032));
        }
    }
}
