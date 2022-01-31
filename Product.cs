using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mvc_poduct.Models
{
    public class Product
    {
        [Key]
        [Required]
        public int Product_Id { get; set; }
        [Required]
        public string Product_Name { get; set; }
        [Required]
        public double Product_Price { get; set; }

        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public Category Category { get; set; }
    }
}