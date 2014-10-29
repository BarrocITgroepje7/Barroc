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
            // Finance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 264);
            this.Controls.Add(this.financial_btn);
            this.Controls.Add(this.finance_lbl);
            this.Controls.Add(this.button1);
            this.Name = "Finance";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label finance_lbl;
        private System.Windows.Forms.Button financial_btn;
    }
}