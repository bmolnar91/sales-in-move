using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using SalesInMove.Models;

namespace SalesInMove.DatabaseRelated
{
    public class SQLCompanyRepositoryAsync : ICompanyRepository
    {
        private SalesmenDbContext _context;

        public SQLCompanyRepositoryAsync(SalesmenDbContext context)
        {
            _context = context;
        }

        public async Task AddEntityAsync(Company entity)
        {
            Company reference = GetCompanyByName(entity.Name);

            if (reference == null)
            {
                await _context.Companies.AddAsync(entity);
                Save();
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
            Save();
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
            Save();

        }

         private void Save()
        {
            _context.SaveChanges();
        }
    }
}