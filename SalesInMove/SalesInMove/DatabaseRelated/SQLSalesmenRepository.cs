using SalesInMove.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesInMove.DatabaseRelated
{
    public class SQLSalesmenRepository : ISalesmenRepository
    {
        private readonly SalesmenDbContext _context;

        public SQLSalesmenRepository(SalesmenDbContext context)
        {
            _context = context;
        }
        public void AddAccount()
        {
            throw new NotImplementedException();
        }

        public Account GetAccount()
        {
            throw new NotImplementedException();
        }
    }
}
