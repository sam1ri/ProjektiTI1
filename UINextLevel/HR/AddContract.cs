using BL_HumanRes_OneTouch;
using BO_HumRes_OneTouch;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_HumRes_OneTouch.HR {
    public partial class AddContract : Form {
        Contract contract;

        public AddContract(Contract contract) {
            InitializeComponent();
            this.contract = contract;
        }

        private void addEmployeeButton_Click(object sender, EventArgs e) {
            string employeeEmail = textBox1.Text;
            string jobTitle = textBox2.Text;
            string description = textBox3.Text;
            DateTime startDate = dateTimePicker2.Value;
            DateTime endDate = dateTimePicker1.Value;
            int createdByUser = GlobalModel.UserId;
            int updatedByUser = GlobalModel.UserId;

            EmployeeBL emp = new EmployeeBL();
            if (emp.AddContract(new ContractBO() {
                EmployeeEmail = employeeEmail,
                JobTitle = jobTitle,
                Description = description,
                StartDate = startDate,
                EndDate = endDate,
                CreatedByUser = createdByUser,
                UpdatedByUser = updatedByUser
            })) {
                this.Close();
                MessageBox.Show("Contract addedd successfully!");
                contract.GetContracts();
            };

        }
    }
}
