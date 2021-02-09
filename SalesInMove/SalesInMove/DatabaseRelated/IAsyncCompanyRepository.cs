using System.Collections.Generic;
using System.Threading.Tasks;
using SalesInMove.Models;

namespace SalesInMove.DatabaseRelated
{
    public interface IAsyncCompanyRepository : IAsyncRepository<Company>
    {
        Task<Company> GetCompanyByNameAsync(string companyName);
        void DeleteCompanyByNameAsync(string companyName);        
    }
}