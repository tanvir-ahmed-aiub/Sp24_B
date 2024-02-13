using FormSubmission.Annotation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormSubmission.Models
{
    public class Person
    {
        [Required(ErrorMessage ="Please provide name")]
        [StringLength(10,ErrorMessage ="Name must be less than 10")]
        
        public string Name { get; set; }
        [Required]
        [StringLength(5,MinimumLength =2)]
        public string Username { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Profession { get; set; }
        [Required]
        [ValidateRoll]
        public int Roll { get; set; }
        [Required]
        public string[] Hobbies { get; set; }
    }
}