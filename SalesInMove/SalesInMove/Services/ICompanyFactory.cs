using System;
using System.Collections.Generic;
using SalesInMove.Models;

namespace SalesInMove.Services
{
    public interface ICompanyFactory : IUserFactory
    {
        Company CreateCompany(string name, string headquarter, long taxNumber, long registry, 
            DateTime? yearOfFoundation, int numberOfSalesman, string sector, long annualNettoIncome,
            string[] employeeOpinions, bool salesSupport, User user, ICollection<Position> positions);
    }
}