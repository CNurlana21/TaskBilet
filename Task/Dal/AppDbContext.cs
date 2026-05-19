using Microsoft.EntityFrameworkCore;
using Task.Models;

namespace Task.Dal
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Member> Members {  get; set; }
        public DbSet<Position> Position {  get; set; }
        
    }
  

}
