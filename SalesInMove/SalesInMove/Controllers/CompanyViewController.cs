using Microsoft.AspNetCore.Mvc;

namespace SalesInMove.Controllers
{
    [Route("company/[action]")]
    public class CompanyViewController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
        
        public IActionResult Profile()
        {
            return View();
        }
    }
}