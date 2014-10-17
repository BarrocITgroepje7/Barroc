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
            this.lbl_Cutomerid = new System.Windows.Forms.Label();
            this.lbl_Cutomername = new System.Windows.Forms.Label();
            this.lbl_adress = new System.Windows.Forms.Label();
            this.lbl_secondadress = new System.Windows.Forms.Label();
            this.lbl_zipcode = new System.Windows.Forms.Label();
            this.lbl_residence = new System.Windows.Forms.Label();
            this.txt_customerid = new System.Windows.Forms.TextBox();
            this.txt_secondadress = new System.Windows.Forms.TextBox();
            this.txt_residence = new System.Windows.Forms.TextBox();
            this.txt_zipcode = new System.Windows.Forms.TextBox();
            this.txt_adress = new System.Windows.Forms.TextBox();
            this.txt_customername = new System.Windows.Forms.TextBox();
            this.lbl_secondresidence = new System.Windows.Forms.Label();
            this.lbl_contactperson = new System.Windows.Forms.Label();
            this.lbl_secondzipcode = new System.Windows.Forms.Label();
            this.lbl_secondtelephonenumber = new System.Windows.Forms.Label();
            this.lbl_telephonenumber = new System.Windows.Forms.Label();
            this.lbl_initials = new System.Windows.Forms.Label();
            this.lbl_faxnumber = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_secondzipcode = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_faxnumber = new System.Windows.Forms.TextBox();
            this.txt_secondtelephonenumber = new System.Windows.Forms.TextBox();
            this.txt_telephonenumber = new System.Windows.Forms.TextBox();
            this.txt_initials = new System.Windows.Forms.TextBox();
            this.txt_contactperson = new System.Windows.Forms.TextBox();
            this.txt_secondresidence = new System.Windows.Forms.TextBox();
            this.btn_toevoegen = new System.Windows.Forms.Button();
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
            // lbl_Cutomerid
            // 
            this.lbl_Cutomerid.AutoSize = true;
            this.lbl_Cutomerid.Location = new System.Drawing.Point(620, 17);
            this.lbl_Cutomerid.Name = "lbl_Cutomerid";
            this.lbl_Cutomerid.Size = new System.Drawing.Size(60, 13);
            this.lbl_Cutomerid.TabIndex = 6;
            this.lbl_Cutomerid.Text = "Cutomer ID";
            // 
            // lbl_Cutomername
            // 
            this.lbl_Cutomername.AutoSize = true;
            this.lbl_Cutomername.Location = new System.Drawing.Point(603, 45);
            this.lbl_Cutomername.Name = "lbl_Cutomername";
            this.lbl_Cutomername.Size = new System.Drawing.Size(77, 13);
            this.lbl_Cutomername.TabIndex = 7;
            this.lbl_Cutomername.Text = "Cutomer Name";
            // 
            // lbl_adress
            // 
            this.lbl_adress.AutoSize = true;
            this.lbl_adress.Location = new System.Drawing.Point(641, 73);
            this.lbl_adress.Name = "lbl_adress";
            this.lbl_adress.Size = new System.Drawing.Size(39, 13);
            this.lbl_adress.TabIndex = 8;
            this.lbl_adress.Text = "Adress";
            // 
            // lbl_secondadress
            // 
            this.lbl_secondadress.AutoSize = true;
            this.lbl_secondadress.Location = new System.Drawing.Point(601, 155);
            this.lbl_secondadress.Name = "lbl_secondadress";
            this.lbl_secondadress.Size = new System.Drawing.Size(79, 13);
            this.lbl_secondadress.TabIndex = 9;
            this.lbl_secondadress.Text = "Second Adress";
            // 
            // lbl_zipcode
            // 
            this.lbl_zipcode.AutoSize = true;
            this.lbl_zipcode.Location = new System.Drawing.Point(634, 103);
            this.lbl_zipcode.Name = "lbl_zipcode";
            this.lbl_zipcode.Size = new System.Drawing.Size(46, 13);
            this.lbl_zipcode.TabIndex = 10;
            this.lbl_zipcode.Text = "Zipcode";
            // 
            // lbl_residence
            // 
            this.lbl_residence.AutoSize = true;
            this.lbl_residence.Location = new System.Drawing.Point(622, 129);
            this.lbl_residence.Name = "lbl_residence";
            this.lbl_residence.Size = new System.Drawing.Size(58, 13);
            this.lbl_residence.TabIndex = 11;
            this.lbl_residence.Text = "Residence";
            // 
            // txt_customerid
            // 
            this.txt_customerid.Location = new System.Drawing.Point(686, 12);
            this.txt_customerid.Name = "txt_customerid";
            this.txt_customerid.Size = new System.Drawing.Size(100, 20);
            this.txt_customerid.TabIndex = 12;
            // 
            // txt_secondadress
            // 
            this.txt_secondadress.Location = new System.Drawing.Point(686, 148);
            this.txt_secondadress.Name = "txt_secondadress";
            this.txt_secondadress.Size = new System.Drawing.Size(100, 20);
            this.txt_secondadress.TabIndex = 13;
            // 
            // txt_residence
            // 
            this.txt_residence.Location = new System.Drawing.Point(686, 122);
            this.txt_residence.Name = "txt_residence";
            this.txt_residence.Size = new System.Drawing.Size(100, 20);
            this.txt_residence.TabIndex = 14;
            // 
            // txt_zipcode
            // 
            this.txt_zipcode.Location = new System.Drawing.Point(686, 96);
            this.txt_zipcode.Name = "txt_zipcode";
            this.txt_zipcode.Size = new System.Drawing.Size(100, 20);
            this.txt_zipcode.TabIndex = 15;
            // 
            // txt_adress
            // 
            this.txt_adress.Location = new System.Drawing.Point(686, 66);
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.Size = new System.Drawing.Size(100, 20);
            this.txt_adress.TabIndex = 16;
            // 
            // txt_customername
            // 
            this.txt_customername.Location = new System.Drawing.Point(686, 38);
            this.txt_customername.Name = "txt_customername";
            this.txt_customername.Size = new System.Drawing.Size(100, 20);
            this.txt_customername.TabIndex = 17;
            // 
            // lbl_secondresidence
            // 
            this.lbl_secondresidence.AutoSize = true;
            this.lbl_secondresidence.Location = new System.Drawing.Point(900, 19);
            this.lbl_secondresidence.Name = "lbl_secondresidence";
            this.lbl_secondresidence.Size = new System.Drawing.Size(98, 13);
            this.lbl_secondresidence.TabIndex = 18;
            this.lbl_secondresidence.Text = "Second Residence";
            this.lbl_secondresidence.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbl_contactperson
            // 
            this.lbl_contactperson.AutoSize = true;
            this.lbl_contactperson.Location = new System.Drawing.Point(920, 45);
            this.lbl_contactperson.Name = "lbl_contactperson";
            this.lbl_contactperson.Size = new System.Drawing.Size(76, 13);
            this.lbl_contactperson.TabIndex = 19;
            this.lbl_contactperson.Text = "Contactperson";
            // 
            // lbl_secondzipcode
            // 
            this.lbl_secondzipcode.AutoSize = true;
            this.lbl_secondzipcode.Location = new System.Drawing.Point(594, 180);
            this.lbl_secondzipcode.Name = "lbl_secondzipcode";
            this.lbl_secondzipcode.Size = new System.Drawing.Size(86, 13);
            this.lbl_secondzipcode.TabIndex = 20;
            this.lbl_secondzipcode.Text = "Second Zipcode";
            // 
            // lbl_secondtelephonenumber
            // 
            this.lbl_secondtelephonenumber.AutoSize = true;
            this.lbl_secondtelephonenumber.Location = new System.Drawing.Point(862, 125);
            this.lbl_secondtelephonenumber.Name = "lbl_secondtelephonenumber";
            this.lbl_secondtelephonenumber.Size = new System.Drawing.Size(136, 13);
            this.lbl_secondtelephonenumber.TabIndex = 21;
            this.lbl_secondtelephonenumber.Text = "Second Telephone number";
            // 
            // lbl_telephonenumber
            // 
            this.lbl_telephonenumber.AutoSize = true;
            this.lbl_telephonenumber.Location = new System.Drawing.Point(900, 96);
            this.lbl_telephonenumber.Name = "lbl_telephonenumber";
            this.lbl_telephonenumber.Size = new System.Drawing.Size(96, 13);
            this.lbl_telephonenumber.TabIndex = 22;
            this.lbl_telephonenumber.Text = "Telephone number";
            // 
            // lbl_initials
            // 
            this.lbl_initials.AutoSize = true;
            this.lbl_initials.Location = new System.Drawing.Point(960, 73);
            this.lbl_initials.Name = "lbl_initials";
            this.lbl_initials.Size = new System.Drawing.Size(36, 13);
            this.lbl_initials.TabIndex = 23;
            this.lbl_initials.Text = "Initials";
            // 
            // lbl_faxnumber
            // 
            this.lbl_faxnumber.AutoSize = true;
            this.lbl_faxnumber.Location = new System.Drawing.Point(931, 148);
            this.lbl_faxnumber.Name = "lbl_faxnumber";
            this.lbl_faxnumber.Size = new System.Drawing.Size(64, 13);
            this.lbl_faxnumber.TabIndex = 24;
            this.lbl_faxnumber.Text = "Fax Number";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(960, 177);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(35, 13);
            this.lbl_email.TabIndex = 26;
            this.lbl_email.Text = "E-mail";
            // 
            // txt_secondzipcode
            // 
            this.txt_secondzipcode.Location = new System.Drawing.Point(686, 177);
            this.txt_secondzipcode.Name = "txt_secondzipcode";
            this.txt_secondzipcode.Size = new System.Drawing.Size(100, 20);
            this.txt_secondzipcode.TabIndex = 27;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(1004, 174);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 20);
            this.txt_email.TabIndex = 28;
            // 
            // txt_faxnumber
            // 
            this.txt_faxnumber.Location = new System.Drawing.Point(1004, 148);
            this.txt_faxnumber.Name = "txt_faxnumber";
            this.txt_faxnumber.Size = new System.Drawing.Size(100, 20);
            this.txt_faxnumber.TabIndex = 29;
            // 
            // txt_secondtelephonenumber
            // 
            this.txt_secondtelephonenumber.Location = new System.Drawing.Point(1004, 121);
            this.txt_secondtelephonenumber.Name = "txt_secondtelephonenumber";
            this.txt_secondtelephonenumber.Size = new System.Drawing.Size(100, 20);
            this.txt_secondtelephonenumber.TabIndex = 30;
            // 
            // txt_telephonenumber
            // 
            this.txt_telephonenumber.Location = new System.Drawing.Point(1004, 96);
            this.txt_telephonenumber.Name = "txt_telephonenumber";
            this.txt_telephonenumber.Size = new System.Drawing.Size(100, 20);
            this.txt_telephonenumber.TabIndex = 31;
            // 
            // txt_initials
            // 
            this.txt_initials.Location = new System.Drawing.Point(1004, 70);
            this.txt_initials.Name = "txt_initials";
            this.txt_initials.Size = new System.Drawing.Size(100, 20);
            this.txt_initials.TabIndex = 32;
            // 
            // txt_contactperson
            // 
            this.txt_contactperson.Location = new System.Drawing.Point(1004, 42);
            this.txt_contactperson.Name = "txt_contactperson";
            this.txt_contactperson.Size = new System.Drawing.Size(100, 20);
            this.txt_contactperson.TabIndex = 33;
            // 
            // txt_secondresidence
            // 
            this.txt_secondresidence.Location = new System.Drawing.Point(1004, 14);
            this.txt_secondresidence.Name = "txt_secondresidence";
            this.txt_secondresidence.Size = new System.Drawing.Size(100, 20);
            this.txt_secondresidence.TabIndex = 34;
            // 
            // btn_toevoegen
            // 
            this.btn_toevoegen.Location = new System.Drawing.Point(1009, 213);
            this.btn_toevoegen.Name = "btn_toevoegen";
            this.btn_toevoegen.Size = new System.Drawing.Size(95, 37);
            this.btn_toevoegen.TabIndex = 35;
            this.btn_toevoegen.Text = "Add";
            this.btn_toevoegen.UseVisualStyleBackColor = true;
            this.btn_toevoegen.Click += new System.EventHandler(this.btn_toevoegen_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(578, 262);
            this.Controls.Add(this.btn_toevoegen);
            this.Controls.Add(this.txt_secondresidence);
            this.Controls.Add(this.txt_contactperson);
            this.Controls.Add(this.txt_initials);
            this.Controls.Add(this.txt_telephonenumber);
            this.Controls.Add(this.txt_secondtelephonenumber);
            this.Controls.Add(this.txt_faxnumber);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_secondzipcode);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_faxnumber);
            this.Controls.Add(this.lbl_initials);
            this.Controls.Add(this.lbl_telephonenumber);
            this.Controls.Add(this.lbl_secondtelephonenumber);
            this.Controls.Add(this.lbl_secondzipcode);
            this.Controls.Add(this.lbl_contactperson);
            this.Controls.Add(this.lbl_secondresidence);
            this.Controls.Add(this.txt_customername);
            this.Controls.Add(this.txt_adress);
            this.Controls.Add(this.txt_zipcode);
            this.Controls.Add(this.txt_residence);
            this.Controls.Add(this.txt_secondadress);
            this.Controls.Add(this.txt_customerid);
            this.Controls.Add(this.lbl_residence);
            this.Controls.Add(this.lbl_zipcode);
            this.Controls.Add(this.lbl_secondadress);
            this.Controls.Add(this.lbl_adress);
            this.Controls.Add(this.lbl_Cutomername);
            this.Controls.Add(this.lbl_Cutomerid);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_invisible);
            this.Controls.Add(this.Customer_grid);
            this.Controls.Add(this.btn_back);
            this.Name = "Customer";
            this.Text = "Customer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Customer_FormClosing);
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Customer_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView Customer_grid;
        private System.Windows.Forms.Button btn_invisible;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label lbl_Cutomerid;
        private System.Windows.Forms.Label lbl_Cutomername;
        private System.Windows.Forms.Label lbl_adress;
        private System.Windows.Forms.Label lbl_secondadress;
        private System.Windows.Forms.Label lbl_zipcode;
        private System.Windows.Forms.Label lbl_residence;
        private System.Windows.Forms.TextBox txt_customerid;
        private System.Windows.Forms.TextBox txt_secondadress;
        private System.Windows.Forms.TextBox txt_residence;
        private System.Windows.Forms.TextBox txt_zipcode;
        private System.Windows.Forms.TextBox txt_adress;
        private System.Windows.Forms.TextBox txt_customername;
        private System.Windows.Forms.Label lbl_secondresidence;
        private System.Windows.Forms.Label lbl_contactperson;
        private System.Windows.Forms.Label lbl_secondzipcode;
        private System.Windows.Forms.Label lbl_secondtelephonenumber;
        private System.Windows.Forms.Label lbl_telephonenumber;
        private System.Windows.Forms.Label lbl_initials;
        private System.Windows.Forms.Label lbl_faxnumber;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_secondzipcode;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_faxnumber;
        private System.Windows.Forms.TextBox txt_secondtelephonenumber;
        private System.Windows.Forms.TextBox txt_telephonenumber;
        private System.Windows.Forms.TextBox txt_initials;
        private System.Windows.Forms.TextBox txt_contactperson;
        private System.Windows.Forms.TextBox txt_secondresidence;
        private System.Windows.Forms.Button btn_toevoegen;

    }
}