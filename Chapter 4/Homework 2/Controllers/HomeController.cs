﻿using Microsoft.AspNetCore.Mvc;

namespace Homework_2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
