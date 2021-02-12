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
        public void AddAccount(Employee account)
        {
            _context.Accounts.Add(account);
            _context.SaveChanges();
        }

        public Employee GetAccount(string email)
        {
            return _context.Accounts.Where(x => x.User.Email.Equals(email)).FirstOrDefault();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _context.Accounts;
        }

        private void Save()
        {
            _context.SaveChanges();
        }
    }
}
