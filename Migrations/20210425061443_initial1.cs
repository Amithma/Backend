using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthDemo.Migrations
{
    public partial class initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1ebdb98e-59a0-4654-baf4-39928c8eb3d7");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "213af392-80ae-41cf-9871-a57e6de5d487");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "acf517f6-1da3-47a4-85cd-73c937a67972");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "baf9fc7d-cc71-44fb-951b-ebc66ac54d31", "3cc13480-c94e-4f76-9cc5-0d2dcc6bf0f7", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "968f4e5b-aedf-4fa6-becb-b0087c8f491a", "f27e0c85-981e-498d-a839-07fbe191d358", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6faffd1a-6335-4270-bf7e-e483c5ea77c5", "4255b5bc-59d9-4f87-8265-0d35a3dd7a1f", "Lecturer", "LECTURER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6faffd1a-6335-4270-bf7e-e483c5ea77c5");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "968f4e5b-aedf-4fa6-becb-b0087c8f491a");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "baf9fc7d-cc71-44fb-951b-ebc66ac54d31");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1ebdb98e-59a0-4654-baf4-39928c8eb3d7", "d3c2b367-feab-4a7a-b3b6-80bf6f8ec87f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "acf517f6-1da3-47a4-85cd-73c937a67972", "1b7f5c33-4495-41f9-b0f4-ab3d966a2cb4", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "213af392-80ae-41cf-9871-a57e6de5d487", "41a081ed-82e9-4e2f-9e02-c584f6f9711e", "Lecturer", "LECTURER" });
        }
    }
}
