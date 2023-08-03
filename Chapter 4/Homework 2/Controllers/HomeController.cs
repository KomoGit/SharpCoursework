using Homework_2.Data;
using Homework_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Homework_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly KanunDBContext _context;
        public HomeController(KanunDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IQueryable<Contact> contacts = _context.Contacts;
            return View(contacts);
        }
    }
}
