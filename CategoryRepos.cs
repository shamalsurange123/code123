using mvc_poduct.Data;
using mvc_poduct.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvc_poduct.Generic_Repos
{
    public class CategoryRepos:GenericRepository<Category>
    {
        CatgoryDbContext dbContext = new CatgoryDbContext();
      
    }
}