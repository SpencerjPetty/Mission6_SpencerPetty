using System.ComponentModel.DataAnnotations;

namespace Mission6_SpencerPetty.Models
{ // This is the model for the Movie object
    public class Movie
    {

        [Key] // Marks this as the primary key
        public int Id { get; set; } // Auto-incrementing primary key
        
        [Required]
        public required string Title { get; set; }

        [Required]
        public required string Director { get; set; }

        [Required]
        [Range(1900, 2100)]
        public int Year { get; set; }

        [Required]
        public required string Genre { get; set; }

        [Required]
        public required string Rating { get; set; }

        public bool? Edited { get; set; }

        public string? LentTo { get; set; }

        [MaxLength(25)]
        public string? Notes { get; set; }
    }
}
