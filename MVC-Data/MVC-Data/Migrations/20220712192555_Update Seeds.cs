using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Data.Migrations
{
    public partial class UpdateSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[,]
                {
                    { "3ad052ac-b8a1-4f1e-a9ff-865c28c6783a", "729e41b6-828e-4bee-89eb-0b6b1c3df9b3", "Admin", "ADMIN" },
                    { "2bb91c9e-939a-43b4-af4e-b2ac81c9ad8a", "e46db022-c91a-434e-94db-fa79d75e197e", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a703f51a-4838-4b41-8285-e46065aa4f85", 0, 640424, "0d4d9b3c-a5b0-43cd-8feb-98a904cf849e", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAELwpRm6K79GdbPd+OkApcOHpYjzO1A4RVTUMQ1P7Ser6ACDcPaixfngR7v+Q5Ji7sQ==", null, false, "db6aebe2-529e-46a4-89f5-019bd1de0a4a", false, "admin@admin.com" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Name",
                keyValue: "Anders",
                columns: new[] { "tempCityName", "tempCountryName", "tempLanguageName" },
                values: new object[] { "stockholm", "sweden", "swedish" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Name",
                keyValue: "George",
                columns: new[] { "tempCityName", "tempCountryName", "tempLanguageName" },
                values: new object[] { "stockholm", "sweden", "swedish" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Name",
                keyValue: "Hannes",
                columns: new[] { "tempCityName", "tempCountryName", "tempLanguageName" },
                values: new object[] { "stockholm", "sweden", "swedish" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Name",
                keyValue: "Ian",
                columns: new[] { "tempCityName", "tempCountryName", "tempLanguageName" },
                values: new object[] { "stockholm", "sweden", "swedish" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Name",
                keyValue: "JP",
                columns: new[] { "tempCityName", "tempCountryName", "tempLanguageName" },
                values: new object[] { "stockholm", "sweden", "swedish" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Name",
                keyValue: "Stefan",
                columns: new[] { "tempCityName", "tempCountryName", "tempLanguageName" },
                values: new object[] { "stockholm", "sweden", "swedish" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Name",
                keyValue: "Svante",
                columns: new[] { "tempCityName", "tempCountryName", "tempLanguageName" },
                values: new object[] { "stockholm", "sweden", "swedish" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Name",
                keyValue: "Zony",
                columns: new[] { "tempCityName", "tempCountryName", "tempLanguageName" },
                values: new object[] { "stockholm", "sweden", "swedish" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a703f51a-4838-4b41-8285-e46065aa4f85", "3ad052ac-b8a1-4f1e-a9ff-865c28c6783a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bb91c9e-939a-43b4-af4e-b2ac81c9ad8a");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a703f51a-4838-4b41-8285-e46065aa4f85", "3ad052ac-b8a1-4f1e-a9ff-865c28c6783a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ad052ac-b8a1-4f1e-a9ff-865c28c6783a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a703f51a-4838-4b41-8285-e46065aa4f85");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7c1b5fd1-c1da-4b7f-a871-f87e2571878d", "ff5b4841-5120-4365-9842-f313ebfaa6ac", "Admin", "ADMIN" },
                    { "55f9eda9-564d-4c08-95a7-e95ab9f4c787", "6e601d94-269a-4b2b-87d8-959069614ae3", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "345efee7-c21c-470c-891d-d53e8851e197", 0, 640424, "35ffe145-5751-422c-8c95-a57dd3f01e62", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAECDh0lZEngHlJBp7xMi8yNqn0yOHU8Pj07JS1p1Tkq473rPRIUHujTVr01iLTq4SRg==", null, false, "985c62ba-6343-46a6-b306-3ac3f5e2e4e5", false, "admin@admin.com" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Name",
                keyValue: "Anders",
                columns: new[] { "tempCityName", "tempCountryName", "tempLanguageName" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Name",
                keyValue: "George",
                columns: new[] { "tempCityName", "tempCountryName", "tempLanguageName" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Name",
                keyValue: "Hannes",
                columns: new[] { "tempCityName", "tempCountryName", "tempLanguageName" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Name",
                keyValue: "Ian",
                columns: new[] { "tempCityName", "tempCountryName", "tempLanguageName" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Name",
                keyValue: "JP",
                columns: new[] { "tempCityName", "tempCountryName", "tempLanguageName" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Name",
                keyValue: "Stefan",
                columns: new[] { "tempCityName", "tempCountryName", "tempLanguageName" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Name",
                keyValue: "Svante",
                columns: new[] { "tempCityName", "tempCountryName", "tempLanguageName" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Name",
                keyValue: "Zony",
                columns: new[] { "tempCityName", "tempCountryName", "tempLanguageName" },
                values: new object[] { null, null, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "345efee7-c21c-470c-891d-d53e8851e197", "7c1b5fd1-c1da-4b7f-a871-f87e2571878d" });
        }
    }
}
