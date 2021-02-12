using System.Collections.Generic;
using SalesInMove.Models;
using SalesInMove.ViewModels;

namespace SalesInMove.Services
{
    public interface IEmployeeSearchService
    {
         List<EmployeeSearchVM> GetEmployees(SearchFormVM searchForm);
         string GetString(SearchFormVM searchForm);

         SearchResultVM GetEmployeeSearchResultVMs(IEnumerable<Employee> employees);
    }
}