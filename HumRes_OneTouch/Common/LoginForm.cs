using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using BL_HumanRes_OneTouch;
using BO_HumRes_OneTouch;
using System.Windows.Forms;

namespace UI_HumRes_OneTouch
{
    public partial class LoginForm : Form
    {
        public bool authorized = false;
        public int role;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = this.email.Text;
            string password = this.password.Text;
            this.authorized = true;
            EmployeeBL emp = new EmployeeBL();
            EmployeeBO employee = emp.Authenticate(email.Trim(), password);

            if (employee != null)
            {
                this.authorized = true;
                this.role = employee.RoleId;
                this.Close();
            }
            else
            {
                this.errorLabel.Text = "Incorrect email or password!";
                this.errorLabel.Visible = true;
            }
        }
    }
}
