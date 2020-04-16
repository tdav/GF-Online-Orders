using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace UniPos.Controllers
{

    [Authorize]
    [SwaggerTag("Дори расмлари")]
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IUnitOfWork uow;

        public ImagesController(IUnitOfWork unitOfWork)  
        {
            uow = unitOfWork;
        }


    }
}
