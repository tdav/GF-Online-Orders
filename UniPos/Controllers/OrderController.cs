using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;
using UniPos.Models;
using UniPos.Models.Views;

namespace UniPos.Controllers
{
    //[Authorize]
    [SwaggerTag("Заказлар")]
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly MyDbContext _context;
        public OrderController(MyDbContext context)
        {
            _context = context;
        }


        [HttpPost]
        [SwaggerOperation("Янги ва узгартириш ( value.Id == null = янги )")]
        public async Task<ActionResult> PosttbOrder(viOrder value)
        {
            tbOrderHeader or;

            if (value.Id != null)
            {
                or = new tbOrderHeader();
                or.Id = value.Id ?? value.Id.Value;

                or.CreateDate = DateTime.Now;
                or.CreateUser = value.CreateUser;
                or.DeliveryTime = DateTime.Now.AddHours(2);

                or.OrderStatusId = 1;
                or.PaymentId = 1;
                or.Status = 1;
                or.UserAgentId = 1;
            }
            else
            {
                or = await _context.tbOrders.FindAsync(value.Id);
                or.CreateDate = value.CreateDate;
                or.CreateUser = value.CreateUser;
                or.DeliveryTime = value.DeliveryTime;
                or.OrderStatusId = value.OrderStatusId;
                or.PaymentId = value.PaymentId;
                or.UserAgentId = value.UserAgentId;
            }

            or.Status = 1;
            or.Description = value.Description;
            or.RegionId = value.RegionId;
            or.DistrictId = value.DistrictId;
            or.Address = value.Address;
            or.DrugStoreId = value.DrugStoreId;
            or.Latitude = value.Latitude;
            or.Longitude = value.Longitude;

            foreach (var it in value.OrderDetails)
            {
                var od = new tbOrderDetails();
                od.CreateDate = DateTime.Now;
                od.CreateUser = value.CreateUser;
                od.DrugId = await GetDrugIdAsync(it.DrugName);
                od.Qty = it.Qty;
                od.Status = 1;
            }

            await _context.tbOrders.AddAsync(or);
            await _context.SaveChangesAsync();

            return Ok();
        }

        private async Task<int> GetDrugIdAsync(string drugName)
        {
            var it = await _context.spDrugs.FirstOrDefaultAsync(x => x.Description == drugName);
            return it.Id;
        }

        [HttpGet("{id}")]
        [SwaggerOperation("Фойдаланувчи заказлар руйхати")]
        public async Task<ActionResult<tbOrderHeader>> GettbOrder(int id)
        {
            var tbOrder = await _context.tbOrders.FindAsync(id);

            if (tbOrder == null)
            {
                return NotFound();
            }

            return tbOrder;
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PuttbOrder(int id, tbOrderHeader tbOrder)
        {
            if (id != tbOrder.Id)
            {
                return BadRequest();
            }

            _context.Entry(tbOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tbOrderExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<tbOrderHeader>> DeletetbOrder(int id)
        {
            var tbOrder = await _context.tbOrders.FindAsync(id);
            if (tbOrder == null)
            {
                return NotFound();
            }

            _context.tbOrders.Remove(tbOrder);
            await _context.SaveChangesAsync();

            return tbOrder;
        }

        private bool tbOrderExists(int id)
        {
            return _context.tbOrders.Any(e => e.Id == id);
        }
    }
}
