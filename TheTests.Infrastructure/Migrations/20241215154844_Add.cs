using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheTests.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a73ed09-b0ae-44e4-8102-b0d57ee89aad", "AQAAAAIAAYagAAAAEGkLAxk+rvKvqWbVNwv38IOVqW2jXsLdlVfLqgR/flWPavO5ffEY4uA8QXyAt8fUwg==", "247805c3-bea1-46dd-8e27-53235458e5f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b47d986-de88-451e-a9a4-08cb0f76fdff", "AQAAAAIAAYagAAAAEBzfYQeek2X3Ea/s5yIogoGpztkV1FvKxbmT0XfP6OO51Qw+rfqRNxdBiFc+fdj4DQ==", "6b6c733c-54e9-4888-ba50-e1851dcbc046" });

            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedAt",
                value: new DateTime(2024, 12, 15, 15, 48, 43, 948, DateTimeKind.Utc).AddTicks(4868));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
