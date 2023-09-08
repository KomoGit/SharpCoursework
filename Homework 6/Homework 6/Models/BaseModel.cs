using System.ComponentModel.DataAnnotations;

namespace Homework_6.Models
{
    public class BaseModel
    {
        [Key]
        public Guid Id { get; set; }
    }
}
