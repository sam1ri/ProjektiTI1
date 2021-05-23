
namespace UI_HumRes_OneTouch
{
    partial class MainForm
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
            this.sidebar = new System.Windows.Forms.Panel();
            this.HolidaysLink = new System.Windows.Forms.Button();
            this.employeesLink = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ProfileLink = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.SystemColors.Highlight;
            this.sidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sidebar.Controls.Add(this.button1);
            this.sidebar.Controls.Add(this.ProfileLink);
            this.sidebar.Controls.Add(this.employeesLink);
            this.sidebar.Controls.Add(this.HolidaysLink);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(153, 571);
            this.sidebar.TabIndex = 2;
            // 
            // HolidaysLink
            // 
            this.HolidaysLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.HolidaysLink.FlatAppearance.BorderSize = 0;
            this.HolidaysLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HolidaysLink.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.HolidaysLink.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.HolidaysLink.Location = new System.Drawing.Point(0, 0);
            this.HolidaysLink.Name = "HolidaysLink";
            this.HolidaysLink.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.HolidaysLink.Size = new System.Drawing.Size(151, 47);
            this.HolidaysLink.TabIndex = 0;
            this.HolidaysLink.Text = "Holidays";
            this.HolidaysLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HolidaysLink.UseVisualStyleBackColor = true;
            this.HolidaysLink.Click += new System.EventHandler(this.OnHolidaysLinkClick);
            // 
            // employeesLink
            // 
            this.employeesLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeesLink.FlatAppearance.BorderSize = 0;
            this.employeesLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeesLink.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.employeesLink.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.employeesLink.Location = new System.Drawing.Point(0, 47);
            this.employeesLink.Name = "employeesLink";
            this.employeesLink.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.employeesLink.Size = new System.Drawing.Size(151, 47);
            this.employeesLink.TabIndex = 0;
            this.employeesLink.Text = "Employees";
            this.employeesLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeesLink.UseVisualStyleBackColor = true;
            this.employeesLink.Click += new System.EventHandler(this.OnEmployeesLinkClick);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(-1, 523);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(153, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Log out";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnProfileLinkClick);
            // 
            // ProfileLink
            // 
            this.ProfileLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProfileLink.FlatAppearance.BorderSize = 0;
            this.ProfileLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileLink.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProfileLink.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ProfileLink.Location = new System.Drawing.Point(0, 94);
            this.ProfileLink.Name = "ProfileLink";
            this.ProfileLink.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ProfileLink.Size = new System.Drawing.Size(151, 47);
            this.ProfileLink.TabIndex = 0;
            this.ProfileLink.Text = "Profile";
            this.ProfileLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProfileLink.UseVisualStyleBackColor = true;
            this.ProfileLink.Click += new System.EventHandler(this.OnProfileLinkClick);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(153, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(801, 571);
            this.mainPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 571);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Layout";
            this.sidebar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button HolidaysLink;
        private System.Windows.Forms.Button ProfileLink;
        private System.Windows.Forms.Button employeesLink;
        private System.Windows.Forms.Button button1;
    }
}