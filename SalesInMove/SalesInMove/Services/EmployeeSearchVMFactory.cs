using SalesInMove.ViewModels;

namespace SalesInMove.Services
{
    public class EmployeeSearchVMFactory : IEmployeeSearchVMFactory
    {
        public EmployeeSearchVM CreateVM(string firstName, string lastName, int age, string profilePicture, string city, string specialisation, string education, long salesTurnOver, string[] languages)
        {
            return new EmployeeSearchVM
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                City = city,
                Specialisation = specialisation,
                Education = education,
                SalesTurnOver = salesTurnOver,
                Languages = languages  
            };
        }
    }
}