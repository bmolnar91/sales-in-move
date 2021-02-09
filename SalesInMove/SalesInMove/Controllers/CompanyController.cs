using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesInMove.DatabaseRelated;
using SalesInMove.Models;

namespace SalesInMove.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly IAsyncCompanyRepository _repo;

        public CompanyController(IAsyncCompanyRepository repo)
        {
            _repo = repo;
        }

        [HttpGet("getcompany/{name}")]
        public Company Get(string name)
        {
            return _repo.GetCompanyByName(name);
        }

    }
}