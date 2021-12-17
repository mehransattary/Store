using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Store.Models
{
    public class Property
    {
        [Key]
        public int PropertyId { get; set; }
        public String PropertyName { get; set; }
        public String ProductColor { get; set; }
        public String ProductSize { get; set; }

        public ICollection<Product_Property> product_property { get; set; }
        public ICollection<Value> value { get; set; }
    }
}
