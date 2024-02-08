using DemoAPIContainer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemoAPIContainer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SalesController : ControllerBase
    {

        // GET: api/Sales
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Sale>>> GetSales()
        //{
        //    return await _context.Sale.ToListAsync();
        //}

        //// GET: api/Sales/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Sale>> GetSale(int id)
        //{
        //    var sale = await _context.Sale.FindAsync(id);

        //    if (sale == null)
        //    {
        //        return NotFound();
        //    }

        //    return sale;
        //}

        //// PUT: api/Sales/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutSale(int id, Sale sale)
        //{
        //    if (id != sale.SaleId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(sale).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!SaleExists(id))
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

        //// POST: api/Sales
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Product>> PostSale(Sale sale)
        //{
        //    _context.Sale.Add(sale);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetSale", new { id = sale.SaleId }, sale);
        //}

        //// DELETE: api/Sales/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteSale(int id)
        //{
        //    var sale = await _context.Sale.FindAsync(id);
        //    if (sale == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Sale.Remove(sale);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}
        //private bool SaleExists(int id)
        //{
        //    return _context.Sale.Any(e => e.SaleId == id);
        //}
    }
}
