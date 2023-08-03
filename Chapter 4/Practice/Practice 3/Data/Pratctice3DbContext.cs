using Microsoft.EntityFrameworkCore;
using Practice_3.Models;

namespace Practice_3.Data
{
    public class Pratctice3DbContext:DbContext
    {
        public Pratctice3DbContext(DbContextOptions<Pratctice3DbContext> options) :base(options)
        {
                
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
    }
}
