using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheTests.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e74d4921-5838-4412-bc9d-44b81945b117", "AQAAAAIAAYagAAAAEDB6vMFwdlK5a9/OkMNJbJYiYTr/IyZ4ZY2+46R8FJhUuTJxNG6KGWzZ4ReEaKYwZw==", "523973b4-2e05-4896-a51f-4f127bf45b72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb4fe8f4-ea5b-4085-a874-29b49bc55797", "AQAAAAIAAYagAAAAEHfMeiv/NcERC4S6s287IJM3Jnsx41yVE1d+EQKtVatLNWEV+SCZK6H4MKQuI5vHwQ==", "70071bd4-abdc-463b-b028-f4890ba612e2" });

            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedAt",
                value: new DateTime(2024, 12, 17, 11, 49, 9, 597, DateTimeKind.Utc).AddTicks(5748));
        }
    }
}
