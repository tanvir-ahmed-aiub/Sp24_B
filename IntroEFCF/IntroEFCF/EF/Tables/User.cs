using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IntroEFCF.EF.Tables
{
    public class User
    {
        [Key]
        [Required]
        [StringLength(10)]
        public string Username { get; set; }
        [Required]
        [StringLength (10)]
        public string Password { get; set; }
        [Required,StringLength (100)]
        public string Name { get; set; }
    }
}