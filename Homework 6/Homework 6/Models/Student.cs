using System.ComponentModel.DataAnnotations;

namespace Homework_6.Models
{
    public class Student:BaseModel
    {
        public Guid? SchoolId { get; set; }
        public Guid? TeacherId { get; set; }
    }
}
