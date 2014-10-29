namespace Barroc
{
    partial class Project
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
            this.Project_grid = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.lbl_projectid = new System.Windows.Forms.Label();
            this.lbl_customerid = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_projectid = new System.Windows.Forms.TextBox();
            this.txt_customerid = new System.Windows.Forms.TextBox();
            this.txt_projectname = new System.Windows.Forms.TextBox();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.txt_applications = new System.Windows.Forms.TextBox();
            this.txt_hardware = new System.Windows.Forms.TextBox();
            this.txt_software = new System.Windows.Forms.TextBox();
            this.txt_offernumber = new System.Windows.Forms.TextBox();
            this.txt_internalcontactperson = new System.Windows.Forms.TextBox();
            this.txt_startdate = new System.Windows.Forms.TextBox();
            this.txt_enddate = new System.Windows.Forms.TextBox();
            this.txt_numberofinvoices = new System.Windows.Forms.TextBox();
            this.btn_toevoegen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Project_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Project_grid
            // 
            this.Project_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Project_grid.Location = new System.Drawing.Point(12, 12);
            this.Project_grid.Name = "Project_grid";
            this.Project_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Project_grid.Size = new System.Drawing.Size(553, 180);
            this.Project_grid.TabIndex = 0;
            this.Project_grid.DoubleClick += new System.EventHandler(this.Project_grid_DoubleClick);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 213);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(95, 37);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(530, 213);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(95, 37);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(571, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(60, 23);
            this.back_btn.TabIndex = 3;
            this.back_btn.Text = "<<Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(583, 12);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(48, 23);
            this.add_btn.TabIndex = 4;
            this.add_btn.Text = "Add>>";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // lbl_projectid
            // 
            this.lbl_projectid.AutoSize = true;
            this.lbl_projectid.Location = new System.Drawing.Point(703, 12);
            this.lbl_projectid.Name = "lbl_projectid";
            this.lbl_projectid.Size = new System.Drawing.Size(54, 13);
            this.lbl_projectid.TabIndex = 5;
            this.lbl_projectid.Text = "Project ID";
            // 
            // lbl_customerid
            // 
            this.lbl_customerid.AutoSize = true;
            this.lbl_customerid.Location = new System.Drawing.Point(692, 42);
            this.lbl_customerid.Name = "lbl_customerid";
            this.lbl_customerid.Size = new System.Drawing.Size(65, 13);
            this.lbl_customerid.TabIndex = 6;
            this.lbl_customerid.Text = "Customer ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(686, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Project Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(720, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(693, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Applications";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(704, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Hardware";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(988, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Software";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(969, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Offer Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(921, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Internal Contact Person";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(982, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Start Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(985, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "End Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(938, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Number of Invoices";
            // 
            // txt_projectid
            // 
            this.txt_projectid.Location = new System.Drawing.Point(766, 9);
            this.txt_projectid.Name = "txt_projectid";
            this.txt_projectid.Size = new System.Drawing.Size(143, 20);
            this.txt_projectid.TabIndex = 18;
            // 
            // txt_customerid
            // 
            this.txt_customerid.Location = new System.Drawing.Point(766, 39);
            this.txt_customerid.Name = "txt_customerid";
            this.txt_customerid.Size = new System.Drawing.Size(143, 20);
            this.txt_customerid.TabIndex = 19;
            // 
            // txt_projectname
            // 
            this.txt_projectname.Location = new System.Drawing.Point(766, 71);
            this.txt_projectname.Name = "txt_projectname";
            this.txt_projectname.Size = new System.Drawing.Size(143, 20);
            this.txt_projectname.TabIndex = 21;
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(766, 102);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(143, 20);
            this.txt_status.TabIndex = 22;
            // 
            // txt_applications
            // 
            this.txt_applications.Location = new System.Drawing.Point(766, 133);
            this.txt_applications.Name = "txt_applications";
            this.txt_applications.Size = new System.Drawing.Size(143, 20);
            this.txt_applications.TabIndex = 23;
            // 
            // txt_hardware
            // 
            this.txt_hardware.Location = new System.Drawing.Point(766, 162);
            this.txt_hardware.Name = "txt_hardware";
            this.txt_hardware.Size = new System.Drawing.Size(143, 20);
            this.txt_hardware.TabIndex = 24;
            // 
            // txt_software
            // 
            this.txt_software.Location = new System.Drawing.Point(1045, 9);
            this.txt_software.Name = "txt_software";
            this.txt_software.Size = new System.Drawing.Size(143, 20);
            this.txt_software.TabIndex = 25;
            // 
            // txt_offernumber
            // 
            this.txt_offernumber.Location = new System.Drawing.Point(1045, 39);
            this.txt_offernumber.Name = "txt_offernumber";
            this.txt_offernumber.Size = new System.Drawing.Size(143, 20);
            this.txt_offernumber.TabIndex = 26;
            // 
            // txt_internalcontactperson
            // 
            this.txt_internalcontactperson.Location = new System.Drawing.Point(1045, 71);
            this.txt_internalcontactperson.Name = "txt_internalcontactperson";
            this.txt_internalcontactperson.Size = new System.Drawing.Size(143, 20);
            this.txt_internalcontactperson.TabIndex = 27;
            // 
            // txt_startdate
            // 
            this.txt_startdate.Location = new System.Drawing.Point(1045, 102);
            this.txt_startdate.Name = "txt_startdate";
            this.txt_startdate.Size = new System.Drawing.Size(143, 20);
            this.txt_startdate.TabIndex = 28;
            // 
            // txt_enddate
            // 
            this.txt_enddate.Location = new System.Drawing.Point(1045, 133);
            this.txt_enddate.Name = "txt_enddate";
            this.txt_enddate.Size = new System.Drawing.Size(143, 20);
            this.txt_enddate.TabIndex = 29;
            // 
            // txt_numberofinvoices
            // 
            this.txt_numberofinvoices.Location = new System.Drawing.Point(1045, 161);
            this.txt_numberofinvoices.Name = "txt_numberofinvoices";
            this.txt_numberofinvoices.Size = new System.Drawing.Size(143, 20);
            this.txt_numberofinvoices.TabIndex = 30;
            // 
            // btn_toevoegen
            // 
            this.btn_toevoegen.Location = new System.Drawing.Point(1093, 213);
            this.btn_toevoegen.Name = "btn_toevoegen";
            this.btn_toevoegen.Size = new System.Drawing.Size(95, 37);
            this.btn_toevoegen.TabIndex = 31;
            this.btn_toevoegen.Text = "Toevoegen";
            this.btn_toevoegen.UseVisualStyleBackColor = true;
            this.btn_toevoegen.Click += new System.EventHandler(this.btn_toevoegen_Click);
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1230, 261);
            this.Controls.Add(this.btn_toevoegen);
            this.Controls.Add(this.txt_numberofinvoices);
            this.Controls.Add(this.txt_enddate);
            this.Controls.Add(this.txt_startdate);
            this.Controls.Add(this.txt_internalcontactperson);
            this.Controls.Add(this.txt_offernumber);
            this.Controls.Add(this.txt_software);
            this.Controls.Add(this.txt_hardware);
            this.Controls.Add(this.txt_applications);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.txt_projectname);
            this.Controls.Add(this.txt_customerid);
            this.Controls.Add(this.txt_projectid);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_customerid);
            this.Controls.Add(this.lbl_projectid);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.Project_grid);
            this.Controls.Add(this.back_btn);
            this.Name = "Project";
            this.Text = "x";
            ((System.ComponentModel.ISupportInitialize)(this.Project_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Project_grid;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label lbl_projectid;
        private System.Windows.Forms.Label lbl_customerid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_projectid;
        private System.Windows.Forms.TextBox txt_customerid;
        private System.Windows.Forms.TextBox txt_projectname;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.TextBox txt_applications;
        private System.Windows.Forms.TextBox txt_hardware;
        private System.Windows.Forms.TextBox txt_software;
        private System.Windows.Forms.TextBox txt_offernumber;
        private System.Windows.Forms.TextBox txt_internalcontactperson;
        private System.Windows.Forms.TextBox txt_startdate;
        private System.Windows.Forms.TextBox txt_enddate;
        private System.Windows.Forms.TextBox txt_numberofinvoices;
        private System.Windows.Forms.Button btn_toevoegen;
    }
}