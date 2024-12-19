using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheTests.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreateAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5578d9d1-fefe-4714-823b-4d3dfcc1852a", "AQAAAAIAAYagAAAAELLKS0HK3yi8rCq0HFuKpgiwCbdqvmRU+gq+5Grv4LauNFUOhY+u4abt89zgEpk/sA==", "62184d32-b213-49ab-ab2c-30ecf057ff60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57561dcb-e595-4dab-a482-c547b4d28017", "AQAAAAIAAYagAAAAEJ/Wt2yUpDjEayrWL88upDR6osg/1YIFBvoFP2o/5uc5ryDXwNHoRZ/Z+nSFy1iepg==", "98095c07-b181-43e5-b9f3-0e8cdb3c103d" });

            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedAt",
                value: new DateTime(2024, 12, 17, 10, 16, 10, 987, DateTimeKind.Utc).AddTicks(7564));
        }
    }
}
