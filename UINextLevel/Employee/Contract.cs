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
    public partial class Contract : Form {
        public Contract() {
            InitializeComponent();
        }

        private void loadContract(object sender, EventArgs e) {
            EmployeeBL empBL = new EmployeeBL();
            ContractBO empBO = empBL.RetrieveContract(GlobalModel.UserId);

            textBox1.Text = empBO.UserName;
            textBox2.Text = empBO.UserLastName;
            textBox3.Text = empBO.JobTitle;
            label7.Text = empBO.StartDate.ToString();
            label9.Text = empBO.EndDate.ToString();


        }
    }
}
