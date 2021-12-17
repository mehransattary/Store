using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Store.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public int ProductNumber { get; set; }
        public string ProductName{ get; set; }
        public string ProductPicture{ get; set; }
        public float ProductPrice{ get; set; }
        public float AfterDiscountPrice{ get; set; }
        public float PriceForMajorSeller{ get; set; }

        //0:available ,1:soldOut 
        public int Status { get; set; }
        public int GroupId { get; set; }
        [ForeignKey("GroupId")]
        public Group group { get; set; }
        public ICollection<Brand> brands { get; set; }
        public ICollection<Product_Property> product_property { get; set; }

    }
}
