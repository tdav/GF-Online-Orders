using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UniPos.Models;
using Swashbuckle.AspNetCore.Annotations;
using UniPos.Core;

namespace UniPos.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    [SwaggerTag("Фойдаланувчилар")]
    public class UsersController : ControllerBase
    {
        private readonly IUnitOfWork db;
        private ILogger<UsersController> _logger;

        public UsersController(IUnitOfWork _db, ILogger<UsersController> logger)
        {
            db = _db;
            _logger = logger;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        [SwaggerOperation("Авторизация")]
        public IActionResult Authenticate([FromBody] viAuthenticateModel model)
        {
            var rpUser = db.GetRepository<tbUser>(true) as UserService;
            var user = rpUser.Authenticate(model.Username, model.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }

        [HttpGet]
        [SwaggerOperation("Хамма user")]
        public IActionResult GetAll()
        {
            var rpUser = db.GetRepository<tbUser>(true) as UserService;
            var users = rpUser.GetAllUsers();

            return Ok(users);
        }
    }
}
