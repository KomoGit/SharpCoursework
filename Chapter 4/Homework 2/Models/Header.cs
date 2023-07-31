using System.ComponentModel.DataAnnotations;

namespace Homework_2.Models
{
    public class Header
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250, ErrorMessage = "Input too long. Max 250 symbols.")]
        public string Twitter { get; set; }
        [MaxLength(250, ErrorMessage = "Input too long. Max 250 symbols.")]
        public string Facebook { get; set; }
        [MaxLength(250, ErrorMessage = "Input too long. Max 250 symbols.")]
        public string LinkedIn { get; set; }
        [MaxLength(250, ErrorMessage = "Input too long. Max 250 symbols.")]
        public string Instagram { get; set; }
        [MaxLength(250, ErrorMessage = "Input too long. Max 250 symbols.")]
        public string Phone { get; set; }
        [MaxLength(250, ErrorMessage = "Input too long. Max 250 symbols.")]
        public string OpeningHours { get;set; }
    }
}
