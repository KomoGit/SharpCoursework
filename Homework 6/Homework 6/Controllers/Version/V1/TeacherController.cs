using AutoMapper;
using Homework_6.Data;
using Homework_6.Models;
using Homework_6.Resources.Student;
using Homework_6.Resources.TeacherResource;
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
            return Ok(teachers);
        }
        [HttpPost]
        public IActionResult Create(CreateTeacherResource resource)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var mappingTeacher = _mapper.Map<CreateTeacherResource, Teacher>(resource);
            _context.Add(mappingTeacher);
            var teacherResource = _mapper.Map<Teacher, TeacherResource>(mappingTeacher);
            _context.SaveChanges();
            return Ok(teacherResource);
        }
        [HttpPut("{id}")]
        public IActionResult Update(Guid id, CreateTeacherResource resource)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var editTeacher = _context.Teachers.FirstOrDefault(s => s.Id == id);
            if (editTeacher == null) return NotFound();
            editTeacher.Name = resource.Name;
            editTeacher.SchoolId = resource.SchoolId;
            editTeacher.Subject = resource.Subject;
            _context.SaveChanges();
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var teacher = _context.Teachers.FirstOrDefault(s => s.Id == id);
            if (teacher == null) return NotFound();
            _context.Teachers.Remove(teacher);
            _context.SaveChanges();
            return Ok("Successfully deleted");
        }
    }
}
