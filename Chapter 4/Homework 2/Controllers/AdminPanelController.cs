using Homework_2.Data;
using Homework_2.Models.Attorneys;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Homework_2.Controllers
{
    public class AdminPanelController : Controller
    {
        private readonly KanunDBContext _context;

        public AdminPanelController(KanunDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IQueryable<Lawyer> lawyers = _context.Lawyers.Include("Socials");
            return View(lawyers);
        }
    }
}
