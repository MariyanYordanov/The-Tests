using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheTests.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixTestIdAutoIncrement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2571ac44-f98c-4064-89d6-644b1e09accd", "AQAAAAIAAYagAAAAELBw6UuMu+owpus0fC1ISWPikqFMKm8cLfStpfZnG1yNDXzRS6mIZ3/2oq1hoNbqGA==", "61cd63cf-9883-460e-9da2-3c37f43fb646" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "caea920e-e711-4a34-9bde-4c5376bb7d5c", "AQAAAAIAAYagAAAAEK3O9q7uIqm7rD1b223LETW+c2D9aQyBKpTsGc9cNRyBO/u5CYiVxbWirEPVTCFbWQ==", "5bc7acb0-8507-4073-b2c6-ee4462067a78" });

            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedAt",
                value: new DateTime(2024, 12, 19, 1, 6, 46, 921, DateTimeKind.Utc).AddTicks(5688));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
