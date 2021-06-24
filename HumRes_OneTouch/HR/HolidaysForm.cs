using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BL_HumanRes_OneTouch;

namespace UI_HumRes_OneTouch.Employee
{
    public partial class HolidaysForm : Form
    {
        public HolidaysForm()
        {
            InitializeComponent();
            FillHolidayData();
        }

        private void FillHolidayData()
        {
            //DataSet dataSet = new DataSet();
            EmployeeBL emp = new EmployeeBL();
            holidayDataGrid.DataSource = emp.FillHolidatsTable();
            //holidayDataGrid.Add
            //DataTable dataTable = new DataTable();

            //dataTable.Columns.Add("ID");
            //dataTable.Columns[0].ReadOnly = true;
            //dataTable.Columns.Add("Start Date");
            //dataTable.Columns.Add("End Date");

            //dataTable.Rows.Add(new object[] { "1", "20/03/1996", "20/03/2021" });
            //dataTable.Rows.Add(new object[] { "2", "20/03/1996", "20/03/2021" });

            //dataSet.Tables.Add(dataTable);

            //holidayDataGrid.DataSource = dataSet.Tables[0].DefaultView;

            //DataGridViewButtonColumn ApproveBtn = new DataGridViewButtonColumn();

            //ApproveBtn.Name = "Approve";
            //ApproveBtn.HeaderText = "Approve";
            //ApproveBtn.Text = "Approve";
            //ApproveBtn.UseColumnTextForButtonValue = true;

            //DataGridViewButtonColumn Decline = new DataGridViewButtonColumn();

            //Decline.Name = "Decline";
            //Decline.HeaderText = "Decline";
            //Decline.Text = "Decline";
            //Decline.UseColumnTextForButtonValue = true;

            ////editButton.Width = 60;
            //holidayDataGrid.Columns.Add(ApproveBtn);
            //holidayDataGrid.Columns.Add(Decline);
        }

        private void holidaysCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void holidayDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void newRequest_Click(object sender, EventArgs e) {
            RequestHoliday requestHoliday = new RequestHoliday(this);

            requestHoliday.ShowDialog(this);
        }
    }
}
