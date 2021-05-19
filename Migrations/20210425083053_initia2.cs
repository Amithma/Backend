using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthDemo.Migrations
{
    public partial class initia2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "marks",
                table: "LOs",
                newName: "Lmarks");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5a31ed78-3ab1-49a1-82b5-446972644599", "bc58a7fb-60b5-4b85-8862-cee98ee5103e", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d753e41c-af9a-4a72-8714-b0e2e2a3421d", "efd955f7-a58f-4fc6-81df-952e3c923482", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5ab76193-9b0f-42b5-986b-f416d82fb9a9", "47d6d95d-6e5e-499f-8d9e-9c034b72599e", "Lecturer", "LECTURER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "5a31ed78-3ab1-49a1-82b5-446972644599");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "5ab76193-9b0f-42b5-986b-f416d82fb9a9");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d753e41c-af9a-4a72-8714-b0e2e2a3421d");

            migrationBuilder.RenameColumn(
                name: "Lmarks",
                table: "LOs",
                newName: "marks");

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
    }
}
