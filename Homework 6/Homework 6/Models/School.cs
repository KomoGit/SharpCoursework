using System.ComponentModel.DataAnnotations;

namespace Homework_6.Models
{
    public class School:BaseModel
    {
        [Required]
        [MaxLength(150,ErrorMessage = "Cannot exceed 150")]
        [MinLength(10, ErrorMessage = "Cannot be less than 10")]
        public string? SchoolName { get; set; }
        public List<Student>? AttendingStudents { get; set; }
        public List<Teacher>? AttendingTeachers { get; set; }
    }
}
