namespace Barroc
{
    partial class ViewStatus
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
            this.viewstatus_grid = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewstatus_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // viewstatus_grid
            // 
            this.viewstatus_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewstatus_grid.Location = new System.Drawing.Point(13, 13);
            this.viewstatus_grid.Name = "viewstatus_grid";
            this.viewstatus_grid.Size = new System.Drawing.Size(586, 177);
            this.viewstatus_grid.TabIndex = 0;
            this.viewstatus_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewstatus_grid_CellContentClick);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 214);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(95, 37);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // ViewStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(611, 263);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.viewstatus_grid);
            this.Name = "ViewStatus";
            this.Text = "ViewStatus";
            ((System.ComponentModel.ISupportInitialize)(this.viewstatus_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView viewstatus_grid;
        private System.Windows.Forms.Button btn_back;
    }
}