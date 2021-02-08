using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SalesInMove.Models;
using System.Collections.Generic;
using System;

namespace SalesInMove.DatabaseRelated
{
    public class SalesmenDbContext : IdentityDbContext
    {
        //connection with the entityframework core
        public SalesmenDbContext(DbContextOptions<SalesmenDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

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
                    UserId = "0"

                }
            );
            #endregion

        }

    }
}
