using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SalesInMove.Migrations
{
    public partial class Init : Migration
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
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    Eletkor = table.Column<int>(type: "integer", nullable: true),
                    Varos = table.Column<string>(type: "text", nullable: true),
                    Szakterulet = table.Column<string>(type: "text", nullable: true),
                    Vegzettseg = table.Column<string>(type: "text", nullable: true),
                    Nyelvek = table.Column<string[]>(type: "text[]", nullable: true),
                    Jogositvany = table.Column<bool>(type: "boolean", nullable: true),
                    SalesKurzusElofizetes = table.Column<bool>(type: "boolean", nullable: true),
                    ErtekesitoiForgalom = table.Column<int>(type: "integer", nullable: true),
                    SzemelyisegTeszt = table.Column<bool>(type: "boolean", nullable: true),
                    Picture = table.Column<string>(type: "text", nullable: true),
                    UserType = table.Column<int>(type: "integer", nullable: true),
                    User_Password = table.Column<string>(type: "text", nullable: true),
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
                    Name = table.Column<string>(type: "text", nullable: true),
                    Headquarter = table.Column<string>(type: "text", nullable: true),
                    TaxNumber = table.Column<long>(type: "bigint", maxLength: 11, nullable: false),
                    Registry = table.Column<long>(type: "bigint", nullable: false),
                    YearOfFoundation = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    NumberOfSalesman = table.Column<int>(type: "integer", nullable: false),
                    Sector = table.Column<string>(type: "text", nullable: true),
                    AnnualNettoIncome = table.Column<long>(type: "bigint", nullable: false),
                    EmployeeOpinions = table.Column<string[]>(type: "text[]", nullable: true),
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
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Eletkor", "Email", "EmailConfirmed", "ErtekesitoiForgalom", "FirstName", "Jogositvany", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Nyelvek", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Picture", "SalesKurzusElofizetes", "SecurityStamp", "Szakterulet", "SzemelyisegTeszt", "TwoFactorEnabled", "UserName", "Varos", "Vegzettseg" },
                values: new object[,]
                {
                    { "2fdb863b-66b3-4e11-94d0-5459e330f234", 0, "b38c2c3c-0110-43f2-b937-10de10a437bf", "Account", 28, "erzsebetchen@gmail.com", true, 50000000, null, true, null, false, null, null, null, new[] { "kinai", "angol" }, "erzsebetchen", null, null, false, "https://images.generated.photos/iZOX8m9z2zgSg7_qWRSr4wBWJLfNkbdeofALD6dRIVU/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA1NDIxMzguanBn.jpg", true, "8b6d8560-392b-4522-91c8-6453a6d02b9e", "Sales specialist", true, false, "Erzsebet Chen", "Budapest", "Marketing BA" },
                    { "98ba488d-f640-4974-9a9a-b4c2900a2fef", 0, "4c332a34-4f0a-4cb1-806b-5208b096cb94", "Account", 30, "marjoiretierney@gmail.com", true, 30000000, null, true, null, false, null, null, null, new[] { "nemet", "angol" }, "marjoiretierney", null, null, false, "https://images.generated.photos/DThx55Jct9pbzh0tEWKAH9ilBwpKhHfPL0f0B6umGxU/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA4NDk3MjcuanBn.jpg", false, "7c7e0717-3982-4bcc-bd71-a8421fc6e37f", "Sales Support", false, false, "Marjorie Tierney", "DunaHaraszti", "Foiskola" },
                    { "998f19bd-6923-4f20-b453-7dde21db3898", 0, "b172f10d-d5ee-45ab-893e-f945c24818df", "Account", 34, "maigriffiths@gmail.com", true, 50000000, null, false, null, false, null, null, null, new[] { "nemet", "angol" }, "maigriffiths", null, null, false, "https://images.generated.photos/1k3lzxgEtWeS2mefKNXprUfn-kPpzyz3QJ0xuizOQrE/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA3NzkzMDkuanBn.jpg", true, "603d4961-5c26-47f8-8a54-fb294afbd052", "Sales adminisztracio", false, false, "Mai Griffits", "Erd", "egyetem" },
                    { "683c3cc6-6e13-4d85-9e1e-ab5a31525fdc", 0, "414bd55e-8e5f-4fb1-b904-0ec42e58169f", "Account", 20, "joannemanning@gmail.com", true, 30000000, null, false, null, false, null, null, null, new[] { "kinai", "angol" }, "joannemanning", null, null, false, "https://images.generated.photos/jEnG00iXVCxYx24J4dFGMRWTkSaYGOR6-Igumi2VP3w/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA5Nzg0MzkuanBn.jpg", false, "805d13c6-a038-409e-a2ec-107ba9d263c3", "Sales adminisztracio", false, false, "Joanne Manning", "Budapest", "egyetem" },
                    { "ed42e67f-329c-4079-ab9c-64b1b622c73b", 0, "a1586d44-6d89-4f0f-bfc5-87cc67522a67", "Account", 22, "keaneboyd@gmail.com", true, 40000000, null, false, null, false, null, null, null, new[] { "orosz", "angol" }, "keaneboyd", null, null, false, "https://images.generated.photos/GmWEUKjveqsM5x3TsJVABoSyjilRB6Tz2Z-Auc9p-8Y/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA2MTI4NTcuanBn.jpg", false, "90e490f9-ac3a-4918-8b2a-b00f3a3567f3", "Sales szaktanacsado", true, false, "Keane Boyd", "Budapest", "PhD" },
                    { "7debd1a8-1c65-4cff-ae15-17b7f3f622b3", 0, "8c51d7ca-ea82-4792-b830-1749fddf3c61", "Account", 34, "aneekaeaton@gmail.com", true, 50000000, null, true, null, false, null, null, null, new[] { "angol" }, "aneekaeaton", null, null, false, "https://images.generated.photos/qvPRjAxXrZdLdgSDd6yk2I7ni0a1LAwFWZBNfvYNMdo/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA4MjM3ODkuanBn.jpg", true, "e8cdc6db-d602-4aa0-a55e-15b45ed1fa3e", "Sales specialist", false, false, "Aneeka Eaton", "Kecsekemet", "DLA" },
                    { "76ee9c8d-0cd3-404b-822e-4bad9478dbfd", 0, "69e9cbb8-effa-4b2a-adc1-a06f5a637162", "Account", 30, "bobacosta@gmail.com", true, 30000000, null, false, null, false, null, null, null, new[] { "angol" }, "bobacosta", null, null, false, "https://images.generated.photos/YFrGWaIDMHGU5HoB3GxLFJ_jXTE8S8gpstIs3Pm9dHE/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA3ODQ4MzYuanBn.jpg", true, "6bf92391-a085-462b-b30c-1a605a2f992c", "Sales Support", false, false, "Bob Acosta", "Erd", "Foiskola" },
                    { "147d42f1-68f0-4252-a531-ecc37da34c0c", 0, "56862338-02b4-4867-ae09-0d96523b5ce5", "Account", 19, "eoinlynn@gmail.com", true, 40000000, null, true, null, false, null, null, null, new[] { "ukran", "angol" }, "eoinlynn", null, null, false, "https://images.generated.photos/aKjcATGNs_-Y5cyzeAdjL3N-cRWqUh7hKjds4pOytgw/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA2ODM0NDMuanBn.jpg", false, "b48d6835-772d-4646-9d09-853201e297cb", "Sales support", true, false, "Eoin Lynn", "Dunaharaszti", "egyetem" },
                    { "84bed6d9-4d39-48be-ab68-ec7d7489baef", 0, "022e79c8-4524-4629-9949-b630400cad9c", "Account", 19, "eoinlynn@gmail.com", true, 40000000, null, true, null, false, null, null, null, new[] { "ukran", "angol" }, "eoinlynn", null, null, false, "https://images.generated.photos/aKjcATGNs_-Y5cyzeAdjL3N-cRWqUh7hKjds4pOytgw/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA2ODM0NDMuanBn.jpg", false, "1918f8a0-15e0-42ad-aa17-9081fead90c0", "Sales support", true, false, "Eoin Lynn", "Dunaharaszti", "egyetem" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "User_Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[] { "0", 0, "6e595669-8e46-4e82-be88-e9e094d3c878", "User", "marko@gmail.com", false, false, null, null, null, "Asd123", null, null, false, "ab733887-e41e-4cc9-b259-0da913e0d902", false, null, 2 });

            migrationBuilder.InsertData(
                table: "WorkHourRatio",
                columns: new[] { "WorkHourRatioId", "DrivingHours", "HomeOfficeHours", "OfficeHours", "WorkHoursPerMonth" },
                values: new object[] { 4, (byte)20, (byte)100, (byte)64, 184 });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "AnnualNettoIncome", "EmployeeOpinions", "Headquarter", "Name", "NumberOfSalesman", "PositionId", "Registry", "SalesSupport", "Sector", "TaxNumber", "UserId", "YearOfFoundation" },
                values: new object[] { 12, 2000321865L, new[] { "Good", "Bad", "Terrific!", "Horrific!" }, "Halásztelek", "Markoó Kft.", 10, 3, 109321480L, true, null, 24767107243L, "0", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Position",
                columns: new[] { "PositionId", "BossExpectations", "City", "CompanyId", "Description", "Expectations", "Name", "OtherBenefits", "ProgressionSupport", "Wages", "WorkHour", "WorkHourRatioId" },
                values: new object[] { 3, "Be good and reliable!", "Halásztelek", null, "Good", null, "Sales manager", "Laptop and car", true, null, "Full", 4 });

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
