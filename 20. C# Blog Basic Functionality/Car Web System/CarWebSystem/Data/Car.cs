namespace CarWebSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Car
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Make { get; set; }

        [Required]
        [MaxLength(50)]
        public string Model { get; set; }

        [Required]
        [Range(1950, 2018)]
        public int Year { get; set; }

        [Required]
        [Range(1, 1_000_000)]
        public decimal Price { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }
    }
}