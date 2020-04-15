using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;
using UniPos.Models;

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

        // GET: api/Orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<tbOrderHeader>>> GettbOrders()
        {
            return await _context.tbOrders.ToListAsync();
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<tbOrderHeader>> GettbOrder(int id)
        {
            var tbOrder = await _context.tbOrders.FindAsync(id);

            if (tbOrder == null)
            {
                return NotFound();
            }

            return tbOrder;
        }

        // PUT: api/Orders/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
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

        // POST: api/Orders
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<tbOrderHeader>> PosttbOrder(tbOrderHeader tbOrder)
        {
            _context.tbOrders.Add(tbOrder);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GettbOrder", new { id = tbOrder.Id }, tbOrder);
        }

        // DELETE: api/Orders/5
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
