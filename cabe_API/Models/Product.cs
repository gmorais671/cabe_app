using System.ComponentModel.DataAnnotations.Schema;

namespace cabe_API.Models
{
    [Table("products")]
    public class Product
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; } = string.Empty;

        [Column("description")]
        public string Description { get; set; } = string.Empty;

        [Column("cost_price")]
        public decimal CostPrice { get; set; } = 0.0m;

        [Column("selling_price")]
        public decimal SellingPrice { get; set; } = 0.0m;

        [Column("amount")]
        public int Amount { get; set; } = 0;
    }
}
