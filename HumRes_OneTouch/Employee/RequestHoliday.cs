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
    public partial class RequestHoliday : Form {
        public RequestHoliday(HolidaysForm hd) {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;
            string description = richTextBox1.Text;
            EmployeeBL empBL = new EmployeeBL();
            empBL.RequestHoliday(startDate, endDate, description, GlobalModel.UserId);

            this.Close();

        }
    }
}
