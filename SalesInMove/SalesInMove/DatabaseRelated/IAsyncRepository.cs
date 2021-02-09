using System.Collections.Generic;

namespace SalesInMove.DatabaseRelated
{
    public interface IAsyncRepository <TEntity> where TEntity : class
    {
        void AddEntityAsync(TEntity entity);
        IEnumerable<TEntity> GetAllEntitiesAsync();
        void UpdateEntityAsync(TEntity entity);
        void SaveAsync();
    }
}