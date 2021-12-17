using Microsoft.EntityFrameworkCore;
using Store.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
           
    }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        // public DbSet<Seller> Sellers { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Category_Group> CategoryGrops { get; set; }
        public DbSet<Category_Property> CategoryProperties { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Product_Property> ProducProperties { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<SuperCategory> SuperCategories { get; set; }
        public DbSet<SuperCategory_Category> SuperCategoryCategories { get; set; }
        public DbSet<Value> values{ get; set; }
    }
}
