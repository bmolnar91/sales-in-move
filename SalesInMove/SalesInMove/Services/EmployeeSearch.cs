using System.Collections;
using System.Collections.Generic;
using SalesInMove.DatabaseRelated;
using SalesInMove.Models;
using SalesInMove.ViewModels;

namespace SalesInMove.Services
{
    public class EmployeeSearch : IEmployeeSearchService
    {
        private readonly IEmployeeSearchRepository _empSearchRepo;
        private readonly IEmployeeSearchVMFactory _employeeSearchVMFactory;

        public EmployeeSearch(IEmployeeSearchRepository searchRepository, IEmployeeSearchVMFactory employeeSearchVMFactory)
        {
            _empSearchRepo = searchRepository;
            _employeeSearchVMFactory = employeeSearchVMFactory;
        }
        public List<EmployeeSearchVM> GetEmployees(SearchFormVM searchForm)
        {

            searchForm.HasDrivingLicence = this.CheckDrivingLicence(searchForm.DrivingLicence);

            IEnumerable<Employee> employees = _empSearchRepo.GetResults(searchForm.Education, searchForm.City, searchForm.Languages, searchForm.HasDrivingLicence);
            
            return this.GetEmployeeSearchVMs(employees);
            
        }

        private List<EmployeeSearchVM> GetEmployeeSearchVMs(IEnumerable<Employee> employees)
        {
            List<EmployeeSearchVM> employeeSearchVMs = new List<EmployeeSearchVM>();

            foreach (Employee employee in employees)
            {
                employeeSearchVMs.Add(_employeeSearchVMFactory.CreateVM(employee.FirstName, employee.LastName, employee.Age, employee.ProfilePicture, employee.City, employee.Specialisation, employee.Education, employee.SalesTurnOver, employee.Languages));
            }

            return employeeSearchVMs;
        }

        public string GetString(SearchFormVM searchForm)
        {
            return _empSearchRepo.GetString(searchForm.Languages);
        }

        private bool CheckDrivingLicence(string licence)
        {
            if(licence == null)
            {
                return false;
            }
            else if(licence.Equals("van"))
            {
                return true;
            }

            return false;
        }

        public SearchResultVM GetEmployeeSearchResultVMs(IEnumerable<Employee> employees)
        {
            List<EmployeeSearchVM> employeeSearchVMs = this.GetEmployeeSearchVMs(employees);

            return new SearchResultVM
            {
                ResultNumber = employeeSearchVMs.Count,
                Results = employeeSearchVMs
            };
        }
    }
}