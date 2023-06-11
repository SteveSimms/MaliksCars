namespace MaliksCars.Application.Models
{
    public class User : BaseModel
    {
        public User()
        {
            UserRoles = new HashSet<UserRole>();
            UserFavoriteCars = new HashSet<UserFavoriteCar>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string ImageUrl { get; set; }

        public string? RememberToken { get; set; }

        public DateTime? EmailVerifiedAt { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }

        public virtual ICollection<UserFavoriteCar> UserFavoriteCars { get; set; }
    }
}
