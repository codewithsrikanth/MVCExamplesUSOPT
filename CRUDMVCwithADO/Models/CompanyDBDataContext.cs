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
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("select * from Employee", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
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
            DBOperations("sp_InsertRec", emp);
        }
        private void DBOperations(string spName, Employee emp)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(spName, con);
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
        public void UpdateEmployee(Employee emp)
        {
            DBOperations("sp_UpdateRec", emp);
        }
        public Employee GetEmployee(int id)
        {
            Employee emp = new Employee();
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("select * from Employee where Eno="+id,con);
                con.Open();
                SqlDataReader dr =  cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    if(dr.Read())
                    {
                        emp.Eno = Convert.ToInt32(dr["Eno"]);
                        emp.Ename = Convert.ToString(dr["Ename"]);
                        emp.Salary = Convert.ToDouble(dr["Salary"]);
                        emp.Job = Convert.ToString(dr["Job"]);
                        emp.Dname = Convert.ToString(dr["Dname"]);
                    }
                }
                con.Close();
            }
            return emp;
        }
        public void DeleteEmp(int eno)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_DeleteRec",con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@eno", eno);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}