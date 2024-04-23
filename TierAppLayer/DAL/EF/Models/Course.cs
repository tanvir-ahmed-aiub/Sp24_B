using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Dept")]
        public int DId { get; set; }
        public virtual Department Dept { get; set; }
    }
}
