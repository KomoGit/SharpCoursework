using System.ComponentModel.DataAnnotations;

namespace Register_And_Login.ViewModel
{
    public class RegisterViewModel
    {
        [Required]
        [MaxLength(100, ErrorMessage = "Cannot be more than 100")]
        [MinLength(5, ErrorMessage = "Cannot be less than 5")]
        public string? Username { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Cannot be more than 100")]
        [MinLength(5, ErrorMessage = "Cannot be less than 5")]
        [EmailAddress(ErrorMessage = "Incorrect format for email address.")]
        public string? Email { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Cannot be more than 100")]
        [MinLength(10,ErrorMessage = "Cannot be less than 10")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Cannot be more than 100")]
        [MinLength(10, ErrorMessage = "Cannot be less than 10")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage = "Password and password confirm do not match.")]
        public string? PasswordConfirm { get; set; }
    }
}
