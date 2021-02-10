using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using SalesInMove.Models;

namespace SalesInMove.DatabaseRelated
{
    public class SQLCompanyRepositoryAsync : ICompanyRepository, IDisposable
    {
        private bool disposedValue;
        private SalesmenDbContext _context;

        public SQLCompanyRepositoryAsync(SalesmenDbContext context)
        {
            _context = context;
        }

        public async Task<Company> AddEntityAsync(Company entity)
        {
            Company reference = GetCompanyByName(entity.Name);

            if (reference == null)
            {
                await _context.Companies.AddAsync(entity);
                SaveAsync();
                return entity;
            }
            else
            {
                throw new ArgumentException($"Company has already registered with this name: {reference.Name}");
            }
        }

        public void DeleteCompanyByName(string companyName)
        {
            Company toDelete = GetCompanyByName(companyName);
            _context.Companies.Remove(toDelete);
            SaveAsync();
        }

        public IEnumerable<Company> GetAllEntities()
        {
            return _context.Companies; 
        }

        public Company GetCompanyByName(string companyName)
        {
            var company = from c in GetAllEntities()
                            where c.Name.Equals(companyName)
                            select c;
            
            return company.FirstOrDefault<Company>();
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