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
            this.txt_customerid = new System.Windows.Forms.TextBox();
            this.txt_projectname = new System.Windows.Forms.TextBox();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.txt_applications = new System.Windows.Forms.TextBox();
            this.txt_hardware = new System.Windows.Forms.TextBox();
            this.txt_software = new System.Windows.Forms.TextBox();
            this.txt_offernumber = new System.Windows.Forms.TextBox();
            this.txt_internalcontactperson = new System.Windows.Forms.TextBox();
            this.txt_numberofinvoices = new System.Windows.Forms.TextBox();
            this.btn_toevoegen = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerid_lbl = new System.Windows.Forms.Label();
            this.projectname_lbl = new System.Windows.Forms.Label();
            this.status_lbl = new System.Windows.Forms.Label();
            this.applications_lbl = new System.Windows.Forms.Label();
            this.hardware_lbl = new System.Windows.Forms.Label();
            this.software_lbl = new System.Windows.Forms.Label();
            this.offernumber_lbl = new System.Windows.Forms.Label();
            this.internalcontactperson_lbl = new System.Windows.Forms.Label();
            this.numberofinvooices_lbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Project_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Project_grid
            // 
            this.Project_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Project_grid.Location = new System.Drawing.Point(12, 52);
            this.Project_grid.Name = "Project_grid";
            this.Project_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Project_grid.Size = new System.Drawing.Size(553, 180);
            this.Project_grid.TabIndex = 0;
            this.Project_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Project_grid_CellContentClick);
            this.Project_grid.DoubleClick += new System.EventHandler(this.Project_grid_DoubleClick);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 272);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(95, 37);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(470, 272);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(95, 37);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
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
            // lbl_customerid
            // 
            this.lbl_customerid.AutoSize = true;
            this.lbl_customerid.Location = new System.Drawing.Point(695, 15);
            this.lbl_customerid.Name = "lbl_customerid";
            this.lbl_customerid.Size = new System.Drawing.Size(65, 13);
            this.lbl_customerid.TabIndex = 6;
            this.lbl_customerid.Text = "Customer ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(689, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Project Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(723, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(696, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Applications";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(707, 157);
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
            // txt_customerid
            // 
            this.txt_customerid.Location = new System.Drawing.Point(769, 12);
            this.txt_customerid.Name = "txt_customerid";
            this.txt_customerid.Size = new System.Drawing.Size(143, 20);
            this.txt_customerid.TabIndex = 19;
            this.txt_customerid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_customerid_KeyPress);
            // 
            // txt_projectname
            // 
            this.txt_projectname.Location = new System.Drawing.Point(769, 66);
            this.txt_projectname.Name = "txt_projectname";
            this.txt_projectname.Size = new System.Drawing.Size(143, 20);
            this.txt_projectname.TabIndex = 21;
            this.txt_projectname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_projectname_KeyPress);
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(769, 97);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(143, 20);
            this.txt_status.TabIndex = 22;
            this.txt_status.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_status_KeyPress);
            // 
            // txt_applications
            // 
            this.txt_applications.Location = new System.Drawing.Point(769, 128);
            this.txt_applications.Name = "txt_applications";
            this.txt_applications.Size = new System.Drawing.Size(143, 20);
            this.txt_applications.TabIndex = 23;
            this.txt_applications.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_applications_KeyPress);
            // 
            // txt_hardware
            // 
            this.txt_hardware.Location = new System.Drawing.Point(769, 154);
            this.txt_hardware.Name = "txt_hardware";
            this.txt_hardware.Size = new System.Drawing.Size(143, 20);
            this.txt_hardware.TabIndex = 24;
            this.txt_hardware.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hardware_KeyPress);
            // 
            // txt_software
            // 
            this.txt_software.Location = new System.Drawing.Point(1045, 9);
            this.txt_software.Name = "txt_software";
            this.txt_software.Size = new System.Drawing.Size(143, 20);
            this.txt_software.TabIndex = 25;
            this.txt_software.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_software_KeyPress);
            // 
            // txt_offernumber
            // 
            this.txt_offernumber.Location = new System.Drawing.Point(1045, 39);
            this.txt_offernumber.Name = "txt_offernumber";
            this.txt_offernumber.Size = new System.Drawing.Size(143, 20);
            this.txt_offernumber.TabIndex = 26;
            this.txt_offernumber.TextChanged += new System.EventHandler(this.txt_offernumber_TextChanged);
            this.txt_offernumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_offernumber_KeyPress);
            // 
            // txt_internalcontactperson
            // 
            this.txt_internalcontactperson.Location = new System.Drawing.Point(1045, 71);
            this.txt_internalcontactperson.Name = "txt_internalcontactperson";
            this.txt_internalcontactperson.Size = new System.Drawing.Size(143, 20);
            this.txt_internalcontactperson.TabIndex = 27;
            this.txt_internalcontactperson.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_internalcontactperson_KeyPress);
            // 
            // txt_numberofinvoices
            // 
            this.txt_numberofinvoices.Location = new System.Drawing.Point(1045, 161);
            this.txt_numberofinvoices.Name = "txt_numberofinvoices";
            this.txt_numberofinvoices.Size = new System.Drawing.Size(143, 20);
            this.txt_numberofinvoices.TabIndex = 30;
            this.txt_numberofinvoices.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numberofinvoices_KeyPress);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(552, 20);
            this.textBox1.TabIndex = 32;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "* Search";
            // 
            // customerid_lbl
            // 
            this.customerid_lbl.AutoSize = true;
            this.customerid_lbl.BackColor = System.Drawing.SystemColors.Window;
            this.customerid_lbl.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.customerid_lbl.Location = new System.Drawing.Point(776, 15);
            this.customerid_lbl.Name = "customerid_lbl";
            this.customerid_lbl.Size = new System.Drawing.Size(13, 13);
            this.customerid_lbl.TabIndex = 35;
            this.customerid_lbl.Text = "1";
            this.customerid_lbl.Click += new System.EventHandler(this.customerid_lbl_Click);
            // 
            // projectname_lbl
            // 
            this.projectname_lbl.AutoSize = true;
            this.projectname_lbl.BackColor = System.Drawing.SystemColors.Window;
            this.projectname_lbl.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.projectname_lbl.Location = new System.Drawing.Point(776, 69);
            this.projectname_lbl.Name = "projectname_lbl";
            this.projectname_lbl.Size = new System.Drawing.Size(69, 13);
            this.projectname_lbl.TabIndex = 36;
            this.projectname_lbl.Text = "Project sprak";
            this.projectname_lbl.Click += new System.EventHandler(this.projectname_lbl_Click);
            // 
            // status_lbl
            // 
            this.status_lbl.AutoSize = true;
            this.status_lbl.BackColor = System.Drawing.SystemColors.Window;
            this.status_lbl.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.status_lbl.Location = new System.Drawing.Point(776, 100);
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(38, 13);
            this.status_lbl.TabIndex = 37;
            this.status_lbl.Text = "Ready";
            this.status_lbl.Click += new System.EventHandler(this.status_lbl_Click);
            // 
            // applications_lbl
            // 
            this.applications_lbl.AutoSize = true;
            this.applications_lbl.BackColor = System.Drawing.SystemColors.Window;
            this.applications_lbl.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.applications_lbl.Location = new System.Drawing.Point(776, 131);
            this.applications_lbl.Name = "applications_lbl";
            this.applications_lbl.Size = new System.Drawing.Size(92, 13);
            this.applications_lbl.TabIndex = 38;
            this.applications_lbl.Text = "Mobile application";
            this.applications_lbl.Click += new System.EventHandler(this.applications_lbl_Click);
            // 
            // hardware_lbl
            // 
            this.hardware_lbl.AutoSize = true;
            this.hardware_lbl.BackColor = System.Drawing.SystemColors.Window;
            this.hardware_lbl.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.hardware_lbl.Location = new System.Drawing.Point(776, 157);
            this.hardware_lbl.Name = "hardware_lbl";
            this.hardware_lbl.Size = new System.Drawing.Size(38, 13);
            this.hardware_lbl.TabIndex = 39;
            this.hardware_lbl.Text = "Mobile";
            this.hardware_lbl.Click += new System.EventHandler(this.hardware_lbl_Click);
            // 
            // software_lbl
            // 
            this.software_lbl.AutoSize = true;
            this.software_lbl.BackColor = System.Drawing.SystemColors.Window;
            this.software_lbl.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.software_lbl.Location = new System.Drawing.Point(1053, 12);
            this.software_lbl.Name = "software_lbl";
            this.software_lbl.Size = new System.Drawing.Size(93, 13);
            this.software_lbl.TabIndex = 40;
            this.software_lbl.Text = "Visual studio 2013";
            this.software_lbl.Click += new System.EventHandler(this.software_lbl_Click);
            // 
            // offernumber_lbl
            // 
            this.offernumber_lbl.AutoSize = true;
            this.offernumber_lbl.BackColor = System.Drawing.SystemColors.Window;
            this.offernumber_lbl.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.offernumber_lbl.Location = new System.Drawing.Point(1053, 42);
            this.offernumber_lbl.Name = "offernumber_lbl";
            this.offernumber_lbl.Size = new System.Drawing.Size(13, 13);
            this.offernumber_lbl.TabIndex = 41;
            this.offernumber_lbl.Text = "1";
            this.offernumber_lbl.Click += new System.EventHandler(this.offernumber_lbl_Click);
            // 
            // internalcontactperson_lbl
            // 
            this.internalcontactperson_lbl.AutoSize = true;
            this.internalcontactperson_lbl.BackColor = System.Drawing.SystemColors.Window;
            this.internalcontactperson_lbl.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.internalcontactperson_lbl.Location = new System.Drawing.Point(1053, 74);
            this.internalcontactperson_lbl.Name = "internalcontactperson_lbl";
            this.internalcontactperson_lbl.Size = new System.Drawing.Size(59, 13);
            this.internalcontactperson_lbl.TabIndex = 42;
            this.internalcontactperson_lbl.Text = "Teun Aarts";
            this.internalcontactperson_lbl.Click += new System.EventHandler(this.internalcontactperson_lbl_Click);
            // 
            // numberofinvooices_lbl
            // 
            this.numberofinvooices_lbl.AutoSize = true;
            this.numberofinvooices_lbl.BackColor = System.Drawing.SystemColors.Window;
            this.numberofinvooices_lbl.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.numberofinvooices_lbl.Location = new System.Drawing.Point(1053, 164);
            this.numberofinvooices_lbl.Name = "numberofinvooices_lbl";
            this.numberofinvooices_lbl.Size = new System.Drawing.Size(13, 13);
            this.numberofinvooices_lbl.TabIndex = 43;
            this.numberofinvooices_lbl.Text = "1";
            this.numberofinvooices_lbl.Click += new System.EventHandler(this.numberofinvooices_lbl_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(1045, 99);
            this.dateTimePicker1.MinDate = new System.DateTime(2014, 11, 5, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(102, 20);
            this.dateTimePicker1.TabIndex = 44;
            this.dateTimePicker1.Value = new System.DateTime(2014, 11, 5, 13, 38, 53, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(1045, 130);
            this.dateTimePicker2.MinDate = new System.DateTime(2014, 11, 5, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(102, 20);
            this.dateTimePicker2.TabIndex = 45;
            this.dateTimePicker2.Value = new System.DateTime(2014, 11, 5, 13, 38, 53, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(648, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Maintenance Contract";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(769, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 21);
            this.comboBox1.TabIndex = 47;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "* Double click to change the project";
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(641, 321);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.numberofinvooices_lbl);
            this.Controls.Add(this.internalcontactperson_lbl);
            this.Controls.Add(this.offernumber_lbl);
            this.Controls.Add(this.software_lbl);
            this.Controls.Add(this.hardware_lbl);
            this.Controls.Add(this.applications_lbl);
            this.Controls.Add(this.status_lbl);
            this.Controls.Add(this.projectname_lbl);
            this.Controls.Add(this.customerid_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_toevoegen);
            this.Controls.Add(this.txt_numberofinvoices);
            this.Controls.Add(this.txt_internalcontactperson);
            this.Controls.Add(this.txt_offernumber);
            this.Controls.Add(this.txt_software);
            this.Controls.Add(this.txt_hardware);
            this.Controls.Add(this.txt_applications);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.txt_projectname);
            this.Controls.Add(this.txt_customerid);
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
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.Project_grid);
            this.Controls.Add(this.back_btn);
            this.Name = "Project";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project";
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
        private System.Windows.Forms.TextBox txt_customerid;
        private System.Windows.Forms.TextBox txt_projectname;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.TextBox txt_applications;
        private System.Windows.Forms.TextBox txt_hardware;
        private System.Windows.Forms.TextBox txt_software;
        private System.Windows.Forms.TextBox txt_offernumber;
        private System.Windows.Forms.TextBox txt_internalcontactperson;
        private System.Windows.Forms.TextBox txt_numberofinvoices;
        private System.Windows.Forms.Button btn_toevoegen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label customerid_lbl;
        private System.Windows.Forms.Label projectname_lbl;
        private System.Windows.Forms.Label status_lbl;
        private System.Windows.Forms.Label applications_lbl;
        private System.Windows.Forms.Label hardware_lbl;
        private System.Windows.Forms.Label software_lbl;
        private System.Windows.Forms.Label offernumber_lbl;
        private System.Windows.Forms.Label internalcontactperson_lbl;
        private System.Windows.Forms.Label numberofinvooices_lbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}