using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheTests.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTestEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Categories_CategoryId",
                table: "Tests");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6183c19-d174-4e96-8874-03dfce1759a5", "AQAAAAIAAYagAAAAEPt1WkeVpah+uA+8lm4nJXcxmEn+mgSI/emPsT+/ISi0bYbcPxSf0xemncj4mMRMOg==", "cfa9e7c5-72c5-4889-a111-4bd954db6701" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bd34834-4c76-4317-bb31-7c6844a0b6c2", "AQAAAAIAAYagAAAAEEkG909StANK4sRhgRb5ThABbLSHRmrD6jZrmWWIzUy986XDs17+FnAS1tKKuqWxtg==", "f7989f4c-7525-4f68-a3fe-8c9a93a21666" });

            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedAt",
                value: new DateTime(2024, 12, 14, 15, 58, 58, 677, DateTimeKind.Utc).AddTicks(7097));

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Categories_CategoryId",
                table: "Tests",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Categories_CategoryId",
                table: "Tests");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36c7f0b6-42fb-499c-918a-79681f17769b", "AQAAAAIAAYagAAAAED6mWUBE1EfZnM6OUQ1SsM4lfZqg0JPXIKTn7xpjAK+/6gaR1n84w8P2s3kfJhpCpw==", "4a2b1df8-012f-458f-a7d7-8ce4dd45d8ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7f3d317-035a-46f8-9863-081861bb27b1", "AQAAAAIAAYagAAAAELbEuA24qkjgsXMvsOdE1ncowyITCWD1zLXeoLUuP45QyFTkYuLNet9N9fe+u4eAsw==", "11fb6e21-ad29-474c-bae0-b6483312cddc" });

            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedAt",
                value: new DateTime(2024, 12, 14, 15, 30, 58, 665, DateTimeKind.Utc).AddTicks(3071));

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Categories_CategoryId",
                table: "Tests",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
