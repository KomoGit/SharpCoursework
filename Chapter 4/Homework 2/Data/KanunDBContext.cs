using Homework_2.Models;
using Homework_2.Models.Home;
using Microsoft.EntityFrameworkCore;

namespace Homework_2.Data
{
    public class KanunDBContext:DbContext   
    {
        public KanunDBContext(DbContextOptions<KanunDBContext> options):base(options)
        {
            
        }

        public DbSet<Carousel> Carousels { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        
    }
}
