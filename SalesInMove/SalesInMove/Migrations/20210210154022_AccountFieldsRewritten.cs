using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesInMove.Migrations
{
    public partial class AccountFieldsRewritten : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GeneratedSalesInForint",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "SalesCourseSubscription",
                table: "AspNetUsers",
                newName: "ÉrtékesítőiForgalom");

            migrationBuilder.RenameColumn(
                name: "Languages",
                table: "AspNetUsers",
                newName: "Nyelvek");

            migrationBuilder.RenameColumn(
                name: "Expertise",
                table: "AspNetUsers",
                newName: "Életkor");

            migrationBuilder.RenameColumn(
                name: "EnglishSpeaker",
                table: "AspNetUsers",
                newName: "Végzettség");

            migrationBuilder.RenameColumn(
                name: "DriverLicense",
                table: "AspNetUsers",
                newName: "SzemélyiségiTeszt");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "AspNetUsers",
                newName: "Város");

            migrationBuilder.RenameColumn(
                name: "BachelorDegree",
                table: "AspNetUsers",
                newName: "Szakterület");

            migrationBuilder.AddColumn<bool>(
                name: "Jogosítvány",
                table: "AspNetUsers",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "SalesKurzusElőfizetés",
                table: "AspNetUsers",
                type: "boolean",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2697c4de-48b4-4905-adf6-81e3808c3cc3", "f4f69176-43bb-47cf-afc5-4281588cc188" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Jogosítvány",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SalesKurzusElőfizetés",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "ÉrtékesítőiForgalom",
                table: "AspNetUsers",
                newName: "SalesCourseSubscription");

            migrationBuilder.RenameColumn(
                name: "Életkor",
                table: "AspNetUsers",
                newName: "Expertise");

            migrationBuilder.RenameColumn(
                name: "Végzettség",
                table: "AspNetUsers",
                newName: "EnglishSpeaker");

            migrationBuilder.RenameColumn(
                name: "Város",
                table: "AspNetUsers",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "SzemélyiségiTeszt",
                table: "AspNetUsers",
                newName: "DriverLicense");

            migrationBuilder.RenameColumn(
                name: "Szakterület",
                table: "AspNetUsers",
                newName: "BachelorDegree");

            migrationBuilder.RenameColumn(
                name: "Nyelvek",
                table: "AspNetUsers",
                newName: "Languages");

            migrationBuilder.AddColumn<int>(
                name: "GeneratedSalesInForint",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e9d47082-b368-4e86-b648-f018a11d0ba7", "a4cfa3a4-b32d-4745-9185-fe984321b049" });
        }
    }
}
