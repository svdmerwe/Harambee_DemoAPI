using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EFDataAccessLibrary.DataAccess;
using EFDataAccessLibrary.Models;
using EFDataAccessLibrary.DataProcessors;

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly DemoDataContext _context;
        private readonly log4net.ILog log;

        public OrdersController(DemoDataContext context)
        {
            _context = context;
            log = Program.log;
        }

        // GET: api/Orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrder()
        {
            log.Info("api/Orders: Executed");

            //return await _context.Order.ToListAsync();
            await _context.Basket.Include(p => p.BasketItems).ToListAsync();
            return await _context.Order.Include(p => p.Basket).ToListAsync();
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
            log.Info("api/Orders/{id}: Executed");
            //var order = await _context.Order.FindAsync(id);
            var order = await _context.Order.Include(o => o.Basket).Where(o => o.Id == id).FirstOrDefaultAsync();

            if (order == null)
            {
                log.Error("api/Orders: Order object is null");
                return NotFound();
            }

            return order;
        }

        // POST: api/Orders
        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(Order order)
        {
            try
            {
                log.Info("api/Orders - Post: Executed");

                //SVDM - Use static method to validate and create the order
                log.Info("api/Orders - Post: Executed");
                Order newOrder = OrderProcessor.CreateOrder(order, _context);

                log.Info("api/Orders - Post: Add newOrder to DBContext");
                _context.Order.Add(newOrder);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetOrder", new { id = order.Id }, order);
            }
            catch (Exception ex)
            {
                log.Error($"api/Orders - Post: {ex.Message}");
                return BadRequest();
            }
        }

        #region Code Generated by Scaffolding Tool - Not Needed for Demo
        //// PUT: api/Orders/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutOrder(int id, Order order)
        //{
        //    if (id != order.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(order).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!OrderExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// DELETE: api/Orders/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteOrder(int id)
        //{
        //    var order = await _context.Order.FindAsync(id);
        //    if (order == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Order.Remove(order);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //} 

        //private bool OrderExists(int id)
        //{
        //    return _context.Order.Any(e => e.Id == id);
        //}
        #endregion
    }
}
