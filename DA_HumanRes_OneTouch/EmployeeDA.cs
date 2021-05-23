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

    }
}
