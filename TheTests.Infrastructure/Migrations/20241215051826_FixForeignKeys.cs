using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheTests.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a98fbed6-e198-4492-82af-7432618b761e", "AQAAAAIAAYagAAAAEMUIeFmTNiUDjM/L+YmuLWL4T1mxaCxLSvC0uBemniMqfaZK83FPXEhim/6vFa/V+w==", "d9b20f09-9c08-4fa3-9079-7b235806b625" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5d6209b-2e71-49dc-9262-258b9c821d59", "AQAAAAIAAYagAAAAEG12n02BafAEBwbSk7Qu+dcMx+qe0WVg4ecX04/AAAZNpaEhj5K0lw1YtcBBeknoXw==", "db42c13d-897d-4479-962e-855cd570264c" });

            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedAt",
                value: new DateTime(2024, 12, 15, 5, 18, 25, 652, DateTimeKind.Utc).AddTicks(9712));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
