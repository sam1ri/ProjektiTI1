using System;
using System.Windows.Forms;

namespace UI_HumRes_OneTouch
{
    public partial class MainForm : Form
    {
        private bool authorized = false;
        private string role = "";
        public MainForm()
        {
            InitializeComponent();
            SetMainFormConfig();
        }

        private void SetMainFormConfig()
        {
            Text = "Human Resources";

            if(!authorized)
            {
                sidebar.Visible = false;
            }

            LoginForm loginForm = new LoginForm();
            loginForm.TopLevel = false;
            loginForm.Parent = mainPanel;
            loginForm.Dock = DockStyle.Fill;
            loginForm.FormBorderStyle = FormBorderStyle.None;
            loginForm.Show();

            loginForm.FormClosed += LoginFormClosed;
        }

        private void LoginFormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = (LoginForm)sender;

            if (loginForm.authorized)
            {
                authorized = loginForm.authorized;
                role = loginForm.role;
                sidebar.Visible = true;

                Employee.HolidaysForm holidaysForm = new Employee.HolidaysForm();
                holidaysForm.TopLevel = false;
                holidaysForm.Parent = mainPanel;
                holidaysForm.Dock = DockStyle.Fill;
                holidaysForm.FormBorderStyle = FormBorderStyle.None;
                holidaysForm.Show();
                this.SetSidebarLinks();
            } else
            {
                MessageBox.Show("Unauthorized!");
            }
        }

        private void SetSidebarLinks()
        {
            if(role != "HR")
            {
                employeesLink.Visible = false;
            }
        }

        private void OnHolidaysLinkClick(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            Employee.HolidaysForm holidaysForm = new Employee.HolidaysForm();
            holidaysForm.TopLevel = false;
            holidaysForm.Parent = mainPanel;
            holidaysForm.Dock = DockStyle.Fill;
            holidaysForm.FormBorderStyle = FormBorderStyle.None;
            holidaysForm.Show();
        }

        private void OnProfileLinkClick(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            Employee.Profile profileForm = new Employee.Profile();
            profileForm.TopLevel = false;
            profileForm.Parent = mainPanel;
            profileForm.Dock = DockStyle.Fill;
            profileForm.FormBorderStyle = FormBorderStyle.None;
            profileForm.Show();
        }

        private void OnEmployeesLinkClick(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            HR.s employeesForm = new HR.s();
            employeesForm.TopLevel = false;
            employeesForm.Parent = mainPanel;
            employeesForm.Dock = DockStyle.Fill;
            employeesForm.FormBorderStyle = FormBorderStyle.None;
            employeesForm.Show();
        }
    }
}
