using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TierAppLayer.Controllers
{
    public class StudentController : ApiController
    {
        [HttpPost]
        [Route("api/student/create")]
        public HttpResponseMessage Create(StudentDTO s) { 
            StudentService.Create(s);
            return Request.CreateResponse(HttpStatusCode.OK);
            
        }
        [HttpGet]
        [Route("api/student/all")]
        public HttpResponseMessage Get() {
            var data = StudentService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
