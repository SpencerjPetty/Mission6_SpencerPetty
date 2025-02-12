using Microsoft.EntityFrameworkCore;
using Mission6_SpencerPetty;

namespace Mission6_SpencerPetty.Models
{
    public class MovieFormContext : DbContext
    {
        public MovieFormContext(DbContextOptions<MovieFormContext> options) : base(options) 
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
