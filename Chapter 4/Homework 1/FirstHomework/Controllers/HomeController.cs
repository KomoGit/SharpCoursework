using Microsoft.AspNetCore.Mvc;

namespace FirstHomework.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
