using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Data.Migrations
{
    public partial class addedmorepeople : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "165b5216-b485-4f35-9c0f-105c76a86dff");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "bf34bb20-871b-404a-9f28-8128765f3129", "f34ee858-8c30-45fd-8cb0-82db365142e9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f34ee858-8c30-45fd-8cb0-82db365142e9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf34bb20-871b-404a-9f28-8128765f3129");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7dbefb45-d924-4e1b-bc4d-530ef7f569f9", "20dbe3cf-8cbc-4ec1-9fc1-1c9bfe801b44", "Admin", "ADMIN" },
                    { "e593f03f-8a9e-4c16-b7f5-ae06ebf39348", "ee527621-a05a-4666-be76-4ecec18d7ee0", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0127e289-e92d-4010-8735-ee1cb99e17b2", 0, 640424, "58e045d1-4061-4b40-940e-b41427e1a336", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEHTiu9eY8yXnvh3WBmRD31tjLh5Jw+kZpCdtInXvo+0NokqTdKdkBSEeVbV8GdPoaw==", null, false, "d586b67a-cdad-4951-b95c-e24c2803171e", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Name", "CityName", "Id", "PhoneNumber" },
                values: new object[,]
                {
                    { "Zony", null, 0, 3 },
                    { "Hannes", null, 99, 35 },
                    { "Anders", null, 7, 122 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "0127e289-e92d-4010-8735-ee1cb99e17b2", "7dbefb45-d924-4e1b-bc4d-530ef7f569f9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "People",
                keyColumn: "Name",
                keyValue: "Anders");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Name",
                keyValue: "Hannes");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Name",
                keyValue: "Zony");

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
                values: new object[] { "f34ee858-8c30-45fd-8cb0-82db365142e9", "56258178-3c7f-48b8-8689-2fec2edb0efd", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "165b5216-b485-4f35-9c0f-105c76a86dff", "3b432b69-eba5-482a-a146-3e207e81ff50", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bf34bb20-871b-404a-9f28-8128765f3129", 0, 640424, "096a8233-834d-4f1b-871c-ab9cb229806e", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEJSqU4M2jbaoV23d9fBSq7T7ADNZ2XN7aYoIZzNO4UJLK9Lur02coVacCQox87xI1A==", null, false, "51a875d8-2fa1-4e85-9163-a731816b4574", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "bf34bb20-871b-404a-9f28-8128765f3129", "f34ee858-8c30-45fd-8cb0-82db365142e9" });
        }
    }
}
