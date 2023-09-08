using AutoMapper;
using Homework_6.Data;
using Homework_6.Models;
using Homework_6.Resources;
using Microsoft.AspNetCore.Mvc;

namespace Homework_6.Controllers.Version.V1
{
    [Route("api/v1/teacher")]
    [ApiController]
    public class TeacherController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDBContext _context;
        public TeacherController(ApplicationDBContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var teachers = _context.Teachers;
            if (teachers == null)
            {
                return NotFound();
            }
            return Ok(teachers);
        }
        [HttpPost]
        public IActionResult Create(TeacherResource resource)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var mappingTeacher = _mapper.Map<TeacherResource, Teacher>(resource);
            _context.Add(mappingTeacher);
            var teacherResource = _mapper.Map<Teacher, TeacherResource>(mappingTeacher);
            _context.SaveChanges();
            return Ok(teacherResource);
        }
    }
}
