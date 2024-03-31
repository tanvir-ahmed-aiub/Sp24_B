using IntroAPI.DTO;
using IntroAPI.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntroAPI.Controllers
{
    public class DepartmentController : ApiController
    {
        Sp24_aEntities db = new Sp24_aEntities();
        [HttpGet]
        [Route("api/department/all")]
        public HttpResponseMessage GetAllDepartment() {
            var data = db.Departments.ToList();
            return Request.CreateResponse(HttpStatusCode.OK, Convert(data));
        }
        [HttpGet]
        [Route("api/department/{d_id}")]
        public HttpResponseMessage GetDept(int d_id) {
            var data = db.Departments.Find(d_id);
            var conv = Convert(data);
            return Request.CreateResponse(HttpStatusCode.OK, conv);

        }
        [HttpPost]
        [Route("api/department/create")]
        public HttpResponseMessage CreateDept(DepartmentDTO d) {
            var data = Convert(d);
            db.Departments.Add(data);
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.Accepted);
        }



        List<DepartmentDTO> Convert(List<Department> depts) { 
            var list = new List<DepartmentDTO>();
            foreach (var item in depts)
            {
                list.Add(Convert(item));
            }
            return list;
        }
        Department Convert(DepartmentDTO d) {
            return new Department { 
                Id = d.Id,
                Name = d.Name
            };
        }
        DepartmentDTO Convert(Department d)
        {
            return new DepartmentDTO
            {
                Id = d.Id,
                Name = d.Name
            };
        }
    }
}
