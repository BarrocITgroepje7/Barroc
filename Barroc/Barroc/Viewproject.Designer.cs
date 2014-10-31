namespace Barroc
{
    partial class Viewproject
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
            this.viewporject_grid = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewporject_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // viewporject_grid
            // 
            this.viewporject_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewporject_grid.Location = new System.Drawing.Point(13, 13);
            this.viewporject_grid.Name = "viewporject_grid";
            this.viewporject_grid.Size = new System.Drawing.Size(609, 193);
            this.viewporject_grid.TabIndex = 0;
            this.viewporject_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewporject_grid_CellContentClick);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 212);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(95, 37);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Viewproject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(634, 261);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.viewporject_grid);
            this.Name = "Viewproject";
            this.Text = "Viewproject";
            ((System.ComponentModel.ISupportInitialize)(this.viewporject_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView viewporject_grid;
        private System.Windows.Forms.Button btn_back;
    }
}