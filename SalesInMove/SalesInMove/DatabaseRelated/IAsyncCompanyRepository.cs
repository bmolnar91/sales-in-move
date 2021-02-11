using System.Collections.Generic;
using System.Threading.Tasks;
using SalesInMove.Models;

namespace SalesInMove.DatabaseRelated
{
    public interface ICompanyRepository : IAsyncRepository<Company>
    {
        Company GetCompanyByName(string companyName);
        void DeleteCompanyByName(string companyName);        
    }
}