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
                    SqlCommand cmdAddEmp = new SqlCommand("AddEmployee", conn);
                    cmdAddEmp.CommandType = System.Data.CommandType.StoredProcedure;

                    cmdAddEmp.Parameters.AddWithValue("@Name", emp.Name);
                    cmdAddEmp.Parameters.AddWithValue("@LastName", emp.Lastname);
                    cmdAddEmp.Parameters.AddWithValue("@Gender", emp.Gender);
                    cmdAddEmp.Parameters.AddWithValue("@Salary", emp.Salary);
                    cmdAddEmp.Parameters.AddWithValue("@BirthDate", emp.Birthdate);
                    cmdAddEmp.Parameters.AddWithValue("@Email", emp.Email);
                    cmdAddEmp.Parameters.AddWithValue("@Password", emp.Password);
                    cmdAddEmp.Parameters.AddWithValue("@RoleId", emp.RoleId);
                    cmdAddEmp.Parameters.AddWithValue("@LastUpdateByUserId", GlobalModel.UserId);
                    //cmdAddEmp.ExecuteNonQuery();

                    int InsertedId = -1;

                    using (SqlDataReader rdr = cmdAddEmp.ExecuteReader()) {
                        // iterate through results, printing each to console
                        while (rdr.Read()) {
                            InsertedId = int.Parse(rdr[0].ToString());
                        }
                    }

                    if (InsertedId == -1) {
                        throw new Exception("Something went wrong!");
                    }
                    SqlCommand cmdAddCV = new SqlCommand("AddCV", conn);
                    cmdAddCV.CommandType = System.Data.CommandType.StoredProcedure;
                    cmdAddCV.Parameters.AddWithValue("@UserId", InsertedId);
                    cmdAddCV.Parameters.AddWithValue("@LastUpdateByUserId", GlobalModel.UserId);
                    cmdAddCV.ExecuteNonQuery();

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
