using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SalesInMove.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    UserType = table.Column<int>(type: "integer", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkHourRatio",
                columns: table => new
                {
                    WorkHourRatioId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WorkHoursPerMonth = table.Column<int>(type: "integer", nullable: false),
                    OfficeHours = table.Column<byte>(type: "smallint", nullable: false),
                    HomeOfficeHours = table.Column<byte>(type: "smallint", nullable: false),
                    DrivingHours = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkHourRatio", x => x.WorkHourRatioId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    JobTitle = table.Column<string>(type: "text", nullable: true),
                    Education = table.Column<string>(type: "text", nullable: true),
                    Languages = table.Column<string[]>(type: "text[]", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    TurnoverLastYear = table.Column<int>(type: "integer", nullable: true),
                    ProfilePicture = table.Column<string>(type: "text", nullable: true),
                    ProfileVideo = table.Column<string>(type: "text", nullable: true),
                    IsSubscribed = table.Column<bool>(type: "boolean", nullable: false),
                    HasPersonalityTest = table.Column<bool>(type: "boolean", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    City = table.Column<string>(type: "text", nullable: true),
                    DrivingLicence = table.Column<bool>(type: "boolean", nullable: false),
                    SalesCourseSubscription = table.Column<bool>(type: "boolean", nullable: false),
                    SalesTurnOver = table.Column<int>(type: "integer", nullable: false),
                    Specialisation = table.Column<string>(type: "text", nullable: true),
                    PreviousCompany = table.Column<string>(type: "text", nullable: true),
                    OtherCertificates = table.Column<string[]>(type: "text[]", nullable: true),
                    Pros = table.Column<string[]>(type: "text[]", nullable: true),
                    Cons = table.Column<string[]>(type: "text[]", nullable: true),
                    ProgressionIntetions = table.Column<string[]>(type: "text[]", nullable: true),
                    Motto = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Accounts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    PositionId = table.Column<int>(type: "integer", nullable: false),
                    CompanyProfile = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Headquarter = table.Column<string>(type: "text", nullable: true),
                    TaxNumber = table.Column<long>(type: "bigint", maxLength: 11, nullable: false),
                    Registry = table.Column<long>(type: "bigint", nullable: false),
                    YearOfFoundation = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    NumberOfSalesman = table.Column<int>(type: "integer", nullable: false),
                    Sector = table.Column<string>(type: "text", nullable: true),
                    AnnualNettoIncome = table.Column<long>(type: "bigint", nullable: false),
                    EmployeeOpinions = table.Column<string>(type: "text", nullable: true),
                    SalesSupport = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyId);
                    table.ForeignKey(
                        name: "FK_Companies_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    PositionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WorkHourRatioId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Expectations = table.Column<string>(type: "text", nullable: true),
                    BossExpectations = table.Column<string>(type: "text", nullable: true),
                    WorkHour = table.Column<string>(type: "text", nullable: true),
                    Wages = table.Column<string>(type: "text", nullable: true),
                    OtherBenefits = table.Column<string>(type: "text", nullable: true),
                    ProgressionSupport = table.Column<bool>(type: "boolean", nullable: false),
                    CompanyId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.PositionId);
                    table.ForeignKey(
                        name: "FK_Position_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Position_WorkHourRatio_WorkHourRatioId",
                        column: x => x.WorkHourRatioId,
                        principalTable: "WorkHourRatio",
                        principalColumn: "WorkHourRatioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[,]
                {
                    { "dummy0", 0, "d4a3e9a9-dea3-49b0-ba16-b09d880cb47d", "User", "erzsebetchen@gmail.com", true, false, null, null, null, "erzsebetchen", null, null, false, "0e0aa504-4805-4f65-b80f-71940609e17c", false, "Erzsebet Chen", 0 },
                    { "dummy1", 0, "bb7e60a1-fb60-4052-8748-1010c29dc1d5", "User", "marjoiretierney@gmail.com", true, false, null, null, null, "marjoiretierney", null, null, false, "54d0d82c-6dd8-4d75-bf1d-b46ad50af403", false, "Marjorie Tierney", 0 },
                    { "dummy2", 0, "a7dc20a8-c92a-40d7-834b-801688c18654", "User", "maigriffiths@gmail.com", true, false, null, null, null, "maigriffiths", null, null, false, "acc1f6f1-e5f2-4f0f-bb76-d1fc147814ff", false, "Mai Griffits", 0 },
                    { "dummy3", 0, "7b14d83a-7f3b-4093-b3e1-e6218fa70cab", "User", "joannemanning@gmail.com", true, false, null, null, null, "joannemanning", null, null, false, "d3dd0355-3460-4c99-8649-985504d57413", false, "Joanne Manning", 0 },
                    { "dummy4", 0, "d0a0923a-6d7f-40cf-b976-ee1e7105a356", "User", "keaneboyd@gmail.com", true, false, null, null, null, "keaneboyd", null, null, false, "61878cb4-c77a-46c9-a543-ca730c19d4c6", false, "Keane Boyd", 0 },
                    { "dummy5", 0, "d8f2064e-79f6-4cc4-a2a6-20b1651c2c5e", "User", "aneekaeaton@gmail.com", true, false, null, null, null, "aneekaeaton", null, null, false, "6c397ca6-c9a7-4a9b-adef-1966662e002f", false, "Aneeka Eaton", 0 },
                    { "dummy6", 0, "bddfe034-6c60-434c-98b1-93ffbf226b35", "User", "bobacosta@gmail.com", true, false, null, null, null, "bobacosta", null, null, false, "a430ce4b-fef5-4fe7-b0fe-5016cb0d3277", false, "Bob Acosta", 0 },
                    { "dummy7", 0, "712d6518-e84c-4276-b8ef-c8acd5c6e546", "User", "eoinlynn@gmail.com", true, false, null, null, null, "eoinlynn", null, null, false, "05f145f5-10c5-4eb6-9aa9-6dc2dcc7b8e6", false, "Eoin Lynn", 0 },
                    { "0", 0, "258f1d38-e56e-4738-babb-54cd47967d01", "User", "marko@gmail.com", false, false, null, null, null, "Asd123", null, null, false, "8dd22b04-a763-400c-8cfd-584286c0ad6d", false, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "WorkHourRatio",
                columns: new[] { "WorkHourRatioId", "DrivingHours", "HomeOfficeHours", "OfficeHours", "WorkHoursPerMonth" },
                values: new object[] { 4, (byte)20, (byte)100, (byte)64, 184 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "EmployeeId", "Age", "BirthDate", "City", "Cons", "DrivingLicence", "Education", "FirstName", "HasPersonalityTest", "IsSubscribed", "JobTitle", "Languages", "LastName", "Motto", "OtherCertificates", "PreviousCompany", "ProfilePicture", "ProfileVideo", "ProgressionIntetions", "Pros", "SalesCourseSubscription", "SalesTurnOver", "Specialisation", "TurnoverLastYear", "UserId" },
                values: new object[,]
                {
                    { 10, 28, null, "Budapest", null, true, "Marketing BA", null, true, false, null, new[] { "kinai", "angol" }, null, null, null, null, "https://images.generated.photos/iZOX8m9z2zgSg7_qWRSr4wBWJLfNkbdeofALD6dRIVU/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA1NDIxMzguanBn.jpg", null, null, null, true, 50000000, "Sales specialist", null, "dummy0" },
                    { 1, 30, null, "Budapest", null, true, "Marketing BA", null, false, false, null, new[] { "nemet", "angol" }, null, null, null, null, "https://images.generated.photos/DThx55Jct9pbzh0tEWKAH9ilBwpKhHfPL0f0B6umGxU/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA4NDk3MjcuanBn.jpg", null, null, null, false, 30000000, "Sales Support", null, "dummy1" },
                    { 2, 34, null, "Budapest", null, false, "Marketing BA", null, false, false, null, new[] { "kinai", "angol, német" }, null, null, null, null, "https://images.generated.photos/1k3lzxgEtWeS2mefKNXprUfn-kPpzyz3QJ0xuizOQrE/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA3NzkzMDkuanBn.jpg", null, null, null, true, 50000000, "Sales adminisztracio", null, "dummy2" },
                    { 3, 20, null, "Budapest", null, false, "Marketing BA", null, false, false, null, new[] { "kinai", "angol" }, null, null, null, null, "https://images.generated.photos/jEnG00iXVCxYx24J4dFGMRWTkSaYGOR6-Igumi2VP3w/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA5Nzg0MzkuanBn.jpg", null, null, null, false, 30000000, "Sales adminisztracio", null, "dummy3" },
                    { 4, 22, null, "Budapest", null, false, "Marketing BA", null, true, false, null, new[] { "kinai" }, null, null, null, null, "https://images.generated.photos/GmWEUKjveqsM5x3TsJVABoSyjilRB6Tz2Z-Auc9p-8Y/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA2MTI4NTcuanBn.jpg", null, null, null, false, 40000000, "Sales szaktanacsado", null, "dummy4" },
                    { 5, 34, null, "Kecsekemet", null, true, "DLA", null, false, false, null, new[] { "angol" }, null, null, null, null, "https://images.generated.photos/qvPRjAxXrZdLdgSDd6yk2I7ni0a1LAwFWZBNfvYNMdo/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA4MjM3ODkuanBn.jpg", null, null, null, true, 50000000, "Sales specialist", null, "dummy5" },
                    { 6, 30, null, "Erd", null, false, "Foiskola", null, false, false, null, new[] { "angol" }, null, null, null, null, "https://images.generated.photos/YFrGWaIDMHGU5HoB3GxLFJ_jXTE8S8gpstIs3Pm9dHE/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA3ODQ4MzYuanBn.jpg", null, null, null, true, 30000000, "Sales Support", null, "dummy6" },
                    { 7, 19, null, "Dunaharaszti", null, true, "egyetem", null, true, false, null, new[] { "ukran", "angol" }, null, null, null, null, "https://images.generated.photos/aKjcATGNs_-Y5cyzeAdjL3N-cRWqUh7hKjds4pOytgw/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA2ODM0NDMuanBn.jpg", null, null, null, false, 40000000, "Sales support", null, "dummy7" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "AnnualNettoIncome", "CompanyProfile", "EmployeeOpinions", "Headquarter", "Name", "NumberOfSalesman", "PositionId", "Registry", "SalesSupport", "Sector", "TaxNumber", "UserId", "YearOfFoundation" },
                values: new object[] { 12, 2000321865L, null, "Good;Bad;Terrific!;Horrific!", "Halásztelek", "Markoó Kft.", 10, 3, 109321480L, true, null, 24767107243L, "0", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Position",
                columns: new[] { "PositionId", "BossExpectations", "City", "CompanyId", "Description", "Expectations", "Name", "OtherBenefits", "ProgressionSupport", "Wages", "WorkHour", "WorkHourRatioId" },
                values: new object[] { 3, "Be good and reliable!", "Halásztelek", null, "Good", null, "Sales manager", "Laptop and car", true, null, "Full", 4 });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_UserId",
                table: "Accounts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Companies_UserId",
                table: "Companies",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Position_CompanyId",
                table: "Position",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Position_WorkHourRatioId",
                table: "Position",
                column: "WorkHourRatioId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "WorkHourRatio");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
