using System.ComponentModel.DataAnnotations;

namespace Register_And_Login.Models
{
    public class Post:BaseModel
    {
        public int UserId { get; set; }
        [Required(ErrorMessage = "Cannot be empty!")]
        [MaxLength(100,ErrorMessage ="Cannot be more than 100")]
        public string? Title { get; set; }
        [MaxLength(280, ErrorMessage = "Cannot be more than 280")]
        public string? Content { get; set; }
        public DateTime PublishDate { get; set; }
        public User? User { get; set; }
    }
}
