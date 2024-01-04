using book_worm_api.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace book_worm_api.Data
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { 
        }

        //EF will not create a new table because it knows that in inherits  the IdentityDbContext
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
