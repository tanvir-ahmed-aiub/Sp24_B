using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataFactory
    {
        public static IRepo<Student,int,bool> StudentData() {
            return new StudentRepoV2();
        }
        public static IRepo<Department, int, bool> DepartmentData() {
            return new DepartmentRepo();
        }
    }
}
