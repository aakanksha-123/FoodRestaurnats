using Microsoft.AspNetCore.Identity;

namespace FoodRestaurnats.Data.Models
{
    public class ApplicationUser:IdentityUser
    {
   
        public ICollection<User>? Users { get; set; }
    }
}
