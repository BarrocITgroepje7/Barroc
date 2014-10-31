namespace Barroc
{
    partial class Development
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
            this.lbl_WelcomeDev = new System.Windows.Forms.Label();
            this.btn_AddProject = new System.Windows.Forms.Button();
            this.btn_ViewStatus = new System.Windows.Forms.Button();
            this.btn_ManageCustomers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // lbl_WelcomeDev
            // 
            this.lbl_WelcomeDev.AccessibleDescription = "lbl_WelcomeDev";
            this.lbl_WelcomeDev.AccessibleName = "lbl_WelcomeDev";
            this.lbl_WelcomeDev.AutoSize = true;
            this.lbl_WelcomeDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WelcomeDev.Location = new System.Drawing.Point(13, 13);
            this.lbl_WelcomeDev.Name = "lbl_WelcomeDev";
            this.lbl_WelcomeDev.Size = new System.Drawing.Size(182, 18);
            this.lbl_WelcomeDev.TabIndex = 1;
            this.lbl_WelcomeDev.Text = "Welcome Development";
            // 
            // btn_AddProject
            // 
            this.btn_AddProject.AccessibleDescription = "btn_AddProject";
            this.btn_AddProject.AccessibleName = "btn_AddProject";
            this.btn_AddProject.Location = new System.Drawing.Point(24, 82);
            this.btn_AddProject.Name = "btn_AddProject";
            this.btn_AddProject.Size = new System.Drawing.Size(120, 49);
            this.btn_AddProject.TabIndex = 2;
            this.btn_AddProject.Text = "Project";
            this.btn_AddProject.UseVisualStyleBackColor = true;
            this.btn_AddProject.Click += new System.EventHandler(this.btn_AddProject_Click);
            // 
            // btn_ViewStatus
            // 
            this.btn_ViewStatus.AccessibleDescription = "btn_ViewStatus";
            this.btn_ViewStatus.AccessibleName = "btn_ViewStatus";
            this.btn_ViewStatus.Location = new System.Drawing.Point(227, 82);
            this.btn_ViewStatus.Name = "btn_ViewStatus";
            this.btn_ViewStatus.Size = new System.Drawing.Size(127, 49);
            this.btn_ViewStatus.TabIndex = 5;
            this.btn_ViewStatus.Text = "View Status";
            this.btn_ViewStatus.UseVisualStyleBackColor = true;
            this.btn_ViewStatus.Click += new System.EventHandler(this.btn_ViewStatus_Click);
            // 
            // btn_ManageCustomers
            // 
            this.btn_ManageCustomers.AccessibleDescription = "btn_ManageCustomers";
            this.btn_ManageCustomers.AccessibleName = "btn_ManageCustomers";
            this.btn_ManageCustomers.Location = new System.Drawing.Point(24, 157);
            this.btn_ManageCustomers.Name = "btn_ManageCustomers";
            this.btn_ManageCustomers.Size = new System.Drawing.Size(120, 56);
            this.btn_ManageCustomers.TabIndex = 6;
            this.btn_ManageCustomers.Text = "Customers";
            this.btn_ManageCustomers.UseVisualStyleBackColor = true;
            this.btn_ManageCustomers.Click += new System.EventHandler(this.btn_ManageCustomers_Click);
            // 
            // Development
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(402, 324);
            this.Controls.Add(this.btn_ManageCustomers);
            this.Controls.Add(this.btn_ViewStatus);
            this.Controls.Add(this.btn_AddProject);
            this.Controls.Add(this.lbl_WelcomeDev);
            this.Controls.Add(this.label1);
            this.Name = "Development";
            this.Text = "Development";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_WelcomeDev;
        private System.Windows.Forms.Button btn_AddProject;
        private System.Windows.Forms.Button btn_ViewStatus;
        private System.Windows.Forms.Button btn_ManageCustomers;
    }
}