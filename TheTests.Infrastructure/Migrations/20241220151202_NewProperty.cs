using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheTests.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NewProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26b260ec-78f6-48d9-aba7-e14a4e653545", "AQAAAAIAAYagAAAAEAR+2oA6rPJHlCAbBnNFHPbHvVq2F+6/FtPpzlZuXwkUqrMphYL9GMnXaR934p1z7g==", "96ee7ee4-153d-40c5-9cbf-8df4595358da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56620bef-95be-4be4-9d45-0383165c658a", "AQAAAAIAAYagAAAAEAO3C3QmX3oq75Efpw8tk94yACgftPtKZ7SHPumTJTGScNQ0OfO01xlGl6w5JTYWOw==", "11814270-2610-4426-ac13-30702ea3303e" });

            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedAt",
                value: new DateTime(2024, 12, 20, 15, 12, 1, 507, DateTimeKind.Utc).AddTicks(8082));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36d56ba1-ada5-497c-a6ef-1b651a58d776", "AQAAAAIAAYagAAAAENjFo74lq+rmpl3nTrQYshUGMugJksWzvidjvxZVUud7LunL/i5axuDMBqsWwfC0Qw==", "79b49032-c9da-4627-95d0-1d102efb2977" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f07a3a9b-53cd-4511-a387-321fea2b239e", "AQAAAAIAAYagAAAAEJQ+2wTgIf+uzb82mLVdd8lrdf7lZeWq63yaYgc+baLPZom6qmokS4S2YGO3AVy5hQ==", "c2283236-9864-47a5-b639-2e1afc0bec93" });

            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedAt",
                value: new DateTime(2024, 12, 20, 15, 3, 47, 300, DateTimeKind.Utc).AddTicks(9003));
        }
    }
}
