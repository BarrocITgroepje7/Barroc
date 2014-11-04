namespace Barroc
{
    partial class Finance
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
            this.button1 = new System.Windows.Forms.Button();
            this.finance_lbl = new System.Windows.Forms.Label();
            this.financial_btn = new System.Windows.Forms.Button();
            this.customervieuw = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(569, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // finance_lbl
            // 
            this.finance_lbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.finance_lbl.Enabled = false;
            this.finance_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finance_lbl.Location = new System.Drawing.Point(12, 9);
            this.finance_lbl.Name = "finance_lbl";
            this.finance_lbl.Size = new System.Drawing.Size(77, 39);
            this.finance_lbl.TabIndex = 0;
            this.finance_lbl.Text = "Welkom Finance ";
            // 
            // financial_btn
            // 
            this.financial_btn.Location = new System.Drawing.Point(127, 12);
            this.financial_btn.Name = "financial_btn";
            this.financial_btn.Size = new System.Drawing.Size(97, 36);
            this.financial_btn.TabIndex = 3;
            this.financial_btn.Text = "financial customer";
            this.financial_btn.UseVisualStyleBackColor = true;
            this.financial_btn.Click += new System.EventHandler(this.financial_btn_Click);
            // 
            // customervieuw
            // 
            this.customervieuw.Location = new System.Drawing.Point(127, 64);
            this.customervieuw.Name = "customervieuw";
            this.customervieuw.Size = new System.Drawing.Size(97, 36);
            this.customervieuw.TabIndex = 4;
            this.customervieuw.Text = "Vieuw Customer";
            this.customervieuw.UseVisualStyleBackColor = true;
            this.customervieuw.Click += new System.EventHandler(this.customervieuw_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(127, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "Edit financial";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(247, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 36);
            this.button3.TabIndex = 6;
            this.button3.Text = "Delete Financials";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(547, 216);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 36);
            this.button4.TabIndex = 7;
            this.button4.Text = "Log Out";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Finance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(656, 264);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.customervieuw);
            this.Controls.Add(this.financial_btn);
            this.Controls.Add(this.finance_lbl);
            this.Controls.Add(this.button1);
            this.Name = "Finance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label finance_lbl;
        private System.Windows.Forms.Button financial_btn;
        private System.Windows.Forms.Button customervieuw;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}