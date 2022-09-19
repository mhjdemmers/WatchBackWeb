using Microsoft.EntityFrameworkCore;
using WatchBackWeb.Models;

namespace WatchBackWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Camera> Cameras { get; set; }
    }
}
