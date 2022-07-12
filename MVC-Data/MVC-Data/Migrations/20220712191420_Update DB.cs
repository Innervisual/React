using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Data.Migrations
{
    public partial class UpdateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8599a2e-a1cf-4c33-bb12-4948b03d8be6");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e400e8ad-8954-4033-ae58-e3d1f87b5a1f", "a84ae404-2c0d-432b-9ad6-b69000f6ed7a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a84ae404-2c0d-432b-9ad6-b69000f6ed7a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e400e8ad-8954-4033-ae58-e3d1f87b5a1f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7c1b5fd1-c1da-4b7f-a871-f87e2571878d", "ff5b4841-5120-4365-9842-f313ebfaa6ac", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "55f9eda9-564d-4c08-95a7-e95ab9f4c787", "6e601d94-269a-4b2b-87d8-959069614ae3", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "345efee7-c21c-470c-891d-d53e8851e197", 0, 640424, "35ffe145-5751-422c-8c95-a57dd3f01e62", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAECDh0lZEngHlJBp7xMi8yNqn0yOHU8Pj07JS1p1Tkq473rPRIUHujTVr01iLTq4SRg==", null, false, "985c62ba-6343-46a6-b306-3ac3f5e2e4e5", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "345efee7-c21c-470c-891d-d53e8851e197", "7c1b5fd1-c1da-4b7f-a871-f87e2571878d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55f9eda9-564d-4c08-95a7-e95ab9f4c787");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "345efee7-c21c-470c-891d-d53e8851e197", "7c1b5fd1-c1da-4b7f-a871-f87e2571878d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c1b5fd1-c1da-4b7f-a871-f87e2571878d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "345efee7-c21c-470c-891d-d53e8851e197");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a84ae404-2c0d-432b-9ad6-b69000f6ed7a", "a6b6a04f-2879-4eed-afc9-973e36a8bd39", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b8599a2e-a1cf-4c33-bb12-4948b03d8be6", "723d7989-ae7e-4d46-9ef1-14bfaea42ba1", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e400e8ad-8954-4033-ae58-e3d1f87b5a1f", 0, 640424, "603e051c-ffca-40e4-953f-69a9a36d7423", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAELiQzCRUoH5Naz+J4Msl3MfOEayLMaLB7ou1+/dn0By5NVHgtrA0E/RG43M+jU/2KQ==", null, false, "6329b0aa-74d0-441e-b2fd-2dc72edfca5d", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "e400e8ad-8954-4033-ae58-e3d1f87b5a1f", "a84ae404-2c0d-432b-9ad6-b69000f6ed7a" });
        }
    }
}
