using Aptex.Controllers;
using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Swashbuckle.AspNetCore.Annotations;
using UniPos.Models;

namespace UniPos.Controllers
{

    [Authorize]
    [SwaggerTag("Дори категорияси")]
    [Route("api/[controller]")]
    [ApiController]
    public class DrugCategoriesController : BaseController<spDrugCategory>
    {
        public DrugCategoriesController(IUnitOfWork unitOfWork, IMemoryCache _cache) : base(unitOfWork, _cache) { }
    }
}
