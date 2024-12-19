using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheTests.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Create : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0a7ca89-f478-495d-806f-b6aaad8f6959", "AQAAAAIAAYagAAAAEGgGITviGZgvoZ9fPlQLogxL7Qa6cTRcj29GWnDsUNkypuSWs43WHfblqhnLWQ/6og==", "6b434bcf-f098-478d-8fc5-981a034e5c12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b093035d-9c46-48ae-b087-edcf7dd0e827", "AQAAAAIAAYagAAAAEJm3z9ExHHvLEhRTtcstVPeg5jTk7fLWEG3ZVs3UL9bxzf2PoMIhD7emyYjHd5HT+w==", "e10b9e02-e106-4e7b-8577-f8058d120128" });

            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedAt",
                value: new DateTime(2024, 12, 16, 8, 4, 14, 797, DateTimeKind.Utc).AddTicks(2473));
        }
    }
}
