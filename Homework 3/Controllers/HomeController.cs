using Microsoft.AspNetCore.Mvc;

namespace Homework_3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
