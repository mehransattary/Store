using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Store.Models
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string GroupPicture { get; set; }
        //***====================================================================================***//
        [Display(Name = "عنوان برای Title")]
        [MaxLength(200)]
        public string Group_Title_Meta { get; set; }
        //***====================================================================================***//
        [Display(Name = "کلمات کلیدی متا تگ")]
        [MaxLength(250)]
        public string Group_Keyword { get; set; }
        //***====================================================================================***//
        [Display(Name = "توضیحات متاتگ")]
        [MaxLength(250)]
        //***====================================================================================***//



        public string Group_Description_MetaTag { get; set; }
        public ICollection<Category_Group> category_group { get; set; }
        public ICollection<Product> products { get; set; }

    }
}
