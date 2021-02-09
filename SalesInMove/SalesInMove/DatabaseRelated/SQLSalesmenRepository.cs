using SalesInMove.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesInMove.DatabaseRelated
{
    public class SQLSalesmenRepository : ISalesmenRepository
    {
        // implements the interace's methods, where we can create and get users
        private readonly SalesmenDbContext _context;

        public SQLSalesmenRepository(SalesmenDbContext context)
        {
            _context = context;
        }
        public void AddAccount(Account account)
        {
            _context.Accounts.Add(account);
            _context.SaveChanges();
        }
        `
        public Account GetAccount(string email)
        {
            return _context.Accounts.Where(x => x.Email.Equals(email)).FirstOrDefault();
        }
    }
}
