using Microsoft.AspNetCore.Identity;

namespace book_worm_api.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string Name { get; set; }
    }
}
