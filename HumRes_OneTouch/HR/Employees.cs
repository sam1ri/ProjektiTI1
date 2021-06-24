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

        private void FillListData()
        {
            //DataSet dataSet = new DataSet();



            //DataTable dataTable = new DataTable();
            //dataTable.Columns.Add("ID");
            //dataTable.Columns[0].ReadOnly = true;
            //dataTable.Columns.Add("First Name");
            //dataTable.Columns.Add("Last Name");

            //dataTable.Rows.Add(new object[] { "1", "James", "Bond"});

            //dataSet.Tables.Add(dataTable);

            //employeesDataGrid.DataSource = dataSet.Tables[0].DefaultView;

            EmployeeBL emp = new EmployeeBL();
            employeesDataGrid.DataSource = emp.FillEmployeeTable();
            employeesDataGrid.AllowUserToAddRows = false;
            DataGridViewButtonColumn View = new DataGridViewButtonColumn();

            View.Name = "Profile";
            View.HeaderText = "View Profile";
            View.Text = "View";
            View.UseColumnTextForButtonValue = true;

            employeesDataGrid.Columns.Add(View);

            DataGridViewButtonColumn Edit = new DataGridViewButtonColumn();

            Edit.Name = "Edit";
            Edit.HeaderText = "Edit Profile";
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;

            employeesDataGrid.Columns.Add(Edit);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Employees_Load(object sender, EventArgs e)
        {

        }

        private void OnAddEmployeeButtonClick(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee(this);
                addEmployee.ShowDialog(this);
        }
    }
}
