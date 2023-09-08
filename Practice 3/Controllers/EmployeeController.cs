using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Practice_3.Data;
using Practice_3.Models;

namespace Practice_3.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly Pratctice3DbContext _context;
        public EmployeeController(Pratctice3DbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Employee> employees = _context.Employees.Include("Position").ToList();
            return View(employees);
        }

        public IActionResult Create()
        {
            List<SelectListItem> titleList = PositionsList();
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
        public IActionResult Create(Employee employee)
        {
            ModelState.Remove("Position");
            if (ModelState.IsValid)
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            List<SelectListItem> positionList = PositionsList();
            positionList.Insert(0, new SelectListItem
            {
                Value = "0",
                Text = "Select",
                Selected = true,
                Disabled = true
            });
            ViewBag.Groups = positionList;
            return View(employee);
        }

        public IActionResult Edit(int id)
        {
            var position = _context.Employees.Include("Position").FirstOrDefault(s => s.Id == id);
            if (position == null) return NotFound();
            List<SelectListItem> positionList = PositionsList();
            ViewBag.Groups = positionList;
            return View(position);
        }
        [HttpPost]
        public IActionResult Edit(Employee emp)
        {
            ModelState.Remove("Position");
            if (ModelState.IsValid)
            {
                _context.Entry(emp).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            List<SelectListItem> titleList = PositionsList();
            ViewBag.Groups = titleList;
            return View(emp);
        }
        public IActionResult Delete(int id)
        {
            Employee? employee = _context.Employees.Find(id);
            if (employee == null) return NotFound();
            _context.Employees.Remove(employee);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        private List<SelectListItem> PositionsList()
        {
            return _context.Positions.Select(
            g => new SelectListItem
            {
                Value = g.Id.ToString(),
                Text = g.Name
            }).ToList();
        }
    }
}
