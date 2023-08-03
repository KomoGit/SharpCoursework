using Homework_3.Models;
using Microsoft.EntityFrameworkCore;

namespace Homework_3.Data
{
    public class HomeworkDBContext : DbContext
    {
        public HomeworkDBContext(DbContextOptions<HomeworkDBContext> options) : base(options)
        {

        }

        public DbSet<Lawyer> Lawyers { get; set; }
        public DbSet<Speciality> Titles { get; set; }
    }
}
