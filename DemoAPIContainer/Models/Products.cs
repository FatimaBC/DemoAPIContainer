using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DemoAPIContainer.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; } 
        public DateTime Date { get; set; }
        public string? Name { get; set; }
        public string? UnitPrice { get; set; }
        public decimal Cost { get; set; }

        public List<Sale>? Items { get; set; }

        public int Id { get; set; }
    }
}