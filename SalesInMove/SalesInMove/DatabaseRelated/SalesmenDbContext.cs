using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SalesInMove.Models;
using System;
using System.Collections.Generic;

namespace SalesInMove.DatabaseRelated
{
    public class SalesmenDbContext : IdentityDbContext
    {
        //connection with the entityframework core
        public SalesmenDbContext(DbContextOptions<SalesmenDbContext> options) : base(options)
        {

        }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Employee> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            #region Account Seed
            builder.Entity<User>().HasData(
                new User
                {
                    Email = "erzsebetchen@gmail.com",
                    EmailConfirmed = true,
                    UserName = "Erzsebet Chen",
                }
            );

            builder.Entity<Employee>().HasData(
                new Employee
                {

                    Password = "erzsebetchen",
                    Age = 28,
                    City = "Budapest",
                    Specialisation = "Sales specialist",
                    Education = "Marketing BA",
                    Languages = new string[]{ "kinai", "angol"},
                    DrivingLicence = true,
                    SalesCourseSubscription = true,
                    HasPersonalityTest = true,
                    SalesTurnOver = 50000000,
                    ProfilePicture = "https://images.generated.photos/iZOX8m9z2zgSg7_qWRSr4wBWJLfNkbdeofALD6dRIVU/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA1NDIxMzguanBn.jpg"
                }
            );

            builder.Entity<User>().HasData(
                new User
                {
                    Id = "dummy1",
                    Email = "marjoiretierney@gmail.com",
                    EmailConfirmed = true,
                    UserName = "Marjorie Tierney",
                }
            );

            builder.Entity<Employee>().HasData(
                new Employee
                {
                    UserId = "dummy1",
                    Password = "marjoiretierney",
                    Age = 30,
                    City = "DunaHaraszti",
                    Specialisation = "Sales Support",
                    Education = "Foiskola",
                    Languages = new string[]{ "nemet", "angol" },
                    DrivingLicence = true,
                    SalesCourseSubscription = false,
                    HasPersonalityTest = false,
                    SalesTurnOver = 30000000,
                    ProfilePicture = "https://images.generated.photos/DThx55Jct9pbzh0tEWKAH9ilBwpKhHfPL0f0B6umGxU/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA4NDk3MjcuanBn.jpg"

                }
            );

            builder.Entity<User>().HasData(
                new User
                {
                    Id = "dummy2",
                    Email = "maigriffiths@gmail.com",
                    EmailConfirmed = true,
                    UserName = "Mai Griffits",
                }
            );

            builder.Entity<Employee>().HasData(
                new Employee
                {
                    UserId = "dummy2",
                    Password = "maigriffiths",
                    Age = 34,
                    City = "Erd",
                    Specialisation = "Sales adminisztracio",
                    Education = "egyetem",
                    Languages = new string[]{ "nemet", "angol" },
                    DrivingLicence = false,
                    SalesCourseSubscription = true,
                    HasPersonalityTest = false,
                    SalesTurnOver = 50000000,
                    ProfilePicture = "https://images.generated.photos/1k3lzxgEtWeS2mefKNXprUfn-kPpzyz3QJ0xuizOQrE/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA3NzkzMDkuanBn.jpg"
                }
            );

            builder.Entity<User>().HasData(
                new User
                {
                    Id = "dummy3",
                    Email = "joannemanning@gmail.com",
                    EmailConfirmed = true,
                    UserName = "Joanne Manning",
                }
            );

            builder.Entity<Employee>().HasData(
                new Employee
                {
                    UserId = "dummy3",
                    Password = "joannemanning",
                    Age = 20,
                    City = "Budapest",
                    Specialisation = "Sales adminisztracio",
                    Education = "egyetem",
                    Languages = new string[]{ "kinai", "angol" },
                    DrivingLicence = false,
                    SalesCourseSubscription = false,
                    HasPersonalityTest = false,
                    SalesTurnOver = 30000000,
                    ProfilePicture = "https://images.generated.photos/jEnG00iXVCxYx24J4dFGMRWTkSaYGOR6-Igumi2VP3w/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA5Nzg0MzkuanBn.jpg"
                }
            );

            builder.Entity<User>().HasData(
                new User
                {
                    Id = "dummy4",
                    Email = "keaneboyd@gmail.com",
                    EmailConfirmed = true,
                    UserName = "Keane Boyd"
                }
            );

            builder.Entity<Employee>().HasData(
                new Employee
                {
                    UserId = "dummy4",
                    Password = "keaneboyd",
                    Age = 22,
                    City = "Budapest",
                    Specialisation = "Sales szaktanacsado",
                    Education = "PhD",
                    Languages = new string[]{ "orosz", "angol" },
                    DrivingLicence = false,
                    SalesCourseSubscription = false,
                    HasPersonalityTest = true,
                    SalesTurnOver = 40000000,
                    ProfilePicture = "https://images.generated.photos/GmWEUKjveqsM5x3TsJVABoSyjilRB6Tz2Z-Auc9p-8Y/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA2MTI4NTcuanBn.jpg"
                }
            );

            builder.Entity<User>().HasData(
                new User
                {
                    Id = "dummy5",
                    Email = "aneekaeaton@gmail.com",
                    EmailConfirmed = true,
                    UserName = "Aneeka Eaton"
                }
            );

            builder.Entity<Employee>().HasData(
                new Employee
                {
                    UserId = "dummy5",
                    Password = "aneekaeaton",
                    Age = 34,
                    City = "Kecsekemet",
                    Specialisation = "Sales specialist",
                    Education = "DLA",
                    Languages = new string[]{"angol" },
                    DrivingLicence = true,
                    SalesCourseSubscription = true,
                    HasPersonalityTest = false,
                    SalesTurnOver = 50000000,
                    ProfilePicture = "https://images.generated.photos/qvPRjAxXrZdLdgSDd6yk2I7ni0a1LAwFWZBNfvYNMdo/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA4MjM3ODkuanBn.jpg"
                }
            );

             builder.Entity<User>().HasData(
                new User
                {
                    Id = "dummy6",
                    Email = "bobacosta@gmail.com",
                    EmailConfirmed = true,
                    UserName = "Bob Acosta",
                }
            );

            builder.Entity<Employee>().HasData(
                new Employee
                {
                    UserId = "dummy6",
                    Password = "bobacosta",
                    Age = 30,
                    City = "Erd",
                    Specialisation = "Sales Support",
                    Education = "Foiskola",
                    Languages = new string[]{ "angol" },
                    DrivingLicence = false,
                    SalesCourseSubscription = true,
                    HasPersonalityTest = false,
                    SalesTurnOver = 30000000,
                    ProfilePicture= "https://images.generated.photos/YFrGWaIDMHGU5HoB3GxLFJ_jXTE8S8gpstIs3Pm9dHE/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA3ODQ4MzYuanBn.jpg"
                }
            );

            builder.Entity<User>().HasData(
                new User
                {
                    Id = "dummy7",
                    Email = "eoinlynn@gmail.com",
                    EmailConfirmed = true,
                    UserName = "Eoin Lynn"
                }
            );

            builder.Entity<Employee>().HasData(
                new Employee
                {
                    UserId = "dummy7",
                    Password = "eoinlynn",
                    Age = 19,
                    City = "Dunaharaszti",
                    Specialisation = "Sales support",
                    Education = "egyetem",
                    Languages = new string[]{ "ukran", "angol" },
                    DrivingLicence = true,
                    SalesCourseSubscription = false,
                    HasPersonalityTest = true,
                    SalesTurnOver = 40000000,
                    ProfilePicture = "https://images.generated.photos/aKjcATGNs_-Y5cyzeAdjL3N-cRWqUh7hKjds4pOytgw/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA2ODM0NDMuanBn.jpg"
                }
            );

            #endregion


            #region PositionSeed
            builder.Entity<WorkHourRatio>().HasData(
                new WorkHourRatio
                {
                    WorkHourRatioId = 4,
                    WorkHoursPerMonth = 184,
                    HomeOfficeHours = 100,
                    DrivingHours = 20,
                    OfficeHours = 64
                }
            );

            builder.Entity<Position>().HasData(
                new Position
                {
                    PositionId = 3,
                    WorkHourRatioId = 4,
                    Name = "Sales manager",
                    City = "Halásztelek",
                    Description = "Good",
                    BossExpectations = "Be good and reliable!",
                    WorkHour = "Full",
                    OtherBenefits = "Laptop and car",
                    ProgressionSupport = true
                }
            );
            #endregion

            #region Company seed
            builder.Entity<User>().HasData(
                new User
                {
                    Id = "0",
                    Email = "marko@gmail.com",
                    Password = "Asd123",
                    UserType = 2,
                }
            );
               

            builder.Entity<Company>().HasData(
                new Company
                {
                    CompanyId = 12,
                    Name = "Markoó Kft.",
                    Headquarter = "Halásztelek",
                    TaxNumber = 24767107243,
                    Registry = 0109321480,
                    YearOfFoundation = DateTime.Parse("Jan 1, 2000"),
                    NumberOfSalesman = 10,
                    AnnualNettoIncome = 2000321865,
                    EmployeeOpinions = new string[] { "Good", "Bad", "Terrific!", "Horrific!" },
                    SalesSupport = true,
                    UserId = "0",
                    PositionId = 3

                }
            );
            #endregion

        }

    }
}
