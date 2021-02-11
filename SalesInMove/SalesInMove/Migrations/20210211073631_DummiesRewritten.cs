using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesInMove.Migrations
{
    public partial class DummiesRewritten : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "ErtékesitoiForgalom",
                table: "AspNetUsers",
                newName: "ErtekesitoiForgalom");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d9c9ee65-bb13-49f9-b87d-8f5bbc1fa620", "bd3e0723-0b1d-461d-981e-05d356df1642" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Eletkor", "Email", "EmailConfirmed", "ErtekesitoiForgalom", "FirstName", "Jogositvany", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Nyelvek", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Picture", "SalesKurzusElofizetes", "SecurityStamp", "Szakterulet", "SzemelyisegTeszt", "TwoFactorEnabled", "UserName", "Varos", "Vegzettseg" },
                values: new object[,]
                {
                    { "a4fe1155-134c-45e9-b6a3-15c83eaade17", 0, "54fd08f0-7115-4c1e-8e1d-3b459e2e8cc8", "Account", 28, "erzsebetchen@gmail.com", true, 50000000, null, true, null, false, null, null, null, new[] { "kinai", "angol" }, "erzsebetchen", null, null, false, "https://images.generated.photos/iZOX8m9z2zgSg7_qWRSr4wBWJLfNkbdeofALD6dRIVU/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA1NDIxMzguanBn.jpg", true, "ea4cb49e-31a7-4e57-a267-d7e89950eb12", "Sales specialist", true, false, "Erzsebet Chen", "Budapest", "Marketing BA" },
                    { "c33ba9a4-6d3c-46cb-af85-078fb8bc2697", 0, "d31b7ed3-ce36-4caf-993e-7636d06bec7c", "Account", 30, "marjoiretierney@gmail.com", true, 30000000, null, true, null, false, null, null, null, new[] { "nemet", "angol" }, "marjoiretierney", null, null, false, "https://images.generated.photos/DThx55Jct9pbzh0tEWKAH9ilBwpKhHfPL0f0B6umGxU/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA4NDk3MjcuanBn.jpg", false, "3b6f0d82-e051-4748-a69b-4222fc250828", "Sales Support", false, false, "Marjorie Tierney", "DunaHaraszti", "Foiskola" },
                    { "1120874a-f40a-4aea-9efb-1b2a7637f2dd", 0, "0f02271c-0364-46a7-b279-b72b6d6c88a3", "Account", 34, "maigriffiths@gmail.com", true, 50000000, null, false, null, false, null, null, null, new[] { "nemet", "angol" }, "maigriffiths", null, null, false, "https://images.generated.photos/1k3lzxgEtWeS2mefKNXprUfn-kPpzyz3QJ0xuizOQrE/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA3NzkzMDkuanBn.jpg", true, "0b2b4645-c292-45b2-9ef9-274a9905c68f", "Sales adminisztracio", false, false, "Mai Griffits", "Erd", "egyetem" },
                    { "7c88f596-9f75-47c0-8077-3d420cda297b", 0, "1dde66e6-1969-4c85-a0c6-07e2f91df20b", "Account", 20, "joannemanning@gmail.com", true, 30000000, null, false, null, false, null, null, null, new[] { "kinai", "angol" }, "joannemanning", null, null, false, "https://images.generated.photos/jEnG00iXVCxYx24J4dFGMRWTkSaYGOR6-Igumi2VP3w/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA5Nzg0MzkuanBn.jpg", false, "1eae799a-5a64-4735-85c6-5032a16447a5", "Sales adminisztracio", false, false, "Joanne Manning", "Budapest", "egyetem" },
                    { "8d400a84-4a8c-4215-8941-b6e7f7727594", 0, "2096984b-8956-48d1-a2ef-8ce081e3345a", "Account", 22, "keaneboyd@gmail.com", true, 40000000, null, false, null, false, null, null, null, new[] { "orosz", "angol" }, "keaneboyd", null, null, false, "https://images.generated.photos/GmWEUKjveqsM5x3TsJVABoSyjilRB6Tz2Z-Auc9p-8Y/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA2MTI4NTcuanBn.jpg", false, "34fb8b53-5e30-4211-8ba8-c230b46b8393", "Sales szaktanacsado", true, false, "Keane Boyd", "Budapest", "PhD" },
                    { "5d18f90a-a741-43e4-a275-f3719dface77", 0, "3561f31a-6501-4be1-baa1-4305e2cad37f", "Account", 34, "aneekaeaton@gmail.com", true, 50000000, null, true, null, false, null, null, null, new[] { "angol" }, "aneekaeaton", null, null, false, "https://images.generated.photos/qvPRjAxXrZdLdgSDd6yk2I7ni0a1LAwFWZBNfvYNMdo/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA4MjM3ODkuanBn.jpg", true, "eb07b99f-bfab-4179-87aa-ec24c953f9c6", "Sales specialist", false, false, "Aneeka Eaton", "Kecsekemet", "DLA" },
                    { "871b5bec-0ca1-48a7-a00d-f5191dee014d", 0, "9486d599-5130-427f-a5aa-0c0638808a26", "Account", 30, "bobacosta@gmail.com", true, 30000000, null, false, null, false, null, null, null, new[] { "angol" }, "bobacosta", null, null, false, "https://images.generated.photos/YFrGWaIDMHGU5HoB3GxLFJ_jXTE8S8gpstIs3Pm9dHE/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA3ODQ4MzYuanBn.jpg", true, "17caec02-64e7-4b7f-99cf-551d0f479341", "Sales Support", false, false, "Bob Acosta", "Erd", "Foiskola" },
                    { "ef369a00-eebd-4e87-bd73-86561ff211bd", 0, "859dafa8-3952-45bb-9f09-acaf9903c921", "Account", 19, "eoinlynn@gmail.com", true, 40000000, null, true, null, false, null, null, null, new[] { "ukran", "angol" }, "eoinlynn", null, null, false, "https://images.generated.photos/aKjcATGNs_-Y5cyzeAdjL3N-cRWqUh7hKjds4pOytgw/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA2ODM0NDMuanBn.jpg", false, "4aa23c05-ab9c-4268-b7ef-ed5045da2959", "Sales support", true, false, "Eoin Lynn", "Dunaharaszti", "egyetem" },
                    { "37a29686-7d80-422a-ab84-96bcecb0f670", 0, "aa1c2026-e5bc-4b08-94b7-573a974e9888", "Account", 19, "eoinlynn@gmail.com", true, 40000000, null, true, null, false, null, null, null, new[] { "ukran", "angol" }, "eoinlynn", null, null, false, "https://images.generated.photos/aKjcATGNs_-Y5cyzeAdjL3N-cRWqUh7hKjds4pOytgw/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA2ODM0NDMuanBn.jpg", false, "639d752e-5a12-45bb-b4f6-9410c55d3cf8", "Sales support", true, false, "Eoin Lynn", "Dunaharaszti", "egyetem" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1120874a-f40a-4aea-9efb-1b2a7637f2dd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37a29686-7d80-422a-ab84-96bcecb0f670");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d18f90a-a741-43e4-a275-f3719dface77");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c88f596-9f75-47c0-8077-3d420cda297b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871b5bec-0ca1-48a7-a00d-f5191dee014d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d400a84-4a8c-4215-8941-b6e7f7727594");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4fe1155-134c-45e9-b6a3-15c83eaade17");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c33ba9a4-6d3c-46cb-af85-078fb8bc2697");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef369a00-eebd-4e87-bd73-86561ff211bd");

            migrationBuilder.RenameColumn(
                name: "ErtekesitoiForgalom",
                table: "AspNetUsers",
                newName: "ErtékesitoiForgalom");

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
    }
}
