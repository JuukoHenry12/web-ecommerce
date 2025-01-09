using Microsoft.EntityFrameworkCore;
using myaspnetmvc.Models;

namespace myaspnetmvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Web Development", DisplayOrder = 1 },
                new Category { CategoryId = 2, Name = "Mobile Development", DisplayOrder = 2 },
                new Category { CategoryId = 3, Name = "Game Development", DisplayOrder = 3 }
            );
        }
    }
}
