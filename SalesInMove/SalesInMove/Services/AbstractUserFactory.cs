using SalesInMove.Models;

namespace SalesInMove.Services
{
    public abstract class AbstractUserFactory
    {
        private protected User CreateUser(int userType, string emailAddress, string password)
        {
            return new User
            {
                UserType = userType,
                Email = emailAddress,
                Password = password
            };
        }
    }
}