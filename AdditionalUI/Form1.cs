using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionalUI {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
        }

        private void Form1_Load(object sender, EventArgs e) {
            Reader r = new Reader();
            List<EmployeeReportBO> emps = r.GetSalaryReport();
            foreach (var item in emps) {
                revenueChart.Series["Salaries"].Points.AddXY(item.Name + " " + item.LastName, item.Salary);
                //revenueChart.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series(item.Name + " " + item.LastName, item.Salary));
            }



        }

        private void revenueChart_Click(object sender, EventArgs e) {
        }
    }
}
