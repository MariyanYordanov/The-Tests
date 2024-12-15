using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheTests.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "Tests",
                comment: "The test entity.");

            migrationBuilder.AlterTable(
                name: "Results",
                comment: "The result entity.");

            migrationBuilder.AlterTable(
                name: "Questions",
                comment: "The question entity.");

            migrationBuilder.AlterTable(
                name: "Categories",
                comment: "The category entity.");

            migrationBuilder.AlterTable(
                name: "AspNetUsers",
                comment: "The application user entity.");

            migrationBuilder.AlterTable(
                name: "Answers",
                comment: "The answer entity.");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "Tests",
                oldComment: "The test entity.");

            migrationBuilder.AlterTable(
                name: "Results",
                oldComment: "The result entity.");

            migrationBuilder.AlterTable(
                name: "Questions",
                oldComment: "The question entity.");

            migrationBuilder.AlterTable(
                name: "Categories",
                oldComment: "The category entity.");

            migrationBuilder.AlterTable(
                name: "AspNetUsers",
                oldComment: "The application user entity.");

            migrationBuilder.AlterTable(
                name: "Answers",
                oldComment: "The answer entity.");

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
    }
}
