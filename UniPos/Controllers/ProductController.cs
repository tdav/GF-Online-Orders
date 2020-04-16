using System.Threading.Tasks;
using Arch.EntityFrameworkCore.UnitOfWork;
using Arch.EntityFrameworkCore.UnitOfWork.Collections;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using UniPos.Models;
using UniPos.Models.Views;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace UniPos.Controllers
{
    [Authorize]
    [SwaggerTag("Дорилар руйхати")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly MyDbContext db;
        private ILogger<ProductController> log;

        public ProductController(MyDbContext context, ILogger<ProductController> logger)
        {
            log = logger;
            db = context;
        }


        [HttpPost("barcode")]
        public Task<List<viProduct>> SearchByBarcode([FromBody] viDrugSearch val)
        {
            return db.tbProductDetails
                         .Include(x => x.Drug)
                         .Include(x => x.Drug.Manufacturer)
                         .Where(x => x.Drug.Barcode == val.value)
                         .Take(20)
                         .Select(x => new viProduct
                         {
                             Id = x.Id,
                             DrugId = x.DrugId,
                             DrugName = x.Drug.Name,
                             Manufacturer = x.Drug.Manufacturer.Name,
                             ExpiryDate = x.ExpiryDate,
                             Price = x.Price,
                             Qty = x.Qty,
                             Vat = x.Vat,
                             Piece = x.Drug.Piece
                         }).ToListAsync();
        }


        [HttpPost("drugname")]
        public Task<List<viProduct>> SearchByName([FromBody] viDrugSearch val)
        {
            var str = FixTiLike(val.value);
            return db.tbProductDetails
                         .Include(x => x.Drug)
                         .Include(x => x.Drug.Manufacturer)
                         .Where(x => EF.Functions.Like(x.Drug.Name, str))
                         .Take(20)
                         .Select(x => new viProduct
                         {
                             Id = x.Id,
                             DrugId = x.DrugId,
                             DrugName = x.Drug.Name,
                             Manufacturer = x.Drug.Manufacturer.Name,
                             ExpiryDate = x.ExpiryDate,
                             Price = x.Price,
                             Qty = x.Qty,
                             Vat = x.Vat,
                             Piece = x.Drug.Piece
                         }).ToListAsync();
        }

        private static string FixTiLike(string val)
        {
            var s = val.ToLower().Trim();

            while (s.IndexOf(' ') > 0)
                s = s.Replace(' ', '%');

            return $"%{s}%";
        }
    }
}
