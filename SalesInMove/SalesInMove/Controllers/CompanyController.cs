using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesInMove.DatabaseRelated;
using SalesInMove.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

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
        public string Get(string name)
        {
            return JsonSerializer.Serialize(_repo.GetCompanyByName(name));
        }

    }
}