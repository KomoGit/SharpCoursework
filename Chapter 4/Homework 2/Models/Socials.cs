using System.ComponentModel.DataAnnotations;

namespace Homework_2.Models
{
    public class Socials
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Cannot be empty")][MaxLength(250,ErrorMessage = "Max Length is 250")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Cannot be empty")][MaxLength(250, ErrorMessage = "Max Length is 250")]
        public string Link { get; set; }
    }
}
