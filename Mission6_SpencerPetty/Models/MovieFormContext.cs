using Microsoft.EntityFrameworkCore;
using Mission6_SpencerPetty;

namespace Mission6_SpencerPetty.Models
{
    public class MovieFormContext : DbContext // This is the context for the Movie object
    {
        public MovieFormContext(DbContextOptions<MovieFormContext> options) : base(options) // Constructor
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
