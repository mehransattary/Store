using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Models;

namespace Store.Models
{
    public class SuperCategory:BaseEntity
    {
     
        public string SuperCategoryName { get; set; }
        public string SuperCategoryIcon { get; set; }
        public string SuperCategoryPicture { get; set; }
        public string Link { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public ICollection<SuperCategory_Category> superCategory_category { get; set; }
    }
}
