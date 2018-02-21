using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using studapi.profbll;
using studapi.Models;

namespace studapi.Controllers
{
    public class professorController : ApiController
    {
        [HttpGet]
        [ActionName("Getprofessor")]
        public List<professor> Getprofessor()
        {
            profbal a = new profbal();
            return a.Getprofessor();

        }
    }
}
