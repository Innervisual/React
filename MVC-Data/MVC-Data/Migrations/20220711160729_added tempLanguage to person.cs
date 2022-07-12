using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Data.Migrations
{
    public partial class addedtempLanguagetoperson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9429db09-2bb7-413b-93a5-1b67b0ff31cc");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0a523966-7d83-476d-8c6f-128bf6199253", "a5632341-5240-47ac-a37d-606b263cd99a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5632341-5240-47ac-a37d-606b263cd99a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a523966-7d83-476d-8c6f-128bf6199253");

            migrationBuilder.AddColumn<string>(
                name: "tempLanguageName",
                table: "People",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "tempLanguageName",
                table: "People");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a5632341-5240-47ac-a37d-606b263cd99a", "17e5dee4-c3df-48e2-9a74-23b65f70afff", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9429db09-2bb7-413b-93a5-1b67b0ff31cc", "f8fd291f-1031-4cc9-b43c-dd94d92bef4c", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0a523966-7d83-476d-8c6f-128bf6199253", 0, 640424, "97fa450b-598f-444d-80cc-f1b3a083278e", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEGOM0K31s9P89kd6odmtZk6ZZ/ACmh3ifpSEGRZJ0lWqBrFMQGntOcmTrIoT6zHGbg==", null, false, "9f7f6990-0a22-4f3c-ac96-e4356ad457ae", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "0a523966-7d83-476d-8c6f-128bf6199253", "a5632341-5240-47ac-a37d-606b263cd99a" });
        }
    }
}
