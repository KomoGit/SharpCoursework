using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Homework_2.Models.Home
{
    public class Carousel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Headers { get; set; }
        [Required]
        public string Bodies { get; set; }
        [NotMapped]
        public List<IFormFile> CarouselImages { get; set; }
    }
}
