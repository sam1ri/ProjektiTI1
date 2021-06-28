
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            resources.ApplyResources(this.sidebar, "sidebar");
            this.sidebar.Name = "sidebar";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ProfileLink
            // 
            resources.ApplyResources(this.ProfileLink, "ProfileLink");
            this.ProfileLink.FlatAppearance.BorderSize = 0;
            this.ProfileLink.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ProfileLink.Name = "ProfileLink";
            this.ProfileLink.UseVisualStyleBackColor = true;
            this.ProfileLink.Click += new System.EventHandler(this.OnProfileLinkClick);
            // 
            // contractLink
            // 
            resources.ApplyResources(this.contractLink, "contractLink");
            this.contractLink.FlatAppearance.BorderSize = 0;
            this.contractLink.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.contractLink.Name = "contractLink";
            this.contractLink.UseVisualStyleBackColor = true;
            this.contractLink.Click += new System.EventHandler(this.button1_Click);
            // 
            // logoutButton
            // 
            resources.ApplyResources(this.logoutButton, "logoutButton");
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.OnLogoutButtonClick);
            // 
            // HolidaysLink
            // 
            resources.ApplyResources(this.HolidaysLink, "HolidaysLink");
            this.HolidaysLink.FlatAppearance.BorderSize = 0;
            this.HolidaysLink.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.HolidaysLink.Name = "HolidaysLink";
            this.HolidaysLink.UseVisualStyleBackColor = true;
            this.HolidaysLink.Click += new System.EventHandler(this.OnHolidaysLinkClick);
            // 
            // employeesLink
            // 
            resources.ApplyResources(this.employeesLink, "employeesLink");
            this.employeesLink.FlatAppearance.BorderSize = 0;
            this.employeesLink.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.employeesLink.Name = "employeesLink";
            this.employeesLink.UseVisualStyleBackColor = true;
            this.employeesLink.Click += new System.EventHandler(this.OnEmployeesLinkClick);
            // 
            // mainPanel
            // 
            resources.ApplyResources(this.mainPanel, "mainPanel");
            this.mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanel.Name = "mainPanel";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
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