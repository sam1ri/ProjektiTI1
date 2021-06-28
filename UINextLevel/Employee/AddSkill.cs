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
    public partial class AddSkill : Form {
        ViewCV v;

        public AddSkill(ViewCV viewCV) {
            InitializeComponent();
            v = viewCV;
        }

        private void addEmployeeButton_Click(object sender, EventArgs e) {
            string courseName = textBox1.Text;

            EmployeeBL empBL = new EmployeeBL();
            Skills skills = new Skills() {
                Name = courseName,
                CVId = v.cv.Id
            };

            if (empBL.AddSkill(skills)) {
                MessageBox.Show("Skill added!");

                this.Close();
                v.PopulateWhatever();
            }
        }
    }
}
