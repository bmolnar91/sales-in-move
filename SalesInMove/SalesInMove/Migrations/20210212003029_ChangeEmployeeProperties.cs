using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesInMove.Migrations
{
    public partial class ChangeEmployeeProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "Education",
                value: "Egyetem");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "Education",
                value: "Egyetem");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "City", "Education" },
                values: new object[] { "Budapest", "főiskola" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "City", "Education" },
                values: new object[] { "Érd", "főiskola" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "Education",
                value: "Marketing BA");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "Education",
                value: "Marketing BA");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "City", "Education" },
                values: new object[] { "Kecsekemet", "DLA" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "City", "Education" },
                values: new object[] { "Erd", "Foiskola" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2231c4a7-a351-4f8c-973b-6cb6c90fe7c5", "26b927fe-3ada-45fb-8214-bcedadcd2e08" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8b370fff-b4a8-482b-bbf9-777a2ce3d509", "5f471b2a-33bc-4b29-88b7-d3f46facd4de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8186b950-667b-4f89-a21b-f0922cd51502", "b4364d1e-1042-4e75-96a5-bc88764583c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7f4af344-df5c-4b92-8ac0-7a7524e199b1", "db9f012d-a62e-4164-9bd8-114ddbe5d6ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5b2b719c-0e92-4b70-97a5-b93c5bbcc3eb", "7f1ae2f2-f63f-4326-872e-adce701f1688" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "54e11789-e53e-406b-8f9a-3831075d1732", "b93da66f-dbfc-4713-ae7f-160311181cab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3f005699-b324-4c87-8c04-dd90fe583eb0", "5ed553c6-07f7-492f-826c-b664b8708143" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "90acaec6-cdb9-4578-a4e8-ba4498e0f8b3", "052cfc7e-5a82-4b00-8a5f-6e2698e25ca1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5c0d1346-2458-4ec6-b9ae-9cfc770dee96", "27f803c7-0e93-4e2a-9f82-44d98dc3de98" });
        }
    }
}
