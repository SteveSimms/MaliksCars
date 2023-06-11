using System.ComponentModel.DataAnnotations;

namespace MaliksCars.Application.Models
{
    public class Car : BaseModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Model { get; set; } = string.Empty;

        [Required]
        public string Color { get; set; } = string.Empty;

        [Required]
        public string Year { get; set; } = string.Empty;

        [Required]
        public string BasePrice { get; set; } = string.Empty;


        public string ImageUrl { get; set; } = string.Empty;

        public string Emoji { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public ICollection<UserFavoriteCar>? UserFavoriteCars { get; set; }

        // public string GetFormattedBasePrice() =>
        //     BasePrice.ToString("00,000.00");
    }
}
