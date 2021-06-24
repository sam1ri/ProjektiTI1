using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI_HumRes_OneTouch.Employee {
    public partial class ViewCV : Form {
        public ViewCV(Profile profile) {
            InitializeComponent();
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
