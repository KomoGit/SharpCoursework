using AngerTravelTours.Data;
using AngerTravelTours.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AngerTravelTours.Controllers
{    
    public class BlogDetailController : Controller
    {
        private readonly AngerDbContext _context;
        public BlogDetailController(AngerDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VMHome model = new()
            {
                Feedbacks = _context.Feedbacks.ToList(),
                Galleries = _context.Galleries.ToList(),
                Partners = _context.Partners.ToList(),
                RecentPosts = _context.Blogs.ToList(),
            };
            return View(model);
        }
    }
}
