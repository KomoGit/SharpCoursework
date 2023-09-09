using System.ComponentModel.DataAnnotations;

namespace Homework_6.Models
{
    public class BaseModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Cannot be empty.")]
        [MaxLength(100, ErrorMessage = "Cannot exceed 100")]
        [MinLength(3, ErrorMessage = "Cannot be less than 100")]
        public string? Name { get; set; }
    }
}
