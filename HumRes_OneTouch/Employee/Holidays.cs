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

        private void FillHolidayRequests() {
            EmployeeBL emp = new EmployeeBL();
            holidayDataGrid.DataSource = emp.FillHolidatsTable();
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
    }
}
