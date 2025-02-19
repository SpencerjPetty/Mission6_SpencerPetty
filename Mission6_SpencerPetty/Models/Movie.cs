using System.ComponentModel.DataAnnotations;

namespace Mission6_SpencerPetty.Models
{ // This is the model for the Movie object
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Movie
    {
        [Key] // Marks this as the primary key
        public int MovieId { get; set; } // Auto-incrementing primary key

        [ForeignKey("CategoryId")] // Foreign key
        public int? CategoryId { get; set; } // Nullable foreign key
        public Category? Category { get; set; } // Navigation property

        [Required]
        public string Title { get; set; }

        [Required]
        [Range(1888, 2100, ErrorMessage = "Year must be 1888 or later.")]
        public int Year { get; set; }

        public string? Director { get; set; }

        public string? Rating { get; set; }

        [Required]
        public bool Edited { get; set; } // Required field (non-nullable boolean)

        public string? LentTo { get; set; }

        [Required]
        public bool CopiedToPlex { get; set; } // Required field (non-nullable boolean)

        [MaxLength(25)]
        public string? Notes { get; set; }
    }

}
