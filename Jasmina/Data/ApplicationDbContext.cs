using Jasmina.Models;
using Microsoft.EntityFrameworkCore;

namespace Jasmina.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Course> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity <Course>().HasData(
                new Course { Id = 1, Title = "JavaScript", Description= "the last course", DisplayOrder = 1 },
                new Course { Id = 2, Title = "C#", Description = "this is the second course", DisplayOrder = 2 },
                new Course { Id = 3, Title = "HTML", Description="this is the first course", DisplayOrder = 3 }
                );
        }
    }
}
