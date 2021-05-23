using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            DataSet dataSet = new DataSet();

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns[0].ReadOnly = true;
            dataTable.Columns.Add("Start Date");
            dataTable.Columns.Add("End Date");

            dataTable.Rows.Add(new object[] { "1", "20/03/1996", "20/03/2021" });
            dataTable.Rows.Add(new object[] { "2", "20/03/1996", "20/03/2021" });

            dataSet.Tables.Add(dataTable);

            holidayDataGrid.DataSource = dataSet.Tables[0].DefaultView;

            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();

            editButton.Name = "Edit";
            editButton.HeaderText = "Edit";
            editButton.Text = "Edit";
            editButton.UseColumnTextForButtonValue = true;

            editButton.Width = 60;
            holidayDataGrid.Columns.Add(editButton);
        }

        private void holidaysCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
