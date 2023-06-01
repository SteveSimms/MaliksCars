namespace MaliksCars.Application.Models
{
    public class Car : BaseModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public string Year { get; set; }

        public string BasePrice { get; set; }

        public string ImageUrl { get; set; }

        public string Emoji { get; set; }

        public string Description { get; set; }

        // public string GetFormattedBasePrice() =>
        //     BasePrice.ToString("00,000.00");
    }
}
