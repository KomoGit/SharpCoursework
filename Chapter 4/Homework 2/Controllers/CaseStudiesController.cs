using Microsoft.AspNetCore.Mvc;

namespace Homework_2.Controllers
{
    public class CaseStudiesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
