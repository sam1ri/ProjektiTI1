
namespace UI_HumRes_OneTouch.Employee
{
    partial class HolidaysForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HolidaysForm));
            this.label1 = new System.Windows.Forms.Label();
            this.holidayDataGrid = new System.Windows.Forms.DataGridView();
            this.newRequest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.holidayDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // holidayDataGrid
            // 
            this.holidayDataGrid.AllowUserToAddRows = false;
            resources.ApplyResources(this.holidayDataGrid, "holidayDataGrid");
            this.holidayDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.holidayDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.holidayDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.holidayDataGrid.Name = "holidayDataGrid";
            this.holidayDataGrid.RowTemplate.Height = 25;
            this.holidayDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.holidayDataGrid_CellContentClick);
            // 
            // newRequest
            // 
            resources.ApplyResources(this.newRequest, "newRequest");
            this.newRequest.BackColor = System.Drawing.SystemColors.Highlight;
            this.newRequest.FlatAppearance.BorderSize = 0;
            this.newRequest.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.newRequest.Name = "newRequest";
            this.newRequest.UseVisualStyleBackColor = false;
            this.newRequest.Click += new System.EventHandler(this.newRequest_Click);
            // 
            // HolidaysForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newRequest);
            this.Controls.Add(this.holidayDataGrid);
            this.Controls.Add(this.label1);
            this.Name = "HolidaysForm";
            ((System.ComponentModel.ISupportInitialize)(this.holidayDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView holidayDataGrid;
        private System.Windows.Forms.Button newRequest;
    }
}