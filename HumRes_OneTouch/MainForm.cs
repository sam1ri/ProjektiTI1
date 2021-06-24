using System;
using System.Windows.Forms;
using UI_HumRes_OneTouch.Employee;
using UI_HumRes_OneTouch.HR;

namespace UI_HumRes_OneTouch
{
    public partial class MainForm : Form
    {
        private bool authorized = false;
        private int role;
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

            this.WindowState = FormWindowState.Normal;

            LoginForm loginForm = new LoginForm();
            loginForm.TopLevel = false;
            loginForm.Parent = mainPanel;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            loginForm.Dock = DockStyle.Fill;
            loginForm.FormBorderStyle = FormBorderStyle.None;
            loginForm.Show();

            loginForm.FormClosed += LoginFormClosed;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
        }

        private void LoginFormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = (LoginForm)sender;

            if (loginForm.authorized)
            {
                this.WindowState = FormWindowState.Maximized;
                authorized = loginForm.authorized;
                role = loginForm.role;
                sidebar.Visible = true;
                SetSidebarLinks();

                if (role != 1) {
                    mainPanel.Controls.Clear();
                    Employee.HolidaysForm holidaysForm = new Employee.HolidaysForm();
                    holidaysForm.TopLevel = false;
                    holidaysForm.Parent = mainPanel;
                    holidaysForm.Dock = DockStyle.Fill;
                    holidaysForm.FormBorderStyle = FormBorderStyle.None;
                    holidaysForm.Show();
                }
                else {
                    mainPanel.Controls.Clear();
                    HR.Holidays holidaysForm = new HR.Holidays();
                    holidaysForm.TopLevel = false;
                    holidaysForm.Parent = mainPanel;
                    holidaysForm.Dock = DockStyle.Fill;
                    holidaysForm.FormBorderStyle = FormBorderStyle.None;
                    holidaysForm.Show();
                }
            } else
            {
                MessageBox.Show("Unauthorized!");
            }
        }

        private void SetSidebarLinks()
        {
            if(role != 1)
            {
                employeesLink.Visible = false;
                contractLink.Visible = true;
                contractLink.Text = "View Contract";
            }
        }

        private void OnHolidaysLinkClick(object sender, EventArgs e)
        {
            if (role != 1) {
                mainPanel.Controls.Clear();
                Employee.HolidaysForm holidaysForm = new Employee.HolidaysForm();
                holidaysForm.TopLevel = false;
                holidaysForm.Parent = mainPanel;
                holidaysForm.Dock = DockStyle.Fill;
                holidaysForm.FormBorderStyle = FormBorderStyle.None;
                holidaysForm.Show();
            }
            else {
                mainPanel.Controls.Clear();
                HR.Holidays holidaysForm = new HR.Holidays();
                holidaysForm.TopLevel = false;
                holidaysForm.Parent = mainPanel;
                holidaysForm.Dock = DockStyle.Fill;
                holidaysForm.FormBorderStyle = FormBorderStyle.None;
                holidaysForm.Show();
            }


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
            HR.Employees employeesForm = new HR.Employees();
            employeesForm.TopLevel = false;
            employeesForm.Parent = mainPanel;
            employeesForm.Dock = DockStyle.Fill;
            employeesForm.FormBorderStyle = FormBorderStyle.None;
            employeesForm.Show();
        }

        private void OnLogoutButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (role == 1) {
                mainPanel.Controls.Clear();
                HR.Contract employeesForm = new HR.Contract();
                employeesForm.TopLevel = false;
                employeesForm.Parent = mainPanel;
                employeesForm.Dock = DockStyle.Fill;
                employeesForm.FormBorderStyle = FormBorderStyle.None;
                employeesForm.Show();
            }
            else {
                mainPanel.Controls.Clear();
                Employee.Contract employeesForm = new Employee.Contract();
                employeesForm.TopLevel = false;
                employeesForm.Parent = mainPanel;
                employeesForm.Dock = DockStyle.Fill;
                employeesForm.FormBorderStyle = FormBorderStyle.None;
                employeesForm.Show();
            }
        }
    }
}
