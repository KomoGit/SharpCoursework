using Microsoft.AspNetCore.Mvc;

namespace Homework_2.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
