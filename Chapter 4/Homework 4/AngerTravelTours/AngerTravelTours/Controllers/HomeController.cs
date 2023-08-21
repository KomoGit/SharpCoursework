﻿using AngerTravelTours.Data;
using AngerTravelTours.Interfaces;
using AngerTravelTours.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AngerTravelTours.Controllers
{
    public class HomeController : Controller, INewsletterCreate
    {
        private readonly AngerDbContext _context;
        
        public HomeController(AngerDbContext context)
        {
            _context = context;
        }

        public IActionResult Create(VMBase sub)
        {
            if (ModelState.IsValid)
            {
                if (sub.Subscriber == null)
                {
                    throw new Exception("Subscriber cannot be null!");
                }
                sub.Subscriber.AddedDate = DateTime.Now;
                _context.Subscribes.Add(sub.Subscriber);
                _context.SaveChanges();
            }
            return RedirectToAction("index", "home");
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
    }
}