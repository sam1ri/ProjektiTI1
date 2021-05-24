using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BO_HumRes_OneTouch;

namespace UI_HumRes_OneTouch.Employee
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
            this.textBox1.Text = GlobalModel.Name;
            this.textBox2.Text = GlobalModel.LastName;

            this.textBox4.Text = "" + GlobalModel.UserId;
            this.textBox5.Text = GlobalModel.Gender;
            this.textBox6.Text = "" + GlobalModel.Salary;
            this.textBox7.Text = "" + GlobalModel.Email;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
