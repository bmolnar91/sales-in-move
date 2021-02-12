using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
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

            var splitStringConverter = new ValueConverter<IList<string>, string>(v => string.Join(";", v), v => v.Split(new[] { ';' }));
            builder.Entity<Company>().Property(nameof(Company.EmployeeOpinions)).HasConversion(splitStringConverter);
            
            builder.Entity<Company>().Property(nameof(Company.CompanyProfile)).HasConversion(splitStringConverter);

            #region Account Seed
            builder.Entity<User>().HasData(
                new User
                {
                    Id = "dummy0",
                    Email = "erzsebetchen@gmail.com",
                    EmailConfirmed = true,
                    UserName = "Erzsebet Chen",
                    Password = "erzsebetchen",
                }
            );

            builder.Entity<Employee>().HasData(
                new Employee
                {
                    UserId = "dummy0",
                    EmployeeId = 10,                    
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
                    Password = "marjoiretierney",
                }
            );

            builder.Entity<Employee>().HasData(
                new Employee
                {
                    UserId = "dummy1",
                    EmployeeId = 1, 
                    Age = 30,
                    City = "Budapest",
                    Specialisation = "Sales Support",
                    Education = "Marketing BA",
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
                    Password = "maigriffiths",
                }
            );

            builder.Entity<Employee>().HasData(
                new Employee
                {
                    UserId = "dummy2",
                    EmployeeId = 2, 
                    Age = 34,
                    City = "Budapest",
                    Specialisation = "Sales adminisztracio",
                    Education = "Marketing BA",
                    Languages = new string[]{ "kinai", "angol, német"},
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
                    Password = "joannemanning",
                }
            );

            builder.Entity<Employee>().HasData(
                new Employee
                {
                    UserId = "dummy3",
                    EmployeeId = 3, 
                    Age = 20,
                    City = "Budapest",
                    Specialisation = "Sales adminisztracio",
                    Education = "Egyetem",
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
                    UserName = "Keane Boyd",
                    Password = "keaneboyd",
                }
            );

            builder.Entity<Employee>().HasData(
                new Employee
                {
                    UserId = "dummy4",
                    EmployeeId = 4, 
                    Age = 22,
                    City = "Budapest",
                    Specialisation = "Sales szaktanacsado",
                    Education = "Egyetem",
                    Languages = new string[]{ "kinai" },
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
                    UserName = "Aneeka Eaton",
                    Password = "aneekaeaton",
                }
            );

            builder.Entity<Employee>().HasData(
                new Employee
                {
                    UserId = "dummy5",
                    EmployeeId = 5, 
                    Age = 34,
                    City = "Budapest",
                    Specialisation = "Sales specialist",
                    Education = "főiskola",
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
                    Password = "bobacosta",
                }
            );

            builder.Entity<Employee>().HasData(
                new Employee
                {
                    UserId = "dummy6",
                    EmployeeId = 6,
                    Age = 30,
                    City = "Érd",
                    Specialisation = "Sales Support",
                    Education = "főiskola",
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
                    UserName = "Eoin Lynn",
                    Password = "eoinlynn",
                }
            );

            builder.Entity<Employee>().HasData(
                new Employee
                {
                    UserId = "dummy7",
                    EmployeeId = 7, 
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
