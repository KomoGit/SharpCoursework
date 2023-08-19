using AngerTravelTours.Data;
using AngerTravelTours.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AngerTravelTours.Controllers
{
    public class NewsletterController : Controller
    {
        private readonly AngerDbContext _context;

        public NewsletterController(AngerDbContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        //SERIALIZATION ISSUE
        public IActionResult Create(Subscriber sub)
        {
            if (ModelState.IsValid)
            {
                sub.AddedDate = DateTime.Now;
                _context.Subscribes.Add(sub);
                _context.SaveChanges();
            }
            return RedirectToAction("index");
        }
    }
}
