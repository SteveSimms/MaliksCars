namespace MaliksCars.Application.Models
{
    public class UserFavoriteCar : BaseModel
    {
        //Composite Keys are UserId CarId
        public int UserId { get; set; }
        public User User { get; set; }
        //Navigation properties Car & User
        public int CarId { get; set; }
        public Car Car { get; set; }

    }
}