using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntroEFCF.EF.Tables
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        [ForeignKey("Ctg")]
        public int C_Id { get; set; }

        public virtual Category Ctg { get; set; }
    }
}