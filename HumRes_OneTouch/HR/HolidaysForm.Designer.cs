
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
            this.label1 = new System.Windows.Forms.Label();
            this.holidayDataGrid = new System.Windows.Forms.DataGridView();
            this.newRequest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.holidayDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Holidays";
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
            this.holidayDataGrid.Location = new System.Drawing.Point(14, 109);
            this.holidayDataGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.holidayDataGrid.Name = "holidayDataGrid";
            this.holidayDataGrid.RowHeadersWidth = 51;
            this.holidayDataGrid.RowTemplate.Height = 25;
            this.holidayDataGrid.Size = new System.Drawing.Size(1146, 933);
            this.holidayDataGrid.TabIndex = 2;
            this.holidayDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.holidayDataGrid_CellContentClick);
            // 
            // newRequest
            // 
            this.newRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newRequest.BackColor = System.Drawing.SystemColors.Highlight;
            this.newRequest.FlatAppearance.BorderSize = 0;
            this.newRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newRequest.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newRequest.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.newRequest.Location = new System.Drawing.Point(993, 61);
            this.newRequest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newRequest.Name = "newRequest";
            this.newRequest.Size = new System.Drawing.Size(167, 40);
            this.newRequest.TabIndex = 4;
            this.newRequest.Text = "New Request";
            this.newRequest.UseVisualStyleBackColor = false;
            this.newRequest.Click += new System.EventHandler(this.newRequest_Click);
            // 
            // HolidaysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1172, 1055);
            this.Controls.Add(this.newRequest);
            this.Controls.Add(this.holidayDataGrid);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HolidaysForm";
            this.Text = "Holidays";
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