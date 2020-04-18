using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RssSata.Utils;
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
    public class OrderController : ControllerBase
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

            ctx.BeginTransaction();

            try
            {
                tbOrderHeader or;
                tbAddress adr;

                if (value.Id == null)
                {
                    or = new tbOrderHeader();
                    or.CreateDate = DateTime.Now;
                    or.CreateUser = User.GetId();
                    or.OrderStatusId = 1;
                }
                else
                {
                    return BadRequest("Бундай ID лик заказ бор...");
                    //or = await ctx.tbOrders.FindAsync(value.Id);
                    //or.UpdateUser = User.GetId();
                    //or.UpdateDate = DateTime.Now;
                }

                var dt = await ctx.spDeliveryTypes.FindAsync(value.DeliveryTypeId);
                var phone = await ctx.tbUser.FindAsync(User.GetId());

                or.Status = 1;
                or.DrugStoreId = 1001;
                or.DeliveryTime = DateTime.Now.AddHours(dt.DeliveryTime);
                or.Description = value.Description;
                or.PaymentId = value.PaymentId;
                or.UserAgentId = value.UserAgentId;
                or.DeliveryTypeId = value.DeliveryTypeId;
                or.Phone = value.Phone;

                if (value.AddressId == null || value.AddressId == 0)
                {
                    adr = new tbAddress();
                    adr.RegionId = value.RegionId ?? value.RegionId.Value;
                    adr.DistrictId = value.DistrictId ?? value.DistrictId.Value;
                    adr.Street = value.Street;
                    adr.House = value.House;
                    adr.Flat = value.Flat;
                    adr.Waymark = value.Waymark;
                    adr.Latitude = value.Latitude;
                    adr.Longitude = value.Longitude;

                    adr.CreateDate = DateTime.Now;
                    adr.CreateUser = User.GetId();
                    adr.Status = 1;

                    await ctx.tbAddress.AddAsync(adr);
                    await ctx.SaveChangesAsync();
                    or.AddressId = adr.Id;
                }
                else
                {
                    or.AddressId = value.AddressId.Value;
                }

                or.ItemQty = value.OrderDetails.Count();
                or.Summa = value.OrderDetails.Sum(x => x.TotalSum);

                or.OrderDetails = new List<tbOrderDetails>();
                foreach (var it in value.OrderDetails)
                {
                    var od = new tbOrderDetails();
                    od.CreateDate = DateTime.Now;
                    od.CreateUser = value.CreateUser;

                    if (it.ProductId == null || it.ProductId == 0)
                        od.ProductId = await GetDrugIdAsync(it.DrugName);
                    else
                        od.ProductId = it.ProductId ?? it.ProductId.Value;

                    od.Qty = it.Qty;
                    od.Price = it.Price;
                    od.TotalSum = it.TotalSum;
                    od.Status = 1;

                    or.OrderDetails.Add(od);
                }

                await ctx.tbOrders.AddAsync(or);
                await ctx.SaveChangesAsync();
                ctx.Commit();
                return Ok(new { OrderId = or.Id, DeliveryTime = or.DeliveryTime });
            }
            catch (Exception)
            {
                ctx.Rollback();
                return BadRequest();
            }
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
        public async Task<ActionResult<viOrder>> GetOrderById(int id)
        {
            var query = ctx.tbOrders.AsQueryable();

            if (!User.IsRoleAdmin())
                query = query.Where(x => x.CreateUser == User.GetId());

            var list = await query
                                .Include(x => x.OrderDetails)
                                .Include(x => x.Address)
                                .Include(x => x.Address.District)
                                .Include(x => x.Address.District.Region)
                                .Include(x => x.DeliveryType)
                                .Include(x => x.DrugStore)
                                .Include(x => x.OrderStatus)
                                .Include(x => x.Payment)
                                .Include(x => x.UserAgent)
                                .Select(x => new viOrder
                                {
                                    Id = x.Id,
                                    AddressId = x.AddressId,
                                    AddressName = x.Address.Description,
                                    RegionId = x.Address.RegionId,
                                    RegionName = x.Address.Region.Name,
                                    DistrictId = x.Address.DistrictId,
                                    DistrictName = x.Address.District.Name,
                                    Street = x.Address.Street,
                                    House = x.Address.House,
                                    Waymark = x.Address.Waymark,
                                    Flat = x.Address.Flat,
                                    Latitude = x.Address.Latitude,
                                    Longitude = x.Address.Longitude,

                                    DrugStoreId = x.DrugStoreId,
                                    DrugStoreName = x.DrugStore.Name,

                                    DeliveryTime = x.DeliveryTime,
                                    DeliveryTypeId = x.DeliveryTypeId,
                                    DeliveryTypeName = x.DeliveryType.Name,

                                    OrderStatusId = x.OrderStatusId,
                                    OrderStatusName = x.OrderStatus.Name,
                                    PaymentId = x.PaymentId,
                                    PaymentName = x.Payment.Name,

                                    UserAgentId = x.UserAgentId,
                                    UserAgentName = x.UserAgent.Name,

                                    CreateDate = x.CreateDate,
                                    CreateUser = x.CreateUser,
                                    Description = x.Description,
                                    Status = x.Status,
                                    Phone = x.Phone,
                                    OrderDetails = x.OrderDetails
                                                    .Select(t => new viOrderDetails
                                                    {
                                                        Id = t.Id,
                                                        ProductId = t.ProductId,
                                                        DrugName = t.Product.Drug.Name,
                                                        Qty = t.Qty,
                                                        Price = t.Price,
                                                        TotalSum = t.TotalSum

                                                    }).ToList()
                                })
                                .SingleOrDefaultAsync(x => x.Id == id);

            if (list == null)
                return NotFound();

            return list;
        }


        [HttpPost("filter")]
        [SwaggerOperation("Закази хаммаси")]
        public async Task<ActionResult<List<viOrder>>> GetOrderAll(viOrderSearchParam param)
        {
            if (param == null) return BadRequest();

            var query = ctx.tbOrders.AsQueryable();


            if (!User.IsRoleAdmin())
                query = query.Where(x => x.CreateUser == param.CreateUser);

            if (param.OrderId != null)
                query = query.Where(x => x.Id == param.OrderId);

            if (param.CreateUser != null)
                query = query.Where(x => x.CreateUser == param.CreateUser);

            if (param.DistrictId != null)
                query = query.Include(x => x.Address).Where(x => x.Address.DistrictId == param.DistrictId);

            if (param.DrugStoreId != null)
                query = query.Where(x => x.DrugStoreId == param.DrugStoreId);

            if (param.OrderStatusId != null)
                query = query.Where(x => x.OrderStatusId == param.OrderStatusId);

            if (param.PaymentId != null)
                query = query.Where(x => x.PaymentId == param.PaymentId);

            if (param.UserAgentId != null)
                query = query.Where(x => x.UserAgentId == param.UserAgentId);


            if (param.CreateDate1 != null && param.CreateDate2 != null)
                query = query.Where(x => x.CreateDate >= param.CreateDate1 && x.CreateDate <= param.CreateDate2);

            if (param.CreateDate1 != null && param.CreateDate2 == null)
                query = query.Where(x => x.CreateDate >= param.CreateDate1);

            if (param.CreateDate1 == null && param.CreateDate2 != null)
                query = query.Where(x => x.CreateDate <= param.CreateDate2);


            if (param.DeliveryTime1 != null && param.DeliveryTime2 != null)
                query = query.Where(x => x.DeliveryTime >= param.DeliveryTime1 && x.DeliveryTime <= param.DeliveryTime2);

            if (param.DeliveryTime1 != null && param.DeliveryTime2 == null)
                query = query.Where(x => x.DeliveryTime >= param.DeliveryTime1);

            if (param.DeliveryTime1 == null && param.DeliveryTime2 != null)
                query = query.Where(x => x.DeliveryTime <= param.DeliveryTime2);



            var list = await query
                                .Include(x => x.OrderDetails)
                                .Include(x => x.Address)
                                .Include(x => x.Address.District)
                                .Include(x => x.Address.District.Region)
                                .Include(x => x.DeliveryType)
                                .Include(x => x.DrugStore)
                                .Include(x => x.OrderStatus)
                                .Include(x => x.Payment)
                                .Include(x => x.UserAgent)
                                .Select(x => new viOrder
                                {
                                    Id = x.Id,
                                    AddressId = x.AddressId,
                                    AddressName = x.Address.Description,
                                    RegionId = x.Address.RegionId,
                                    RegionName = x.Address.Region.Name,
                                    DistrictId = x.Address.DistrictId,
                                    DistrictName = x.Address.District.Name,
                                    Street = x.Address.Street,
                                    House = x.Address.House,
                                    Waymark = x.Address.Waymark,
                                    Flat = x.Address.Flat,
                                    Latitude = x.Address.Latitude,
                                    Longitude = x.Address.Longitude,

                                    DrugStoreId = x.DrugStoreId,
                                    DrugStoreName = x.DrugStore.Name,

                                    DeliveryTime = x.DeliveryTime,
                                    DeliveryTypeId = x.DeliveryTypeId,
                                    DeliveryTypeName = x.DeliveryType.Name,

                                    OrderStatusId = x.OrderStatusId,
                                    OrderStatusName = x.OrderStatus.Name,
                                    PaymentId = x.PaymentId,
                                    PaymentName = x.Payment.Name,

                                    UserAgentId = x.UserAgentId,
                                    UserAgentName = x.UserAgent.Name,

                                    CreateDate = x.CreateDate,
                                    CreateUser = x.CreateUser,
                                    Description = x.Description,
                                    Phone = x.Phone,
                                    Status = x.Status,
                                    OrderDetails = x.OrderDetails
                                                    .Select(t => new viOrderDetails
                                                    {
                                                        Id = t.Id,
                                                        ProductId = t.ProductId,
                                                        DrugName = t.Product.Drug.Name,
                                                        Qty = t.Qty,
                                                        Price = t.Price,
                                                        TotalSum = t.TotalSum

                                                    }).ToList()
                                })
                                .ToListAsync();

            if (list == null)
                return NotFound();

            return list;
        }


        [HttpPost("SetStatus")]
        [SwaggerOperation("Закази статусини узгартириш")]
        public async Task<IActionResult> SetStatusOrder(int id)
        {
            tbOrderHeader order;

            if (User.IsRoleAdmin())
            {   // Is User
                order = await ctx.tbOrders
                                      .Include(x => x.OrderDetails)
                                      .Where(x => x.CreateUser == User.GetId())
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
            }
            else
            {
                return NotFound();
            }
        }
    }
}
