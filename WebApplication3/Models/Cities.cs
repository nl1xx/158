using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Cities
    {
        [Key]
         public int ID { get; set; }
         public string Name { get; set; }
        public decimal Price { get; set; }
         public string Description { get; set; }
         public int? CategoryID { get; set; }
         public virtual Category Category { get; set; }
    }
}