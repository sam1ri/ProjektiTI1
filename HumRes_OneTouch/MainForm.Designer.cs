
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
            this.button1 = new System.Windows.Forms.Button();
            this.ProfileLink = new System.Windows.Forms.Button();
            this.contractLink = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.HolidaysLink = new System.Windows.Forms.Button();
            this.employeesLink = new System.Windows.Forms.Button();
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
            this.sidebar.Controls.Add(this.contractLink);
            this.sidebar.Controls.Add(this.logoutButton);
            this.sidebar.Controls.Add(this.HolidaysLink);
            this.sidebar.Controls.Add(this.employeesLink);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(219, 615);
            this.sidebar.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(0, 252);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(217, 63);
            this.button1.TabIndex = 2;
            this.button1.Text = "Stats";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ProfileLink
            // 
            this.ProfileLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProfileLink.FlatAppearance.BorderSize = 0;
            this.ProfileLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileLink.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProfileLink.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ProfileLink.Location = new System.Drawing.Point(0, 189);
            this.ProfileLink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProfileLink.Name = "ProfileLink";
            this.ProfileLink.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.ProfileLink.Size = new System.Drawing.Size(217, 63);
            this.ProfileLink.TabIndex = 0;
            this.ProfileLink.Text = "Profile";
            this.ProfileLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProfileLink.UseVisualStyleBackColor = true;
            this.ProfileLink.Click += new System.EventHandler(this.OnProfileLinkClick);
            // 
            // contractLink
            // 
            this.contractLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.contractLink.FlatAppearance.BorderSize = 0;
            this.contractLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contractLink.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.contractLink.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.contractLink.Location = new System.Drawing.Point(0, 126);
            this.contractLink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contractLink.Name = "contractLink";
            this.contractLink.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.contractLink.Size = new System.Drawing.Size(217, 63);
            this.contractLink.TabIndex = 1;
            this.contractLink.Text = "Manage Contracts";
            this.contractLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contractLink.UseVisualStyleBackColor = true;
            this.contractLink.Click += new System.EventHandler(this.button1_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.logoutButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.logoutButton.Location = new System.Drawing.Point(-1, 565);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.logoutButton.Size = new System.Drawing.Size(175, 36);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "Exit";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.OnLogoutButtonClick);
            // 
            // HolidaysLink
            // 
            this.HolidaysLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.HolidaysLink.FlatAppearance.BorderSize = 0;
            this.HolidaysLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HolidaysLink.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.HolidaysLink.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.HolidaysLink.Location = new System.Drawing.Point(0, 63);
            this.HolidaysLink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HolidaysLink.Name = "HolidaysLink";
            this.HolidaysLink.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.HolidaysLink.Size = new System.Drawing.Size(217, 63);
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
            this.employeesLink.Location = new System.Drawing.Point(0, 0);
            this.employeesLink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employeesLink.Name = "employeesLink";
            this.employeesLink.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.employeesLink.Size = new System.Drawing.Size(217, 63);
            this.employeesLink.TabIndex = 0;
            this.employeesLink.Text = "Employees";
            this.employeesLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeesLink.UseVisualStyleBackColor = true;
            this.employeesLink.Click += new System.EventHandler(this.OnEmployeesLinkClick);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.AutoSize = true;
            this.mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanel.Location = new System.Drawing.Point(175, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(804, 615);
            this.mainPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 615);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button contractLink;
        private System.Windows.Forms.Button button1;
    }
}