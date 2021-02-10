using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesInMove.Migrations
{
    public partial class AccountfieldsModification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BachelorDegree",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DriverLicense",
                table: "AspNetUsers",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnglishSpeaker",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Expertise",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GeneratedSalesInForint",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<List<string>>(
                name: "Languages",
                table: "AspNetUsers",
                type: "text[]",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "SalesCourseSubscription",
                table: "AspNetUsers",
                type: "boolean",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e9d47082-b368-4e86-b648-f018a11d0ba7", "a4cfa3a4-b32d-4745-9185-fe984321b049" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BachelorDegree",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DriverLicense",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EnglishSpeaker",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Expertise",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "GeneratedSalesInForint",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Languages",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SalesCourseSubscription",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cbc07a5d-15b8-4fe1-b247-1203d71dbe3e", "894fd9c0-4429-4aa8-8c39-c24030f300f3" });
        }
    }
}
