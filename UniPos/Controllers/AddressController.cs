using Aptex.Controllers;
using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UniPos.Extensions;
using UniPos.Models;

namespace UniPos.Controllers
{
    [Authorize]
    [ApiController]
    [SwaggerTag("Адрес")]
    [Route("api/[controller]")]
    public class AddressController : ControllerBase
    {
        private readonly IUnitOfWork uow;
        

        public AddressController(IUnitOfWork unitOfWork)
        {
            uow = unitOfWork;

            /*
               UserId = User.GetId();
            IsAdmin = User.IsRoleAdmin();
            UserAccess = User.GetAccess();
             */
        }


        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var UserId = User.GetId();
            var _storage = uow.GetRepository<tbAddress>();
            var res = await _storage.GetAllAsync(x => x.CreateUser == UserId);
            return Ok(res);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var UserId = User.GetId();
            var _storage = uow.GetRepository<tbAddress>();
            var res = await _storage.GetAllAsync(x => x.Id == id && x.CreateUser == UserId);

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
            value.CreateDate= DateTime.Now;

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
