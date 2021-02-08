using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SalesInMove.Models;
using SalesInMove.Models.JoinTables;


namespace SalesInMove.DatabaseRelated
{
    public class SalesmenDbContext : IdentityDbContext
    {
        //connection with the entityframework core
        public SalesmenDbContext(DbContextOptions<SalesmenDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<UserCompany> UserCompanies { get; set; }

        public DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserCompany>()
                .HasOne(userCompany => userCompany.User)
                .WithOne()
                .HasForeignKey<User>(user => user.Id);

            builder.Entity<UserCompany>()
                .HasOne(userCompany => userCompany.Company)
                .WithOne(company => company.UserCompany)
                .HasForeignKey<Company>(company => company.Id);
        }

    }
}
