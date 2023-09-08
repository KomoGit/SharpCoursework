using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Homework_6.Models
{
    public class Student:BaseModel
    {
        [Required(ErrorMessage = "Cannot be empty.")]
        [MaxLength(100,ErrorMessage = "Cannot exceed 100")]
        [MinLength(3,ErrorMessage = "Cannot be less than 100")]
        public string? Fullname { get; set; }
        public Guid SchooldId { get; set; }
    }
}
