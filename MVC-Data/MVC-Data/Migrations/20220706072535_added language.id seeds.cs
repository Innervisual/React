using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Data.Migrations
{
    public partial class addedlanguageidseeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "902f29f1-efae-40d2-b82f-47f7491061d2");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4cca15f8-f338-49b6-ac4a-e6165a2e61df", "f320bc52-877d-4262-91e5-25935017122c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f320bc52-877d-4262-91e5-25935017122c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4cca15f8-f338-49b6-ac4a-e6165a2e61df");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "f34ee858-8c30-45fd-8cb0-82db365142e9", "56258178-3c7f-48b8-8689-2fec2edb0efd", "Admin", "ADMIN" },
                    { "165b5216-b485-4f35-9c0f-105c76a86dff", "3b432b69-eba5-482a-a146-3e207e81ff50", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bf34bb20-871b-404a-9f28-8128765f3129", 0, 640424, "096a8233-834d-4f1b-871c-ab9cb229806e", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEJSqU4M2jbaoV23d9fBSq7T7ADNZ2XN7aYoIZzNO4UJLK9Lur02coVacCQox87xI1A==", null, false, "51a875d8-2fa1-4e85-9163-a731816b4574", false, "admin@admin.com" });

            migrationBuilder.UpdateData(
                table: "Langs",
                keyColumn: "Name",
                keyValue: "English",
                column: "Id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Langs",
                keyColumn: "Name",
                keyValue: "French",
                column: "Id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Langs",
                keyColumn: "Name",
                keyValue: "German",
                column: "Id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Langs",
                keyColumn: "Name",
                keyValue: "Portugese",
                column: "Id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Langs",
                keyColumn: "Name",
                keyValue: "Spanish",
                column: "Id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Langs",
                keyColumn: "Name",
                keyValue: "Swedish",
                column: "Id",
                value: 2);

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "bf34bb20-871b-404a-9f28-8128765f3129", "f34ee858-8c30-45fd-8cb0-82db365142e9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "f320bc52-877d-4262-91e5-25935017122c", "c346698a-4447-4408-8e23-cd93d5ff9e6f", "Admin", "ADMIN" },
                    { "902f29f1-efae-40d2-b82f-47f7491061d2", "dde79665-d883-422c-b196-93013a8f3622", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4cca15f8-f338-49b6-ac4a-e6165a2e61df", 0, 640424, "599840c8-3442-41e2-a157-19eeca2f87ff", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEBOTB+4MbiP67rnvPSR/blw9jtzuKCwYLA5hlaARaJraZe3c8BrhzFwTw9ZZw36o0A==", null, false, "a2110659-fac5-4b20-a94c-c34f7e31b3d1", false, "admin@admin.com" });

            migrationBuilder.UpdateData(
                table: "Langs",
                keyColumn: "Name",
                keyValue: "English",
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Langs",
                keyColumn: "Name",
                keyValue: "French",
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Langs",
                keyColumn: "Name",
                keyValue: "German",
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Langs",
                keyColumn: "Name",
                keyValue: "Portugese",
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Langs",
                keyColumn: "Name",
                keyValue: "Spanish",
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Langs",
                keyColumn: "Name",
                keyValue: "Swedish",
                column: "Id",
                value: 0);

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "4cca15f8-f338-49b6-ac4a-e6165a2e61df", "f320bc52-877d-4262-91e5-25935017122c" });
        }
    }
}
