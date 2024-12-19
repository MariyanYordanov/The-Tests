using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheTests.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixTestModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67e89a0d-02d5-4cf3-ae0c-85b7afd1a81c", "AQAAAAIAAYagAAAAEDiSj7kD54GqcLPxS9vDmBiffoL5BuW8fBPoSO4NJwkLDkMJLP0OYyVPIBj4+01xjQ==", "c6936856-01f2-44df-a023-5a903dc7ee47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b90b09a-5eb2-42f4-a279-ec29212c5be5", "AQAAAAIAAYagAAAAENx6LGQGvk+7Rv/5BB5doGEeglxP1zaU4+uzu618utnzRpYjrXKcI6zfMTzQprfaIQ==", "65f68a59-cbe2-4b2f-88da-a3666cd1df00" });

            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedAt",
                value: new DateTime(2024, 12, 15, 11, 52, 37, 776, DateTimeKind.Utc).AddTicks(7106));
        }
    }
}
