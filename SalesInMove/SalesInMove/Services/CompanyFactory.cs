using System.Collections;
using System;
using System.Collections.Generic;
using SalesInMove.Models;
using System.Linq;

namespace SalesInMove.Services
{
    public class CompanyFactory : AbstractUserFactory, ICompanyFactory
    {
        
        public Company CreateCompany
        (
            byte userType, string email, string password, string companyName,
            string contactFirstName, string contactLastName, string[] companyProfile, 
            string headquarter, long taxNumber, long registry, DateTime? yearOfFoundation, 
            int numberOfSalesman, string sector, long annualNettoIncome, bool salesSupport, 
            string[] employeeOpinions = null
        )
        {
            User companyUser = base.CreateUser(userType, email, password);

            Company newCompany = new Company {
                ContactFirstName = contactFirstName,
                ContactLastName = contactLastName,
                Name = companyName,
                CompanyProfile = companyProfile.ToList(),
                Headquarter = headquarter,
                TaxNumber = taxNumber,
                Registry = registry,
                YearOfFoundation = yearOfFoundation,
                NumberOfSalesman = numberOfSalesman,
                Sector = sector,
                AnnualNettoIncome = annualNettoIncome,
                EmployeeOpinions = (employeeOpinions != null) ? employeeOpinions.ToList() : new List<string>(),
                SalesSupport = salesSupport,
                User = companyUser
            };

            companyUser.Company = newCompany;

            return newCompany;
        }
    }
}