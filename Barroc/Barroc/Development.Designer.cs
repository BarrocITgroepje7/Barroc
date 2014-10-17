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
            this.btn_AddProject = new System.Windows.Forms.Button();
            this.btn_ManageProject = new System.Windows.Forms.Button();
            this.btn_DeleteProject = new System.Windows.Forms.Button();
            this.btn_ViewStatus = new System.Windows.Forms.Button();
            this.btn_ManageCustomers = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AddProject
            // 
            this.btn_AddProject.AccessibleDescription = "btn_AddProject";
            this.btn_AddProject.AccessibleName = "btn_AddProject";
            this.btn_AddProject.Location = new System.Drawing.Point(34, 72);
            this.btn_AddProject.Name = "btn_AddProject";
            this.btn_AddProject.Size = new System.Drawing.Size(106, 50);
            this.btn_AddProject.TabIndex = 0;
            this.btn_AddProject.Text = "Add Project";
            this.btn_AddProject.UseVisualStyleBackColor = true;
            // 
            // btn_ManageProject
            // 
            this.btn_ManageProject.AccessibleDescription = "btn_ManageProject";
            this.btn_ManageProject.AccessibleName = "btn_ManageProject";
            this.btn_ManageProject.Location = new System.Drawing.Point(34, 139);
            this.btn_ManageProject.Name = "btn_ManageProject";
            this.btn_ManageProject.Size = new System.Drawing.Size(106, 51);
            this.btn_ManageProject.TabIndex = 1;
            this.btn_ManageProject.Text = "Manage Projects";
            this.btn_ManageProject.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteProject
            // 
            this.btn_DeleteProject.AccessibleDescription = "btn_DeleteProject";
            this.btn_DeleteProject.AccessibleName = "btn_DeleteProject";
            this.btn_DeleteProject.Location = new System.Drawing.Point(34, 209);
            this.btn_DeleteProject.Name = "btn_DeleteProject";
            this.btn_DeleteProject.Size = new System.Drawing.Size(106, 48);
            this.btn_DeleteProject.TabIndex = 2;
            this.btn_DeleteProject.Text = "Delete Projects";
            this.btn_DeleteProject.UseVisualStyleBackColor = true;
            // 
            // btn_ViewStatus
            // 
            this.btn_ViewStatus.AccessibleDescription = "btn_ViewStatus";
            this.btn_ViewStatus.AccessibleName = "btn_ViewStatus";
            this.btn_ViewStatus.Location = new System.Drawing.Point(185, 72);
            this.btn_ViewStatus.Name = "btn_ViewStatus";
            this.btn_ViewStatus.Size = new System.Drawing.Size(100, 50);
            this.btn_ViewStatus.TabIndex = 3;
            this.btn_ViewStatus.Text = "View Project Status";
            this.btn_ViewStatus.UseVisualStyleBackColor = true;
            // 
            // btn_ManageCustomers
            // 
            this.btn_ManageCustomers.AccessibleDescription = "btn_ManageCustomers";
            this.btn_ManageCustomers.AccessibleName = "btn_ManageCustomers";
            this.btn_ManageCustomers.Location = new System.Drawing.Point(185, 139);
            this.btn_ManageCustomers.Name = "btn_ManageCustomers";
            this.btn_ManageCustomers.Size = new System.Drawing.Size(100, 51);
            this.btn_ManageCustomers.TabIndex = 4;
            this.btn_ManageCustomers.Text = "Manage Customers";
            this.btn_ManageCustomers.UseVisualStyleBackColor = true;
            // 
            // btn_Logout
            // 
            this.btn_Logout.AccessibleDescription = "btn_Logout";
            this.btn_Logout.AccessibleName = "btn_Logout";
            this.btn_Logout.Location = new System.Drawing.Point(185, 209);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(100, 48);
            this.btn_Logout.TabIndex = 5;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            // 
            // Development
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(386, 308);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_ManageCustomers);
            this.Controls.Add(this.btn_ViewStatus);
            this.Controls.Add(this.btn_DeleteProject);
            this.Controls.Add(this.btn_ManageProject);
            this.Controls.Add(this.btn_AddProject);
            this.Name = "Development";
            this.Text = "Development";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AddProject;
        private System.Windows.Forms.Button btn_ManageProject;
        private System.Windows.Forms.Button btn_DeleteProject;
        private System.Windows.Forms.Button btn_ViewStatus;
        private System.Windows.Forms.Button btn_ManageCustomers;
        private System.Windows.Forms.Button btn_Logout;
    }
}