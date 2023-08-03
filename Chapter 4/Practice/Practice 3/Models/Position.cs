using System.ComponentModel.DataAnnotations;

namespace Practice_3.Models
{
    public class Position
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name cannot be empty!")]
        [MaxLength(100, ErrorMessage = "Cannot be above 100")]
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
