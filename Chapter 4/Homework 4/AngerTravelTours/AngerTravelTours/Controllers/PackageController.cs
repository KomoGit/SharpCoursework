using AngerTravelTours.Data;
using AngerTravelTours.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AngerTravelTours.Controllers
{
    public class PackageController : Controller
    {
        private readonly AngerDbContext _context;
        public PackageController(AngerDbContext context)
        {
            _context=context;
        }

        public IActionResult Index()
        {
            VMPackage package = new()
            {
                RecentPosts = _context.Blogs.OrderBy(o => o.AddedDate).Take(3).ToList(),
                Packages = _context.TourPackages.ToList(),
                Feedbacks = _context.Feedbacks.ToList(),
                Partners = _context.Partners.ToList(),
            };
            return View(package);
        }
    }
}
