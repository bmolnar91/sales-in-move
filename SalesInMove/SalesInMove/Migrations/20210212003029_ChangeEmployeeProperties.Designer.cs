﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SalesInMove.DatabaseRelated;

namespace SalesInMove.Migrations
{
    [DbContext(typeof(SalesmenDbContext))]
    [Migration("20210212003029_ChangeEmployeeProperties")]
    partial class ChangeEmployeeProperties
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SalesInMove.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<long>("AnnualNettoIncome")
                        .HasColumnType("bigint");

                    b.Property<string>("CompanyProfile")
                        .HasColumnType("text");

                    b.Property<string>("EmployeeOpinions")
                        .HasColumnType("text");

                    b.Property<string>("Headquarter")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("NumberOfSalesman")
                        .HasColumnType("integer");

                    b.Property<int>("PositionId")
                        .HasColumnType("integer");

                    b.Property<long>("Registry")
                        .HasColumnType("bigint");

                    b.Property<bool>("SalesSupport")
                        .HasColumnType("boolean");

                    b.Property<string>("Sector")
                        .HasColumnType("text");

                    b.Property<long>("TaxNumber")
                        .HasMaxLength(11)
                        .HasColumnType("bigint");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("YearOfFoundation")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("CompanyId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            CompanyId = 12,
                            AnnualNettoIncome = 2000321865L,
                            EmployeeOpinions = "Good;Bad;Terrific!;Horrific!",
                            Headquarter = "Halásztelek",
                            Name = "Markoó Kft.",
                            NumberOfSalesman = 10,
                            PositionId = 3,
                            Registry = 109321480L,
                            SalesSupport = true,
                            TaxNumber = 24767107243L,
                            UserId = "0",
                            YearOfFoundation = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("SalesInMove.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string[]>("Cons")
                        .HasColumnType("text[]");

                    b.Property<bool>("DrivingLicence")
                        .HasColumnType("boolean");

                    b.Property<string>("Education")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<bool>("HasPersonalityTest")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsSubscribed")
                        .HasColumnType("boolean");

                    b.Property<string>("JobTitle")
                        .HasColumnType("text");

                    b.Property<string[]>("Languages")
                        .HasColumnType("text[]");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Motto")
                        .HasColumnType("text");

                    b.Property<string[]>("OtherCertificates")
                        .HasColumnType("text[]");

                    b.Property<string>("PreviousCompany")
                        .HasColumnType("text");

                    b.Property<string>("ProfilePicture")
                        .HasColumnType("text");

                    b.Property<string>("ProfileVideo")
                        .HasColumnType("text");

                    b.Property<string[]>("ProgressionIntetions")
                        .HasColumnType("text[]");

                    b.Property<string[]>("Pros")
                        .HasColumnType("text[]");

                    b.Property<bool>("SalesCourseSubscription")
                        .HasColumnType("boolean");

                    b.Property<int>("SalesTurnOver")
                        .HasColumnType("integer");

                    b.Property<string>("Specialisation")
                        .HasColumnType("text");

                    b.Property<int?>("TurnoverLastYear")
                        .HasColumnType("integer");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("EmployeeId");

                    b.HasIndex("UserId");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            EmployeeId = 10,
                            Age = 28,
                            City = "Budapest",
                            DrivingLicence = true,
                            Education = "Marketing BA",
                            HasPersonalityTest = true,
                            IsSubscribed = false,
                            Languages = new[] { "kinai", "angol" },
                            ProfilePicture = "https://images.generated.photos/iZOX8m9z2zgSg7_qWRSr4wBWJLfNkbdeofALD6dRIVU/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA1NDIxMzguanBn.jpg",
                            SalesCourseSubscription = true,
                            SalesTurnOver = 50000000,
                            Specialisation = "Sales specialist",
                            UserId = "dummy0"
                        },
                        new
                        {
                            EmployeeId = 1,
                            Age = 30,
                            City = "Budapest",
                            DrivingLicence = true,
                            Education = "Marketing BA",
                            HasPersonalityTest = false,
                            IsSubscribed = false,
                            Languages = new[] { "nemet", "angol" },
                            ProfilePicture = "https://images.generated.photos/DThx55Jct9pbzh0tEWKAH9ilBwpKhHfPL0f0B6umGxU/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA4NDk3MjcuanBn.jpg",
                            SalesCourseSubscription = false,
                            SalesTurnOver = 30000000,
                            Specialisation = "Sales Support",
                            UserId = "dummy1"
                        },
                        new
                        {
                            EmployeeId = 2,
                            Age = 34,
                            City = "Budapest",
                            DrivingLicence = false,
                            Education = "Marketing BA",
                            HasPersonalityTest = false,
                            IsSubscribed = false,
                            Languages = new[] { "kinai", "angol, német" },
                            ProfilePicture = "https://images.generated.photos/1k3lzxgEtWeS2mefKNXprUfn-kPpzyz3QJ0xuizOQrE/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA3NzkzMDkuanBn.jpg",
                            SalesCourseSubscription = true,
                            SalesTurnOver = 50000000,
                            Specialisation = "Sales adminisztracio",
                            UserId = "dummy2"
                        },
                        new
                        {
                            EmployeeId = 3,
                            Age = 20,
                            City = "Budapest",
                            DrivingLicence = false,
                            Education = "Egyetem",
                            HasPersonalityTest = false,
                            IsSubscribed = false,
                            Languages = new[] { "kinai", "angol" },
                            ProfilePicture = "https://images.generated.photos/jEnG00iXVCxYx24J4dFGMRWTkSaYGOR6-Igumi2VP3w/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA5Nzg0MzkuanBn.jpg",
                            SalesCourseSubscription = false,
                            SalesTurnOver = 30000000,
                            Specialisation = "Sales adminisztracio",
                            UserId = "dummy3"
                        },
                        new
                        {
                            EmployeeId = 4,
                            Age = 22,
                            City = "Budapest",
                            DrivingLicence = false,
                            Education = "Egyetem",
                            HasPersonalityTest = true,
                            IsSubscribed = false,
                            Languages = new[] { "kinai" },
                            ProfilePicture = "https://images.generated.photos/GmWEUKjveqsM5x3TsJVABoSyjilRB6Tz2Z-Auc9p-8Y/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA2MTI4NTcuanBn.jpg",
                            SalesCourseSubscription = false,
                            SalesTurnOver = 40000000,
                            Specialisation = "Sales szaktanacsado",
                            UserId = "dummy4"
                        },
                        new
                        {
                            EmployeeId = 5,
                            Age = 34,
                            City = "Budapest",
                            DrivingLicence = true,
                            Education = "főiskola",
                            HasPersonalityTest = false,
                            IsSubscribed = false,
                            Languages = new[] { "angol" },
                            ProfilePicture = "https://images.generated.photos/qvPRjAxXrZdLdgSDd6yk2I7ni0a1LAwFWZBNfvYNMdo/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA4MjM3ODkuanBn.jpg",
                            SalesCourseSubscription = true,
                            SalesTurnOver = 50000000,
                            Specialisation = "Sales specialist",
                            UserId = "dummy5"
                        },
                        new
                        {
                            EmployeeId = 6,
                            Age = 30,
                            City = "Érd",
                            DrivingLicence = false,
                            Education = "főiskola",
                            HasPersonalityTest = false,
                            IsSubscribed = false,
                            Languages = new[] { "angol" },
                            ProfilePicture = "https://images.generated.photos/YFrGWaIDMHGU5HoB3GxLFJ_jXTE8S8gpstIs3Pm9dHE/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA3ODQ4MzYuanBn.jpg",
                            SalesCourseSubscription = true,
                            SalesTurnOver = 30000000,
                            Specialisation = "Sales Support",
                            UserId = "dummy6"
                        },
                        new
                        {
                            EmployeeId = 7,
                            Age = 19,
                            City = "Dunaharaszti",
                            DrivingLicence = true,
                            Education = "egyetem",
                            HasPersonalityTest = true,
                            IsSubscribed = false,
                            Languages = new[] { "ukran", "angol" },
                            ProfilePicture = "https://images.generated.photos/aKjcATGNs_-Y5cyzeAdjL3N-cRWqUh7hKjds4pOytgw/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA2ODM0NDMuanBn.jpg",
                            SalesCourseSubscription = false,
                            SalesTurnOver = 40000000,
                            Specialisation = "Sales support",
                            UserId = "dummy7"
                        });
                });

            modelBuilder.Entity("SalesInMove.Models.Position", b =>
                {
                    b.Property<int>("PositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("BossExpectations")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Expectations")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("OtherBenefits")
                        .HasColumnType("text");

                    b.Property<bool>("ProgressionSupport")
                        .HasColumnType("boolean");

                    b.Property<string>("Wages")
                        .HasColumnType("text");

                    b.Property<string>("WorkHour")
                        .HasColumnType("text");

                    b.Property<int>("WorkHourRatioId")
                        .HasColumnType("integer");

                    b.HasKey("PositionId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("WorkHourRatioId")
                        .IsUnique();

                    b.ToTable("Position");

                    b.HasData(
                        new
                        {
                            PositionId = 3,
                            BossExpectations = "Be good and reliable!",
                            City = "Halásztelek",
                            Description = "Good",
                            Name = "Sales manager",
                            OtherBenefits = "Laptop and car",
                            ProgressionSupport = true,
                            WorkHour = "Full",
                            WorkHourRatioId = 4
                        });
                });

            modelBuilder.Entity("SalesInMove.Models.WorkHourRatio", b =>
                {
                    b.Property<int>("WorkHourRatioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<byte>("DrivingHours")
                        .HasColumnType("smallint");

                    b.Property<byte>("HomeOfficeHours")
                        .HasColumnType("smallint");

                    b.Property<byte>("OfficeHours")
                        .HasColumnType("smallint");

                    b.Property<int>("WorkHoursPerMonth")
                        .HasColumnType("integer");

                    b.HasKey("WorkHourRatioId");

                    b.ToTable("WorkHourRatio");

                    b.HasData(
                        new
                        {
                            WorkHourRatioId = 4,
                            DrivingHours = (byte)20,
                            HomeOfficeHours = (byte)100,
                            OfficeHours = (byte)64,
                            WorkHoursPerMonth = 184
                        });
                });

            modelBuilder.Entity("SalesInMove.Models.User", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserType")
                        .HasColumnType("integer");

                    b.HasDiscriminator().HasValue("User");

                    b.HasData(
                        new
                        {
                            Id = "dummy0",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "17d9b418-3f0a-4237-8c40-b90da27a5346",
                            Email = "erzsebetchen@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "08ff2932-a594-42bb-8c55-be66c2b3926e",
                            TwoFactorEnabled = false,
                            UserName = "Erzsebet Chen",
                            Password = "erzsebetchen",
                            UserType = 0
                        },
                        new
                        {
                            Id = "dummy1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d666b2ce-351f-4154-988a-3d5d7c6ccd2a",
                            Email = "marjoiretierney@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "054859f9-9681-40cf-8794-f463e00fb8c9",
                            TwoFactorEnabled = false,
                            UserName = "Marjorie Tierney",
                            Password = "marjoiretierney",
                            UserType = 0
                        },
                        new
                        {
                            Id = "dummy2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a8d4e4ae-ad83-4be4-9046-5e563fef763c",
                            Email = "maigriffiths@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "bd22ac04-cc3c-4c38-bc97-36b707709060",
                            TwoFactorEnabled = false,
                            UserName = "Mai Griffits",
                            Password = "maigriffiths",
                            UserType = 0
                        },
                        new
                        {
                            Id = "dummy3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "aebeb356-9238-4d08-b54f-e34e986df5c8",
                            Email = "joannemanning@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "84c4e059-9b8b-4881-84d1-ad2ee75206ea",
                            TwoFactorEnabled = false,
                            UserName = "Joanne Manning",
                            Password = "joannemanning",
                            UserType = 0
                        },
                        new
                        {
                            Id = "dummy4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b15088de-c696-4992-ac04-af2c5d1abcb9",
                            Email = "keaneboyd@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "240fa030-b1e1-4dc3-b94f-0084ba9b5551",
                            TwoFactorEnabled = false,
                            UserName = "Keane Boyd",
                            Password = "keaneboyd",
                            UserType = 0
                        },
                        new
                        {
                            Id = "dummy5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "861161a1-0ef6-446d-9198-0867fa27997b",
                            Email = "aneekaeaton@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "00357250-7d93-4c2a-8a30-90ebeb070985",
                            TwoFactorEnabled = false,
                            UserName = "Aneeka Eaton",
                            Password = "aneekaeaton",
                            UserType = 0
                        },
                        new
                        {
                            Id = "dummy6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2f5f3783-2351-4297-a58c-b49d21c94891",
                            Email = "bobacosta@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2c01e6b5-a7ce-4d9f-87e0-bfa0fc397b02",
                            TwoFactorEnabled = false,
                            UserName = "Bob Acosta",
                            Password = "bobacosta",
                            UserType = 0
                        },
                        new
                        {
                            Id = "dummy7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "12c2f2d1-3a38-4bdc-8f94-53f614480214",
                            Email = "eoinlynn@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2e2891be-aeb0-41d7-8fab-802e763a56f6",
                            TwoFactorEnabled = false,
                            UserName = "Eoin Lynn",
                            Password = "eoinlynn",
                            UserType = 0
                        },
                        new
                        {
                            Id = "0",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "211ca8c1-6a4c-45e2-a652-259c0b054810",
                            Email = "marko@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "09fdfb13-85f2-439b-941b-f94023f94d32",
                            TwoFactorEnabled = false,
                            Password = "Asd123",
                            UserType = 2
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SalesInMove.Models.Company", b =>
                {
                    b.HasOne("SalesInMove.Models.User", "User")
                        .WithOne("Company")
                        .HasForeignKey("SalesInMove.Models.Company", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SalesInMove.Models.Employee", b =>
                {
                    b.HasOne("SalesInMove.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SalesInMove.Models.Position", b =>
                {
                    b.HasOne("SalesInMove.Models.Company", "Company")
                        .WithMany("Positions")
                        .HasForeignKey("CompanyId");

                    b.HasOne("SalesInMove.Models.WorkHourRatio", "WorkHourRatio")
                        .WithOne("Position")
                        .HasForeignKey("SalesInMove.Models.Position", "WorkHourRatioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("WorkHourRatio");
                });

            modelBuilder.Entity("SalesInMove.Models.Company", b =>
                {
                    b.Navigation("Positions");
                });

            modelBuilder.Entity("SalesInMove.Models.WorkHourRatio", b =>
                {
                    b.Navigation("Position");
                });

            modelBuilder.Entity("SalesInMove.Models.User", b =>
                {
                    b.Navigation("Company");
                });
#pragma warning restore 612, 618
        }
    }
}
