namespace Barroc
{
    partial class Appointment
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Subject_txt = new System.Windows.Forms.TextBox();
            this.Next_txt = new System.Windows.Forms.TextBox();
            this.Contact_txt = new System.Windows.Forms.TextBox();
            this.Action_txt = new System.Windows.Forms.TextBox();
            this.Customer_txt = new System.Windows.Forms.TextBox();
            this.Appointment_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Appointment_grid = new System.Windows.Forms.DataGridView();
            this.back_btn = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Appointment_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(642, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Subject";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(642, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Next Action";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(642, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Last Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(642, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Date of Action";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(642, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Customer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(639, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Appointment ID";
            // 
            // Subject_txt
            // 
            this.Subject_txt.Location = new System.Drawing.Point(725, 141);
            this.Subject_txt.Name = "Subject_txt";
            this.Subject_txt.Size = new System.Drawing.Size(100, 20);
            this.Subject_txt.TabIndex = 24;
            // 
            // Next_txt
            // 
            this.Next_txt.Location = new System.Drawing.Point(725, 115);
            this.Next_txt.Name = "Next_txt";
            this.Next_txt.Size = new System.Drawing.Size(100, 20);
            this.Next_txt.TabIndex = 23;
            // 
            // Contact_txt
            // 
            this.Contact_txt.Location = new System.Drawing.Point(725, 89);
            this.Contact_txt.Name = "Contact_txt";
            this.Contact_txt.Size = new System.Drawing.Size(100, 20);
            this.Contact_txt.TabIndex = 22;
            // 
            // Action_txt
            // 
            this.Action_txt.Location = new System.Drawing.Point(725, 63);
            this.Action_txt.Name = "Action_txt";
            this.Action_txt.Size = new System.Drawing.Size(100, 20);
            this.Action_txt.TabIndex = 21;
            // 
            // Customer_txt
            // 
            this.Customer_txt.Location = new System.Drawing.Point(725, 37);
            this.Customer_txt.Name = "Customer_txt";
            this.Customer_txt.Size = new System.Drawing.Size(100, 20);
            this.Customer_txt.TabIndex = 20;
            // 
            // Appointment_txt
            // 
            this.Appointment_txt.Location = new System.Drawing.Point(725, 11);
            this.Appointment_txt.Name = "Appointment_txt";
            this.Appointment_txt.Size = new System.Drawing.Size(100, 20);
            this.Appointment_txt.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(723, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add Appointments";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(584, 12);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(48, 23);
            this.Add_btn.TabIndex = 17;
            this.Add_btn.Text = "Add>>";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Appointment_grid
            // 
            this.Appointment_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Appointment_grid.Location = new System.Drawing.Point(12, 12);
            this.Appointment_grid.Name = "Appointment_grid";
            this.Appointment_grid.Size = new System.Drawing.Size(553, 180);
            this.Appointment_grid.TabIndex = 16;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(572, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(60, 23);
            this.back_btn.TabIndex = 31;
            this.back_btn.Text = "<<Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(13, 219);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 32;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 262);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Subject_txt);
            this.Controls.Add(this.Next_txt);
            this.Controls.Add(this.Contact_txt);
            this.Controls.Add(this.Action_txt);
            this.Controls.Add(this.Customer_txt);
            this.Controls.Add(this.Appointment_txt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.Appointment_grid);
            this.Controls.Add(this.back_btn);
            this.Name = "Appointment";
            this.Text = "Appointment";
            ((System.ComponentModel.ISupportInitialize)(this.Appointment_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Subject_txt;
        private System.Windows.Forms.TextBox Next_txt;
        private System.Windows.Forms.TextBox Contact_txt;
        private System.Windows.Forms.TextBox Action_txt;
        private System.Windows.Forms.TextBox Customer_txt;
        private System.Windows.Forms.TextBox Appointment_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.DataGridView Appointment_grid;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button btn_back;
    }
}