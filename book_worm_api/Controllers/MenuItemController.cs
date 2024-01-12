using book_worm_api.Data;
using book_worm_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace book_worm_api.Controllers
{
    [Route("api/MenuItem")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private ApiResponse _response;
        public MenuItemController(ApplicationDbContext db)
        {
            _db = db;
            _response = new ApiResponse();
        }

        [HttpGet]
        public async Task<IActionResult> GetMenuItems()
        {
            _response.Result = _db.MenuItems;
            _response.StatusCode = HttpStatusCode.OK;
            return Ok(_response);
        }

        //Swagger makes difference between APIs by looking at tags and not at the function name and it's argument.
        //If we have two instances of [HttpGet] tags, swagger will throw an error. The argument should be put in tag for it to make the diffence.
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetMenuItem(int id)
        {
            if(id == 0)
            {
                _response.StatusCode = HttpStatusCode.BadRequest;
                return BadRequest(_response);
            }
            MenuItem menuItem = _db.MenuItems.FirstOrDefault(x => x.Id == id);
            if (menuItem==null)
            {
                _response.StatusCode = HttpStatusCode.NotFound;
                return NotFound(_response);
            }
            _response.Result = menuItem;
            _response.StatusCode = HttpStatusCode.OK;
            return Ok(_response);
        }
    }
}
