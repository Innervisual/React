using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Data.Migrations
{
    public partial class addedstringcityforsendingtoreact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "528cc81f-ab11-4f74-8b81-751e24836d6b");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d0c54505-6795-45df-ae8b-a4a9bfcf2cfc", "e9ef88a4-a226-4c61-a230-02f6be638afa" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9ef88a4-a226-4c61-a230-02f6be638afa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0c54505-6795-45df-ae8b-a4a9bfcf2cfc");

            migrationBuilder.AddColumn<string>(
                name: "tempCityName",
                table: "People",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "265a8f74-1bca-4253-a6f1-136b68f33d0b", "52f63f2b-bf7b-40cf-ada1-9d6dff09020e", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5f5b76df-871f-43d2-a604-64b8b56e8655", "560ca7ab-1c61-473a-8dcb-a1f1a39acac8", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "405bcfc4-bb1f-4d34-9c57-28171a3a6d83", 0, 640424, "597f3578-6d29-4911-b5d2-4f23291a08e4", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEOQX3oPABxoOhLqs+6GrNfP+3uEJTb3hJ3saJOxVOzWuPmkTW2uN8UhaFAjPqZCnsg==", null, false, "7d368a88-077a-4a2b-91ba-eb5bb73d5fcb", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "405bcfc4-bb1f-4d34-9c57-28171a3a6d83", "265a8f74-1bca-4253-a6f1-136b68f33d0b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f5b76df-871f-43d2-a604-64b8b56e8655");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "405bcfc4-bb1f-4d34-9c57-28171a3a6d83", "265a8f74-1bca-4253-a6f1-136b68f33d0b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "265a8f74-1bca-4253-a6f1-136b68f33d0b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "405bcfc4-bb1f-4d34-9c57-28171a3a6d83");

            migrationBuilder.DropColumn(
                name: "tempCityName",
                table: "People");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e9ef88a4-a226-4c61-a230-02f6be638afa", "85e3cff1-c92a-405f-9463-973b4e7b41ec", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "528cc81f-ab11-4f74-8b81-751e24836d6b", "1b6ebb73-28c5-4b25-a984-c04fc6bb5e39", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d0c54505-6795-45df-ae8b-a4a9bfcf2cfc", 0, 640424, "9b4d981f-9816-4b10-8752-da0bc7c351b5", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEC1KblWL0WZZmaqRBM9c2BBfJkpYdERCc0O6NXG7UuybLWYGYMNsqEVv0eB+YUOcXA==", null, false, "56e4b584-d8b5-442c-bfed-606859814f2b", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "d0c54505-6795-45df-ae8b-a4a9bfcf2cfc", "e9ef88a4-a226-4c61-a230-02f6be638afa" });
        }
    }
}
