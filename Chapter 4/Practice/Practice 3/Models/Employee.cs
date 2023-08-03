using System.ComponentModel.DataAnnotations;

namespace Practice_3.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name cannot be empty!")]
        [MaxLength(100, ErrorMessage = "Cannot be above 100")]
        public string Fullname { get; set; }
        [Required(ErrorMessage = "Cannot be empty!")]
        public int PositionId { get; set; }
        public Position Position { get; set; }
    }
}
