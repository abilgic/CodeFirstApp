using Microsoft.EntityFrameworkCore;

namespace CodeFirstApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        DbSet<Job> Job { get; set; }
    }
}
