using Microsoft.EntityFrameworkCore;
using Mission6_SpencerPetty;

namespace Mission6_SpencerPetty.Models
{
    public class MovieFormContext : DbContext // This is the context for the Movie object, a liaison from the app to the database
    {
        public MovieFormContext(DbContextOptions<MovieFormContext> options) : base(options) // Constructor
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) // Seed the database with some categories
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Miscellaneous"
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Drama"
                },
                new Category
                {
                    CategoryId = 3,
                    CategoryName = "Television"
                },
                new Category
                {
                    CategoryId = 4,
                    CategoryName = "Horror/Suspense"
                },
                new Category
                {
                    CategoryId = 5,
                    CategoryName = "Comedy"
                },
                new Category
                {
                    CategoryId = 6,
                    CategoryName = "Family"
                },
                new Category
                {
                    CategoryId = 7,
                    CategoryName = "Action/Adventure"
                },
                new Category
                {
                    CategoryId = 8,
                    CategoryName = "VHS"
                }
            );
        }
    }
}
