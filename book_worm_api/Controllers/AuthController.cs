using book_worm_api.Data;
using book_worm_api.Models;
using book_worm_api.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace book_worm_api.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private ApiResponse _response;
        private readonly UserManager<ApplicationUser> _userManager;
        // IdentityRole defined in services
        private readonly RoleManager<IdentityRole> _roleManager;
        private string secretKey;
        //with IConfiguration we can acces appsettings
        public AuthController(ApplicationDbContext db, IConfiguration configuaretion, RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            secretKey = configuaretion.GetValue<string>("ApiSettings:Secret");
            _response = new ApiResponse();
            _roleManager = roleManager;
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDTO model)
        {

        }
    }
}
