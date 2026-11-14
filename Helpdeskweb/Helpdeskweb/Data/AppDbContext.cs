using Helpdeskweb.Models;
using Microsoft.EntityFrameworkCore;

namespace Helpdeskweb.data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {            
        }
        public DbSet<Game> Games { get; set; }
    }
}
