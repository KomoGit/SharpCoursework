using Homework_2.Data;
using Homework_2.Models;
using Microsoft.AspNetCore.Mvc;


namespace Homework_2.Controllers
{
    public class ContactController : Controller
    {
        private readonly KanunDBContext _context;

        public ContactController(KanunDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var partialViewModel = new PartialViewResult();
            return View(partialViewModel);
        }
        [HttpGet]
        public IActionResult Create(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _context.Contacts.Add(contact);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            return View(contact);
        }
    }
}
