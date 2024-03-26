using Microsoft.EntityFrameworkCore;

namespace Demo.DAL
{
    public class DemoContext : DbContext
    {
        public DbSet<Entities.Task> Tasks { get; set; }
        public DbSet<Entities.User> Users { get; set; }

        public DemoContext(DbContextOptions options): base(options) 
        {
                
        } 
    }
}
