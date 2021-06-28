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
    public partial class ViewCV : Form {

        public Profile profile;
        public CV cv;

        public ViewCV(Profile profile) {
            InitializeComponent();
            this.profile = profile;

            if (GlobalModel.UserId != 4) {
                profile.UserId = GlobalModel.UserId;
            }

            PopulateWhatever();



            //empBL

        }

        public void PopulateWhatever() {
            EmployeeBL empBL = new EmployeeBL();
            EmployeeBO emp = empBL.GetEmployeeById(profile.UserId);
            textBox4.Text = emp.Name;
            textBox1.Text = emp.Lastname;
            CV cv = empBL.GetCVByEmployeeId(profile.UserId);
            if (cv == null) {
                return;
            }
            this.cv = cv;
            if (cv.skills != null)
                PopulateSkills(cv.skills);
            if (cv.education != null)
                PopulateEducations(cv.education);
            if (cv.experience != null)
                PopulateExperiences(cv.experience);
        }

        public void PopulateSkills(List<Skills> skills) {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Name", typeof(string));

            foreach (var item in skills) {
                table.Rows.Add(item.Id, item.Name);
            }

            dgvSkills.DataSource = table;

        }

        public void PopulateEducations(List<Education> education) {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("InstituteName", typeof(string));
            table.Columns.Add("Location", typeof(string));
            table.Columns.Add("StartDate", typeof(DateTime));
            table.Columns.Add("EndDate", typeof(DateTime));

            foreach (var item in education) {
                table.Rows.Add(item.Id, item.Name, item.InstituteName, item.Location, item.StartDate, item.EndDate);
            }

            dgvEducation.DataSource = table;

        }

        public void PopulateExperiences(List<Experience> experiences) {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("RoleName", typeof(string));
            table.Columns.Add("CompanyName", typeof(string));
            table.Columns.Add("Description", typeof(string));
            table.Columns.Add("StartDate", typeof(DateTime));
            table.Columns.Add("EndDate", typeof(DateTime));

            foreach (var item in experiences) {
                table.Rows.Add(item.Id, item.RoleName, item.CompanyName, item.Description, item.StartDate, item.EndDate);

            }

            dgvExperience.DataSource = table;
            //dvgEx.DataSource = table;

        }

        private void addEmployeeButton_Click(object sender, EventArgs e) {
            AddSkill addSkill = new AddSkill(this);
            addSkill.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e) {
            AddEducation addEducation = new AddEducation(this);
            addEducation.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e) {
            AddExperience addExperience = new AddExperience(this);
            addExperience.ShowDialog(this);
        }
    }
}
