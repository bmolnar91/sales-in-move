using System.Text;
using System.ComponentModel;
using System.Globalization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesInMove.DatabaseRelated;
using SalesInMove.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace SalesInMove.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyRepository _repo;
        private readonly JsonSerializerOptions _jsonOptions;

        public CompanyController(ICompanyRepository repo)
        {
            _repo = repo;
            _jsonOptions = new JsonSerializerOptions {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.All)
            };
        }

        [HttpGet("getcompany/{name}")]
        public string Get(string name)
        {

            return JsonSerializer.Serialize(_repo.GetCompanyByName(name), _jsonOptions);
        }

    }
}