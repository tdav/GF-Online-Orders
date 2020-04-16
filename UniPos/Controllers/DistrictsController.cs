using Aptex.Controllers;
using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Swashbuckle.AspNetCore.Annotations;
using UniPos.Models;

namespace UniPos.Controllers
{

    //[Authorize]
    [SwaggerTag("Туманлар руйхати")]
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictsController : BaseController<spDistrict>
    {
        public DistrictsController(IUnitOfWork unitOfWork, IMemoryCache _cache) : base(unitOfWork, _cache) { }
    }
}
