﻿namespace Barroc
{
    partial class Customer
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
            this.Customer_grid = new System.Windows.Forms.DataGridView();
            this.btn_invisible = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Customer_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Customer_grid
            // 
            this.Customer_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Customer_grid.Location = new System.Drawing.Point(12, 12);
            this.Customer_grid.Name = "Customer_grid";
            this.Customer_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Customer_grid.Size = new System.Drawing.Size(470, 181);
            this.Customer_grid.TabIndex = 1;
            this.Customer_grid.DoubleClick += new System.EventHandler(this.Customer_grid_DoubleClick);
            // 
            // btn_invisible
            // 
            this.btn_invisible.Location = new System.Drawing.Point(405, 213);
            this.btn_invisible.Name = "btn_invisible";
            this.btn_invisible.Size = new System.Drawing.Size(95, 37);
            this.btn_invisible.TabIndex = 2;
            this.btn_invisible.Text = "Invisible";
            this.btn_invisible.UseVisualStyleBackColor = true;
            this.btn_invisible.Click += new System.EventHandler(this.btn_invisible_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(512, 262);
            this.Controls.Add(this.btn_invisible);
            this.Controls.Add(this.Customer_grid);
            this.Name = "Customer";
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.Customer_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView Customer_grid;
        private System.Windows.Forms.Button btn_invisible;

    }
}