using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Register_And_Login.Models
{
    public class User:BaseModel
    {
        #region Authentication
        [Required]
        [MaxLength(100,ErrorMessage = "Cannot be more than 20")]
        [MinLength(5,ErrorMessage = "Cannot be less than 5")]
        public string? Username { get; set; }
        [Required]
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Token { get; set; }
        #endregion
        #region Descriptions
        public List<Post>? UserPosts { get; set; }
        [Required]
        [MaxLength(250, ErrorMessage = "Cannot be more than 250")]
        public string? ProfilePicture { get; set; }
        [Column(TypeName = "ntext")]
        [MaxLength(250,ErrorMessage = "Cannot be more than 250")]
        [MinLength(50,ErrorMessage = "Cannot be less than 50")]
        public string? Biography { get; set; }
        #endregion
    }
}
