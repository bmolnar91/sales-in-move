using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesInMove.Migrations
{
    public partial class PositionSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyPositionId",
                table: "Position");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ca4aa081-928d-4045-bfff-513e64448f4c", "218b2118-30b6-49d3-9e1d-bfd0d1be984f" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 12,
                column: "PositionId",
                value: 3);

            migrationBuilder.InsertData(
                table: "WorkHourRatio",
                columns: new[] { "WorkHourRatioId", "DrivingHours", "HomeOfficeHours", "OfficeHours", "WorkHoursPerMonth" },
                values: new object[] { 4, (byte)20, (byte)100, (byte)64, 184 });

            migrationBuilder.InsertData(
                table: "Position",
                columns: new[] { "PositionId", "BossExpectations", "City", "CompanyId", "Description", "Expectations", "Name", "OtherBenefits", "ProgressionSupport", "Wages", "WorkHour", "WorkHourRatioId" },
                values: new object[] { 3, "Be good and reliable!", "Halásztelek", null, "Good", null, "Sales manager", "Laptop and car", true, null, "Full", 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "PositionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WorkHourRatio",
                keyColumn: "WorkHourRatioId",
                keyValue: 4);

            migrationBuilder.AddColumn<int>(
                name: "CompanyPositionId",
                table: "Position",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2cf815ef-87f1-4328-ae9b-4114554f54d8", "ca4cc619-ad5e-44b4-84b7-84a778f02cb1" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 12,
                column: "PositionId",
                value: 0);
        }
    }
}
