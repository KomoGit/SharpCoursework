using AngerTravelTours.Data;
using AngerTravelTours.Models;
using AngerTravelTours.ViewModel;
using Microsoft.AspNetCore.Mvc;

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
            //Subscriber sub = new();
            //VMHome home = new()
            //{
            //    Feedbacks = _context.Feedbacks.ToList(),
            //    Galleries = _context.Galleries.ToList(),
            //    Partners = _context.Partners.ToList(),
            //    Packages = _context.TourPackages.ToList(),
            //    Subscriber = _context.Subscriber,
            //    RecentPosts = _context.Blogs.OrderByDescending(o => o.AddedDate).Take(3).ToList()
            //};
            return View();
        }
        //SERIALIZATION ISSUE but how?!
        [HttpPost]       
        public IActionResult Create(Subscriber sub) //public IActionResult Create(Subscriber sub)
        {
            //Console.WriteLine(email);
            //Subscriber sub = new()
            //{
            //    Email = email,
            //    AddedDate = DateTime.Now,
            //};
            if (ModelState.IsValid)
            {
                //sub.AddedDate = DateTime.Now;
                _context.Subscriber = sub;
                _context.SaveChanges();
            }
            return RedirectToAction("index");//"home"
        }
    }
}
