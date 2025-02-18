namespace Mission6_SpencerPetty.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Category
    {
        [Required]
        public int CategoryId { get; set; } // Primary key
        [Required]
        public string? CategoryName { get; set; } // Name of the category
    }
}
