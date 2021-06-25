using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DA_HumanRes_OneTouch;
using BO_HumRes_OneTouch;

namespace BL_HumanRes_OneTouch
{
    public class EmployeeBL
    {
        EmployeeDA empDA;
        public EmployeeBL()
        {
            empDA = new EmployeeDA();
        }

        public DataTable FillEmployeeTable()
        {
            return empDA.GetAllEmployee();
        }

        public EmployeeBO GetEmployeeById(int EmpId) {
            return empDA.GetEmployeeById(EmpId);
        }

        public ContractBO RetrieveContract(int userId) {
            return empDA.RetrieveContract(userId);
        }

        public DataTable LoadContracts() {
            return empDA.LoadContracts();
        }

        public bool AddSkill(Skills skills) {
            return empDA.addSkill(skills);
        }

        public DataTable FillHolidatsTableForEmployee(int userId) {
            return empDA.GetAllHolidaysForEmployee(userId);
        }

        public DataTable FillHolidatsTable()
        {
            return empDA.GetAllHolidays();
        }

        public CV GetCVByEmployeeId(int userId) {
            return empDA.GetCVByEmployeeId(userId);
        }

        public bool AddEducation(Education ed) {
            return empDA.AddEducation(ed);
        }

        public bool AddExperience(Experience ex) {
            return empDA.AddExperience(ex);
        }

        public bool AddContract(ContractBO contractBO) {
            return empDA.AddContract(contractBO);
        }

        public bool RequestHoliday(DateTime startDate, DateTime endDate, string description, int userId) {
            return empDA.RequestHoliday(startDate, endDate, description, userId);
        }

        public bool AddEmployee(EmployeeBO emp)
        {
            return empDA.InsertEmployee(emp);
        }

        public EmployeeBO Authenticate(string Email, string Password)
        {
            return empDA.Login(Email, Password);
        }

        public bool DeleteEmployee(int userId) {
            return empDA.DeleteEmployee(userId);
        }

        public bool SetHolidayStatus(int holidayId, string status) {
            return empDA.SetHolidayStatus(holidayId, status);
        }

        public bool EditProfile(EmployeeBO userId) {
            return empDA.EditProfile(userId);
        }
    }
}
