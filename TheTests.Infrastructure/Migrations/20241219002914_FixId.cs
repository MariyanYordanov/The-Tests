using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheTests.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47809187-f78c-4804-9332-c1cd20e7c548", "AQAAAAIAAYagAAAAECcg+/rMacphrK5xDR5ahZorM7QADN2oV99OJiYzAKlS+KImVaPMC+rm4Vb95rWqcA==", "15dec8f6-1854-4ae7-abab-87e3dd7e2d11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f889d262-568b-4cda-be4e-b84d05c27391", "AQAAAAIAAYagAAAAEJaYjuaPI+nzQAa0+payaSKdd7s2/gydz5puhyhKjdDhXYXmkhjY/NAx7N957/hsTg==", "0e26da49-0baf-4b8a-92f4-e282e4143dba" });

            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedAt",
                value: new DateTime(2024, 12, 19, 0, 29, 13, 519, DateTimeKind.Utc).AddTicks(6032));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b89ab72c-280f-4ac4-91fb-861db7f58532", "AQAAAAIAAYagAAAAEFyrtqZZ8t9o1h8Y7kvgKYsMsl45vgZsMbSGNbAgLwdravAYJGIdEN4Qml8hExifbA==", "368685c6-962f-4361-8fcc-dc036c9974ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d03ef28-b09d-40d3-8664-168f27db6ad5", "AQAAAAIAAYagAAAAEGFgt4svWe1OIMVRpcX33sCc8HvilCLVCEdUZLQhmYvZVhq5d5YgymXvHs/mJ0d6dg==", "8df4e648-3b82-41fb-bb38-f9003cb70227" });

            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedAt",
                value: new DateTime(2024, 12, 19, 0, 24, 24, 283, DateTimeKind.Utc).AddTicks(590));
        }
    }
}
