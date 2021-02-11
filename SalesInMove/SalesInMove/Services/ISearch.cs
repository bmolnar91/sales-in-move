using SalesInMove.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesInMove.Services
{
    public interface ISearch
    {
        List<Account> Search(Company company, Dictionary<string,bool> parameters);
    }
}
