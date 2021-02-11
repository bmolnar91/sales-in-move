using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SalesInMove.Migrations
{
    public partial class ApiUserBranchMerge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "User_Password",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    JobTitle = table.Column<string>(type: "text", nullable: true),
                    Education = table.Column<string>(type: "text", nullable: true),
                    Languages = table.Column<string[]>(type: "text[]", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    TurnoverLastYear = table.Column<int>(type: "integer", nullable: true),
                    ProfilePicture = table.Column<string>(type: "text", nullable: true),
                    ProfileVideo = table.Column<string>(type: "text", nullable: true),
                    IsSubscribed = table.Column<bool>(type: "boolean", nullable: false),
                    HasPersonalityTest = table.Column<bool>(type: "boolean", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    City = table.Column<string>(type: "text", nullable: true),
                    DrivingLicence = table.Column<bool>(type: "boolean", nullable: false),
                    SalesCourseSubscription = table.Column<bool>(type: "boolean", nullable: false),
                    SalesTurnOver = table.Column<int>(type: "integer", nullable: false),
                    Specialisation = table.Column<string>(type: "text", nullable: true),
                    PreviousCompany = table.Column<string>(type: "text", nullable: true),
                    OtherCertificates = table.Column<string[]>(type: "text[]", nullable: true),
                    Pros = table.Column<string[]>(type: "text[]", nullable: true),
                    Cons = table.Column<string[]>(type: "text[]", nullable: true),
                    ProgressionIntetions = table.Column<string[]>(type: "text[]", nullable: true),
                    Motto = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Accounts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "Password", "SecurityStamp" },
                values: new object[] { "c86f787d-efcf-4a25-9e57-fb9cff410d92", "Asd123", "e0cc1f8c-0316-4217-842a-2f6565555315" });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_UserId",
                table: "Accounts",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User_Password",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "User_Password", "SecurityStamp" },
                values: new object[] { "dbff3fee-b160-40b0-ac32-5add4d384132", "Asd123", "ff7314d5-b1d7-4751-b578-4d7d6a1ce41e" });
        }
    }
}
