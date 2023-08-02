using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Homework_2.Models.Attorneys
{
    public class Lawyer
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Cannot be empty")][MaxLength(250,ErrorMessage = "Cannot be above 250 symbols")]
        public string Fullname { get; set; }
        public string Title { get; set; }
        [Required(ErrorMessage = "All socials are mandatory")]
        public List<Socials> Socials { get; set; }
        [Required(ErrorMessage = "Image is mandatory")][NotMapped]
        public IFormFile Image { get; set; }
    }
}
