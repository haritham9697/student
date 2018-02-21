using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using studapi.DAL;
using studapi.Models;
using System.Web.Http;
using studapi.profdl;

namespace studapi.BLL
{
    public class studentbl
    {
        
       
        public void AddStudent(student stud)
        {
            studdl a = new studdl();
            a.AddStudent(stud);


        }
        public void DeleteStudentByID(int id)
        {
            studdl b = new studdl();
            b.DeleteStudentByID(id);
        }
        public List<student> GetStudentbydob()
        {
            studdl c = new studdl();
            return c.GetStudentbydob();
        }


    }
}
