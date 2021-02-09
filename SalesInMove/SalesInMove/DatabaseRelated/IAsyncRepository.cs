using System.Collections.Generic;
using System;

namespace SalesInMove.DatabaseRelated
{
    public interface IAsyncRepository<TEntity> : IDisposable
    {
         public void AddAsync(TEntity entity);
         public void UpdateAsync(TEntity entity);
         public IEnumerable<TEntity> GetAllAsync(TEntity entity);
         public TEntity GetByEmailAsync(TEntity entity);
         public void DeleteByEmailAsync(TEntity entity);
         public void SaveAsync();
    }
}