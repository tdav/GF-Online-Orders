using Aptex.Controllers;
using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Swashbuckle.AspNetCore.Annotations;
using UniPos.Models;

namespace UniPos.Controllers
{

   // [Authorize]
    [SwaggerTag("Дори кути формаси")]
    [Route("api/[controller]")]
    [ApiController]
    public class UnitsController : BaseController<spUnit>
    {
        public UnitsController(IUnitOfWork unitOfWork, IMemoryCache _cache) : base(unitOfWork, _cache) { }

    }
}
