using BL_HumanRes_OneTouch;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI_HumRes_OneTouch.HR {
    public partial class Holidays : Form {
        public Holidays() {
            InitializeComponent();
            FillHolidayRequests();
        }

        public void FillDataTable() {
            EmployeeBL emp = new EmployeeBL();
            holidayDataGrid.DataSource = emp.FillHolidatsTable();
        }

        private void FillHolidayRequests() {

            FillDataTable();
            DataGridViewButtonColumn ApproveBtn = new DataGridViewButtonColumn();
            ApproveBtn.Name = "Approve";
            ApproveBtn.HeaderText = "Approve";
            ApproveBtn.Text = "Approve";
            ApproveBtn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn Decline = new DataGridViewButtonColumn();

            Decline.Name = "Decline";
            Decline.HeaderText = "Decline";
            Decline.Text = "Decline";
            Decline.UseColumnTextForButtonValue = true;

            //editButton.Width = 60;
            holidayDataGrid.Columns.Add(ApproveBtn);
            holidayDataGrid.Columns.Add(Decline);
        }

        private void ResponseClick(object sender, DataGridViewCellEventArgs e) {
            var senderGrid = (DataGridView)sender;
            int holidayId;
            holidayId = int.Parse(senderGrid.CurrentRow.Cells[2].Value.ToString());
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 0 && e.RowIndex >= 0) {
                EmployeeBL emp = new EmployeeBL();
                emp.SetHolidayStatus(holidayId, "Approved");
                FillDataTable();
            }

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 1 && e.RowIndex >= 0) {
                EmployeeBL empBL = new EmployeeBL();
                empBL.SetHolidayStatus(holidayId, "Declined");
                FillDataTable();
            }
        }
    }
}
