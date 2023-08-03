using Homework_3.Data;
using Homework_3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Homework_3.Controllers
{
    public class LawyerController : Controller
    {
        private readonly HomeworkDBContext _context;

        public LawyerController(HomeworkDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Lawyer> lawyers = _context.Lawyers.Include("Title").ToList();
            return View(lawyers);
        }
        [HttpGet]
        public IActionResult Create()
        {
            List<SelectListItem> titleList = TitleLists();
            titleList.Insert(0, new SelectListItem
            {
                Value = "0",
                Text = "Select",
                Selected = true,
                Disabled = true
            });
            ViewBag.Groups = titleList;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Lawyer law)
        {
            ModelState.Remove("Title");
            if (ModelState.IsValid)
            {
                _context.Lawyers.Add(law);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            List<SelectListItem> titleList = TitleLists();
            titleList.Insert(0, new SelectListItem
            {
                Value = "0",
                Text = "Select",
                Selected = true,
                Disabled = true
            });
            ViewBag.Groups = titleList;
            return View(law);
        }
        public IActionResult Edit(int id)
        {
            var title = _context.Lawyers.Include("Title").FirstOrDefault(s => s.Id == id);
            if (title == null) return NotFound();
            List<SelectListItem> titleList = TitleLists();
            ViewBag.Groups = titleList;
            return View(title);
        }
        [HttpPost]
        public IActionResult Edit(Lawyer student)
        {
            ModelState.Remove("Title");
            if (ModelState.IsValid)
            {
                _context.Entry(student).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            List<SelectListItem> titleList = TitleLists();
            ViewBag.Groups = titleList;
            return View(student);
        }
        public IActionResult Delete(int id)
        {
            Lawyer? lawyer = _context.Lawyers.Find(id);
            if (lawyer == null) return NotFound();
            _context.Lawyers.Remove(lawyer);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        private List<SelectListItem> TitleLists()
        {
            return _context.Titles.Select(
            g => new SelectListItem
            {
                Value = g.Id.ToString(),
                Text = g.Name
            }).ToList();
        }
    }
}
