using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesInMove.Migrations
{
    public partial class DummiesRewrittenAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ErtekesitoiForgalom",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1a112d90-a761-41c6-8f65-2a0c5724325b", "eadd8dc6-65d3-417d-9a99-df7343a53242" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Eletkor", "Email", "EmailConfirmed", "FirstName", "Jogositvany", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Nyelvek", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Picture", "SalesKurzusElofizetes", "SecurityStamp", "Szakterulet", "SzemelyisegTeszt", "TwoFactorEnabled", "UserName", "Varos", "Vegzettseg" },
                values: new object[,]
                {
                    { "070e95b1-d4dc-4d25-8879-f5c3b979ce7f", 0, "f421e8f9-544d-421a-b127-215d1c91322e", "Account", 28, "erzsebetchen@gmail.com", true, null, true, null, false, null, null, null, new[] { "kinai", "angol" }, "erzsebetchen", null, null, false, "https://images.generated.photos/iZOX8m9z2zgSg7_qWRSr4wBWJLfNkbdeofALD6dRIVU/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA1NDIxMzguanBn.jpg", true, "37f93fb6-d6c7-41ba-8cbe-298051837664", "Sales specialist", true, false, "Erzsebet Chen", "Budapest", "Marketing BA" },
                    { "28014d56-ff08-4ada-a86f-90f979c58355", 0, "bd0a6f15-a961-4c8a-9dc1-88a1044fd3fb", "Account", 30, "marjoiretierney@gmail.com", true, null, true, null, false, null, null, null, new[] { "nemet", "angol" }, "marjoiretierney", null, null, false, "https://images.generated.photos/DThx55Jct9pbzh0tEWKAH9ilBwpKhHfPL0f0B6umGxU/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA4NDk3MjcuanBn.jpg", false, "e3994b92-607c-45f8-b86c-b58b9d8ae985", "Sales Support", false, false, "Marjorie Tierney", "DunaHaraszti", "Foiskola" },
                    { "2ca11fc1-3b5f-4107-9b8a-12c183fdd9ba", 0, "b232931d-59ed-49a2-a62c-fa9d4422c766", "Account", 34, "maigriffiths@gmail.com", true, null, false, null, false, null, null, null, new[] { "nemet", "angol" }, "maigriffiths", null, null, false, "https://images.generated.photos/1k3lzxgEtWeS2mefKNXprUfn-kPpzyz3QJ0xuizOQrE/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA3NzkzMDkuanBn.jpg", true, "719aa919-4d80-4028-8376-50b797029cf5", "Sales adminisztracio", false, false, "Mai Griffits", "Erd", "egyetem" },
                    { "9a9df8d2-c7c2-406a-ac3e-af657097e562", 0, "b4a49285-f38a-4559-8125-5cb2607be2d8", "Account", 20, "joannemanning@gmail.com", true, null, false, null, false, null, null, null, new[] { "kinai", "angol" }, "joannemanning", null, null, false, "https://images.generated.photos/jEnG00iXVCxYx24J4dFGMRWTkSaYGOR6-Igumi2VP3w/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA5Nzg0MzkuanBn.jpg", false, "ee13a393-0a58-443f-a96f-bab33c680862", "Sales adminisztracio", false, false, "Joanne Manning", "Budapest", "egyetem" },
                    { "e8bbb611-b820-4dc2-b302-976b0d04c1af", 0, "3857459c-dd54-4896-8eeb-b0081066d3c9", "Account", 22, "keaneboyd@gmail.com", true, null, false, null, false, null, null, null, new[] { "orosz", "angol" }, "keaneboyd", null, null, false, "https://images.generated.photos/GmWEUKjveqsM5x3TsJVABoSyjilRB6Tz2Z-Auc9p-8Y/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA2MTI4NTcuanBn.jpg", false, "2a28f9e4-2b68-4697-924f-3a1fd47ec18f", "Sales szaktanacsado", true, false, "Keane Boyd", "Budapest", "PhD" },
                    { "0c5e6a14-4d64-481b-889e-6edb7e16362d", 0, "ec2fe587-c1f9-45fe-bbaa-c94377537c92", "Account", 34, "aneekaeaton@gmail.com", true, null, true, null, false, null, null, null, new[] { "angol" }, "aneekaeaton", null, null, false, "https://images.generated.photos/qvPRjAxXrZdLdgSDd6yk2I7ni0a1LAwFWZBNfvYNMdo/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA4MjM3ODkuanBn.jpg", true, "0c7c0472-39cb-4cae-a93a-ecf98ac45d53", "Sales specialist", false, false, "Aneeka Eaton", "Kecsekemet", "DLA" },
                    { "35a90338-e54e-4b91-8d9a-9a880759f3cd", 0, "9af4452b-f618-4d6b-ad72-7457859f92c0", "Account", 30, "bobacosta@gmail.com", true, null, false, null, false, null, null, null, new[] { "angol" }, "bobacosta", null, null, false, "https://images.generated.photos/YFrGWaIDMHGU5HoB3GxLFJ_jXTE8S8gpstIs3Pm9dHE/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA3ODQ4MzYuanBn.jpg", true, "81f717cd-fb83-439d-84f8-c20e22fb2229", "Sales Support", false, false, "Bob Acosta", "Erd", "Foiskola" },
                    { "775d0a7b-a5e6-4662-9bd0-18ad682beaa3", 0, "5163710a-c562-4fe3-8cbd-a00a546df14a", "Account", 19, "eoinlynn@gmail.com", true, null, true, null, false, null, null, null, new[] { "ukran", "angol" }, "eoinlynn", null, null, false, "https://images.generated.photos/aKjcATGNs_-Y5cyzeAdjL3N-cRWqUh7hKjds4pOytgw/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA2ODM0NDMuanBn.jpg", false, "9849731f-9db8-4eb4-8f3a-566ed7b2af90", "Sales support", true, false, "Eoin Lynn", "Dunaharaszti", "egyetem" },
                    { "92cb73c7-84f5-4b8c-8cb4-6b0c6e152c24", 0, "22b2e94f-7014-4bcb-a279-2f703ccef2fd", "Account", 19, "eoinlynn@gmail.com", true, null, true, null, false, null, null, null, new[] { "ukran", "angol" }, "eoinlynn", null, null, false, "https://images.generated.photos/aKjcATGNs_-Y5cyzeAdjL3N-cRWqUh7hKjds4pOytgw/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA2ODM0NDMuanBn.jpg", false, "51aff7bf-9c11-4ac2-8697-3586aa126e95", "Sales support", true, false, "Eoin Lynn", "Dunaharaszti", "egyetem" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070e95b1-d4dc-4d25-8879-f5c3b979ce7f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c5e6a14-4d64-481b-889e-6edb7e16362d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28014d56-ff08-4ada-a86f-90f979c58355");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ca11fc1-3b5f-4107-9b8a-12c183fdd9ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35a90338-e54e-4b91-8d9a-9a880759f3cd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "775d0a7b-a5e6-4662-9bd0-18ad682beaa3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92cb73c7-84f5-4b8c-8cb4-6b0c6e152c24");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a9df8d2-c7c2-406a-ac3e-af657097e562");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8bbb611-b820-4dc2-b302-976b0d04c1af");

            migrationBuilder.AddColumn<string>( 
                name: "ErtekesitoiForgalom",
                table: "AspNetUsers",
                type: "string",
                nullable: true);

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
    }
}
