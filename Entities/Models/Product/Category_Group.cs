using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Store.Models
{
    public class Category_Group
    {
        [Key]
        public int Category_Group_Id { get; set; }
        public int GroupId { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("GroupId")]
        public Group  group { get; set; }

        [ForeignKey("CategoryId")]
        public  Category  category { get; set; }

    }
}
