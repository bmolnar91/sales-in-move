using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesInMove.Migrations
{
    public partial class ChangeDummyParameters3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "City",
                value: "Budapest");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "City",
                value: "Budapest");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "City",
                value: "DunaHaraszti");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "City",
                value: "Erd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5fc31cc3-7e54-4fa5-b487-e2e8cb3025be", "1d8fef57-139d-4b55-beb2-b7db3bcc2cda" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0c59741f-1836-4410-979d-a281942d03af", "804cb020-c4c4-4c67-965e-bf1cc5980b8a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "227db717-4813-486d-8424-012dfe90c487", "8f96b94f-dc55-402a-9fb2-090e786daf5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e3e21d12-9dc7-4245-b5b9-db32dc997dd0", "197f7094-a4ad-4275-a789-645bdb40393a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7ccb2a94-c1f9-410f-a74b-ae35d193217d", "eb959440-9c1d-4098-8099-f86a57094e9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dd329bf2-4a67-43e2-8e0a-a0a44faecac4", "24e27f3b-0652-46bf-8884-6bf26023c217" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a40f88ad-aa93-41d4-bb57-da9a847895fd", "9696fa17-4d1a-41e8-aeff-32bafbc75db2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d8fd33e1-9708-4119-80c6-9bb1d21f917e", "580808b7-2a0c-49b0-b335-2f323cd7943b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e179b71e-6fa2-4e33-8cc8-43f262a31c76", "09f45ba0-76be-4669-aeb0-4230ea494d21" });
        }
    }
}
