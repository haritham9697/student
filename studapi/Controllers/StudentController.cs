using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using studapi.BLL;
using studapi.Models;
using studapi.profbll;


namespace studapi.Controllers
{
    public class StudentController : ApiController
    {
        
        [HttpPost]
        public void AddStudent(student stud)
        {
            studentbl b = new studentbl();
            b.AddStudent(stud);

        }
        [HttpDelete]
        [ActionName("Deletestudent")]
        public void DeleteStudentByID(int id)
        {
            studentbl c = new studentbl();
            c.DeleteStudentByID(id);
        }
        [HttpGet]
        [ActionName ("Getstudentsbydob")]
        public List<student> GetStudentbydob()
        {
            studentbl e = new studentbl();
            return e.GetStudentbydob();
        }



    }
}
