using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Models;

namespace Store.Models
{
    public class Category : BaseEntity
    {

        public string Category_CategoryName { get; set; }
        public string Category_CategoryPicture { get; set; }
        public string Category_ShortDescription { get; set; }
        public string Category_Description { get; set; }
        public string Category_Link { get; set; }
        public string Category_IsShow { get; set; }
        public string Category_Order { get; set; }
        //***====================================================================================***//
        [Display(Name = " عنوان دوم")]
        [MaxLength(200)]    
        public string Category_Title_Second { get; set; }
        //***====================================================================================***//
        [Display(Name = "عنوان برای Title")]
        [MaxLength(200)]
        public string Category_Title_Meta { get; set; }
        //***====================================================================================***//
        [Display(Name = "کلمات کلیدی متا تگ")]
        [MaxLength(250)]
        public string Category_Keyword { get; set; }
        //***====================================================================================***//
        [Display(Name = "توضیحات متاتگ")]
        [MaxLength(250)]
        public string Category_Description_MetaTag { get; set; }


        public ICollection<SuperCategory_Category> superCategory_category { get; set; }
        public ICollection<Category_Group> category_group { get; set; }
        public ICollection<Category_Property> category_property { get; set; }

    }
}
