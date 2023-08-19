using AngerTravelTours.Data;
using AngerTravelTours.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AngerTravelTours.Controllers
{
    public class ContactController : Controller
    {
        private readonly AngerDbContext _context;

        public ContactController(AngerDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            VMContact contact = new()
            {
                Feedbacks = _context.Feedbacks.ToList(),
                Contacts = _context.Contacts.ToList(),
                Partners = _context.Partners.ToList(),
                RecentPosts = _context.Blogs.OrderBy(o => o.AddedDate).Take(3).ToList()
            };
            return View(contact);
        }
    }
}
