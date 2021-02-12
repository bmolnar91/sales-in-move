using System.Text.RegularExpressions;
using System.Collections.Generic;
using SalesInMove.Models;
using System.Linq;

namespace SalesInMove.DatabaseRelated
{
    public class SQLEmployeeSearchRepository : IEmployeeSearchRepository
    {
        private readonly SalesmenDbContext _context;

        public SQLEmployeeSearchRepository(SalesmenDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Employee> GetResults(string education, string city, string[] languages, bool hasDrivingLicence)
        {
            
            IEnumerable<Employee> firstRoundEmps = from employee in _context.Accounts
                                                where employee.Education == education &&
                                                employee.City == city
                                                select employee;
            
            if(hasDrivingLicence == true)
            {
                return from employee in firstRoundEmps
                        where employee.DrivingLicence == true
                        select employee;
            }
            else
            {
                return firstRoundEmps;
            }

            

        }

        // public IEnumerable<Employee> GetResults(string education, string city, string[] languages)
        // {
        //     string stringLanguages = languages.Aggregate((current, next) => current + next);
        //     string formattedLanguages = Regex.Replace(stringLanguages, @"[, ]", "");
            
        //     IEnumerable<Employee> firstRoundEmps = from employee in _context.Accounts
        //                                         where employee.Education == education &&
        //                                         employee.City == city
        //                                         select employee;
            
        //     return from employee in firstRoundEmps
        //             where employee.Languages.Aggregate((current, next) => current + next)
        //             .Contains(formattedLanguages)
        //             select employee;
        // }

        public string GetString(string[] languages)
        {
            IEnumerable<Employee> emp = from empe in _context.Accounts
                            where empe.User.Email == "marjoiretierney@gmail.com"
                            select empe;
            string stringLanguages = languages.Aggregate((current, next) => current + next);
            string formattedLanguages = Regex.Replace(stringLanguages, @"[, ]", "");
            return formattedLanguages;
        }
    }
}