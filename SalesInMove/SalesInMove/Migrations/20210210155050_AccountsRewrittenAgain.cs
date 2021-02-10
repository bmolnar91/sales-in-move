using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesInMove.Migrations
{
    public partial class AccountsRewrittenAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ÉrtékesítőiForgalom",
                table: "AspNetUsers",
                newName: "SzemelyisegTeszt");

            migrationBuilder.RenameColumn(
                name: "Életkor",
                table: "AspNetUsers",
                newName: "Vegzettseg");

            migrationBuilder.RenameColumn(
                name: "Végzettség",
                table: "AspNetUsers",
                newName: "Varos");

            migrationBuilder.RenameColumn(
                name: "Város",
                table: "AspNetUsers",
                newName: "Szakterulet");

            migrationBuilder.RenameColumn(
                name: "SzemélyiségiTeszt",
                table: "AspNetUsers",
                newName: "SalesKurzusElofizetes");

            migrationBuilder.RenameColumn(
                name: "Szakterület",
                table: "AspNetUsers",
                newName: "Eletkor");

            migrationBuilder.RenameColumn(
                name: "SalesKurzusElőfizetés",
                table: "AspNetUsers",
                newName: "Jogositvany");

            migrationBuilder.RenameColumn(
                name: "Jogosítvány",
                table: "AspNetUsers",
                newName: "ErtékesitoiForgalom");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "393f176a-33a7-466a-b02a-7f53f5fe5c98", "3fcc256b-db81-470c-a6bd-3503d33ca22a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Vegzettseg",
                table: "AspNetUsers",
                newName: "Életkor");

            migrationBuilder.RenameColumn(
                name: "Varos",
                table: "AspNetUsers",
                newName: "Végzettség");

            migrationBuilder.RenameColumn(
                name: "SzemelyisegTeszt",
                table: "AspNetUsers",
                newName: "ÉrtékesítőiForgalom");

            migrationBuilder.RenameColumn(
                name: "Szakterulet",
                table: "AspNetUsers",
                newName: "Város");

            migrationBuilder.RenameColumn(
                name: "SalesKurzusElofizetes",
                table: "AspNetUsers",
                newName: "SzemélyiségiTeszt");

            migrationBuilder.RenameColumn(
                name: "Jogositvany",
                table: "AspNetUsers",
                newName: "SalesKurzusElőfizetés");

            migrationBuilder.RenameColumn(
                name: "ErtékesitoiForgalom",
                table: "AspNetUsers",
                newName: "Jogosítvány");

            migrationBuilder.RenameColumn(
                name: "Eletkor",
                table: "AspNetUsers",
                newName: "Szakterület");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2697c4de-48b4-4905-adf6-81e3808c3cc3", "f4f69176-43bb-47cf-afc5-4281588cc188" });
        }
    }
}
