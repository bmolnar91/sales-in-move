using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesInMove.Migrations
{
    public partial class SeedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "61a9e116-4ec0-43ee-92ad-c70437a43d9a", "3764cb85-a243-43cd-8030-61402351d820" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[,]
                {
                    { "dummy0", 0, "51683318-e7ac-4d63-807b-2e2cfdb33001", "User", "erzsebetchen@gmail.com", true, false, null, null, null, "erzsebetchen", null, null, false, "53fbf294-dee0-4996-90cb-c8841bd09e80", false, "Erzsebet Chen", 0 },
                    { "dummy1", 0, "ab46c94f-79b5-4885-83af-f7a81320acf3", "User", "marjoiretierney@gmail.com", true, false, null, null, null, "marjoiretierney", null, null, false, "ab6a88be-fdbe-4b80-a800-157057fd036b", false, "Marjorie Tierney", 0 },
                    { "dummy2", 0, "d212208f-39a5-422c-a1dc-5da2ef06c5ad", "User", "maigriffiths@gmail.com", true, false, null, null, null, "maigriffiths", null, null, false, "4ce11074-bc9f-4933-a09e-0d7ce5d93696", false, "Mai Griffits", 0 },
                    { "dummy3", 0, "7c8d416f-303e-40e6-9cde-ac5e5aab84a5", "User", "joannemanning@gmail.com", true, false, null, null, null, "joannemanning", null, null, false, "29051027-3ffe-48e4-b768-2b46ab9edc6a", false, "Joanne Manning", 0 },
                    { "dummy4", 0, "0990acef-ba3b-46be-97f7-bdf6459a237c", "User", "keaneboyd@gmail.com", true, false, null, null, null, "keaneboyd", null, null, false, "0393b002-b0a2-443d-9362-ac9d8cfdb4bd", false, "Keane Boyd", 0 },
                    { "dummy5", 0, "18fe9c94-b266-42a3-a2e5-60d2674b19da", "User", "aneekaeaton@gmail.com", true, false, null, null, null, "aneekaeaton", null, null, false, "448888f3-f396-4326-ad3f-5c42744e60f7", false, "Aneeka Eaton", 0 },
                    { "dummy6", 0, "8c743595-bc68-4371-8905-dec8854d7d1d", "User", "bobacosta@gmail.com", true, false, null, null, null, "bobacosta", null, null, false, "b8033be1-1d13-41ea-b2ea-88b9c1454f4c", false, "Bob Acosta", 0 },
                    { "dummy7", 0, "7c257764-0f5b-4874-99e5-a1ccd06e5417", "User", "eoinlynn@gmail.com", true, false, null, null, null, "eoinlynn", null, null, false, "c5901b55-3296-40e2-9bd1-4b9635b7247c", false, "Eoin Lynn", 0 }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "EmployeeId", "Age", "BirthDate", "City", "Cons", "DrivingLicence", "Education", "FirstName", "HasPersonalityTest", "IsSubscribed", "JobTitle", "Languages", "LastName", "Motto", "OtherCertificates", "PreviousCompany", "ProfilePicture", "ProfileVideo", "ProgressionIntetions", "Pros", "SalesCourseSubscription", "SalesTurnOver", "Specialisation", "TurnoverLastYear", "UserId" },
                values: new object[,]
                {
                    { 10, 28, null, "Budapest", null, true, "Marketing BA", null, true, false, null, new[] { "kinai", "angol" }, null, null, null, null, "https://images.generated.photos/iZOX8m9z2zgSg7_qWRSr4wBWJLfNkbdeofALD6dRIVU/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA1NDIxMzguanBn.jpg", null, null, null, true, 50000000, "Sales specialist", null, "dummy0" },
                    { 1, 30, null, "DunaHaraszti", null, true, "Foiskola", null, false, false, null, new[] { "nemet", "angol" }, null, null, null, null, "https://images.generated.photos/DThx55Jct9pbzh0tEWKAH9ilBwpKhHfPL0f0B6umGxU/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA4NDk3MjcuanBn.jpg", null, null, null, false, 30000000, "Sales Support", null, "dummy1" },
                    { 2, 34, null, "Erd", null, false, "egyetem", null, false, false, null, new[] { "nemet", "angol" }, null, null, null, null, "https://images.generated.photos/1k3lzxgEtWeS2mefKNXprUfn-kPpzyz3QJ0xuizOQrE/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA3NzkzMDkuanBn.jpg", null, null, null, true, 50000000, "Sales adminisztracio", null, "dummy2" },
                    { 3, 20, null, "Budapest", null, false, "egyetem", null, false, false, null, new[] { "kinai", "angol" }, null, null, null, null, "https://images.generated.photos/jEnG00iXVCxYx24J4dFGMRWTkSaYGOR6-Igumi2VP3w/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA5Nzg0MzkuanBn.jpg", null, null, null, false, 30000000, "Sales adminisztracio", null, "dummy3" },
                    { 4, 22, null, "Budapest", null, false, "PhD", null, true, false, null, new[] { "orosz", "angol" }, null, null, null, null, "https://images.generated.photos/GmWEUKjveqsM5x3TsJVABoSyjilRB6Tz2Z-Auc9p-8Y/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA2MTI4NTcuanBn.jpg", null, null, null, false, 40000000, "Sales szaktanacsado", null, "dummy4" },
                    { 5, 34, null, "Kecsekemet", null, true, "DLA", null, false, false, null, new[] { "angol" }, null, null, null, null, "https://images.generated.photos/qvPRjAxXrZdLdgSDd6yk2I7ni0a1LAwFWZBNfvYNMdo/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA4MjM3ODkuanBn.jpg", null, null, null, true, 50000000, "Sales specialist", null, "dummy5" },
                    { 6, 30, null, "Erd", null, false, "Foiskola", null, false, false, null, new[] { "angol" }, null, null, null, null, "https://images.generated.photos/YFrGWaIDMHGU5HoB3GxLFJ_jXTE8S8gpstIs3Pm9dHE/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA3ODQ4MzYuanBn.jpg", null, null, null, true, 30000000, "Sales Support", null, "dummy6" },
                    { 7, 19, null, "Dunaharaszti", null, true, "egyetem", null, true, false, null, new[] { "ukran", "angol" }, null, null, null, null, "https://images.generated.photos/aKjcATGNs_-Y5cyzeAdjL3N-cRWqUh7hKjds4pOytgw/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA2ODM0NDMuanBn.jpg", null, null, null, false, 40000000, "Sales support", null, "dummy7" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "EmployeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "EmployeeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "EmployeeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "EmployeeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "EmployeeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1e53a7d7-f17a-4bff-b2b2-61efff6c9c8a", "fd9cd9dc-bd79-4b2e-a480-7b38a8c0ce6d" });
        }
    }
}
