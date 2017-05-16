using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace OnlineStore.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public int Inventory { get; set; }
        public DateTime Today { get; set; } = DateTime.Now;
        public string SubCategory { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
