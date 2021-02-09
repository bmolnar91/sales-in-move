using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesInMove.Migrations
{
    public partial class ChangeEmployeeOpinionsType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EmployeeOpinions",
                table: "Companies",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2a9e74e3-a2c0-4f9d-9d64-932d20288beb", "7bbf5341-1f65-434e-a7b5-ed9dffd3e5cb" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 12,
                column: "EmployeeOpinions",
                value: "Good;Bad;Terrific!;Horrific!");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string[]>(
                name: "EmployeeOpinions",
                table: "Companies",
                type: "text[]",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cbc07a5d-15b8-4fe1-b247-1203d71dbe3e", "894fd9c0-4429-4aa8-8c39-c24030f300f3" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 12,
                column: "EmployeeOpinions",
                value: new[] { "Good", "Bad", "Terrific!", "Horrific!" });
        }
    }
}
