using Microsoft.AspNetCore.Mvc;

namespace Homework_2.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
