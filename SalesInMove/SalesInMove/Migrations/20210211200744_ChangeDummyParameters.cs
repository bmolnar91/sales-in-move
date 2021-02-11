using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesInMove.Migrations
{
    public partial class ChangeDummyParameters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "Education", "Languages" },
                values: new object[] { "Marketing BA", new[] { "kinai", "angol, német" } });

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
                column: "Languages",
                value: new[] { "kinai" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "Education", "Languages" },
                values: new object[] { "egyetem", new[] { "nemet", "angol" } });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "Education",
                value: "egyetem");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "Languages",
                value: new[] { "orosz", "angol" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "61a9e116-4ec0-43ee-92ad-c70437a43d9a", "3764cb85-a243-43cd-8030-61402351d820" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "51683318-e7ac-4d63-807b-2e2cfdb33001", "53fbf294-dee0-4996-90cb-c8841bd09e80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ab46c94f-79b5-4885-83af-f7a81320acf3", "ab6a88be-fdbe-4b80-a800-157057fd036b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d212208f-39a5-422c-a1dc-5da2ef06c5ad", "4ce11074-bc9f-4933-a09e-0d7ce5d93696" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7c8d416f-303e-40e6-9cde-ac5e5aab84a5", "29051027-3ffe-48e4-b768-2b46ab9edc6a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0990acef-ba3b-46be-97f7-bdf6459a237c", "0393b002-b0a2-443d-9362-ac9d8cfdb4bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "18fe9c94-b266-42a3-a2e5-60d2674b19da", "448888f3-f396-4326-ad3f-5c42744e60f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8c743595-bc68-4371-8905-dec8854d7d1d", "b8033be1-1d13-41ea-b2ea-88b9c1454f4c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dummy7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7c257764-0f5b-4874-99e5-a1ccd06e5417", "c5901b55-3296-40e2-9bd1-4b9635b7247c" });
        }
    }
}
