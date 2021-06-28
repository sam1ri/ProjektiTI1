
namespace UI_HumRes_OneTouch.HR {
    partial class Holidays {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Holidays));
            this.holidayDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.holidayDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // holidayDataGrid
            // 
            resources.ApplyResources(this.holidayDataGrid, "holidayDataGrid");
            this.holidayDataGrid.AllowUserToAddRows = false;
            this.holidayDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.holidayDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.holidayDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.holidayDataGrid.Name = "holidayDataGrid";
            this.holidayDataGrid.RowTemplate.Height = 25;
            this.holidayDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ResponseClick);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Holidays
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.holidayDataGrid);
            this.Controls.Add(this.label1);
            this.Name = "Holidays";
            ((System.ComponentModel.ISupportInitialize)(this.holidayDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView holidayDataGrid;
        private System.Windows.Forms.Label label1;
    }
}