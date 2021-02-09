using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SalesInMove.Models;

namespace SalesInMove.DatabaseRelated
{
    public class SQLCompanyRepositoryAsync : IAsyncCompanyRepository, IDisposable
    {
        private bool disposedValue;
        private SalesmenDbContext _context;

        public SQLCompanyRepositoryAsync(SalesmenDbContext context)
        {
            _context = context;
        }

        public async void AddEntityAsync(Company entity)
        {
            Company reference = GetCompanyByNameAsync(entity.Name).Result;

            if (reference == null)
            {
                await _context.Companies.AddAsync(entity);
                SaveAsync();
            }
            else
            {
                throw new ArgumentException($"Company has already registered with this name: {reference.Name}");
            }
        }

        public async void DeleteCompanyByNameAsync(string companyName)
        {
            Company toDelete = await GetCompanyByNameAsync(companyName);
            _context.Companies.Remove(toDelete);
            SaveAsync();
        }

        public IEnumerable<Company> GetAllEntities()
        {
            return _context.Companies; 
        }

        public async Task<Company> GetCompanyByNameAsync(string companyName)
        {
            return await _context.Companies.FindAsync(companyName);
        }

        public void UpdateEntityAsync(Company entity)
        {
            var changedEntity = _context.Companies.Attach(entity);
            changedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            SaveAsync();

        }

         private async void SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
        

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

    }
}