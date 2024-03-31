using IntroAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntroAPI.Controllers
{
    public class HomeController : ApiController
    {
        public HttpResponseMessage Get() {
            string[] names = { "tanvir","sabbir","karim"};
            return Request.CreateResponse(HttpStatusCode.OK,names);
        }
        public HttpResponseMessage Post() {
            var p = new Person() { Id=1,Name="tanvir"};
            return Request.CreateResponse(HttpStatusCode.OK,p);
        }
    }
}
