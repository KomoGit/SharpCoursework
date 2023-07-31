using Microsoft.AspNetCore.Mvc;

namespace Homework_2.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
