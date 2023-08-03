using Homework_2.Data;
using Homework_2.Models.Attorneys;
using Microsoft.AspNetCore.Mvc;

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
            IQueryable<Lawyer> lawyers = _context.Lawyers;
            return View(lawyers);
        }
        [HttpGet]
        public IActionResult Create(Lawyer lawyer)
        {
            if (ModelState.IsValid)
            {
                _context.Lawyers.Add(lawyer);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            return View(lawyer);
        }
    }
}
