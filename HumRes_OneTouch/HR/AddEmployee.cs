using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BL_HumanRes_OneTouch;
using BO_HumRes_OneTouch;

namespace UI_HumRes_OneTouch.HR
{
    public partial class AddEmployee : Form
    {

        public AddEmployee()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gender_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void onNewEmployeeSubmit(object sender, EventArgs e)
        {
            string firstName = this.firstName.Text;
            string lastName = this.lastName.Text;
            string gender = this.gender.Text;
            string salary = this.salary.Text;
            string email = this.email.Text;
            string password = this.password.Text;
            DateTime birthdate = this.dateTimePicker1.Value;
            EmployeeBL employee = new EmployeeBL();
            if (
                    employee.AddEmployee(
                    new EmployeeBO(firstName, double.Parse(salary), lastName, birthdate, gender, email, password, 2)
                ))
            {
                this.Parent.Hide();
            }
            

        }
    }
}
