using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Data;
using WebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseholdController : ControllerBase
    {
        public readonly APIDbContext _context;

        public HouseholdController(APIDbContext context)
        {
            _context = context;
        }
        // GET: api/<HouseholdController>
        [HttpGet]
        public List<Household> Get()
        {
            return _context.Households.ToList();
        }

        // GET api/<HouseholdController>/5
        [HttpGet("{id}")]
        public Household GetById(int id)
        {
            var household = _context.Households.Where(a => a.HouseholdId == id).SingleOrDefault();
            return household;
        }

        // POST api/<HouseholdController>
        [HttpPost]
        public IActionResult Post([FromBody] Household household)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");
            household.CreatedDate = DateTime.Now;
            _context.Households.Add(household);
            _context.SaveChanges();
            return Ok();
        }

        // PUT api/<HouseholdController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Household household)
        {
            if (id != household.HouseholdId)
            {
                return BadRequest();
            }

            _context.Entry(household).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HouseholdExists(id))
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

        // DELETE api/<HouseholdController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var household = await _context.Households.FindAsync(id);
            if (household == null)
            {
                return NotFound();
            }

            _context.Households.Remove(household);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HouseholdExists(int id)
        {
            return _context.Households.Any(e => e.HouseholdId == id);
        }
    }
}
