using System.ComponentModel.DataAnnotations;

namespace Homework_3.Models
{
    public class Lawyer
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name cannot be empty!")]
        [MaxLength(100,ErrorMessage = "Cannot be above 100")]
        public string Fullname { get; set; }
        [Required(ErrorMessage = "Cannot be empty!")]
        public int SpecialityId { get; set; }
        public Speciality Title { get; set; }
    }
}
