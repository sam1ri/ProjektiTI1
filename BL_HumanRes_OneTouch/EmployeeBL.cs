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

        public DataTable FillHolidatsTable()
        {
            return empDA.GetAllHolidays();
        }

        public bool AddEmployee(EmployeeBO emp)
        {
            return empDA.InsertEmployee(emp);
        }

        public EmployeeBO Authenticate(string Email, string Password)
        {
            return empDA.Login(Email, Password);
        }

    }
}
