using System;
using System.Collections.Generic;
using SalesInMove.Models;

namespace SalesInMove.Services
{
    public sealed class CompanyFactory : AbstractUserFactory, ICompanyFactory
    {
        
        public Company CreateCompany(int userType, string emailAddress, string password, string companyName, 
            string headquarter, long taxNumber, long registry, DateTime? yearOfFoundation, 
            int numberOfSalesman, string sector, long annualNettoIncome, List<string> employeeOpinions, 
            bool salesSupport, User user, ICollection<Position> positions)
        {
            User companyUser = base.CreateUser(userType, emailAddress, password);

            Company newCompany = new Company {
                Name = companyName,
                Headquarter = headquarter,
                TaxNumber = taxNumber,
                Registry = registry,
                YearOfFoundation = yearOfFoundation,
                NumberOfSalesman = numberOfSalesman,
                Sector = sector,
                AnnualNettoIncome = annualNettoIncome,
                EmployeeOpinions = employeeOpinions,
                SalesSupport = salesSupport,
                User = companyUser
            };

            companyUser.Company = newCompany;

            return newCompany;
        }
    }
}