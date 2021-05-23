using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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
    }
}
