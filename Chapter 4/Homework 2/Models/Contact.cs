using System.ComponentModel.DataAnnotations;

namespace Homework_2.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250, ErrorMessage = "Input too long. Max 250 symbols.")]
        public string Address  { get; set; }
        [MaxLength(250, ErrorMessage = "Input too long. Max 250 symbols.")]
        public string Phone { get; set; }
        [MaxLength(250, ErrorMessage = "Input too long. Max 250 symbols.")]
        public string EmailAddress { get; set; }
    }
}
