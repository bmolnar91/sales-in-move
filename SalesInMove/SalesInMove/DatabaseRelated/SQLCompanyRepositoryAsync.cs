using System;
using System.Collections.Generic;
using SalesInMove.Models;

namespace SalesInMove.DatabaseRelated
{
    public class SQLCompanyRepositoryAsync : IAsyncCompanyRepository, IDisposable
    {
        private bool disposedValue;

        public void AddEntityAsync(Company entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteCompanyByNameAsync(string companyName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Company> GetAllEntitiesAsync()
        {
            throw new NotImplementedException();
        }

        public Company GetCompanyByNameAsync(string companyName)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntityAsync(Company entity)
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
        // ~SQLCompanyRepositoryAsync()
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