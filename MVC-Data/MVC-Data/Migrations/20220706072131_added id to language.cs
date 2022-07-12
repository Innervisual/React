using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Data.Migrations
{
    public partial class addedidtolanguage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9258dc8f-7b01-48ef-9bbf-c8cc005bc826");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f1c3e2cf-8147-495e-982c-6c6b2397d6ad", "b1709fef-eb3a-472a-b39c-97cc3324785a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1709fef-eb3a-472a-b39c-97cc3324785a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1c3e2cf-8147-495e-982c-6c6b2397d6ad");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Langs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f320bc52-877d-4262-91e5-25935017122c", "c346698a-4447-4408-8e23-cd93d5ff9e6f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "902f29f1-efae-40d2-b82f-47f7491061d2", "dde79665-d883-422c-b196-93013a8f3622", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4cca15f8-f338-49b6-ac4a-e6165a2e61df", 0, 640424, "599840c8-3442-41e2-a157-19eeca2f87ff", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEBOTB+4MbiP67rnvPSR/blw9jtzuKCwYLA5hlaARaJraZe3c8BrhzFwTw9ZZw36o0A==", null, false, "a2110659-fac5-4b20-a94c-c34f7e31b3d1", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "4cca15f8-f338-49b6-ac4a-e6165a2e61df", "f320bc52-877d-4262-91e5-25935017122c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Langs");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b1709fef-eb3a-472a-b39c-97cc3324785a", "d246f422-8747-4519-925a-817da601657b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9258dc8f-7b01-48ef-9bbf-c8cc005bc826", "ed234cfc-eed8-4604-8a9f-cb0008e8fa82", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f1c3e2cf-8147-495e-982c-6c6b2397d6ad", 0, 640424, "e1809e43-db1a-4017-8c9d-f79de8962cc6", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAELFo3VX6JseWMwVzUYcFO98+28aNJrzYVCVko9do4KluuHbP8YhFKqqQVo4go1jRSg==", null, false, "41bbfcfd-ea03-4a80-b315-f49b2871866c", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "f1c3e2cf-8147-495e-982c-6c6b2397d6ad", "b1709fef-eb3a-472a-b39c-97cc3324785a" });
        }
    }
}
