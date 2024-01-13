using Microsoft.AspNetCore.Identity;

namespace book_worm_api.Models
{
    public class ApplicationUser:IdentityUser
    {
        //Stands for the actual name of the user. UserName in database means Email.
        public string Name { get; set; }
    }
}
