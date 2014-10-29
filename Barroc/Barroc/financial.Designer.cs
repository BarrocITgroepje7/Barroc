namespace Barroc
{
    partial class financial
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
            this.financialgrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.financialgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // financialgrid
            // 
            this.financialgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.financialgrid.Location = new System.Drawing.Point(12, 12);
            this.financialgrid.Name = "financialgrid";
            this.financialgrid.Size = new System.Drawing.Size(521, 169);
            this.financialgrid.TabIndex = 0;
            // 
            // financial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 274);
            this.Controls.Add(this.financialgrid);
            this.Name = "financial";
            this.Text = "financial";
            ((System.ComponentModel.ISupportInitialize)(this.financialgrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView financialgrid;
    }
}