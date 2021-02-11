using SalesInMove.ViewModels;

namespace SalesInMove.Services
{
    public interface IEmployeeSearchVMFactory
    {
         EmployeeSearchVM CreateVM(string firstName, string lastName, int Age, string profilePicture, string city, string specialisation, string education, long salesTurnOver, string[] languages);
    }
}