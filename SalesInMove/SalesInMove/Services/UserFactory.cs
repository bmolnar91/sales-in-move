using SalesInMove.Models;

namespace SalesInMove.Services
{
    public class UserFactory : IUserFactory
    {
        public User CreateUser(int userType, string emailAddress, string password)
        {
            return new User {
                UserType = userType,
                Email = emailAddress,
                Password = password
            };
        }
    }
}