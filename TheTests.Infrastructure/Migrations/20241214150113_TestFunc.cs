using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheTests.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TestFunc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "706dbf06-077d-483a-ada0-dbf9dfd286bd", "JOHN.DOE", "AQAAAAIAAYagAAAAEL7sSPAPiDL99Cw2kblaL9VeXjsaqDMGvQVYH3ispGDpYZ3s+y4H1d65caOIGkJ0Cw==", "f5980242-f511-4422-8217-afdebcd3bf8e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db7e9969-183e-4dfb-8442-9c7039c34ddb", "JANE.SMITH", "AQAAAAIAAYagAAAAEO1lgnZ9bCfRP9dvpMe/UdGrZQcEJlX58YEfjo0mJBfl0e8/eDvSYyhEyWhU6uQh2A==", "2705a867-2f42-43a4-bca2-06b274b5dde0" });

            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedAt",
                value: new DateTime(2024, 12, 14, 15, 1, 12, 430, DateTimeKind.Utc).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 1,
                column: "QuestionType",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuestionType",
                table: "Tests");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "247c1d26-4e2b-4a4e-9431-01008b3c3c34", null, "AQAAAAIAAYagAAAAEPcfoscEcRdbsAEl9rWeJWmIWdpMdm+aqBnrB57KCjIXo3/wE/qHbHtAm1BK4HX8Bw==", "560b1beb-f54c-4745-8de3-f17a76eef5fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cdadd46f-0e82-46dc-9aa8-aeb204a467d6", null, "AQAAAAIAAYagAAAAEOwGFHK4z5juJTThc42VYCOi/wwnHYdSFGMhVZ785rvmzNcV+SnO+ZO1fmxi/LXSaw==", "d92a99b7-2286-4bf4-aa6d-e57baf44a763" });

            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedAt",
                value: new DateTime(2024, 12, 14, 2, 1, 49, 55, DateTimeKind.Utc).AddTicks(9521));
        }
    }
}
