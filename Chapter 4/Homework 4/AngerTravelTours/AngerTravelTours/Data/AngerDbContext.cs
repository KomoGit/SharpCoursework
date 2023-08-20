using AngerTravelTours.Models;
using Microsoft.EntityFrameworkCore;

namespace AngerTravelTours.Data
{
    public class AngerDbContext:DbContext
    {
        public AngerDbContext(DbContextOptions<AngerDbContext> options):base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ChooseUs> ChooseUs { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public Subscriber Subscriber { get; set; } //was a DbSet<> before
        public DbSet<TourPackage> TourPackages { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}
