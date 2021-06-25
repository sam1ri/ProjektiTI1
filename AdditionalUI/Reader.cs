using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionalUI {
    class Reader {

        public List<EmployeeReportBO> GetSalaryReport() {
            try {
                using (SqlConnection conn = new SqlConnection(DbConnection.conString)) {
                    conn.Open();
                    SqlCommand cmdAddEmp = new SqlCommand("EmployeeWageReport", conn);
                    cmdAddEmp.CommandType = System.Data.CommandType.StoredProcedure;
                    List<EmployeeReportBO> emp = new List<EmployeeReportBO>();
                    using (SqlDataReader rdr = cmdAddEmp.ExecuteReader()) {
                        // iterate through results, printing each to console
                        while (rdr.Read()) {
                            emp.Add(new EmployeeReportBO() 
                                { 
                                    Name = rdr.GetString(0),
                                    LastName = rdr.GetString(1),
                                    Salary = rdr.GetDouble(2)
                                }
                            );
                        }
                    }
                    if (emp.Count > 0) {
                        return emp;
                    }
                    return null;
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Something wrong happened!");
                return null;
            }
        }

    }
}
