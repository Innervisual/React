using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Data.Migrations
{
    public partial class addedidtocountries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Countries",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b1709fef-eb3a-472a-b39c-97cc3324785a", "d246f422-8747-4519-925a-817da601657b", "Admin", "ADMIN" },
                    { "9258dc8f-7b01-48ef-9bbf-c8cc005bc826", "ed234cfc-eed8-4604-8a9f-cb0008e8fa82", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f1c3e2cf-8147-495e-982c-6c6b2397d6ad", 0, 640424, "e1809e43-db1a-4017-8c9d-f79de8962cc6", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAELFo3VX6JseWMwVzUYcFO98+28aNJrzYVCVko9do4KluuHbP8YhFKqqQVo4go1jRSg==", null, false, "41bbfcfd-ea03-4a80-b315-f49b2871866c", false, "admin@admin.com" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Name",
                keyValue: "England",
                column: "Id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Name",
                keyValue: "France",
                column: "Id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Name",
                keyValue: "Germany",
                column: "Id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Name",
                keyValue: "Portugal",
                column: "Id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Name",
                keyValue: "Spain",
                column: "Id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Name",
                keyValue: "Sweden",
                column: "Id",
                value: 2);

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "f1c3e2cf-8147-495e-982c-6c6b2397d6ad", "b1709fef-eb3a-472a-b39c-97cc3324785a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Countries");

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
    }
}
