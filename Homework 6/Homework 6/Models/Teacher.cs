using System.ComponentModel.DataAnnotations;

namespace Homework_6.Models
{
    public class Teacher:BaseModel
    {
        [Required(ErrorMessage = "Cannot be empty.")]
        [MaxLength(100, ErrorMessage = "Cannot exceed 100")]
        [MinLength(6, ErrorMessage = "Cannot be less than 6")]
        public string? Subject { get; set; }
        [Required]
        public List<Student>? Students { get; set; }
        public Guid? SchoolId  { get; set; }


    }
}
