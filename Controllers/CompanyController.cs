using Application1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Application1.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {

            var companies = new List<CompanyDetailsDto>
            {
                 
            
            };

            return View(companies);
            
        }
    }
}
