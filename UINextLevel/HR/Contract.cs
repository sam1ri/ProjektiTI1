using BL_HumanRes_OneTouch;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI_HumRes_OneTouch.HR {
    public partial class Contract : Form {
        public Contract() {
            InitializeComponent();
        }

        private void loadContracts(object sender, EventArgs e) {
            GetContracts();
        }

        public void GetContracts() {
            EmployeeBL empBL = new EmployeeBL();
            dataGridView1.DataSource = empBL.LoadContracts();
        }

        private void newRequest_Click(object sender, EventArgs e) {
            AddContract addC = new AddContract(this);
            addC.ShowDialog(this);
        }
    }
}
