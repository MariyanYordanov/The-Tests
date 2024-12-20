using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheTests.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TestNewProp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Tests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsPublished",
                table: "Tests",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "PassPoints",
                table: "Tests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "259424b4-979d-4dde-9093-5f3bc93c0d17", "AQAAAAIAAYagAAAAEHD3QClg5wONh7FOZSOpWbZBAEC64FZ9MXeXebo9PzEGyHpdxX05oydRwhJeYxe7nQ==", "39e52bcb-527f-4196-9800-28c840b0cd4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e01220e8-4c17-4861-b714-1d7f897e41a5", "AQAAAAIAAYagAAAAEABlF2+0ujdKMSLEqQ93lmPbiLjfsgIkTgZHtZM+18AyHTca4mKEi1zIwkPsFhldGQ==", "7209d178-88e4-4a1a-93c4-17f93523d5ec" });

            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedAt",
                value: new DateTime(2024, 12, 20, 13, 58, 59, 611, DateTimeKind.Utc).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsPublished", "PassPoints" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "IsPublished",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "PassPoints",
                table: "Tests");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58d80376-d03a-4c06-af55-ea2dfc7d1fb4", "AQAAAAIAAYagAAAAEJ82Y6PLeJviHnpJpzfL/RNjJlzLGjM0+6Bhw9XmzXApOzD2CjmPC5cfTazI6psElA==", "250347a3-a6c7-468b-bf48-997e5d859acd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db50cbeb-5102-4263-8084-0a3de85df3b2", "AQAAAAIAAYagAAAAEJK/3dDwcTmtDQA+8iOLyIsigwV1e4dt1coYLDzpMaIIIpr7R0xSfr92Ph6tDb3GXQ==", "73d696a0-9eae-47e0-aa8a-a044d4fb3c2e" });

            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedAt",
                value: new DateTime(2024, 12, 20, 10, 17, 50, 916, DateTimeKind.Utc).AddTicks(1609));
        }
    }
}
