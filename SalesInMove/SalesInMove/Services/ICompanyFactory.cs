using System;
using System.Collections.Generic;
using SalesInMove.Models;

namespace SalesInMove.Services
{
    public interface ICompanyFactory
    {
        Company CreateCompany(byte userType, string email, string password, string companyName, 
            string[] companyProfile, string headquarter, long taxNumber, long registry, DateTime? yearOfFoundation, 
            int numberOfSalesman, string sector, long annualNettoIncome, bool salesSupport, 
            string[] employeeOpinions = null);
    }
}