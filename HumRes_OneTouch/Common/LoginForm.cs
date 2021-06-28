using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using BL_HumanRes_OneTouch;
using BO_HumRes_OneTouch;
using System.Windows.Forms;
using System.Threading;
using System.Xml;
using System.Configuration;

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

        public static void ChangeLanguage(string key, string value) {
            var xml = new XmlDocument();

            xml.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            foreach (XmlElement item in xml.DocumentElement) {
                if (item.Name == "appSettings") {
                    foreach (XmlNode item1 in item.ChildNodes) {
                        if (item1.Attributes[0].Value.Equals(key)) {
                            item1.Attributes[1].Value = value;
                        }
                    }
                }
            }

            ConfigurationManager.RefreshSection("appSettings");

            xml.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            Application.Restart();
        }

        private void label1_Click(object sender, EventArgs e)
        {


            //Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("sq");
            //this.Controls.Clear();
            //InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e) {
            GlobalModel.Language = "sq-AL";
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(GlobalModel.Language);
            this.Controls.Clear();
            InitializeComponent();
        }
    }
}
