using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Store.Models
{
    public class Value
    {
        [Key]
        public int Id{ get; set; }
        public int value{ get; set; }

        [ForeignKey("PropertyId")]
        public Property property { get; set; }

        public int PropertyId { get; set; }

    }
}
