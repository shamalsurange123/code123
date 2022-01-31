using mvc_poduct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_poduct.Generic_Repos
{
   
    public class ProductRepos:GenericRepository<Product>
    {
        CategoryRepos categoryRepos = new CategoryRepos();

        
    }
}