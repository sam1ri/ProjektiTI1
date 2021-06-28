using BL_HumanRes_OneTouch;
using BO_HumRes_OneTouch;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI_HumRes_OneTouch.Employee {
    public partial class AddExperience : Form {

        ViewCV v;

        public AddExperience(ViewCV viewCV) {
            InitializeComponent();
            v = viewCV;
        }

        private void addEmployeeButton_Click(object sender, EventArgs e) {
            string roleName = textBox1.Text;
            string description = richTextBox1.Text;
            string companyName = textBox3.Text;

            DateTime startDate = dateTimePicker2.Value;
            DateTime endDate = dateTimePicker1.Value;

            EmployeeBL empBL = new EmployeeBL();
            Experience ed = new Experience() {
                RoleName = roleName,
                Description = description,
                CompanyName = companyName,
                StartDate = startDate,
                EndDate = endDate,
                CVId = v.cv.Id
            };

            if (empBL.AddExperience(ed)) {
                MessageBox.Show("Experience added!");

                this.Close();
                v.PopulateWhatever();
            }
        }
    }
}
