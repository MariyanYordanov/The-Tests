using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheTests.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixBool : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "edf1dd94-70ef-4cc0-9e8e-ee600573eb52", "AQAAAAIAAYagAAAAEBaC+G1gLrD9z+ZNJB2MWB3Rvh3HY4nqCf8/qOfMw7ve6bKgzRQwC//pgUUrpIVooQ==", "b43d0501-118d-4c69-8aed-d40a0f84787c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f22ecf07-5e75-4e77-a78c-4d8fa65a2e24", "AQAAAAIAAYagAAAAECi5Hd5QQzoWBBUDh7ePMXOREuQkTOr22tE7BjcJcNbFuKTw42Q5d5Odr7scqJLJNg==", "cf283422-1454-4db3-b7b6-925bc0f3b899" });

            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedAt",
                value: new DateTime(2024, 12, 19, 7, 50, 47, 759, DateTimeKind.Utc).AddTicks(8810));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
