namespace SalesInMove.Services
{
    public class EmployeeFactory : UserFactory, IEntityFactory<Account>
    {
        public Account CreateEntity(int userType, string emailAddress, string password, params object[] args)
        {
            throw new System.NotImplementedException();
        }
    }
}