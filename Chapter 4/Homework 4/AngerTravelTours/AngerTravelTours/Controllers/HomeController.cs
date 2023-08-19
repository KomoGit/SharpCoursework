using AngerTravelTours.Data;
using AngerTravelTours.Models;
using AngerTravelTours.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AngerTravelTours.Controllers
{
    public class HomeController : Controller
    {
        private readonly AngerDbContext _context;
        
        public HomeController(AngerDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            VMHome home = new()
            {
                Feedbacks = _context.Feedbacks.ToList(),
                Galleries = _context.Galleries.ToList(),
                Partners = _context.Partners.ToList(),
                Packages = _context.TourPackages.ToList(),
                RecentPosts = _context.Blogs.OrderByDescending(o => o.AddedDate).Take(3).ToList()
            };
            return View(home);
        }

        [HttpPost]
        public IActionResult Create(string mail)
        {
            Console.WriteLine(mail);
            Subscriber sub = new()
            {
                Email = mail,
                AddedDate = DateTime.Now
            };
            if (ModelState.IsValid)
            {
                _context.Subscribes.Add(sub);
                _context.SaveChanges();
            }
            return RedirectToAction("index");
        }
    }
}
