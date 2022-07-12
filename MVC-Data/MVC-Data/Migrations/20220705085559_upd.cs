using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Data.Migrations
{
    public partial class upd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "674756da-3b1c-498a-8607-86d63a35acb7", "9d87813a-0f4b-4f5d-bec1-9a6115d11c67", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "971d0804-7025-47d3-9882-7641fdd3393d", "f30e8c4a-9308-4cf3-a872-7e0d26860667", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "81bca6cc-48f8-41d7-9d42-dc2367f7eb95", 0, 640424, "4341a1f3-6400-4a28-907b-2ce3babe66e6", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAELgzfNvW0ANNiwebj/ywLC/jONeg/8I3EHllGpQ4j5n9Fn0UEAxELvwJv3tOIRPpcQ==", null, false, "aa2d8a61-6408-4bb0-a13e-e71772705d82", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "81bca6cc-48f8-41d7-9d42-dc2367f7eb95", "674756da-3b1c-498a-8607-86d63a35acb7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "971d0804-7025-47d3-9882-7641fdd3393d");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "81bca6cc-48f8-41d7-9d42-dc2367f7eb95", "674756da-3b1c-498a-8607-86d63a35acb7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "674756da-3b1c-498a-8607-86d63a35acb7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "81bca6cc-48f8-41d7-9d42-dc2367f7eb95");

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
    }
}
