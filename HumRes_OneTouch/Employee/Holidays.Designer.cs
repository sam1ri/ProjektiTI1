
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
            this.holidayDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.holidayDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // holidayDataGrid
            // 
            this.holidayDataGrid.AllowUserToAddRows = false;
            this.holidayDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.holidayDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.holidayDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.holidayDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.holidayDataGrid.Location = new System.Drawing.Point(17, 72);
            this.holidayDataGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.holidayDataGrid.Name = "holidayDataGrid";
            this.holidayDataGrid.RowHeadersWidth = 51;
            this.holidayDataGrid.RowTemplate.Height = 25;
            this.holidayDataGrid.Size = new System.Drawing.Size(1544, 970);
            this.holidayDataGrid.TabIndex = 6;
            this.holidayDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ResponseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "Holidays";
            // 
            // Holidays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1573, 1055);
            this.Controls.Add(this.holidayDataGrid);
            this.Controls.Add(this.label1);
            this.Name = "Holidays";
            this.Text = "Holidays";
            ((System.ComponentModel.ISupportInitialize)(this.holidayDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView holidayDataGrid;
        private System.Windows.Forms.Label label1;
    }
}