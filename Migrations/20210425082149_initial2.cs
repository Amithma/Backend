using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthDemo.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "marks",
                table: "LOs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8fc602cc-3566-4bbb-9f29-14d54c30d120", "a29f8302-60e3-406a-b902-2504d8a1ee00", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ebf8a620-ddcc-4250-927e-7ef324c92a31", "86d4a98e-44f9-472f-aadd-8d79100cb4b8", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7abff817-cb0d-4f2e-acd9-aacc365a8d5b", "4ed30f11-abbe-4209-bda6-12786b5792cf", "Lecturer", "LECTURER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "7abff817-cb0d-4f2e-acd9-aacc365a8d5b");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "8fc602cc-3566-4bbb-9f29-14d54c30d120");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ebf8a620-ddcc-4250-927e-7ef324c92a31");

            migrationBuilder.DropColumn(
                name: "marks",
                table: "LOs");

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
    }
}
