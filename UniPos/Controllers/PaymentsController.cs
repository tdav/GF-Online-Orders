using Aptex.Controllers;
using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Swashbuckle.AspNetCore.Annotations;
using UniPos.Models;

namespace UniPos.Controllers
{
    //[Authorize]
    [SwaggerTag("Тулов тури")]
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : BaseController<spPayment>
    {
        public PaymentsController(IUnitOfWork unitOfWork, IMemoryCache _cache) : base(unitOfWork, _cache) { }

    }
}
