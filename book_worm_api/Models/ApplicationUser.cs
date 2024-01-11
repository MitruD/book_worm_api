using Microsoft.AspNetCore.Identity;

namespace book_worm_api.Models
{
    public class ApplicationUser:IdentityUser
    {
        //Stands for the name of the user. User name in database means Email.
        public string Name { get; set; }
    }
}
