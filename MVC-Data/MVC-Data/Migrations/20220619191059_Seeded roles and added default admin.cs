using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Data.Migrations
{
    public partial class Seededrolesandaddeddefaultadmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "70f5c4ee-55c7-4f1c-ae89-f4ad307812f8", "aa3dc876-2ef4-4157-a74c-4979dddb85bf", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "06b3ea91-d46d-4cfa-bddc-273189a8f26e", "526b2387-510d-40f6-a1d9-1b25a70cc6af", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "161f99da-29b4-4775-9e32-e2d6854b66d2", 0, 640424, "3b6cd5db-e237-45b8-81fd-a290cfd6d7d8", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAED51Z5Bymmhk/sGnr/dhF7WXAOxZdngInz8LAXACcnmWRlNWObRcqIy/pJrZMXluDA==", null, false, "5b7463d0-f857-4e11-beae-a19e292bb8db", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "161f99da-29b4-4775-9e32-e2d6854b66d2", "70f5c4ee-55c7-4f1c-ae89-f4ad307812f8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06b3ea91-d46d-4cfa-bddc-273189a8f26e");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "161f99da-29b4-4775-9e32-e2d6854b66d2", "70f5c4ee-55c7-4f1c-ae89-f4ad307812f8" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70f5c4ee-55c7-4f1c-ae89-f4ad307812f8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "161f99da-29b4-4775-9e32-e2d6854b66d2");
        }
    }
}
