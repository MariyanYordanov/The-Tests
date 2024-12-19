using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheTests.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixTestCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuestionType",
                table: "Tests");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuestionType",
                table: "Tests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b9bf9aa-025d-44cd-be00-e6a95589104f", "AQAAAAIAAYagAAAAEGHsKanLR4CIGD4/ueOH2QqU67iMYOgBddyakErIM81MOKtP8/CpjYIRH72BJTFWzQ==", "36f7b161-7501-4077-9333-f62a58d5c9c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe375992-64eb-444c-a01f-b3973e4c41dd", "AQAAAAIAAYagAAAAEIqml8/iIsvhujCHmxu2+O+RtF9WztALpDeJf9NrFb1QKya8b0mP9autb8Wpd3Zw7A==", "6f2fbc90-8e26-44ec-847d-970ba1d22373" });

            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedAt",
                value: new DateTime(2024, 12, 15, 10, 24, 24, 205, DateTimeKind.Utc).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 1,
                column: "QuestionType",
                value: 0);
        }
    }
}
