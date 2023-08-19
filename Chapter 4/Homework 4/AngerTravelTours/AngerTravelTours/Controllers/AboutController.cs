using AngerTravelTours.Data;
using AngerTravelTours.Models;
using AngerTravelTours.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AngerTravelTours.Controllers
{
    public class AboutController : Controller
    {
        private readonly AngerDbContext _context;

        public AboutController(AngerDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VMAbout model = new()
            {
                Feedbacks = _context.Feedbacks.ToList(),
                Partners = _context.Partners.ToList(),
                RecentPosts = _context.Blogs.OrderBy(o=>o.AddedDate).Take(3).ToList(),
            };
            return View(model);
        }
    }
}
