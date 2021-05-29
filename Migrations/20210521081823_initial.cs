using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthDemo.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IdentityRole",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IdentityUserRole<string>",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserRole<string>", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    ModuleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Credits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.ModuleId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeatherForecasts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TemperatureC = table.Column<int>(type: "int", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherForecasts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LOs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LOID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lmarks = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModuleId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LOs_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "POs",
                columns: table => new
                {
                    POID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    POName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID = table.Column<int>(type: "int", nullable: false),
                    LOID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POs", x => x.POID);
                    table.ForeignKey(
                        name: "FK_POs_LOs_ID",
                        column: x => x.ID,
                        principalTable: "LOs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AsComponents",
                columns: table => new
                {
                    AsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ascomponent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LOID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    POID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Marks = table.Column<int>(type: "int", nullable: false),
                    LD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lid = table.Column<int>(type: "int", nullable: false),
                    ModuleId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsComponents", x => x.AsID);
                    table.ForeignKey(
                        name: "FK_AsComponents_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AsComponents_POs_POID",
                        column: x => x.POID,
                        principalTable: "POs",
                        principalColumn: "POID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b081fddb-c2d4-45ca-87c4-820be0b532c6", "82ec5a23-a59e-421e-a0b9-7fd6564c5ec5", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "72265c5d-d3d8-4c52-bf62-b6357fb78ff7", "6e9d6847-bb15-4ce5-9f0d-71a40a76a932", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a1b13364-4495-447a-ac26-fbf441552f46", "4e5f17f8-f290-46e0-be71-9722abb9ab0f", "Lecturer", "LECTURER" });

            migrationBuilder.CreateIndex(
                name: "IX_AsComponents_ModuleId",
                table: "AsComponents",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_AsComponents_POID",
                table: "AsComponents",
                column: "POID");

            migrationBuilder.CreateIndex(
                name: "IX_LOs_ModuleId",
                table: "LOs",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_POs_ID",
                table: "POs",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsComponents");

            migrationBuilder.DropTable(
                name: "IdentityRole");

            migrationBuilder.DropTable(
                name: "IdentityUserRole<string>");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "WeatherForecasts");

            migrationBuilder.DropTable(
                name: "POs");

            migrationBuilder.DropTable(
                name: "LOs");

            migrationBuilder.DropTable(
                name: "Modules");
        }
    }
}
