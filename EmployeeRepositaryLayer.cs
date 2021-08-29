using EmployeeDb.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EmployeeDb.RepositaryLayer
{
    public class EmployeeRepositaryLayer
    {
        public List<EmployeeModel> GetEmployeeData()
        {
            List<EmployeeModel> employeeModels = new List<EmployeeModel>();
            EmployeeModel employeeModel = new EmployeeModel();
            SqlConnection con = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con = new SqlConnection(connectionString);
                con.Open();
                string query = "select * from EmployeeDb";
                SqlCommand cm = new SqlCommand(query, con);
                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    employeeModel = new EmployeeModel();
                    employeeModel.Id = Convert.ToInt32(sdr["Id"]);
                    employeeModel.FirstName = Convert.ToString(sdr["FirstName"]);
                    employeeModel.LastName = Convert.ToString(sdr["LastName"]);
                    employeeModel.EmailId = Convert.ToString(sdr["EmailId"]);
                    employeeModel.Active = Convert.ToInt32(sdr["Active"]);
                    employeeModels.Add(employeeModel);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            };
            return employeeModels;
        }
        public string SaveEmployeeData(EmployeeModel  employee)
        {

            try
            {
                SqlConnection con = new SqlConnection("data source=.; database=Stories;integrated security=SSPI");
                con.Open();
                SqlCommand cm = new SqlCommand("insert into EmployeeDb values(" + employee.Id + ", '" + employee.FirstName + "'," +
                    "'" + employee.LastName + "','" + employee.EmailId + "', '" + employee.Active + "');", con);
                SqlDataReader dr = cm.ExecuteReader();
            }
            catch (Exception ex)
            {

            }
            return " insert data sucessfully";
        }

        public string UpdateEmployeeData(EmployeeModel employee)
        {
            try
            {
                SqlConnection con = new SqlConnection("data source=.;database=Stories;integrated security=SSPI");
                con.Open();
                SqlCommand cm = new SqlCommand("update EmployeeDb set  FirstName='" + employee.FirstName + "',LastName='" + employee.LastName + "',EmailId='" + employee.EmailId + "',Active=" + employee.Active + " where Id=" + employee.Id + "", con);
                cm.ExecuteNonQuery();

            }

            catch (Exception ex)
            {
                Console.WriteLine("ex.error");
            }

            return "updated";
        }

        public string DeleteEmployeeData(int Id)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source =.;database=Stories;integrated security=SSPI");
                con.Open();
                string query = "delete from EmployeeDb where Id =  " + Id + "";
                SqlCommand cm = new SqlCommand(query, con);
                SqlDataReader dr = cm.ExecuteReader();
            }

            catch (Exception ex)
            {
                Console.WriteLine("ex.error");
            }
            return "deleted";

        }
    }
}
    
