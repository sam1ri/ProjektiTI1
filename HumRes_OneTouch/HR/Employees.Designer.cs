
namespace UI_HumRes_OneTouch.HR
{
    partial class s
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
            this.label1 = new System.Windows.Forms.Label();
            this.employeesDataGrid = new System.Windows.Forms.DataGridView();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employees";
            // 
            // employeesDataGrid
            // 
            this.employeesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeesDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.employeesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGrid.GridColor = System.Drawing.SystemColors.ControlLight;
            this.employeesDataGrid.Location = new System.Drawing.Point(25, 82);
            this.employeesDataGrid.MultiSelect = false;
            this.employeesDataGrid.Name = "employeesDataGrid";
            this.employeesDataGrid.RowTemplate.Height = 25;
            this.employeesDataGrid.Size = new System.Drawing.Size(755, 447);
            this.employeesDataGrid.TabIndex = 1;
            this.employeesDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.addEmployeeButton.FlatAppearance.BorderSize = 0;
            this.addEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployeeButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addEmployeeButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.addEmployeeButton.Location = new System.Drawing.Point(634, 27);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(146, 30);
            this.addEmployeeButton.TabIndex = 2;
            this.addEmployeeButton.Text = "Add New";
            this.addEmployeeButton.UseVisualStyleBackColor = false;
            // 
            // s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 591);
            this.Controls.Add(this.addEmployeeButton);
            this.Controls.Add(this.employeesDataGrid);
            this.Controls.Add(this.label1);
            this.Name = "s";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView employeesDataGrid;
        private System.Windows.Forms.Button addNew;
        private System.Windows.Forms.Button addEmployeeButton;
    }
}