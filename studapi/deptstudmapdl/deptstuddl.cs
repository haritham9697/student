using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using studapi.Models;
using System.Data.SqlTypes;

namespace studapi.deptstudmapdl
{
    public class deptstuddl
    {


        public List<deptstudmap> Getstud(int id)
        {

            SqlConnection myconnection = new SqlConnection();
            myconnection.ConnectionString=(System.Configuration.ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString);
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = myconnection;
            List<deptstudmap> stud = new List<Models.deptstudmap>();

            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select s.ID,s.Firstname,s.Lastname,s.Dateofbirth,p.DeptID,p.Deptname,p.HODname from students s  JOIN studdeptmap st on s.ID=st.ID JOIN professor p  on p.DeptID = st.DeptID where st.DeptID="+ id +"";
            SqlDataReader reader = null;
            myconnection.Open();
            reader = sqlCmd.ExecuteReader();
            deptstudmap deptstud = null;
            while (reader.Read())
            {
                deptstud = new deptstudmap();
                deptstud.ID = Convert.ToInt32(reader.GetValue(0));
                deptstud.Firstname = reader.GetValue(1).ToString();
                deptstud.Lastname = reader.GetValue(2).ToString();
                deptstud.Dateofbirth = reader.GetValue(3).ToString();
                deptstud.DeptID = Convert.ToInt32(reader.GetValue(4));
                deptstud.Deptname = reader.GetValue(5).ToString();
                deptstud.HODname = reader.GetValue(6).ToString();
                stud.Add(deptstud);
            }
            myconnection.Close();
            return stud;
        }
    }
}