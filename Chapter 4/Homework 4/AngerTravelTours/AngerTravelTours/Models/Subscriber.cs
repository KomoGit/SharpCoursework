using System.ComponentModel.DataAnnotations;

namespace AngerTravelTours.Models
{
    public class Subscriber:BaseEntities
    {
        [EmailAddress(ErrorMessage = "Email is not valid")]
        public string? Email { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
