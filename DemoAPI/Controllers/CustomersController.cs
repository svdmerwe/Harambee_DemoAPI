﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EFDataAccessLibrary.DataAccess;
using EFDataAccessLibrary.Models;

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly DemoDataContext _context;
        private readonly log4net.ILog log;

        public CustomersController(DemoDataContext context)
        {
            _context = context;
            log = Program.log;
        }

        // GET: api/Customers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomer()
        {
            try
            {
                log.Info("api/Customer: Executed");
                return await _context.Customer.ToListAsync();
            }
            catch (Exception ex)
            {
                log.Error($"api/Customer: {ex.Message}");
                return BadRequest();
            }            
        }

        // GET: api/Customers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomer(int id)
        {
            log.Info("api/Customer/{id}: Executed");
            var customer = await _context.Customer.FindAsync(id);

            if (customer == null)
            {
                log.Error("api/Customer/{id}: Customer Object is null");
                return NotFound();
            }

            return customer;
        }

        // POST: api/Customers
        [HttpPost]
        public async Task<ActionResult<Customer>> PostCustomer(Customer customer)
        {
            log.Info("api/Customer - Post: Executed");

            log.Info("api/Customer - Post: Save Customer to DBContext");
            _context.Customer.Add(customer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomer", new { id = customer.Id }, customer);
        }


        #region Code Generated by Scaffolding Tool - Not Needed for Demo
        //// PUT: api/Customers/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutCustomer(int id, Customer customer)
        //{
        //    if (id != customer.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(customer).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!CustomerExists(id))
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



        //// DELETE: api/Customers/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteCustomer(int id)
        //{
        //    var customer = await _context.Customer.FindAsync(id);
        //    if (customer == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Customer.Remove(customer);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool CustomerExists(int id)
        //{
        //    return _context.Customer.Any(e => e.Id == id);
        //} 
        #endregion
    }
}
