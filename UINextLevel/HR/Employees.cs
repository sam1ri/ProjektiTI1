using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using BL_HumanRes_OneTouch;

namespace UI_HumRes_OneTouch.HR
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
            this.FillListData();
        }

        public void FillListDynamic() {
            EmployeeBL emp = new EmployeeBL();
            employeesDataGrid.DataSource = emp.FillEmployeeTable();
            employeesDataGrid.AllowUserToAddRows = false;
        }

        private void FillListData()
        {
            //DataSet dataSet = new DataSet();

            FillListDynamic();
            DataGridViewButtonColumn View = new DataGridViewButtonColumn();

            View.Name = "Profile";
            View.HeaderText = "View Profile";
            View.Text = "View";
            View.UseColumnTextForButtonValue = true;

            employeesDataGrid.Columns.Add(View);

            DataGridViewButtonColumn Edit = new DataGridViewButtonColumn();

            Edit.Name = "Delete";
            Edit.HeaderText = "Action Delete";
            Edit.Text = "Delete";
            Edit.UseColumnTextForButtonValue = true;

            employeesDataGrid.Columns.Add(Edit);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            int userId;
            userId = int.Parse(senderGrid.CurrentRow.Cells[2].Value.ToString());
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 0 && e.RowIndex >= 0) {
                Employee.Profile profile = new Employee.Profile(userId, this);
                profile.Size = new Size(900,800);
                profile.ShowDialog(this);

            }

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex ==  1 && e.RowIndex >= 0) {
                EmployeeBL empBL = new EmployeeBL();
                if (empBL.DeleteEmployee(userId)) {
                    FillListDynamic();
                    MessageBox.Show("User deleted successfully!");
                }
            }
        }

        private void Employees_Load(object sender, EventArgs e)
        {

        }

        private void OnAddEmployeeButtonClick(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee(this);
                addEmployee.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e) {
            Microsoft.Office.Interop.Excel.Application fileIexcelit = new Microsoft.Office.Interop.Excel.Application();
            fileIexcelit.Application.Workbooks.Add(Type.Missing);

            for (int i = 3; i < employeesDataGrid.Columns.Count + 1; i++) {
                fileIexcelit.Cells[1, i - 2] = employeesDataGrid.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < employeesDataGrid.Rows.Count; i++) {
                for (int j = 2; j < employeesDataGrid.Columns.Count; j++) {
                    fileIexcelit.Cells[i + 2, j - 1] = employeesDataGrid.Rows[i].Cells[j].Value.ToString();
                }
            }
            fileIexcelit.Columns.AutoFit();
            fileIexcelit.Visible = true;


        }
    }
}
