using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;
using UniPos.Extensions;
using UniPos.Models;
using UniPos.Models.Views;

namespace UniPos.Controllers
{
    [Authorize]
    [SwaggerTag("Заказлар")]
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : MyControllerBase
    {
        private readonly MyDbContext ctx;
        public OrderController(MyDbContext context)
        {
            ctx = context;
        }


        [HttpPost]
        [SwaggerOperation("Янги")]
        public async Task<ActionResult> PosttbOrder(viOrder value)
        {
            tbOrderHeader or;

            if (value.Id == null)
            {
                or = new tbOrderHeader();
                or.CreateDate = DateTime.Now;
                or.CreateUser = UserId;
                or.DeliveryTime = DateTime.Now.AddHours(2);

                or.OrderStatusId = 1;
                or.PaymentId = 1;
                or.UserAgentId = 1;
            }
            else
            {
                or = await ctx.tbOrders.FindAsync(value.Id);
                or.CreateDate = value.CreateDate;
                or.CreateUser = value.CreateUser;
                or.DeliveryTime = value.DeliveryTime;
                or.OrderStatusId = value.OrderStatusId;
                or.PaymentId = value.PaymentId;
                or.UserAgentId = value.UserAgentId;
            }

            or.Status = 1;
            or.DrugStoreId = 1001;
            or.Description = value.Description;
            or.AddressId = value.AddressId;
            or.ItemQty = value.OrderDetails.Count();
            or.Summa = value.OrderDetails.Sum(x => x.TotalSum);

            or.OrderDetails = new List<tbOrderDetails>();
            foreach (var it in value.OrderDetails)
            {
                var od = new tbOrderDetails();
                od.CreateDate = DateTime.Now;
                od.CreateUser = value.CreateUser;

                if (it.ProductId == null)
                    od.ProductId = await GetDrugIdAsync(it.DrugName);
                else
                    od.ProductId = it.ProductId ?? it.ProductId.Value;

                od.Qty = it.Qty;
                od.Status = 1;

                or.OrderDetails.Add(od);
            }

            await ctx.tbOrders.AddAsync(or);
            await ctx.SaveChangesAsync();

            return Ok();
        }

        private async Task<int> GetDrugIdAsync(string drugName)
        {
            var it = await ctx.tbProductDetails
                                   .Include(x => x.Drug)
                                   .FirstOrDefaultAsync(x => x.Drug.Description == drugName);
            return it.Id;
        }

        [HttpGet("{id}")]
        [SwaggerOperation("Фойдаланувчи закази")]
        public async Task<ActionResult<tbOrderHeader>> GetOrderById(int id)
        {           
            var tbOrder = await ctx.tbOrders
                                        .Include(x => x.OrderDetails)
                                        .Where(x => x.CreateUser == UserId)
                                        .SingleOrDefaultAsync(x => x.Id == id);

            if (tbOrder == null)
            {
                return NotFound();
            }

            return tbOrder;
        }


        [HttpPost("filter")]
        [SwaggerOperation("Закази хаммаси")]
        public async Task<ActionResult<List<tbOrderHeader>>> GetOrderAll(viOrderSearchParam param)
        {
            if (param == null) return BadRequest();

            if (!IsAdmin) return NotFound();


            var query = ctx.tbOrders.Include(x => x.OrderDetails);


            if (param.CreateUser != null)
                query.Where(x => x.CreateUser == param.CreateUser);

            if (param.DistrictId != null)
                query.Include(x=>x.Address).Where(x => x.Address.DistrictId == param.DistrictId);

            if (param.DrugStoreId != null)
                query.Where(x => x.DrugStoreId == param.DrugStoreId);

            if (param.OrderStatusId != null)
                query.Where(x => x.OrderStatusId == param.OrderStatusId);

            if (param.PaymentId != null)
                query.Where(x => x.PaymentId == param.PaymentId);

            if (param.UserAgentId != null)
                query.Where(x => x.UserAgentId == param.UserAgentId);

            
            if (param.CreateDate1 != null && param.CreateDate2 != null)
                query.Where(x => x.CreateDate <= param.CreateDate1 && x.CreateDate >= param.CreateDate2);

            if (param.CreateDate1 != null && param.CreateDate2 == null)
                query.Where(x => x.CreateDate <= param.CreateDate1);

            if (param.CreateDate1 == null && param.CreateDate2 != null)
                query.Where(x => x.CreateDate >= param.CreateDate2);

            
            if (param.DeliveryTime1 != null && param.DeliveryTime2 != null)
                query.Where(x => x.DeliveryTime <= param.DeliveryTime1 && x.DeliveryTime >= param.DeliveryTime2);

            if (param.DeliveryTime1 != null && param.DeliveryTime2 == null)
                query.Where(x => x.DeliveryTime <= param.DeliveryTime1);

            if (param.DeliveryTime1 == null && param.DeliveryTime2 != null)
                query.Where(x => x.DeliveryTime >= param.DeliveryTime2);



            var list = await query.ToListAsync();

            if (list == null)
                return NotFound();

            return list;
        }


        [HttpPost("SetStatus")]
        [SwaggerOperation("Закази статусини узгартириш")]
        public async Task<IActionResult> SetStatusOrder(int id)
        {
            tbOrderHeader order;

            if (IsAdmin)
            {   // Is User
                order = await ctx.tbOrders
                                      .Include(x => x.OrderDetails)
                                      .Where(x => x.CreateUser == UserId)
                                      .SingleOrDefaultAsync(x => x.Id == id);
            }
            else
            {   // Is Admin
                order = await ctx.tbOrders
                                      .Include(x => x.OrderDetails)
                                      .SingleOrDefaultAsync(x => x.Id == id);
            }


            if (order != null)
            {
                order.OrderStatusId = id;
                await ctx.SaveChangesAsync();
                return Ok();
            }else
            {
                return NotFound();
            }
        }
    }
}
