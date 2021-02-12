using System.Collections;
using System.Collections.Generic;
using SalesInMove.Models;

namespace SalesInMove.DatabaseRelated
{
    public interface IEmployeeSearchRepository
    {
         IEnumerable<Employee> GetResults(string education, string city, string[] languages);
         string GetString(string[] languages);
    }
}