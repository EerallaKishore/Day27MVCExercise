using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day27MVCExercise.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int Sku_No { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }

        public decimal price { get; set; }
        public bool isavailable { get; set; }

        public DateTime CreatedDate { get; set; }= DateTime.Now;

        public Category Category { get; set; }  
         public int CategoryId { get; set; }


    }
}