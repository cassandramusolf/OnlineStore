using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace OnlineStore.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public DateTime Today { get; set; } = DateTime.Now;
        public decimal PriceTotal { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
