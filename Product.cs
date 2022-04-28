using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace task_product.Models
{
    public class Product
    {
        [Key]
        [Required]
        public int Prodid { get; set; }
        public string Prodname { get; set; }
        public int price { get; set; }
        public DateTime Datemanu { get; set; }
    }
}
