using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CRUDMVCwithADO.Models
{
    public class CompanyDBDataContext
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            using(SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("select * from Employee", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while(dr.Read())
                    {
                        Employee emp = new Employee();
                        emp.Eno = Convert.ToInt32(dr["Eno"]);
                        emp.Ename = Convert.ToString(dr["Ename"]);
                        emp.Salary = Convert.ToDouble(dr["Salary"]);
                        emp.Job = Convert.ToString(dr["Job"]);
                        emp.Dname = Convert.ToString(dr["Dname"]);
                        employees.Add(emp);
                    }
                }
                dr.Close();
                con.Close();
            }
            return employees;
        }
        public void InsertEmployee(Employee emp)
        {
            using(SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_InsertRec", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@eno", emp.Eno);
                cmd.Parameters.AddWithValue("@ename", emp.Ename);
                cmd.Parameters.AddWithValue("@job", emp.Job);
                cmd.Parameters.AddWithValue("@salary", emp.Salary);
                cmd.Parameters.AddWithValue("@dname", emp.Dname);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}