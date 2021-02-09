using System;
using System.Collections.Generic;
using SalesInMove.Models;

namespace SalesInMove.Services
{
    public interface ICompanyFactory
    {
        Company CreateCompany(int userType, string emailAddress, string password, string companyName, 
            string headquarter, long taxNumber, long registry, 
            DateTime? yearOfFoundation, int numberOfSalesman, string sector, long annualNettoIncome,
            List<string> employeeOpinions, bool salesSupport, User user, ICollection<Position> positions);
    }
}