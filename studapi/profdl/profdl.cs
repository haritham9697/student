using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using studapi.Models;
using System.Data.SqlClient;
using System.Data;

namespace studapi.profdl
{
    public class profdal
    {
        SqlConnection myconnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString);


        public List<professor> Getprofessor()
        {

            SqlConnection myconnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString);
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = myconnection;
            List<professor> lstprof = new List<Models.professor>();

            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "Select DeptID,Deptname,HODname from professor ";
            SqlDataReader reader = null;
            myconnection.Open();
            reader = sqlCmd.ExecuteReader();
            professor prof = null;
            while (reader.Read())
            {
                prof = new professor();
                prof.DeptID = Convert.ToInt32(reader.GetValue(0));
                prof.Deptname = reader.GetValue(1).ToString();
                prof.HODname = reader.GetValue(2).ToString();
                lstprof.Add(prof);
            }
            myconnection.Close();
            return lstprof;
        }
    }
}