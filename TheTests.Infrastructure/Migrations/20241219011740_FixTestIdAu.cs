using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheTests.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixTestIdAu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2e116e7-5c53-488a-a963-31e5172945c3", "AQAAAAIAAYagAAAAEHlUdelJkWdsZNPdba6Y7ib9kbonP6YexfnbJieJ1o8CuWktlldfjLyiJzn2eIiBFw==", "06048e5b-c8f8-4ff4-8a18-f44e40e3900a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1d148ab-3679-4fe4-93d1-ace050788731", "AQAAAAIAAYagAAAAELHlXb0sBGzl4uQ2HXqKIKSdJM5CMq75GDUCx5yGKb1KdtOeSRPYLujrxy8aauptLQ==", "26dbdfef-364c-4950-864a-d5ed20621928" });

            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedAt",
                value: new DateTime(2024, 12, 19, 1, 17, 40, 193, DateTimeKind.Utc).AddTicks(3405));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
