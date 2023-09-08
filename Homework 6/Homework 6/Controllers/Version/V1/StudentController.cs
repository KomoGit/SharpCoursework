using AutoMapper;
using Homework_6.Data;
using Homework_6.Models;
using Homework_6.Resources;
using Microsoft.AspNetCore.Mvc;

namespace Homework_6.Controllers.Version.V1
{
    [Route("api/v1/student")]
    [ApiController]
    public class StudentController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDBContext _context;
        public StudentController(ApplicationDBContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var students  = _context.Students;
            if(students == null)
            {
                return NotFound();
            }
            return Ok(students);
        }
        [HttpPost]
        public IActionResult Create(StudentResource resource)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var mappingStudent = _mapper.Map<StudentResource, Student>(resource);
            _context.Add(mappingStudent);
            var studentResource = _mapper.Map<Student, StudentResource>(mappingStudent);
            _context.SaveChanges();
            return Ok(studentResource);
        }
    }
}
