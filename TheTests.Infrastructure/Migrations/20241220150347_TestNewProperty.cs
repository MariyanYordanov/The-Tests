using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheTests.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TestNewProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
