using SalesInMove.Models;
using System;
using System.Collections.Generic;

namespace SalesInMove.DatabaseRelated
{
    public class SQLAsyncUserRepository : IAsyncRepository<User>, IDisposable
    {
        private bool disposedValue;
        private SalesmenDbContext _context;

        public SQLAsyncUserRepository(SalesmenDbContext context)
        {
            _context = context;
        }

        public async void AddAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteByEmailAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public User GetByEmailAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public void SaveAsync()
        {
            throw new NotImplementedException();
        }

        public void UpdateAsync(User entity)
        {
            throw new NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~SQLAsyncUserRepository()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}