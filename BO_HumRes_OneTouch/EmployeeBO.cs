using System;
using System.Collections.Generic;
using System.Text;

namespace BO_HumRes_OneTouch
{
    public class EmployeeBO : Base
    {
        private string _name;
        private string _lastName;
        private string _email;
        private string _password;
        private double _salary;

        public int EmployeeId { get; set; }
        public string Name
        {
            get { return _name; }
            set
            {
                if (value != "")
                {
                    _name = value;
                }
                else
                {
                    throw new Exception("Name cannot be empty!");
                }
            }
        }

        public string Lastname
        {
            get { return _lastName; }
            set
            {
                if (value != "")
                {
                    _lastName = value;
                }
                else
                {
                    throw new Exception("Last name cannot be empty!");
                }
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                if (value != "")
                {
                    _email = value;
                }
                else
                {
                    throw new Exception("Email cannot be empty!");
                }
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                if (value != "")
                {
                    _password = value;
                }
                else
                {
                    throw new Exception("Password cannot be empty!");
                }
            }
        }

        public double Salary
        {
            get { return _salary; }
            set
            {
                if (value > 0) // value nket rast osht 100
                {
                    _salary = value;
                }
                else
                {
                    throw new Exception("Salary cannot be empty!");
                }
            }
        }

        public DateTime Birthdate { get; set; }
        public string Gender { get; set; }
        public int RoleId { get; set; }

        public EmployeeBO(string name, double salary, string lastName, DateTime birthdate, string gender, string email, string password, int roleId)
        {

            //EmployeeId = employeeId;
            Name = name;
            Lastname = lastName;
            Birthdate = birthdate;
            Gender = gender;
            Email = email;
            Salary = salary;
            Password = password;
            RoleId = roleId;
        }
        public EmployeeBO(int id, string name, double salary, string lastName, DateTime birthdate, string gender, string email, string password, int roleId)
        {

            EmployeeId = id;
            Name = name;
            Lastname = lastName;
            Birthdate = birthdate;
            Gender = gender;
            Email = email;
            Salary = salary;
            Password = password;
            RoleId = roleId;
        }

    }
}
