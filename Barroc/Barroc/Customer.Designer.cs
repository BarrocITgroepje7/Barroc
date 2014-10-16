namespace Barroc
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
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
            this.btn_invisible.Location = new System.Drawing.Point(387, 213);
            this.btn_invisible.Name = "btn_invisible";
            this.btn_invisible.Size = new System.Drawing.Size(95, 37);
            this.btn_invisible.TabIndex = 2;
            this.btn_invisible.Text = "Delete";
            this.btn_invisible.UseVisualStyleBackColor = true;
            this.btn_invisible.Click += new System.EventHandler(this.btn_invisible_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(509, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(48, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add>>";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(497, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(60, 23);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "<<Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(12, 213);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(95, 37);
            this.back_btn.TabIndex = 5;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(564, 262);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_invisible);
            this.Controls.Add(this.Customer_grid);
            this.Controls.Add(this.btn_back);
            this.Name = "Customer";
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.Customer_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView Customer_grid;
        private System.Windows.Forms.Button btn_invisible;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button back_btn;

    }
}