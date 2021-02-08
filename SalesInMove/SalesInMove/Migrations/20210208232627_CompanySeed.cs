using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SalesInMove.Migrations
{
    public partial class CompanySeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserType",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User_Password",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    PositionId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Headquarter = table.Column<string>(type: "text", nullable: true),
                    TaxNumber = table.Column<long>(type: "bigint", maxLength: 11, nullable: false),
                    Registry = table.Column<long>(type: "bigint", nullable: false),
                    YearOfFoundation = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    NumberOfSalesman = table.Column<int>(type: "integer", nullable: false),
                    Sector = table.Column<string>(type: "text", nullable: true),
                    AnnualNettoIncome = table.Column<long>(type: "bigint", nullable: false),
                    EmployeeOpinions = table.Column<string[]>(type: "text[]", nullable: true),
                    SalesSupport = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyId);
                    table.ForeignKey(
                        name: "FK_Companies_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkHourRatio",
                columns: table => new
                {
                    WorkHourRatioId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WorkHoursPerMonth = table.Column<int>(type: "integer", nullable: false),
                    OfficeHours = table.Column<byte>(type: "smallint", nullable: false),
                    HomeOfficeHours = table.Column<byte>(type: "smallint", nullable: false),
                    DrivingHours = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkHourRatio", x => x.WorkHourRatioId);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    PositionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CompanyPositionId = table.Column<int>(type: "integer", nullable: false),
                    WorkHourRatioId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Expectations = table.Column<string>(type: "text", nullable: true),
                    BossExpectations = table.Column<string>(type: "text", nullable: true),
                    WorkHour = table.Column<string>(type: "text", nullable: true),
                    Wages = table.Column<string>(type: "text", nullable: true),
                    OtherBenefits = table.Column<string>(type: "text", nullable: true),
                    ProgressionSupport = table.Column<bool>(type: "boolean", nullable: false),
                    CompanyId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.PositionId);
                    table.ForeignKey(
                        name: "FK_Position_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Position_WorkHourRatio_WorkHourRatioId",
                        column: x => x.WorkHourRatioId,
                        principalTable: "WorkHourRatio",
                        principalColumn: "WorkHourRatioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailAddress", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "User_Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[] { "0", 0, "2cf815ef-87f1-4328-ae9b-4114554f54d8", "User", "marko@gmail.com", null, false, false, null, null, null, "Asd123", null, null, false, "ca4cc619-ad5e-44b4-84b7-84a778f02cb1", false, null, 2 });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "AnnualNettoIncome", "EmployeeOpinions", "Headquarter", "Name", "NumberOfSalesman", "PositionId", "Registry", "SalesSupport", "Sector", "TaxNumber", "UserId", "YearOfFoundation" },
                values: new object[] { 12, 2000321865L, new[] { "Good", "Bad", "Terrific!", "Horrific!" }, "Halásztelek", "Markoó Kft.", 10, 0, 109321480L, true, null, 24767107243L, "0", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_Companies_UserId",
                table: "Companies",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Position_CompanyId",
                table: "Position",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Position_WorkHourRatioId",
                table: "Position",
                column: "WorkHourRatioId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "WorkHourRatio");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0");

            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserType",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "User_Password",
                table: "AspNetUsers");
        }
    }
}
