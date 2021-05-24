using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BO_HumRes_OneTouch;
using System.Text;

namespace DA_HumanRes_OneTouch
{
    public class EmployeeDA
    {
        public DataTable GetAllEmployee()
        {
            try
            {
                using (DbConnection.conn = new SqlConnection(DbConnection.conString))
                {
                    DbConnection.da = new SqlDataAdapter("AllEmployees", DbConnection.conn);
                    DataTable dTable = new DataTable();
                    DbConnection.da.Fill(dTable);

                    return dTable;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetAllHolidays()
        {
            try
            {
                using (DbConnection.conn = new SqlConnection(DbConnection.conString))
                {
                    DbConnection.da = new SqlDataAdapter("AllHolidays", DbConnection.conn);
                    DataTable dTable = new DataTable();
                    DbConnection.da.Fill(dTable);

                    return dTable;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool InsertEmployee(EmployeeBO emp)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConnection.conString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("AddEmployee", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Name", emp.Name);
                    cmd.Parameters.AddWithValue("@LastName", emp.Lastname);
                    cmd.Parameters.AddWithValue("@Gender", emp.Gender);
                    cmd.Parameters.AddWithValue("@Salary", emp.Salary);
                    cmd.Parameters.AddWithValue("@BirthDate", emp.Birthdate);
                    cmd.Parameters.AddWithValue("@Email", emp.Email);
                    cmd.Parameters.AddWithValue("@Password", emp.Password);
                    cmd.Parameters.AddWithValue("@RoleId", emp.RoleId);
                    cmd.Parameters.AddWithValue("@LastUpdateByUserId", GlobalModel.UserId);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public EmployeeBO Login(string email, string password)
        {
            DataSet ds;
            EmployeeBO emp;

            try
            {
                using (DbConnection.conn = new SqlConnection(DbConnection.conString))
                {
                    DbConnection.conn.Open();
                    DbConnection.cmd = new SqlCommand("Login", DbConnection.conn);
                    DbConnection.cmd.CommandType = CommandType.StoredProcedure;
                    DbConnection.cmd.Parameters.AddWithValue("@Email", email);
                    DbConnection.cmd.Parameters.AddWithValue("@Password", password);

                    DbConnection.da = new SqlDataAdapter(DbConnection.cmd);
                    ds = new DataSet();
                    DbConnection.da.Fill(ds);

                    int rId = int.Parse(Convert.ToString(ds.Tables[0].Rows[0]["Id"]));
                    string rName = Convert.ToString(ds.Tables[0].Rows[0]["Name"]);
                    string rLastName = Convert.ToString(ds.Tables[0].Rows[0]["LastName"]);
                    DateTime rBirthDate = DateTime.Parse(Convert.ToString(ds.Tables[0].Rows[0]["Birthdate"]));
                    string rEmail = Convert.ToString(ds.Tables[0].Rows[0]["Email"]);
                    string rGender = Convert.ToString(ds.Tables[0].Rows[0]["Gender"]);
                    float rSalary = float.Parse(Convert.ToString(ds.Tables[0].Rows[0]["Salary"]));
                    int rRoleId = int.Parse(Convert.ToString(ds.Tables[0].Rows[0]["RoleId"]));
                    emp = new EmployeeBO(rId, rName, rSalary, rLastName, rBirthDate, rGender, rEmail, null, rRoleId);

                    GlobalModel.Name = rName;
                    GlobalModel.LastName = rLastName;
                    GlobalModel.BirthDate = rBirthDate;
                    GlobalModel.Salary = rSalary;
                    GlobalModel.Gender = rGender;
                    GlobalModel.Email= rEmail;
                    return emp;


                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
