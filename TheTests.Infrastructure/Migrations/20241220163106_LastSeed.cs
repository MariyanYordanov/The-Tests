using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheTests.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class LastSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fc73890-656d-41d9-be93-ab1e33cc69b7", "AQAAAAIAAYagAAAAELmadADYkjIPubhPSYCqE/hd3bshdCV5gqbMNwvwbwzeYwiy95oBnqENJLEb/WuZtg==", "747789dc-2237-49af-be87-72286d496275" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a34675bc-95c7-4e6d-a151-388bff139df9", "AQAAAAIAAYagAAAAEByUJ7VTxH5QYLZLGwaCIM+RRQjzj3vlQMebc+b4Z8Ywegp8+Ql7aeSUDASqrSjZTA==", "3bf164ac-e46c-454a-bceb-952c131f1b4d" });

            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedAt",
                value: new DateTime(2024, 12, 20, 15, 48, 53, 760, DateTimeKind.Utc).AddTicks(8177));
        }
    }
}
