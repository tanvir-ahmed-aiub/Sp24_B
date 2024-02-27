using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PMSDemo.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }
        public int C_Id { get; set; }
    }
}