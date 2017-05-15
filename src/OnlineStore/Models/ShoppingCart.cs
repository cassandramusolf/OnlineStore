using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace OnlineStore.Models
{
    [Table("ShoppingCarts")]
    public class ShoppingCart
    {
        [Key]
        public int Id { get; set; }
        public int ProductCount { get; set; }
        public int ProductId { get; set; }
        public static DateTime Now { get; }
        public virtual Product Product { get; set; }
    }
}
