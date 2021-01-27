using SalesInMove.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesInMove.DatabaseRelated
{
    public interface ISalesmenRepository
    {
        Account GetAccount();
        void AddAccount();
    }
}
