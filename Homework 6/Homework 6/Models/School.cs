using System.ComponentModel.DataAnnotations;

namespace Homework_6.Models
{
    public class School:BaseModel
    {
        public List<Student>? AttendingStudents { get; set; }
        public List<Teacher>? AttendingTeachers { get; set; }
    }
}
