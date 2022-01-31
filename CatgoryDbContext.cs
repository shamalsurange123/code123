using mvc_poduct.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvc_poduct.Data
{
    public class CatgoryDbContext:DbContext
    {
        public CatgoryDbContext():base("Om")
        {

        }
        public DbSet<Category> category { get; set; }
        public DbSet<Product> product { get; set; }

    }
}