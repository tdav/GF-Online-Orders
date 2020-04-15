using Aptex.Controllers;
using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Swashbuckle.AspNetCore.Annotations;
using UniPos.Models;

namespace UniPos.Controllers
{
    //[Authorize]
    [SwaggerTag("Фойдаланувчи настройкалари")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserSetupController : BaseController<tbSetup>
    {
        public UserSetupController(IUnitOfWork unitOfWork, IMemoryCache _cache) : base(unitOfWork, _cache) { }
    }
}
