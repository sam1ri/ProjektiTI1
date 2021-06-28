
namespace UI_HumRes_OneTouch.HR
{
    partial class Employees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            this.label1 = new System.Windows.Forms.Label();
            this.employeesDataGrid = new System.Windows.Forms.DataGridView();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // employeesDataGrid
            // 
            resources.ApplyResources(this.employeesDataGrid, "employeesDataGrid");
            this.employeesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeesDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.employeesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGrid.GridColor = System.Drawing.SystemColors.ControlLight;
            this.employeesDataGrid.MultiSelect = false;
            this.employeesDataGrid.Name = "employeesDataGrid";
            this.employeesDataGrid.ReadOnly = true;
            this.employeesDataGrid.RowTemplate.Height = 25;
            this.employeesDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // addEmployeeButton
            // 
            resources.ApplyResources(this.addEmployeeButton, "addEmployeeButton");
            this.addEmployeeButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.addEmployeeButton.FlatAppearance.BorderSize = 0;
            this.addEmployeeButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.UseVisualStyleBackColor = false;
            this.addEmployeeButton.Click += new System.EventHandler(this.OnAddEmployeeButtonClick);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Employees
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addEmployeeButton);
            this.Controls.Add(this.employeesDataGrid);
            this.Controls.Add(this.label1);
            this.Name = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridView employeesDataGrid;
        private System.Windows.Forms.Button addNew;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Button button1;
    }
}