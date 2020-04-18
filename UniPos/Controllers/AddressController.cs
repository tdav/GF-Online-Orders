using Aptex.Controllers;
using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using UniPos.Extensions;
using UniPos.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace UniPos.Controllers
{
    [Authorize]
    [ApiController]
    [SwaggerTag("Адрес")]
    [Route("api/[controller]")]
    public class AddressController : ControllerBase
    {
        private readonly IUnitOfWork uow;
        private readonly MyDbContext ctx;

        public AddressController(IUnitOfWork unitOfWork, MyDbContext _ctx)
        {
            uow = unitOfWork;
            ctx = _ctx;
            /*
               UserId = User.GetId();
            IsAdmin = User.IsRoleAdmin();
            UserAccess = User.GetAccess();
             */
        }


        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try
            {
                var UserId = User.GetId();

                var res = await ctx.tbAddress
                                   .Where(x => x.CreateUser == UserId)
                                   .Include(x => x.District)
                                   .Include(x => x.District.Region)
                                   .Select(x => new viAddress
                                   {
                                       Id = x.Id,
                                       RegionId = x.RegionId,
                                       RegionName = x.Region.Name,
                                       DistrictId = x.DistrictId,
                                       DistrictName = x.District.Name,
                                       Street = x.Street,
                                       House = x.House,
                                       Flat = x.Flat,
                                       Waymark = x.Waymark,
                                       Latitude = x.Latitude,
                                       Longitude = x.Longitude,
                                       Description = x.Description
                                   }).ToListAsync();

                return Ok(res);
            }
            catch (Exception ee)
            {
                return NotFound(ee.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var UserId = User.GetId();
            var res = await ctx.tbAddress
                             .Include(x => x.District)
                             .Include(x => x.District.Region)
                             .Where(x => x.CreateUser == UserId && x.Id == id)
                             .Select(x => new viAddress
                             {
                                 Id = x.Id,
                                 RegionId = x.RegionId,
                                 RegionName = x.Region.Name,
                                 DistrictId = x.DistrictId,
                                 DistrictName = x.District.Name,
                                 Street = x.Street,
                                 House = x.House,
                                 Flat = x.Flat,
                                 Waymark = x.Waymark,
                                 Latitude = x.Latitude,
                                 Longitude = x.Longitude,
                                 Description = x.Description
                             }).FirstOrDefaultAsync();

            if (res != null)
            {
                return Ok(res);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] tbAddress value)
        {
            var UserId = User.GetId();
            value.CreateUser = UserId;
            value.CreateDate = DateTime.Now;

            var _storage = uow.GetRepository<tbAddress>();
            await _storage.InsertAsync(value);
            await uow.SaveChangesAsync();
            return Ok(value);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody]tbAddress value)
        {
            var UserId = User.GetId();
            value.UpdateUser = UserId;
            value.UpdateDate = DateTime.Now;

            var _storage = uow.GetRepository<tbAddress>();
            _storage.Update(value);
            await uow.SaveChangesAsync();
            return Ok();
        }
    }
}
