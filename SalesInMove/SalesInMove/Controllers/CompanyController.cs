using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesInMove.DatabaseRelated;
using SalesInMove.Models;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using SalesInMove.Services;
using System;
using SalesInMove.ViewModels;

namespace SalesInMove.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyRepository _repo;
        private readonly JsonSerializerOptions _jsonOptions;
        private readonly ICompanyFactory _companyFactory;

        public CompanyController(ICompanyRepository repo, ICompanyFactory companyFactory)
        {
            _repo = repo;
            _jsonOptions = new JsonSerializerOptions {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.All)
            };
            _companyFactory = companyFactory;
        }

        [HttpGet("{name}")]
        public string Get(string name)
        {
            return System.Text.Json.JsonSerializer.Serialize(_repo.GetCompanyByName(name), _jsonOptions);
        }

        [HttpPost]
        public async Task CreateAsync([FromBody]CompanyRegistrationVM jsonDatas)
        {
            DateTime yearOfFoundationDate = DateTime.Parse(jsonDatas.YearOfFoundation);
            
            Company newCompany = _companyFactory.CreateCompany
            (
                jsonDatas.UserType, jsonDatas.Email, jsonDatas.Password, jsonDatas.CompanyName,
                jsonDatas.CompanyProfile, jsonDatas.Headquarter, jsonDatas.TaxNumber, jsonDatas.Registry,
                yearOfFoundationDate, jsonDatas.NumberOfSalesman, jsonDatas.Sector, jsonDatas.AnnualNettoIncome,
                jsonDatas.SalesSupport, jsonDatas.EmployeeOpinions
            );

            await _repo.AddEntityAsync(newCompany);
        }

    }
}