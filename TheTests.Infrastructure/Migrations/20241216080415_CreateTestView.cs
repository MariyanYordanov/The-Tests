using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheTests.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreateTestView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0a7ca89-f478-495d-806f-b6aaad8f6959", "AQAAAAIAAYagAAAAEGgGITviGZgvoZ9fPlQLogxL7Qa6cTRcj29GWnDsUNkypuSWs43WHfblqhnLWQ/6og==", "6b434bcf-f098-478d-8fc5-981a034e5c12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b093035d-9c46-48ae-b087-edcf7dd0e827", "AQAAAAIAAYagAAAAEJm3z9ExHHvLEhRTtcstVPeg5jTk7fLWEG3ZVs3UL9bxzf2PoMIhD7emyYjHd5HT+w==", "e10b9e02-e106-4e7b-8577-f8058d120128" });

            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedAt",
                value: new DateTime(2024, 12, 16, 8, 4, 14, 797, DateTimeKind.Utc).AddTicks(2473));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
