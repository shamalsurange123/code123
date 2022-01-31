using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mvc_poduct.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int CategoryID { get; set; }
        [Required]
        public string Category_Name { get; set; }


    }
}