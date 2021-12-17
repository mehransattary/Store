using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Store.Models
{
    public class Category_Property
    {
        public int CategoryPropertyId { get; set; }
        public int CategoryId { get; set; }
        public int PropertyId { get; set; }
        [ForeignKey("PropertyId")]
        public Property property { get; set; }
        [ForeignKey("CategoryId")]
        public Category category { get; set; }
    }
}
