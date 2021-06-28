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
    public partial class AddEducation : Form {

        ViewCV v;

        public AddEducation(ViewCV viewCV) {
            InitializeComponent();
            v = viewCV;
        }

        private void addEmployeeButton_Click(object sender, EventArgs e) {
            string courseName = textBox1.Text;
            string address = textBox2.Text;
            string instituteName = textBox3.Text;

            DateTime startDate = dateTimePicker2.Value;
            DateTime endDate = dateTimePicker1.Value;

            EmployeeBL empBL = new EmployeeBL();
            Education ed = new Education() {
                Name = courseName,
                Location = address,
                InstituteName = instituteName,
                StartDate = startDate,
                EndDate = endDate,
                CVId = v.cv.Id
            };

            if (empBL.AddEducation(ed)) {
                MessageBox.Show("Education added!");
                
                this.Close();
                v.PopulateWhatever();
            }
        }
    }
}
