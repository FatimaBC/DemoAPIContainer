using Microsoft.AspNetCore.Mvc;
using DemoAPIContainer.Models;
using Microsoft.EntityFrameworkCore;


namespace DemoAPIContainer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        List<Products> items = new List<Products>();

        [HttpGet]
        public IEnumerable<Products> Get()
        {


            //// inicializamos una instancia de movimiento
            //Products mov1 = new Products();
            //// inicializamos una lista de items dentro de la clase Movimiento
            //mov1.Items = new List<Sale>();

            //// ahora agregamos los MovimientoDto a la propiedad Items
            //mov1.Items.Add(new Sale
            //{
            //    SaleId = 1,
            //    Date = Convert.ToDateTime("2023-05-10 08:24:00.000"),
            //    Total = 15155
            //});

            //// y gregamos a la lista movimientos el movimiento y sus items
            //items.Add(mov1);

            //items.Add(new Products()
            //{
            //    ProductId = 1,
            //    Items = new List<Sale>()
            //});

            items.Add(new Products()
            {
                ProductId = 1,
                Items = new List<Sale>()
                    {
                     new Sale{  SaleId = 1, Date = Convert.ToDateTime("2024-05-10 08:00:00.000"), Total = 231554 }
                    }
            }
            );
            items.Add(new Products()
            {
                ProductId = 2,
                Items = new List<Sale>()
                        {
                         new Sale{  SaleId = 2, Date = Convert.ToDateTime("2024-06-13 08:00:00.000"), Total = 555466 }
                        }
            }
            );

            return items;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Products item)
        {
            items.Add(item);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Products item)
        {
            int index = items.FindIndex(i => i.Id == id);

            if (index != -1)
            {
                items[index] = item;
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int index = items.FindIndex(i => i.Id == id);

            if (index != -1)
            {
                items.RemoveAt(index);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}