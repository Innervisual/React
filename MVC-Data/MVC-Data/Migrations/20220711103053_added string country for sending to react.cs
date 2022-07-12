using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Data.Migrations
{
    public partial class addedstringcountryforsendingtoreact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "tempCountryName",
                table: "People",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "tempCountryName",
                table: "People");

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
    }
}
