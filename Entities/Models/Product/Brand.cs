using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Store.Models
{
    public class Brand
    {
        [Key]
        public int BrandId { get; set; }
        public int BrandName { get; set; }

        [ForeignKey("ProductId")]
        public Product product { get; set; }
        public int ProductId { get; set; }
    }
}
