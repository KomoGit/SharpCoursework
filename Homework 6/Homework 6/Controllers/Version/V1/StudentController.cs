using AutoMapper;
using Homework_6.Data;
using Homework_6.Models;
using Homework_6.Resources;
using Homework_6.Resources.School;
using Homework_6.Resources.Student;
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
            return Ok(students);
        }
        [HttpPost]
        public IActionResult Create(CreateStudentResource resource)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var mappingStudent = _mapper.Map<CreateStudentResource, Student>(resource);
            _context.Add(mappingStudent);
            var studentResource = _mapper.Map<Student, StudentResource>(mappingStudent);
            _context.SaveChanges();
            return Ok(studentResource);
        }
        [HttpPut("{id}")]
        public IActionResult Update(Guid id, CreateStudentResource resource)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var editStudent = _context.Students.FirstOrDefault(s => s.Id == id);
            if (editStudent == null) return NotFound();
            editStudent.Name = resource.Name;
            editStudent.SchoolId = resource.SchoolId;
            editStudent.TeacherId = resource.TeacherId;
            _context.SaveChanges();
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var student = _context.Students.FirstOrDefault(s => s.Id == id);
            if (student == null) return NotFound();
            _context.Students.Remove(student);
            _context.SaveChanges();
            return Ok("Successfully deleted");
        }
    }
}
