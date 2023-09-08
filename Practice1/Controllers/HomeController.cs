using Microsoft.AspNetCore.Mvc;

namespace Practice1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
