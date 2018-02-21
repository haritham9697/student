using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using studapi.Models;
using System.Net.Http;
using System.Net;
using System.Web.Http;
using System.Data.SqlTypes;

namespace studapi.DAL
{
    public class studdl
    {
        SqlConnection myconnection = new SqlConnection();
                     
        public void AddStudent(student stud)
        {
            //int maxId = listEmp.Max(e => e.ID);  
            //employee.ID = maxId + 1;  
            //listEmp.Add(employee);  


            myconnection.ConnectionString = (System.Configuration.ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString);
            //SqlCommand sqlCmd = new SqlCommand("INSERT INTO tblEmployee (EmployeeId,Name,ManagerId) Values (@EmployeeId,@Name,@ManagerId)", myConnection);  
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO students (ID,Firstname,Lastname,Dateofbirth,Image) Values (@ID,@Firstname,@Lastname,@Dateofbirth,@Image)";
            sqlCmd.Connection = myconnection;


            sqlCmd.Parameters.AddWithValue("@ID", stud.ID);
            sqlCmd.Parameters.AddWithValue("@Firstname", stud.Firstname);
            sqlCmd.Parameters.AddWithValue("@Lastname", stud.Lastname);
            sqlCmd.Parameters.AddWithValue("@Dateofbirth", stud.Dateofbirth);
            sqlCmd.Parameters.AddWithValue("@Image", stud.Image);
            myconnection.Open();
            int rowInserted = sqlCmd.ExecuteNonQuery();
            myconnection.Close();
        }
        
        public void DeleteStudentByID(int id)
        {
            myconnection.ConnectionString = (System.Configuration.ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString);

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "delete from students where ID=" + id + "";
            sqlCmd.Connection = myconnection;
            myconnection.Open();
            int rowDeleted = sqlCmd.ExecuteNonQuery();
            myconnection.Close();
        }
        public List<student> GetStudentbydob()
        {
            myconnection.ConnectionString = (System.Configuration.ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString);
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = myconnection;
            List<student> lstStud = new List<Models.student>();
            int a;
            int b;
            int e;
            int d;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "Select ID,Firstname,Lastname,Dateofbirth,Image from students ";
            SqlDataReader reader = null;
            myconnection.Open();
            reader = sqlCmd.ExecuteReader();
            student stud = null;
            while (reader.Read())
            {
                stud = new student();
                stud.ID = Convert.ToInt32(reader.GetValue(0));
                stud.Firstname = reader.GetValue(1).ToString();
                stud.Lastname = reader.GetValue(2).ToString();
                stud.Dateofbirth = reader.GetValue(3).ToString();
                stud.Image = reader.GetValue(4).ToString();
                lstStud.Add(stud);
            }
            myconnection.Close();
            return lstStud;

        }



    }
        }
