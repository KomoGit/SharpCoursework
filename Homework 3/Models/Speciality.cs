using System.ComponentModel.DataAnnotations;

namespace Homework_3.Models
{
    public class Speciality
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name cannot be empty!")]
        [MaxLength(100, ErrorMessage = "Cannot be above 100")]
        public string Name { get; set; }
        public List<Lawyer> Lawyers { get; set; }
    }
}