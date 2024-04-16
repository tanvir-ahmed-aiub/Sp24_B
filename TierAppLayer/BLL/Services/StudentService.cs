using BLL.DTOs;
using DAL.EF.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class StudentService
    {
        public static void Create(StudentDTO s) {
            //conversion to ef model
            var sm = new Student(); //converted ef model
            new StudentRepo().Create(sm);
        }
        public static List<StudentDTO> Get() {
            var data = new StudentRepo().Get();
            //convert ef model to dto
            var d2 = new List<StudentDTO>(); //converted data
            return d2;
        }
    }
}
