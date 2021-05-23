using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI_HumRes_OneTouch
{
    public partial class LoginForm : Form
    {
        public bool authorized = false;
        public string role = "";
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
            this.authorized = true;
            this.role = "HR";
            this.Close();
        }
    }
}
