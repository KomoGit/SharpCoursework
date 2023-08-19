﻿using AngerTravelTours.Data;
using AngerTravelTours.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;

namespace AngerTravelTours.Controllers
{
    public class GalleryController : Controller
    {
        private readonly AngerDbContext _context;
        public GalleryController(AngerDbContext context)
        {
            _context=context;
        }

        public IActionResult Index()
        {
            VMGallery gallery = new()
            {
                Feedbacks=_context.Feedbacks.ToList(),
                Galleries=_context.Galleries.ToList(),
                Partners=_context.Partners.ToList(),
                RecentPosts = _context.Blogs.OrderBy(o=>o.AddedDate).Take(3).ToList(),
            };
            return View(gallery);
        }
    }
}
