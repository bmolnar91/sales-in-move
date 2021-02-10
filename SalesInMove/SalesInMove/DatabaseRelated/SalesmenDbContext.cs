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

        public DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            #region Account Seed
            builder.Entity<Account>().HasData(
                new Account
                {
                    Email = "erzsebetchen@gmail.com",
                    EmailConfirmed = true,
                    Password = "erzsebetchen",
                    UserName = "Erzsebet Chen",
                    Eletkor = 28,
                    Varos = "Budapest",
                    Szakterulet = "Sales specialist",
                    Vegzettseg = "Marketing BA",
                    Nyelvek = new List<string>() { "kinai", "angol"},
                    Jogositvany = true,
                    SalesKurzusElofizetes = true,
                    SzemelyisegTeszt = true,
                    ErtékesitoiForgalom = 50000000,
                    Picture = "https://images.generated.photos/iZOX8m9z2zgSg7_qWRSr4wBWJLfNkbdeofALD6dRIVU/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA1NDIxMzguanBn.jpg"
                }
            );

            builder.Entity<Account>().HasData(
                new Account
                {
                    Email = "marjoiretierney@gmail.com",
                    EmailConfirmed = true,
                    Password = "marjoiretierney",
                    UserName = "Marjorie Tierney",
                    Eletkor = 30,
                    Varos = "DunaHaraszti",
                    Szakterulet = "Sales Support",
                    Vegzettseg = "Foiskola",
                    Nyelvek = new List<string>() { "nemet", "angol" },
                    Jogositvany = true,
                    SalesKurzusElofizetes = false,
                    SzemelyisegTeszt = false,
                    ErtékesitoiForgalom = 30000000,
                    Picture = "https://images.generated.photos/DThx55Jct9pbzh0tEWKAH9ilBwpKhHfPL0f0B6umGxU/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA4NDk3MjcuanBn.jpg"

                }
            );

            builder.Entity<Account>().HasData(
                new Account
                {
                    Email = "maigriffiths@gmail.com",
                    EmailConfirmed = true,
                    Password = "maigriffiths",
                    UserName = "Mai Griffits",
                    Eletkor = 34,
                    Varos = "Erd",
                    Szakterulet = "Sales adminisztracio",
                    Vegzettseg = "egyetem",
                    Nyelvek = new List<string>() { "nemet", "angol" },
                    Jogositvany = false,
                    SalesKurzusElofizetes = true,
                    SzemelyisegTeszt = false,
                    ErtékesitoiForgalom = 50000000,
                    Picture = "https://images.generated.photos/1k3lzxgEtWeS2mefKNXprUfn-kPpzyz3QJ0xuizOQrE/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA3NzkzMDkuanBn.jpg"
                }
            );

            builder.Entity<Account>().HasData(
                new Account
                {
                    Email = "joannemanning@gmail.com",
                    EmailConfirmed = true,
                    Password = "joannemanning",
                    UserName = "Joanne Manning",
                    Eletkor = 20,
                    Varos = "Budapest",
                    Szakterulet = "Sales adminisztracio",
                    Vegzettseg = "egyetem",
                    Nyelvek = new List<string>() { "kinai", "angol" },
                    Jogositvany = false,
                    SalesKurzusElofizetes = false,
                    SzemelyisegTeszt = false,
                    ErtékesitoiForgalom = 30000000,
                    Picture = "https://images.generated.photos/jEnG00iXVCxYx24J4dFGMRWTkSaYGOR6-Igumi2VP3w/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA5Nzg0MzkuanBn.jpg"
                }
            );

            builder.Entity<Account>().HasData(
                new Account
                {
                    Email = "keaneboyd@gmail.com",
                    EmailConfirmed = true,
                    Password = "keaneboyd",
                    UserName = "Keane Boyd",
                    Eletkor = 22,
                    Varos = "Budapest",
                    Szakterulet = "Sales szaktanacsado",
                    Vegzettseg = "PhD",
                    Nyelvek = new List<string>() { "orosz", "angol" },
                    Jogositvany = false,
                    SalesKurzusElofizetes = false,
                    SzemelyisegTeszt = true,
                    ErtékesitoiForgalom = 40000000,
                    Picture = "https://images.generated.photos/GmWEUKjveqsM5x3TsJVABoSyjilRB6Tz2Z-Auc9p-8Y/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA2MTI4NTcuanBn.jpg"
                }
            );

            builder.Entity<Account>().HasData(
                new Account
                {
                    Email = "aneekaeaton@gmail.com",
                    EmailConfirmed = true,
                    Password = "aneekaeaton",
                    UserName = "Aneeka Eaton",
                    Eletkor = 34,
                    Varos = "Kecsekemet",
                    Szakterulet = "Sales specialist",
                    Vegzettseg = "DLA",
                    Nyelvek = new List<string>() {"angol" },
                    Jogositvany = true,
                    SalesKurzusElofizetes = true,
                    SzemelyisegTeszt = false,
                    ErtékesitoiForgalom = 50000000,
                    Picture = "https://images.generated.photos/qvPRjAxXrZdLdgSDd6yk2I7ni0a1LAwFWZBNfvYNMdo/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA4MjM3ODkuanBn.jpg"
                }
            );

            builder.Entity<Account>().HasData(
                new Account
                {
                    Email = "bobacosta@gmail.com",
                    EmailConfirmed = true,
                    Password = "bobacosta",
                    UserName = "Bob Acosta",
                    Eletkor = 30,
                    Varos = "Erd",
                    Szakterulet = "Sales Support",
                    Vegzettseg = "Foiskola",
                    Nyelvek = new List<string>() { "angol" },
                    Jogositvany = false,
                    SalesKurzusElofizetes = true,
                    SzemelyisegTeszt = false,
                    ErtékesitoiForgalom = 30000000,
                    Picture= "https://images.generated.photos/YFrGWaIDMHGU5HoB3GxLFJ_jXTE8S8gpstIs3Pm9dHE/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA3ODQ4MzYuanBn.jpg"
                }
            );
            builder.Entity<Account>().HasData(
                new Account
                {
                    Email = "eoinlynn@gmail.com",
                    EmailConfirmed = true,
                    Password = "eoinlynn",
                    UserName = "Eoin Lynn",
                    Eletkor = 19,
                    Varos = "Dunaharaszti",
                    Szakterulet = "Sales support",
                    Vegzettseg = "egyetem",
                    Nyelvek = new List<string>() { "ukran", "angol" },
                    Jogositvany = true,
                    SalesKurzusElofizetes = false,
                    SzemelyisegTeszt = true,
                    ErtékesitoiForgalom = 40000000,
                    Picture = "https://images.generated.photos/aKjcATGNs_-Y5cyzeAdjL3N-cRWqUh7hKjds4pOytgw/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA2ODM0NDMuanBn.jpg"
                }
            );

            builder.Entity<Account>().HasData(
                new Account
                {
                    Email = "eoinlynn@gmail.com",
                    EmailConfirmed = true,
                    Password = "eoinlynn",
                    UserName = "Eoin Lynn",
                    Eletkor = 19,
                    Varos = "Dunaharaszti",
                    Szakterulet = "Sales support",
                    Vegzettseg = "egyetem",
                    Nyelvek = new List<string>() { "ukran", "angol" },
                    Jogositvany = true,
                    SalesKurzusElofizetes = false,
                    SzemelyisegTeszt = true,
                    ErtékesitoiForgalom = 40000000,
                    Picture = "https://images.generated.photos/aKjcATGNs_-Y5cyzeAdjL3N-cRWqUh7hKjds4pOytgw/rs:fit:512:512/wm:0.95:sowe:18:18:0.33/Z3M6Ly9nZW5lcmF0/ZWQtcGhvdG9zL3Yz/XzA2ODM0NDMuanBn.jpg"
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
