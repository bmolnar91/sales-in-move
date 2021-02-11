using SalesInMove.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesInMove.DatabaseRelated
{
    public interface ISalesmenRepository
    {
        //interface which sqlslaesmenrepository to implement the methods
        Employee GetAccount(string email);
        void AddAccount(Employee account);
    }
}
