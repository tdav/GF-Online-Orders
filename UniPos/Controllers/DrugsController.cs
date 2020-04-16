using Aptex.Controllers;
using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Swashbuckle.AspNetCore.Annotations;
using UniPos.Models;

namespace UniPos.Controllers
{

    // [Authorize]
    [SwaggerTag("Дорилар руйхати")]
    [Route("api/[controller]")]
    [ApiController]
    public class DrugsController : BaseController<spDrug>
    {
        public DrugsController(IUnitOfWork unitOfWork, IMemoryCache _cache) : base(unitOfWork, _cache) { }
    }
}
