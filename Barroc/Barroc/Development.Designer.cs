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
            this.btn_ManageProject = new System.Windows.Forms.Button();
            this.btn_DeleteProject = new System.Windows.Forms.Button();
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
            this.btn_AddProject.Text = "Add Project";
            this.btn_AddProject.UseVisualStyleBackColor = true;
            // 
            // btn_ManageProject
            // 
            this.btn_ManageProject.AccessibleDescription = "btn_ManageProject";
            this.btn_ManageProject.AccessibleName = "btn_ManageProject";
            this.btn_ManageProject.Location = new System.Drawing.Point(24, 152);
            this.btn_ManageProject.Name = "btn_ManageProject";
            this.btn_ManageProject.Size = new System.Drawing.Size(120, 56);
            this.btn_ManageProject.TabIndex = 3;
            this.btn_ManageProject.Text = "Manage Project";
            this.btn_ManageProject.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteProject
            // 
            this.btn_DeleteProject.AccessibleDescription = "btn_DeleteProject";
            this.btn_DeleteProject.AccessibleName = "btn_DeleteProject";
            this.btn_DeleteProject.Location = new System.Drawing.Point(24, 230);
            this.btn_DeleteProject.Name = "btn_DeleteProject";
            this.btn_DeleteProject.Size = new System.Drawing.Size(120, 52);
            this.btn_DeleteProject.TabIndex = 4;
            this.btn_DeleteProject.Text = "Delete Project";
            this.btn_DeleteProject.UseVisualStyleBackColor = true;
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
            // 
            // btn_ManageCustomers
            // 
            this.btn_ManageCustomers.AccessibleDescription = "btn_ManageCustomers";
            this.btn_ManageCustomers.AccessibleName = "btn_ManageCustomers";
            this.btn_ManageCustomers.Location = new System.Drawing.Point(227, 152);
            this.btn_ManageCustomers.Name = "btn_ManageCustomers";
            this.btn_ManageCustomers.Size = new System.Drawing.Size(127, 56);
            this.btn_ManageCustomers.TabIndex = 6;
            this.btn_ManageCustomers.Text = "Manage Customers";
            this.btn_ManageCustomers.UseVisualStyleBackColor = true;
            // 
            // Development
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(580, 324);
            this.Controls.Add(this.btn_ManageCustomers);
            this.Controls.Add(this.btn_ViewStatus);
            this.Controls.Add(this.btn_DeleteProject);
            this.Controls.Add(this.btn_ManageProject);
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
        private System.Windows.Forms.Button btn_ManageProject;
        private System.Windows.Forms.Button btn_DeleteProject;
        private System.Windows.Forms.Button btn_ViewStatus;
        private System.Windows.Forms.Button btn_ManageCustomers;
    }
}