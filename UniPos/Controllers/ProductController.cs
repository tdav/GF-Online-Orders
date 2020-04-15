using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arch.EntityFrameworkCore.UnitOfWork;
using Arch.EntityFrameworkCore.UnitOfWork.Collections;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using UniPos.Models;

namespace UniPos.Controllers
{
    // [Authorize]
    [SwaggerTag("Дорилар руйхати")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IUnitOfWork uow;
        private ILogger<ProductController> log;

        public ProductController(IUnitOfWork unitOfWork, ILogger<ProductController> logger)
        {
            log = logger;
            uow = unitOfWork;
        }


        [HttpGet("barcode/{pageIndex}/{pageSize}/{barcode}")]
        public async Task<IPagedList<tbProductDetails>> GetByBarcode(int pageIndex, int pageSize, string barcode)
        {
            var db = uow.GetRepository<tbProductDetails>();
            var items = await db.GetPagedListAsync(x => x.Drug.Barcode == barcode, pageIndex: pageIndex, pageSize: pageSize);
            return items;
        }


        [HttpGet("drugname/{pageIndex}/{pageSize}/{name}")]
        public async Task<IPagedList<tbProductDetails>> GetByName(int pageIndex, int pageSize, string name)
        {
            var db = uow.GetRepository<tbProductDetails>();
            var items = await db.GetPagedListAsync(x => x.Drug.Barcode.Contains( name.Trim() ), pageIndex: pageIndex, pageSize: pageSize);
            return items;
        }

        // GET api/values/4
        [HttpGet("{id}")]
        public async ValueTask<tbProductDetails> Get(int id)
        {
            var db = uow.GetRepository<tbProductDetails>();
            var it = await db.FindAsync(id);
            return it;
        }
    }
}
