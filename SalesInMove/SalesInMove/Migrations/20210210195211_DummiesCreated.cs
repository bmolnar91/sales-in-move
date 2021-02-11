using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesInMove.Migrations
{
    public partial class DummiesCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ErtékesitoiForgalom",
                table: "AspNetUsers",
                type: "integer",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Eletkor",
                table: "AspNetUsers",
                type: "integer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "aa2e1a96-cc22-4dcb-b246-6bed69bc2aae", "db87ac3c-ad51-4d26-b84e-42d6addcc3af" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Eletkor", "Email", "EmailConfirmed", "ErtékesitoiForgalom", "FirstName", "Jogositvany", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Nyelvek", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Picture", "SalesKurzusElofizetes", "SecurityStamp", "Szakterulet", "SzemelyisegTeszt", "TwoFactorEnabled", "UserName", "Varos", "Vegzettseg" },
                values: new object[,]
                {
                    { "d4ce3ca7-a539-4831-957e-083c0978b4c9", 0, "f3332d6e-0515-4cfa-88d6-9c597fedc9f0", "Account", 28, "erzsebetchen@gmail.com", true, 50000000, null, true, null, false, null, null, null, new[] { "kinai", "angol" }, "erzsebetchen", null, null, false, "https://images.generated.photos/iZOX8m9z2zgSg7_qWRSr4wBWJLfNkbdeofALD6dRIVU/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA1NDIxMzguanBn.jpg", true, "bb9ed458-68b4-4af6-ba15-11b4201c3494", "Sales specialist", true, false, "Erzsebet Chen", "Budapest", "Marketing BA" },
                    { "c62abf04-501b-4aed-92a9-cd047ccc8f4d", 0, "ea13d1db-c5a7-43b7-b7f0-358fcb673d48", "Account", 30, "marjoiretierney@gmail.com", true, 30000000, null, true, null, false, null, null, null, new[] { "nemet", "angol" }, "marjoiretierney", null, null, false, "https://images.generated.photos/DThx55Jct9pbzh0tEWKAH9ilBwpKhHfPL0f0B6umGxU/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA4NDk3MjcuanBn.jpg", false, "47819e05-6e15-4efd-a75b-1ea59e3b82eb", "Sales Support", false, false, "Marjorie Tierney", "DunaHaraszti", "Foiskola" },
                    { "d3c94edf-8957-41a3-b502-7f4de5723e75", 0, "46967a4f-893e-47fc-81f6-457cc3bc9584", "Account", 34, "maigriffiths@gmail.com", true, 50000000, null, false, null, false, null, null, null, new[] { "nemet", "angol" }, "maigriffiths", null, null, false, "https://images.generated.photos/1k3lzxgEtWeS2mefKNXprUfn-kPpzyz3QJ0xuizOQrE/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA3NzkzMDkuanBn.jpg", true, "f27c53bb-93ae-4113-9805-0ac77b7bc62b", "Sales adminisztracio", false, false, "Mai Griffits", "Erd", "egyetem" },
                    { "33ef471b-6b19-4320-b344-72495dba98ea", 0, "ecf5cfa1-f181-4464-ba69-dcc6201a3d82", "Account", 20, "joannemanning@gmail.com", true, 30000000, null, false, null, false, null, null, null, new[] { "kinai", "angol" }, "joannemanning", null, null, false, "https://images.generated.photos/jEnG00iXVCxYx24J4dFGMRWTkSaYGOR6-Igumi2VP3w/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA5Nzg0MzkuanBn.jpg", false, "a7ff958b-aadd-43d5-86c8-d1bba936b802", "Sales adminisztracio", false, false, "Joanne Manning", "Budapest", "egyetem" },
                    { "aa8ffda2-1da3-4d21-a276-6b16aaec41e2", 0, "daab6860-28b3-40c7-b083-ab2afc91713f", "Account", 22, "keaneboyd@gmail.com", true, 40000000, null, false, null, false, null, null, null, new[] { "orosz", "angol" }, "keaneboyd", null, null, false, "https://images.generated.photos/GmWEUKjveqsM5x3TsJVABoSyjilRB6Tz2Z-Auc9p-8Y/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA2MTI4NTcuanBn.jpg", false, "c3baf0e1-db55-4ee1-b983-c63bd2f45a1f", "Sales szaktanacsado", true, false, "Keane Boyd", "Budapest", "PhD" },
                    { "127cc818-4212-42a1-a2c2-b887a10a3bca", 0, "0ce5e00a-a1c1-48bd-89cb-76896f72e539", "Account", 34, "aneekaeaton@gmail.com", true, 50000000, null, true, null, false, null, null, null, new[] { "angol" }, "aneekaeaton", null, null, false, "https://images.generated.photos/qvPRjAxXrZdLdgSDd6yk2I7ni0a1LAwFWZBNfvYNMdo/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA4MjM3ODkuanBn.jpg", true, "c590113e-bc77-49ac-a5b5-50279c5786a2", "Sales specialist", false, false, "Aneeka Eaton", "Kecsekemet", "DLA" },
                    { "f10f9596-f3f3-42c7-98ae-e297c81c353e", 0, "574858e7-d34b-4f51-9bbe-722e2a49743c", "Account", 30, "bobacosta@gmail.com", true, 30000000, null, false, null, false, null, null, null, new[] { "angol" }, "bobacosta", null, null, false, "https://images.generated.photos/YFrGWaIDMHGU5HoB3GxLFJ_jXTE8S8gpstIs3Pm9dHE/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA3ODQ4MzYuanBn.jpg", true, "e490662c-4071-4996-9d42-0671ab79dccb", "Sales Support", false, false, "Bob Acosta", "Erd", "Foiskola" },
                    { "a072e6be-bebf-42ef-97ac-e4433d3afad8", 0, "e2ff7f77-5e30-4cbb-b981-a967a095f7fb", "Account", 19, "eoinlynn@gmail.com", true, 40000000, null, true, null, false, null, null, null, new[] { "ukran", "angol" }, "eoinlynn", null, null, false, "https://images.generated.photos/aKjcATGNs_-Y5cyzeAdjL3N-cRWqUh7hKjds4pOytgw/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA2ODM0NDMuanBn.jpg", false, "7da53e18-a1e1-459b-8bfe-99047ae38a67", "Sales support", true, false, "Eoin Lynn", "Dunaharaszti", "egyetem" },
                    { "d32c9bce-0b33-45ac-ab62-c468ffed9c07", 0, "ff91a733-3b2b-4b1c-ad8b-6b9caca56020", "Account", 19, "eoinlynn@gmail.com", true, 40000000, null, true, null, false, null, null, null, new[] { "ukran", "angol" }, "eoinlynn", null, null, false, "https://images.generated.photos/aKjcATGNs_-Y5cyzeAdjL3N-cRWqUh7hKjds4pOytgw/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA2ODM0NDMuanBn.jpg", false, "e6c52a29-bc4f-4bc8-9b50-6420057d1f57", "Sales support", true, false, "Eoin Lynn", "Dunaharaszti", "egyetem" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "127cc818-4212-42a1-a2c2-b887a10a3bca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33ef471b-6b19-4320-b344-72495dba98ea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a072e6be-bebf-42ef-97ac-e4433d3afad8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa8ffda2-1da3-4d21-a276-6b16aaec41e2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c62abf04-501b-4aed-92a9-cd047ccc8f4d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d32c9bce-0b33-45ac-ab62-c468ffed9c07");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d3c94edf-8957-41a3-b502-7f4de5723e75");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4ce3ca7-a539-4831-957e-083c0978b4c9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f10f9596-f3f3-42c7-98ae-e297c81c353e");

            migrationBuilder.DropColumn(
                name: "Picture",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<bool>(
                name: "ErtékesitoiForgalom",
                table: "AspNetUsers",
                type: "boolean",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Eletkor",
                table: "AspNetUsers",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "393f176a-33a7-466a-b02a-7f53f5fe5c98", "3fcc256b-db81-470c-a6bd-3503d33ca22a" });
        }
    }
}
