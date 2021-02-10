using SalesInMove.Models;

namespace SalesInMove.Services
{
    public interface IUserFactory
    {
         User CreateUser(int userType, string emailAddress, string password);
    }
}