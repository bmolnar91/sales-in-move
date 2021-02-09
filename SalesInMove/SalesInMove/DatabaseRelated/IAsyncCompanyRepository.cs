using System.Collections.Generic;
using SalesInMove.Models;

namespace SalesInMove.DatabaseRelated
{
    public interface IAsyncCompanyRepository : IAsyncRepository<Company>
    {
        Company GetCompanyByNameAsync(string companyName);
        void DeleteCompanyByNameAsync(string companyName);        
    }
}