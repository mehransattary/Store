using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Models
{
    public class SuperCategory_Category
    {
        [Key]
        public int SuperCategory_Category_Id { get; set; }
        public int SuperCategoryId { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey("SuperCategoryId")]
        public SuperCategory superCategory { get; set; }

        [ForeignKey("CategoryId")]
        public Category category { get; set; }
    }
}
