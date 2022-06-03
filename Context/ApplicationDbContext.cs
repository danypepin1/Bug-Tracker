using BugTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User>? Users { get; set; }
    }
}
