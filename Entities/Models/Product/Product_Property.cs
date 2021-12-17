using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Store.Models
{
    public class Product_Property
    {
        [Key]
        public int ProductPropertyId;
        public int ProductId { get; set; }
        public int PropertyId { get; set; }

        [ForeignKey("ProductId")]
        public Product product{ get; set; }

        [ForeignKey("PropertyId")]
        public Property Property { get; set; }
    }
}
