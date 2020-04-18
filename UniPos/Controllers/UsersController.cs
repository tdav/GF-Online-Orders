using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UniPos.Models;
using Swashbuckle.AspNetCore.Annotations;
using UniPos.Core;
using UniPos.Models.Views;
using System;
using System.Threading.Tasks;
using UniPos.Extensions;

namespace UniPos.Controllers
{
    [Authorize]
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

        [HttpGet("test/{id}")]
        public string Test(string id)
        {
            var ss = (User.IsRoleAdmin() ? "admin" : "user") + " ID:" + User.GetId().ToString();
            return ss;
        }

        [AllowAnonymous]
        [HttpPost("register")]
        [SwaggerOperation("Янги фойдаланувчи")]
        public async Task<ActionResult> Authenticate([FromBody] viRegisterUserModel model)
        {
            var rp = db.GetRepository<tbUser>(true) as UserService;

            var eu = await rp.GetFirstOrDefaultAsync(predicate: x => x.Username == model.Username, disableTracking: true);
            if (eu != null) return BadRequest("Бундай фойдаланувчи бор");


            var u = new tbUser();
            u.FirstName = model.FirstName;
            u.LastName = model.LastName;
            u.Username = model.Username;
            u.Password = model.Password;
            u.Phone = model.Phone;
            u.RoleId = 2;
            u.Status = 1;
            u.CreateUser = 1;
            u.CreateDate = DateTime.Now;


            await rp.InsertAsync(u);
            await db.SaveChangesAsync();

            var rpUser = db.GetRepository<tbUser>(true) as UserService;
            var user = rpUser.Authenticate(model.Username, model.Password);

            return Ok(user);
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

            return Ok(users.WithoutPasswords());
        }
    }
}
