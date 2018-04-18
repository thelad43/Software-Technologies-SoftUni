namespace CarWebSystem.Models.Cars
{
    using System.ComponentModel.DataAnnotations;

    public class AddCarFormModel
    {
        [Required]
        [MaxLength(30)]
        public string Make { get; set; }

        [Required]
        [MaxLength(50)]
        public string Model { get; set; }

        [Required]
        [Range(1950, 2018, ErrorMessage = "Year must be between 1950 and 2018!")]
        public int Year { get; set; }

        [Required]
        [Range(1, 1_000_000, ErrorMessage = "Price must be between 1 and 1 000 000!")]
        public decimal Price { get; set; }

        [Url]
        [Display(Name = "Image URL")]
        [Required]
        public string ImageUrl { get; set; }
    }
}