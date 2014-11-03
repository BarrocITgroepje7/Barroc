namespace Barroc
{
    partial class Form1
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
            this.Username_txt = new System.Windows.Forms.TextBox();
            this.Password_lbl = new System.Windows.Forms.Label();
            this.Username_lbl = new System.Windows.Forms.Label();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Username_txt
            // 
            this.Username_txt.Location = new System.Drawing.Point(251, 52);
            this.Username_txt.Name = "Username_txt";
            this.Username_txt.Size = new System.Drawing.Size(117, 20);
            this.Username_txt.TabIndex = 12;
            // 
            // Password_lbl
            // 
            this.Password_lbl.AutoSize = true;
            this.Password_lbl.Location = new System.Drawing.Point(179, 97);
            this.Password_lbl.Name = "Password_lbl";
            this.Password_lbl.Size = new System.Drawing.Size(53, 13);
            this.Password_lbl.TabIndex = 11;
            this.Password_lbl.Text = "Password";
            // 
            // Username_lbl
            // 
            this.Username_lbl.AutoSize = true;
            this.Username_lbl.Location = new System.Drawing.Point(177, 52);
            this.Username_lbl.Name = "Username_lbl";
            this.Username_lbl.Size = new System.Drawing.Size(55, 13);
            this.Username_lbl.TabIndex = 10;
            this.Username_lbl.Text = "Username";
            // 
            // Name_lbl
            // 
            this.Name_lbl.Font = new System.Drawing.Font("Khmer UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_lbl.Location = new System.Drawing.Point(12, 9);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(147, 45);
            this.Name_lbl.TabIndex = 9;
            this.Name_lbl.Text = "Barroc IT.               Software for real";
            this.Name_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Password_txt
            // 
            this.Password_txt.Location = new System.Drawing.Point(251, 97);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.PasswordChar = '•';
            this.Password_txt.Size = new System.Drawing.Size(117, 20);
            this.Password_txt.TabIndex = 8;
            this.Password_txt.Tag = "";
            // 
            // Btn_Login
            // 
            this.Btn_Login.AutoSize = true;
            this.Btn_Login.Location = new System.Drawing.Point(251, 142);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(117, 27);
            this.Btn_Login.TabIndex = 7;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(375, 175);
            this.Controls.Add(this.Username_txt);
            this.Controls.Add(this.Password_lbl);
            this.Controls.Add(this.Username_lbl);
            this.Controls.Add(this.Name_lbl);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.Btn_Login);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barroc-IT Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username_txt;
        private System.Windows.Forms.Label Password_lbl;
        private System.Windows.Forms.Label Username_lbl;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.Button Btn_Login;
    }
}

