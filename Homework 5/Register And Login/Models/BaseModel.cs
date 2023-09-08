using System.ComponentModel.DataAnnotations;

namespace Register_And_Login.Models
{
    public abstract class BaseModel
    {
        [Key]
        public int Id { get; set; }
    }
}
