using Microsoft.EntityFrameworkCore;
using Trellow.Models.App;

namespace Trellow.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Card> Cards { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Epic> Epics { get; set; }

        public DbSet<List> Lists { get; set; }

        public DbSet<Member> Members { get; set; }

        public DbSet<Sprint> Sprints { get; set; }
    }
}
