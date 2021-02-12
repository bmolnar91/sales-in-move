using System.Collections;
using System.Collections.Generic;
using SalesInMove.Models;

namespace SalesInMove.DatabaseRelated
{
    public interface IEmployeeSearchRepository
    {
         //IEnumerable<Employee> GetResults(string education, string city, string[] languages);
         
         IEnumerable<Employee> GetResults(string education, string city, string[] languages, bool hasDrivingLicence);
         
         string GetString(string[] languages);
    }
}