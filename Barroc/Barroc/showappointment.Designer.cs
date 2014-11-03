namespace Barroc
{
    partial class showappointment
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nextcontact = new System.Windows.Forms.TextBox();
            this.txt_subject = new System.Windows.Forms.TextBox();
            this.txt_lastcontact = new System.Windows.Forms.TextBox();
            this.txt_datofaction = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of Action";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Contact";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Next Contact";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Subject";
            // 
            // txt_nextcontact
            // 
            this.txt_nextcontact.Location = new System.Drawing.Point(144, 116);
            this.txt_nextcontact.Name = "txt_nextcontact";
            this.txt_nextcontact.Size = new System.Drawing.Size(159, 20);
            this.txt_nextcontact.TabIndex = 7;
            // 
            // txt_subject
            // 
            this.txt_subject.Location = new System.Drawing.Point(144, 164);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(159, 20);
            this.txt_subject.TabIndex = 8;
            // 
            // txt_lastcontact
            // 
            this.txt_lastcontact.Location = new System.Drawing.Point(144, 70);
            this.txt_lastcontact.Name = "txt_lastcontact";
            this.txt_lastcontact.Size = new System.Drawing.Size(159, 20);
            this.txt_lastcontact.TabIndex = 9;
            // 
            // txt_datofaction
            // 
            this.txt_datofaction.Location = new System.Drawing.Point(144, 26);
            this.txt_datofaction.Name = "txt_datofaction";
            this.txt_datofaction.Size = new System.Drawing.Size(159, 20);
            this.txt_datofaction.TabIndex = 10;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(265, 239);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(95, 37);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(17, 239);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(95, 37);
            this.btn_back.TabIndex = 12;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // showappointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(372, 288);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_datofaction);
            this.Controls.Add(this.txt_lastcontact);
            this.Controls.Add(this.txt_subject);
            this.Controls.Add(this.txt_nextcontact);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "showappointment";
            this.Text = "showappointment";
            this.Load += new System.EventHandler(this.showappointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.TextBox txt_nextcontact;
        public System.Windows.Forms.TextBox txt_subject;
        public System.Windows.Forms.TextBox txt_lastcontact;
        public System.Windows.Forms.TextBox txt_datofaction;
        private System.Windows.Forms.Button btn_back;
    }
}