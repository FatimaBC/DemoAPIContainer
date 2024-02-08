using System.ComponentModel.DataAnnotations;

namespace DemoAPIContainer.Models
{
    public class Sale
    {

        [Key]
        public int SaleId { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
    }
}
