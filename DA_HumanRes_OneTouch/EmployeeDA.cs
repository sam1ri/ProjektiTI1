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

        public ContractBO RetrieveContract(int userId) {
            try {
                ContractBO contract = null;
                using (SqlConnection conn = new SqlConnection(DbConnection.conString)) {
                    conn.Open();
                    SqlCommand cmdAddEmp = new SqlCommand("GetContractByEmployeeId", conn);
                    cmdAddEmp.CommandType = System.Data.CommandType.StoredProcedure;

                    cmdAddEmp.Parameters.AddWithValue("@UserId", userId);

                    using (SqlDataReader rdr = cmdAddEmp.ExecuteReader()) {
                        // iterate through results, printing each to console

                        contract = new ContractBO();
                        if (rdr.Read()) {
                            contract.JobTitle = rdr["Title"].ToString();
                            contract.Description = rdr["Description"].ToString();
                            contract.UserName = rdr["Name"].ToString();
                            contract.UserLastName = rdr["LastName"].ToString();
                            contract.StartDate = Convert.ToDateTime(rdr["CreatedAt"].ToString());
                            contract.EndDate = Convert.ToDateTime(rdr["ExpiresAt"].ToString());
                        }
                    }

                }
                return contract;
            }
            catch (Exception ex) {
                return null;
            }
        }

        public bool addSkill(Skills skills) {
            try {
                using (SqlConnection conn = new SqlConnection(DbConnection.conString)) {
                    conn.Open();
                    SqlCommand cmdAddEmp = new SqlCommand("AddSkill", conn);
                    cmdAddEmp.CommandType = System.Data.CommandType.StoredProcedure;

                    cmdAddEmp.Parameters.AddWithValue("@Name", skills.Name);
                    cmdAddEmp.Parameters.AddWithValue("@CVId", skills.CVId);
                    cmdAddEmp.Parameters.AddWithValue("@LastUpdateByUserId", GlobalModel.UserId);
                    if (cmdAddEmp.ExecuteNonQuery() <= 0) {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception exx) {
                return false;
            }
        }

        public bool AddExperience(Experience ex) {
            try {
                using (SqlConnection conn = new SqlConnection(DbConnection.conString)) {
                    conn.Open();
                    SqlCommand cmdAddEmp = new SqlCommand("AddExperience", conn);
                    cmdAddEmp.CommandType = System.Data.CommandType.StoredProcedure;

                    cmdAddEmp.Parameters.AddWithValue("@CVId", ex.CVId);
                    cmdAddEmp.Parameters.AddWithValue("@RoleName", ex.RoleName);
                    cmdAddEmp.Parameters.AddWithValue("@CompanyName", ex.CompanyName);
                    cmdAddEmp.Parameters.AddWithValue("@Description", ex.Description);
                    cmdAddEmp.Parameters.AddWithValue("@StartDate", ex.StartDate);
                    cmdAddEmp.Parameters.AddWithValue("@EndDate", ex.EndDate);
                    cmdAddEmp.Parameters.AddWithValue("@LastUpdateByUserId", GlobalModel.UserId);
                    if (cmdAddEmp.ExecuteNonQuery() <= 0) {
                        return false;
                    }   
                }
                return true;
            }
            catch (Exception exx) {
                return false;
            }
        }

        public bool AddEducation(Education ed) {
            try {
                using (SqlConnection conn = new SqlConnection(DbConnection.conString)) {
                    conn.Open();
                    SqlCommand cmdAddEmp = new SqlCommand("AddEducation", conn);
                    cmdAddEmp.CommandType = System.Data.CommandType.StoredProcedure;

                    cmdAddEmp.Parameters.AddWithValue("@CVId", ed.CVId);
                    cmdAddEmp.Parameters.AddWithValue("@Name", ed.Name);
                    cmdAddEmp.Parameters.AddWithValue("@InstituteName", ed.InstituteName);
                    cmdAddEmp.Parameters.AddWithValue("@Location", ed.Location);
                    cmdAddEmp.Parameters.AddWithValue("@StartDate", ed.StartDate);
                    cmdAddEmp.Parameters.AddWithValue("@EndDate", ed.EndDate);
                    cmdAddEmp.Parameters.AddWithValue("@LastUpdateByUserId", GlobalModel.UserId);
                    if (cmdAddEmp.ExecuteNonQuery() <= 0) {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }

        public DataTable LoadContracts() {
            try {
                using (DbConnection.conn = new SqlConnection(DbConnection.conString)) {
                    DbConnection.da = new SqlDataAdapter("AllContracts", DbConnection.conn);
                    DataTable dTable = new DataTable();
                    DbConnection.da.Fill(dTable);

                    return dTable;
                }
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public bool AddContract(ContractBO contractBO) {
            try {
                using (SqlConnection conn = new SqlConnection(DbConnection.conString)) {
                    conn.Open();
                    SqlCommand cmdAddEmp = new SqlCommand("AddContract", conn);
                    cmdAddEmp.CommandType = System.Data.CommandType.StoredProcedure;

                    cmdAddEmp.Parameters.AddWithValue("@StartsAt", contractBO.StartDate);
                    cmdAddEmp.Parameters.AddWithValue("@ExpiresAt", contractBO.EndDate);
                    cmdAddEmp.Parameters.AddWithValue("@IssuedByUserId", contractBO.CreatedByUser);
                    cmdAddEmp.Parameters.AddWithValue("@IssuedToUserEmail", contractBO.EmployeeEmail);
                    cmdAddEmp.Parameters.AddWithValue("@Title", contractBO.JobTitle);
                    cmdAddEmp.Parameters.AddWithValue("@Description", contractBO.Description);
                    cmdAddEmp.Parameters.AddWithValue("@LastUpdateByUserId", contractBO.UpdatedByUser);
                    if (cmdAddEmp.ExecuteNonQuery() <= 0) {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }

        public bool SetHolidayStatus(int holidayId, string status) {
            //SetHolidayStatus
            try {
                using (SqlConnection conn = new SqlConnection(DbConnection.conString)) {
                    conn.Open();
                    SqlCommand cmdAddEmp = new SqlCommand("SetHolidayStatus", conn);
                    cmdAddEmp.CommandType = System.Data.CommandType.StoredProcedure;
                    cmdAddEmp.Parameters.AddWithValue("@Id", holidayId);
                    cmdAddEmp.Parameters.AddWithValue("@Status", status);
                    if (cmdAddEmp.ExecuteNonQuery() <= 0) {
                        return false;
                    }

                }
                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }

        public CV GetCVByEmployeeId(int userId) {
            CV cv = new CV();

            try {
                using (SqlConnection conn = new SqlConnection(DbConnection.conString)) {
                    conn.Open();
                    SqlCommand cmdAddEmp = new SqlCommand("GetCVByEmployeeId", conn);
                    cmdAddEmp.CommandType = System.Data.CommandType.StoredProcedure;
                    cmdAddEmp.Parameters.AddWithValue("@UserId", userId);

                    using (SqlDataReader rdr = cmdAddEmp.ExecuteReader()) {
                        // iterate through results, printing each to console

                        if (rdr.Read()) {
                            cv.Id = int.Parse(rdr["Id"].ToString());
                            cv.UserId = int.Parse(rdr["UserId"].ToString());
                        }
                        else {
                            return null;
                        }
                    }

                    SqlCommand cmd2 = new SqlCommand("GetExperienceByCvId", conn);
                    cmd2.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@CVId", cv.Id);

                    using (SqlDataReader rdr = cmd2.ExecuteReader()) {
                        // iterate through results, printing each to console
                        cv.experience = new List<Experience>();
                        while (rdr.Read()) {
                            cv.experience.Add(new Experience() {
                                Id = int.Parse(rdr["Id"].ToString()),
                                CVId = int.Parse(rdr["CVId"].ToString()),
                                RoleName = rdr["RoleName"].ToString(),
                                CompanyName = rdr["CompanyName"].ToString(),
                                Description = rdr["Description"].ToString(),
                                StartDate = Convert.ToDateTime(rdr["StartDate"].ToString()),
                                EndDate = Convert.ToDateTime(rdr["EndDate"].ToString())

                            });
                        }
                    }


                    SqlCommand cmd3 = new SqlCommand("GetEducationByCvId", conn);
                    cmd3.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd3.Parameters.AddWithValue("@CVId", cv.Id);

                    using (SqlDataReader rdr = cmd3.ExecuteReader()) {
                        // iterate through results, printing each to console
                        cv.education = new List<Education>();
                        while (rdr.Read()) {
                            cv.education.Add(new Education() {
                                Id = int.Parse(rdr["Id"].ToString()),
                                CVId = int.Parse(rdr["CVId"].ToString()),
                                Name = rdr["Name"].ToString(),
                                InstituteName = rdr["InstituteName"].ToString(),
                                Location = rdr["Location"].ToString(),
                                StartDate = Convert.ToDateTime(rdr["StartDate"].ToString()),
                                EndDate = Convert.ToDateTime(rdr["EndDate"].ToString())
                            });
                        }
                    }


                    SqlCommand cmd4 = new SqlCommand("GetSkillsByCvId", conn);
                    cmd4.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd4.Parameters.AddWithValue("@CVId", cv.Id);

                    using (SqlDataReader rdr = cmd4.ExecuteReader()) {
                        // iterate through results, printing each to console
                        cv.skills = new List<Skills>();
                        while (rdr.Read()) {
                            cv.skills.Add(new Skills() {
                                Id = int.Parse(rdr["Id"].ToString()),
                                CVId = int.Parse(rdr["CVId"].ToString()),
                                Name = rdr["Name"].ToString()
                            });
                        }
                    }




                    return cv;




                }
                return null;
            }
            catch (Exception ex) {
                return null;
            }

        }

        public bool RequestHoliday(DateTime startDate, DateTime endDate, string description, int userId) {
            try {
                using (SqlConnection conn = new SqlConnection(DbConnection.conString)) {
                    conn.Open();
                    SqlCommand cmdAddEmp = new SqlCommand("RequestHoliday", conn);
                    cmdAddEmp.CommandType = System.Data.CommandType.StoredProcedure;

                    cmdAddEmp.Parameters.AddWithValue("@UserId", userId);
                    cmdAddEmp.Parameters.AddWithValue("@Description", description);
                    cmdAddEmp.Parameters.AddWithValue("@startDate", startDate);
                    cmdAddEmp.Parameters.AddWithValue("@endDate", endDate);
                    if (cmdAddEmp.ExecuteNonQuery() <= 0) {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }

        public DataTable GetAllHolidaysForEmployee(int userId) {
            try {
                using (DbConnection.conn = new SqlConnection(DbConnection.conString)) {
                    DbConnection.da = new SqlDataAdapter("SELECT h.StartDate, h.EndDate, u.Name, u.LastName, h.Description, h.InsertDate, h.Status FROM HolidayRequest as h INNER JOIN Users as u on u.Id = h.IssuedForUserId WHERE h.IssuedForUserId = @UserId", DbConnection.conn);
                    DbConnection.da.SelectCommand.Parameters.AddWithValue("@UserId", userId);
                    DataTable dTable = new DataTable();
                    DbConnection.da.Fill(dTable);

                    return dTable;
                }
            }
            catch (Exception ex) {
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

        public bool EditProfile(EmployeeBO user) {
            try {
                using (SqlConnection conn = new SqlConnection(DbConnection.conString)) {
                    conn.Open();
                    SqlCommand cmdAddEmp = new SqlCommand("UpdateEmployeeById", conn);
                    cmdAddEmp.CommandType = System.Data.CommandType.StoredProcedure;

                    cmdAddEmp.Parameters.AddWithValue("@Id", user.EmployeeId);
                    cmdAddEmp.Parameters.AddWithValue("@FirstName", user.Name);
                    cmdAddEmp.Parameters.AddWithValue("@LastName", user.Lastname);
                    cmdAddEmp.Parameters.AddWithValue("@Gender", user.Gender);
                    cmdAddEmp.Parameters.AddWithValue("@Salary", user.Salary);
                    cmdAddEmp.Parameters.AddWithValue("@Email", user.Email);
                    if (cmdAddEmp.ExecuteNonQuery() > 0) {
                        return true;
                    }


                }
                return false;
            }
            catch (Exception ex) {
                return false;
            }
        }

        public bool DeleteEmployee(int userId) {
            try {
                using (SqlConnection conn = new SqlConnection(DbConnection.conString)) {
                    conn.Open();
                    SqlCommand cmdAddEmp = new SqlCommand("DeleteEmployeeById", conn);
                    cmdAddEmp.CommandType = System.Data.CommandType.StoredProcedure;

                    cmdAddEmp.Parameters.AddWithValue("@UserId", userId);

                    if (cmdAddEmp.ExecuteNonQuery() > 0) {
                        return true;
                    }
                    
                }
                return false ;
            }
            catch (Exception ex) {
                return false;
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

        public EmployeeBO GetEmployeeById(int id) {
            try {
                EmployeeBO employee = null;
                using (SqlConnection conn = new SqlConnection(DbConnection.conString)) {
                    conn.Open();
                    SqlCommand cmdAddEmp = new SqlCommand("GetEmployeeById", conn);
                    cmdAddEmp.CommandType = System.Data.CommandType.StoredProcedure;

                    cmdAddEmp.Parameters.AddWithValue("@Id", id);

                    using (SqlDataReader rdr = cmdAddEmp.ExecuteReader()) {
                        // iterate through results, printing each to console

                        employee = new EmployeeBO();
                        if (rdr.Read()) {
                            employee.EmployeeId = int.Parse(rdr["Id"].ToString());
                            employee.Name = rdr["Name"].ToString();
                            employee.Salary = float.Parse(rdr["Salary"].ToString());
                            employee.Lastname = rdr["LastName"].ToString();
                            employee.Gender = rdr["Gender"].ToString();
                            employee.Email = rdr["Email"].ToString();
                        }
                    }

                }
                return employee;
            }
            catch (Exception ex) {
                return null;
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

                    GlobalModel.UserId = emp.EmployeeId;
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
