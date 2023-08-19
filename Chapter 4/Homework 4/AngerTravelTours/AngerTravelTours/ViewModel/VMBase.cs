using AngerTravelTours.Models;

namespace AngerTravelTours.ViewModel
{
    public abstract class VMBase
    {
        public List<Blog>? RecentPosts { get; set; }
        public List<Partner>? Partners { get; set; }
        public List<Feedback>? Feedbacks { get; set; }
        public Subscriber? Subscriber { get; set; } //turn it into list maybe?
        public List<Social>? Socials { get; set; }
    }
}
