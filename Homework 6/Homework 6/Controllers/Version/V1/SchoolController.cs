using AutoMapper;
using Homework_6.Data;
using Homework_6.Models;
using Homework_6.Resources;
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
            if (students == null)
            {
                return NotFound();
            }
            return Ok(students);
        }
        [HttpPost]
        public IActionResult Create(SchoolResource resource)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var mappingSchool = _mapper.Map<SchoolResource, School>(resource);
            _context.Add(mappingSchool);
            var schoolResource = _mapper.Map<School, SchoolResource>(mappingSchool);
            _context.SaveChanges();
            return Ok(schoolResource);
        }
    }
}
