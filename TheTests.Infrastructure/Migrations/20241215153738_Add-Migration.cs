using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheTests.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78399847-1ccf-437a-a11b-caacdcfa3298", "AQAAAAIAAYagAAAAEN2woXhlxxh3HlLcJJcokhalSUdBG7vQPfZ0jyhrRAN75psHJW/HcgBSKJGZYvGEew==", "2fda337e-6106-4084-964d-4eba2d5572a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "405461ed-3c9f-4685-81cf-5b7197777a5d", "AQAAAAIAAYagAAAAEDt2yNLl3PG4znQmHIKvAU8bxwxsPtWGSX5KQP8CFmEdEvynFAIWVc5Cs7zC15lv7Q==", "1851b083-22d8-4606-ba9b-6d5629bc9f1d" });

            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedAt",
                value: new DateTime(2024, 12, 15, 15, 37, 37, 660, DateTimeKind.Utc).AddTicks(9241));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b2353e3-a20b-4d35-819f-b35250c83e91", "AQAAAAIAAYagAAAAEIDon9GlOp9KveS3g3LjMEcs6nmsz85GWSx47lKsIvMHXMqVuX0sszne1A3K+DW7gg==", "c7aa4c9c-8a5e-4eae-a792-a44187c5be63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2357d76-4e21-41ed-8cd7-5769c93a6848", "AQAAAAIAAYagAAAAEO1+aM0sp/Ewti6HBnzbUriB79yHt7eE8wW160pbGKy8m5ALBmzAJIJdTDG2tgPtBQ==", "d61e1d52-8808-43a1-b67f-7b8f518ee361" });

            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedAt",
                value: new DateTime(2024, 12, 15, 15, 17, 45, 759, DateTimeKind.Utc).AddTicks(7979));
        }
    }
}
