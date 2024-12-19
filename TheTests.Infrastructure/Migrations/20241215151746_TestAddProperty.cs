using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheTests.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TestAddProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Tests",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsActive",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Tests");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e5ea2c6-86ff-44ad-9355-79f33e1f58a4", "AQAAAAIAAYagAAAAEFmvhBWX9YDCFr5Lx5Yx5RTUGR4ieH0ygw2Mn9nJImPvDq7nvIqsHOYbgUVz5bXruw==", "d194e4ba-beb1-42dd-a272-1374c313b3fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "343fb5f7-8454-44a6-9d9a-f622a571007c", "AQAAAAIAAYagAAAAEDzBmLsoM5b+zalpCRCfIfcvMQ/f0MA6aopsUY1u3UCaFsnZNXKyrzw17meROBnv6g==", "f4a833dc-7f22-4c03-b074-17bca852aa7b" });

            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedAt",
                value: new DateTime(2024, 12, 15, 12, 10, 9, 496, DateTimeKind.Utc).AddTicks(4216));
        }
    }
}
