using AutoMapper;
using Homework_6.Data;
using Homework_6.Models;
using Homework_6.Resources;
using Homework_6.Resources.School;
using Microsoft.AspNetCore.Mvc;

namespace Homework_6.Controllers.Version.V1
{
    [Route("api/v1/school")]
    [ApiController]
    public class SchoolController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDBContext _context;
        public SchoolController(ApplicationDBContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var students = _context.Students;
            return Ok(students);
        }
        [HttpPost]
        public IActionResult Create(CreateSchoolResource resource)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var mappingSchool = _mapper.Map<CreateSchoolResource, School>(resource);
            _context.Add(mappingSchool);
            var schoolResource = _mapper.Map<School, SchoolResource>(mappingSchool);
            _context.SaveChanges();
            return Ok(schoolResource);
        }
        [HttpPut("{id}")]
        public IActionResult Update(Guid id, CreateSchoolResource resource)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var editSchool = _context.Schools.FirstOrDefault(s => s.Id == id);
            if (editSchool == null) return NotFound();
            editSchool.Name = resource.Name;
            _context.SaveChanges();
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var school = _context.Schools.FirstOrDefault(s => s.Id == id);
            if (school == null) return NotFound();
            _context.Schools.Remove(school);
            _context.SaveChanges();
            return Ok("Successfully deleted");
        }
    }
}
