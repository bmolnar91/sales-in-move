using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesInMove.Migrations
{
    public partial class ChangeValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "Education",
                value: "egyetem");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "99990950-76b8-4d1f-9c22-50b0c5092b2d", "21b3a8d0-1ec5-4d06-9ea0-6c26e4f45900" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cf9dea6c-0c81-45e0-b383-98f57e178fe5", "228e8104-a931-4d86-804d-1b55b23fe9ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "394c0373-8587-4daf-9452-f7ee307f7154", "dc712a2d-c753-4ae4-8446-dfab9447cc4c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "05faf37f-5faa-42c9-8a75-d209ec37c5f8", "c24fa18c-441a-46ff-87a2-504f49c3d58c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e8589a37-9e10-4914-a410-364a7098d4bf", "fb555f16-d9a6-4a19-8898-dfc9560db6b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7baee9c5-cdac-482e-9c91-4ff7a6c4f81f", "66b6b008-2536-447e-8912-4a14a91896fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5e761859-b94e-4a9d-95d4-f238d122de40", "834b619b-01e1-43b1-9184-0776ec6a41e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e7fe7cf8-be41-4fd8-aab0-4175ac91f36d", "242b6d32-0a0f-4960-965f-4911883360d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5a97b041-df3a-490e-99cb-73c733007eb2", "2d8edd55-ca6e-43b0-8c41-5f4e99bf627f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "Education",
                value: "Egyetem");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "211ca8c1-6a4c-45e2-a652-259c0b054810", "09fdfb13-85f2-439b-941b-f94023f94d32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "17d9b418-3f0a-4237-8c40-b90da27a5346", "08ff2932-a594-42bb-8c55-be66c2b3926e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d666b2ce-351f-4154-988a-3d5d7c6ccd2a", "054859f9-9681-40cf-8794-f463e00fb8c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a8d4e4ae-ad83-4be4-9046-5e563fef763c", "bd22ac04-cc3c-4c38-bc97-36b707709060" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "aebeb356-9238-4d08-b54f-e34e986df5c8", "84c4e059-9b8b-4881-84d1-ad2ee75206ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b15088de-c696-4992-ac04-af2c5d1abcb9", "240fa030-b1e1-4dc3-b94f-0084ba9b5551" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "861161a1-0ef6-446d-9198-0867fa27997b", "00357250-7d93-4c2a-8a30-90ebeb070985" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2f5f3783-2351-4297-a58c-b49d21c94891", "2c01e6b5-a7ce-4d9f-87e0-bfa0fc397b02" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "12c2f2d1-3a38-4bdc-8f94-53f614480214", "2e2891be-aeb0-41d7-8fab-802e763a56f6" });
        }
    }
}
