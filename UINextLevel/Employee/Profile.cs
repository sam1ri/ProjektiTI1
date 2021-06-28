using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BL_HumanRes_OneTouch;
using BO_HumRes_OneTouch;

namespace UI_HumRes_OneTouch.Employee
{
    public partial class Profile : Form
    {

        public int UserId { get; set; }
        public int role { get; set; }
        public HR.Employees emp;

        public Profile(int role)
        {
            InitializeComponent();
            LoadProfile(GlobalModel.UserId);
            if (role == 1) {
                button1.Visible = false;
            }

        }

        public Profile(int userId, HR.Employees emp) {
            this.emp = emp;
            InitializeComponent();
            UserId = userId;
            LoadProfile(userId);
            
        }

        public void LoadProfile(int userId) {
            EmployeeBL empBL = new EmployeeBL();
            EmployeeBO emp = empBL.GetEmployeeById(userId);

            this.textBox1.Text = emp.Name;
            this.textBox2.Text = emp.Lastname;

            this.textBox4.Text = "" + emp.EmployeeId;
            this.textBox5.Text = emp.Gender;
            this.textBox6.Text = "" + emp.Salary;
            this.textBox7.Text = "" + emp.Email;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) {
            ViewCV viewCV = new ViewCV(this);
            viewCV.ShowDialog(this);
        }

        private void addEmployeeButton_Click(object sender, EventArgs e) {
            //AddCV addCV = new AddCV();
            //addCV.ShowDialog(this);
        }

        private void editProfileClick(object sender, EventArgs e) {
            EmployeeBL empBL = new EmployeeBL();
            EmployeeBO emp = new EmployeeBO();

            emp.EmployeeId = int.Parse(this.textBox4.Text);
            emp.Name = this.textBox1.Text;
            emp.Lastname = this.textBox2.Text;
            emp.Gender = this.textBox5.Text;
            try {
                emp.Salary = float.Parse(this.textBox6.Text);
            }
            catch(Exception ex) {
                MessageBox.Show("Wrong parameters");
                return;
            }
            emp.Email = this.textBox7.Text;

            if (empBL.EditProfile(emp)) {
                if (role == 1) {
                    this.emp.FillListDynamic();
                }
            }

        }
    }
}
