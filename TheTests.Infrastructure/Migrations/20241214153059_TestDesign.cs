using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheTests.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TestDesign : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36c7f0b6-42fb-499c-918a-79681f17769b", "AQAAAAIAAYagAAAAED6mWUBE1EfZnM6OUQ1SsM4lfZqg0JPXIKTn7xpjAK+/6gaR1n84w8P2s3kfJhpCpw==", "4a2b1df8-012f-458f-a7d7-8ce4dd45d8ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7f3d317-035a-46f8-9863-081861bb27b1", "AQAAAAIAAYagAAAAELbEuA24qkjgsXMvsOdE1ncowyITCWD1zLXeoLUuP45QyFTkYuLNet9N9fe+u4eAsw==", "11fb6e21-ad29-474c-bae0-b6483312cddc" });

            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedAt",
                value: new DateTime(2024, 12, 14, 15, 30, 58, 665, DateTimeKind.Utc).AddTicks(3071));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "706dbf06-077d-483a-ada0-dbf9dfd286bd", "AQAAAAIAAYagAAAAEL7sSPAPiDL99Cw2kblaL9VeXjsaqDMGvQVYH3ispGDpYZ3s+y4H1d65caOIGkJ0Cw==", "f5980242-f511-4422-8217-afdebcd3bf8e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db7e9969-183e-4dfb-8442-9c7039c34ddb", "AQAAAAIAAYagAAAAEO1lgnZ9bCfRP9dvpMe/UdGrZQcEJlX58YEfjo0mJBfl0e8/eDvSYyhEyWhU6uQh2A==", "2705a867-2f42-43a4-bca2-06b274b5dde0" });

            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedAt",
                value: new DateTime(2024, 12, 14, 15, 1, 12, 430, DateTimeKind.Utc).AddTicks(5062));
        }
    }
}
