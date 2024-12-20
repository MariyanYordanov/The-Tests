using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheTests.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixPublish : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPublished",
                table: "Tests");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6bd92df5-be98-49c1-83d2-d9ff86006d6b", "AQAAAAIAAYagAAAAEJjVWtlUYJyFEtRjLrySYQ5oxcJqGBWAb2Pdq3ZMKdL7sSteuGaT/V6H1cS3GaMb6A==", "8fa383bd-f195-45c3-9459-e8179b1a0cbe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d70b810-ef4e-4a11-803e-79989ccdc904", "AQAAAAIAAYagAAAAEDI7YGkLXIh6J0OjRtYCbo0P08b/E5FKmApYJhSHZijyDw5WyMvXXK7JREPZgeYQ1Q==", "0f95812c-0b4a-498c-a93a-1f6fa39aa2c7" });

            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedAt",
                value: new DateTime(2024, 12, 20, 17, 32, 26, 888, DateTimeKind.Utc).AddTicks(2324));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPublished",
                table: "Tests",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49e3a18d-840e-4af1-920f-d58282bdbe02", "AQAAAAIAAYagAAAAELntSze/9pyIemQY6kPtkCgJ4kmgrwRK8OrstJ7V0co+ndS+oemByATs+uUH5x0PgQ==", "c1e2c065-e074-48ff-ba59-e1fb2e332450" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37a744de-87f5-45cd-8e21-288f6001f7a3", "AQAAAAIAAYagAAAAEHo7rCAM867A+BgKQfBAm2xzL1GIZ4JSutVxJ9Wgdvm5Bf50e/8p7XccwSE6lp2VgQ==", "ca354140-cef2-4daf-ba6b-1c70b2ce755f" });

            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedAt",
                value: new DateTime(2024, 12, 20, 16, 31, 6, 246, DateTimeKind.Utc).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsPublished",
                value: false);
        }
    }
}
