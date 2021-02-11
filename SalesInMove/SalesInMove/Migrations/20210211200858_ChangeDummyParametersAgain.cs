using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesInMove.Migrations
{
    public partial class ChangeDummyParametersAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "Education",
                value: "Marketing BA");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "Education",
                value: "Marketing BA");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "Education",
                value: "Foiskola");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "Education",
                value: "PhD");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bfcbdade-2c99-40c4-8629-858bfc8a5d26", "42e57504-0dc3-458b-b715-9869eab72b2c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "020a5502-2993-4f56-bf3f-1e384d054bf8", "30eca729-a661-4cc0-95e2-6c2a3c3f423e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5f9f08f6-d70e-4b0f-b220-f340ec966b4f", "4f57b12f-e0c7-480f-a03f-49bb58bad9ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c09aed5c-dfb6-4e02-a749-f9017951d25a", "b306d7e7-2822-46d4-935c-7fcf7b65108e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "de113e28-c8af-4ab3-8ba5-a07ae099c6d5", "66f60d50-f2ac-40a7-98cd-8d051e0d31b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3013c62d-b03f-4a35-bc09-a6599f64647b", "400b481f-150e-46ce-b262-910c79e52f3b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "134a492d-76e8-4524-abaf-279e119bc579", "62873921-01f5-49e2-a6d5-9683a55b0323" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "641fdc10-0984-4e5f-8aa4-1a5e6f303a66", "3cbeffa9-b80e-4270-b75e-05e7db77c638" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fd420e52-64d1-405a-b56c-c0a585573724", "a6270d3f-21d0-4d3c-881b-55a30a7b3de3" });
        }
    }
}
