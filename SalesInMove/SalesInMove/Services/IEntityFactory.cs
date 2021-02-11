using SalesInMove.Models;

namespace SalesInMove.Services
{
    public interface IEntityFactory<TEntity> where TEntity : class
    {
        TEntity CreateEntity(int userType, string emailAddress, string password, params object[] args);
    }
}