namespace SalesInMove.DatabaseRelated
{
    public interface IAsyncRepository<TEntity>
    {
         public TEntity AddAsync(TEntity entity);
         public TEntity UpdateAsync(TEntity entity);
         public TEntity GetAllAsync(TEntity entity);
         public TEntity GetByEmailAsync(TEntity entity);
         public TEntity DeleteByEmailAsync(TEntity entity);
    }
}