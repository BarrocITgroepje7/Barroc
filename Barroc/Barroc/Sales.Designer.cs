namespace Barroc
{
    partial class Sales
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
            this.appointment_btn = new System.Windows.Forms.Button();
            this.Deletecustomer = new System.Windows.Forms.Button();
            this.Manageproject_btn = new System.Windows.Forms.Button();
            this.Managecustomer_btn = new System.Windows.Forms.Button();
            this.Createcustomer_btn = new System.Windows.Forms.Button();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.Welkom_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // appointment_btn
            // 
            this.appointment_btn.Location = new System.Drawing.Point(16, 135);
            this.appointment_btn.Name = "appointment_btn";
            this.appointment_btn.Size = new System.Drawing.Size(81, 37);
            this.appointment_btn.TabIndex = 13;
            this.appointment_btn.Text = "Appointment";
            this.appointment_btn.UseVisualStyleBackColor = true;
            this.appointment_btn.Click += new System.EventHandler(this.appointment_btn_Click);
            // 
            // Deletecustomer
            // 
            this.Deletecustomer.Location = new System.Drawing.Point(337, 135);
            this.Deletecustomer.Name = "Deletecustomer";
            this.Deletecustomer.Size = new System.Drawing.Size(95, 37);
            this.Deletecustomer.TabIndex = 12;
            this.Deletecustomer.Text = "Delete customer";
            this.Deletecustomer.UseVisualStyleBackColor = true;
            // 
            // Manageproject_btn
            // 
            this.Manageproject_btn.Location = new System.Drawing.Point(337, 53);
            this.Manageproject_btn.Name = "Manageproject_btn";
            this.Manageproject_btn.Size = new System.Drawing.Size(95, 37);
            this.Manageproject_btn.TabIndex = 11;
            this.Manageproject_btn.Text = "Manage project";
            this.Manageproject_btn.UseVisualStyleBackColor = true;
            // 
            // Managecustomer_btn
            // 
            this.Managecustomer_btn.Location = new System.Drawing.Point(165, 135);
            this.Managecustomer_btn.Name = "Managecustomer_btn";
            this.Managecustomer_btn.Size = new System.Drawing.Size(95, 37);
            this.Managecustomer_btn.TabIndex = 10;
            this.Managecustomer_btn.Text = "Manage customer";
            this.Managecustomer_btn.UseVisualStyleBackColor = true;
            this.Managecustomer_btn.Click += new System.EventHandler(this.Managecustomer_btn_Click);
            // 
            // Createcustomer_btn
            // 
            this.Createcustomer_btn.Location = new System.Drawing.Point(165, 53);
            this.Createcustomer_btn.Name = "Createcustomer_btn";
            this.Createcustomer_btn.Size = new System.Drawing.Size(95, 37);
            this.Createcustomer_btn.TabIndex = 9;
            this.Createcustomer_btn.Text = "Create customer";
            this.Createcustomer_btn.UseVisualStyleBackColor = true;
            // 
            // Logout_btn
            // 
            this.Logout_btn.Location = new System.Drawing.Point(16, 53);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(95, 37);
            this.Logout_btn.TabIndex = 8;
            this.Logout_btn.Text = "Log out";
            this.Logout_btn.UseVisualStyleBackColor = true;
            // 
            // Welkom_lbl
            // 
            this.Welkom_lbl.AutoSize = true;
            this.Welkom_lbl.Font = new System.Drawing.Font("Khmer UI", 12F, System.Drawing.FontStyle.Bold);
            this.Welkom_lbl.Location = new System.Drawing.Point(12, 9);
            this.Welkom_lbl.Name = "Welkom_lbl";
            this.Welkom_lbl.Size = new System.Drawing.Size(117, 21);
            this.Welkom_lbl.TabIndex = 7;
            this.Welkom_lbl.Text = "Welkom Sales";
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(454, 203);
            this.Controls.Add(this.appointment_btn);
            this.Controls.Add(this.Deletecustomer);
            this.Controls.Add(this.Manageproject_btn);
            this.Controls.Add(this.Managecustomer_btn);
            this.Controls.Add(this.Createcustomer_btn);
            this.Controls.Add(this.Logout_btn);
            this.Controls.Add(this.Welkom_lbl);
            this.Name = "Sales";
            this.Text = "Sales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sales_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button appointment_btn;
        private System.Windows.Forms.Button Deletecustomer;
        private System.Windows.Forms.Button Manageproject_btn;
        private System.Windows.Forms.Button Managecustomer_btn;
        private System.Windows.Forms.Button Createcustomer_btn;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.Label Welkom_lbl;
    }
}