using System.Collections.Generic;
using System;

namespace SalesInMove.DatabaseRelated
{
    public interface IAsyncRepository<TEntity> : IDisposable
    {
         void AddAsync(TEntity entity);
         void UpdateAsync(TEntity entity);
         IEnumerable<TEntity> GetAllAsync(TEntity entity);
         TEntity GetByEmailAsync(TEntity entity);
         void DeleteByEmailAsync(TEntity entity);
         void SaveAsync();
    }
}