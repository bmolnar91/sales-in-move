using Microsoft.AspNetCore.Mvc;
using SalesInMove.DatabaseRelated;
using SalesInMove.Models;

namespace SalesInMove.Controllers
{
    [Route("company/[action]")]
    public class CompanyViewController : Controller
    {
        private readonly ICompanyRepository _companyRepo;

        public CompanyViewController(ICompanyRepository companyRepo)
        {
            _companyRepo = companyRepo;
        }

        public IActionResult Register()
        {
            return View();
        }
        
        public IActionResult Profile(string companyName)
        {
            Company company = _companyRepo.GetCompanyByName(companyName);
            
            return View(company);
        }
    }
}