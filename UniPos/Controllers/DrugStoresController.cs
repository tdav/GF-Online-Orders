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
    [SwaggerTag("Склад")]
    [Route("api/[controller]")]
    [ApiController]
    public class DrugStoresController : BaseController<spDrugStore>
    {
        public DrugStoresController(IUnitOfWork unitOfWork, IMemoryCache _cache) : base(unitOfWork, _cache) { }
    }
}
