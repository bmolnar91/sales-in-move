using SalesInMove.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesInMove.DatabaseRelated
{
    public class SQLSalesmenRepository : ISalesmenRepository, IDisposable
    {
        // implements the interace's methods, where we can create and get users
        private bool disposedValue;
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

        public Account GetAccount(string email)
        {
            return _context.Accounts.Where(x => x.Email.Equals(email)).FirstOrDefault();
        }

        private async void SaveAsync()
        {
            await _context.SaveChangesAsync();
        }


        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
