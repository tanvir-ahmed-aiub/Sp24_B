using DAL.EF;
using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class DepartmentRepo :Repo, IRepo<Department, int, bool>
    {
        public void Create(Department obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Department Get(int id)
        {
            return db.Departments.Find(id);
        }

        public List<Department> Get()
        {
            return db.Departments.ToList();
        }

        public bool Update(Department obj)
        {
            throw new NotImplementedException();
        }
    }
}
