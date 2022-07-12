using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Data.Migrations
{
    public partial class insertsseedsagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e593f03f-8a9e-4c16-b7f5-ae06ebf39348");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0127e289-e92d-4010-8735-ee1cb99e17b2", "7dbefb45-d924-4e1b-bc4d-530ef7f569f9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7dbefb45-d924-4e1b-bc4d-530ef7f569f9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0127e289-e92d-4010-8735-ee1cb99e17b2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7dbefb45-d924-4e1b-bc4d-530ef7f569f9", "20dbe3cf-8cbc-4ec1-9fc1-1c9bfe801b44", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e593f03f-8a9e-4c16-b7f5-ae06ebf39348", "ee527621-a05a-4666-be76-4ecec18d7ee0", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0127e289-e92d-4010-8735-ee1cb99e17b2", 0, 640424, "58e045d1-4061-4b40-940e-b41427e1a336", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEHTiu9eY8yXnvh3WBmRD31tjLh5Jw+kZpCdtInXvo+0NokqTdKdkBSEeVbV8GdPoaw==", null, false, "d586b67a-cdad-4951-b95c-e24c2803171e", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "0127e289-e92d-4010-8735-ee1cb99e17b2", "7dbefb45-d924-4e1b-bc4d-530ef7f569f9" });
        }
    }
}
