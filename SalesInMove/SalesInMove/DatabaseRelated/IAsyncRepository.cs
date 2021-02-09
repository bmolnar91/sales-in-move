using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalesInMove.DatabaseRelated
{
    public interface IAsyncRepository <TEntity> where TEntity : class
    {
        void AddEntityAsync(TEntity entity);
        IEnumerable<TEntity> GetAllEntities();
        void UpdateEntityAsync(TEntity entity);
    }
}