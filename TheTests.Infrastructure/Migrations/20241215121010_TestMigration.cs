using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheTests.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TestMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f49ee6e6-81c7-40fe-bdea-31a6d9cdbb89", "AQAAAAIAAYagAAAAEGEbp2CvAbsTYGHXV1pfc6bDf+Mj0SmYS10iH7dWdgKLeDPWD/nf4aRCKonWngkl3A==", "7bbb9a02-acba-44c4-9add-5c17812c042b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9f27cbf-4840-4851-9f20-7999253b9e88", "AQAAAAIAAYagAAAAEKpZgdwBCF6RK6fz0ArBhBgAgwDNQc/yd41CMIcJiBUqfbDMF76fu11sneAKfsGyWQ==", "6f7db79f-19ee-46e0-9dc3-5c92e871d69e" });

            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedAt",
                value: new DateTime(2024, 12, 15, 12, 5, 14, 584, DateTimeKind.Utc).AddTicks(5455));
        }
    }
}
