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
    [ApiController]
    [SwaggerTag("Фойдаланувчи доступлари ")]
    public class AccessListsController : BaseController<spAccessList>
    {
        public AccessListsController(IUnitOfWork unitOfWork, IMemoryCache _cache) : base(unitOfWork, _cache) { }

        [HttpGet("test/{id}")]
        public string Test(string id)
        {
            return id;
        }
    }
}
