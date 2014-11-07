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
            this.lbl_Cutomername = new System.Windows.Forms.Label();
            this.lbl_adress = new System.Windows.Forms.Label();
            this.lbl_secondadress = new System.Windows.Forms.Label();
            this.lbl_zipcode = new System.Windows.Forms.Label();
            this.lbl_residence = new System.Windows.Forms.Label();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adress_lbl = new System.Windows.Forms.Label();
            this.zipcode_lbl = new System.Windows.Forms.Label();
            this.residence_lbl = new System.Windows.Forms.Label();
            this.secondadress_lbl = new System.Windows.Forms.Label();
            this.secondzipcode_lbl = new System.Windows.Forms.Label();
            this.contactperson_lbl = new System.Windows.Forms.Label();
            this.secondresidence_lbl = new System.Windows.Forms.Label();
            this.initials_lbl = new System.Windows.Forms.Label();
            this.telephonenumber_lbl = new System.Windows.Forms.Label();
            this.secondtelephonenumber_lbl = new System.Windows.Forms.Label();
            this.faxnumber_lbl = new System.Windows.Forms.Label();
            this.email_lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Customer_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Customer_grid
            // 
            this.Customer_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Customer_grid.Location = new System.Drawing.Point(12, 48);
            this.Customer_grid.Name = "Customer_grid";
            this.Customer_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Customer_grid.Size = new System.Drawing.Size(470, 169);
            this.Customer_grid.TabIndex = 1;
            this.Customer_grid.DoubleClick += new System.EventHandler(this.Customer_grid_DoubleClick);
            // 
            // btn_invisible
            // 
            this.btn_invisible.Location = new System.Drawing.Point(387, 241);
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
            this.back_btn.Location = new System.Drawing.Point(12, 241);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(95, 37);
            this.back_btn.TabIndex = 5;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // lbl_Cutomername
            // 
            this.lbl_Cutomername.AutoSize = true;
            this.lbl_Cutomername.Location = new System.Drawing.Point(594, 45);
            this.lbl_Cutomername.Name = "lbl_Cutomername";
            this.lbl_Cutomername.Size = new System.Drawing.Size(86, 13);
            this.lbl_Cutomername.TabIndex = 7;
            this.lbl_Cutomername.Text = "Customer Name*";
            // 
            // lbl_adress
            // 
            this.lbl_adress.AutoSize = true;
            this.lbl_adress.Location = new System.Drawing.Point(637, 73);
            this.lbl_adress.Name = "lbl_adress";
            this.lbl_adress.Size = new System.Drawing.Size(43, 13);
            this.lbl_adress.TabIndex = 8;
            this.lbl_adress.Text = "Adress*";
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
            this.lbl_zipcode.Location = new System.Drawing.Point(630, 103);
            this.lbl_zipcode.Name = "lbl_zipcode";
            this.lbl_zipcode.Size = new System.Drawing.Size(50, 13);
            this.lbl_zipcode.TabIndex = 10;
            this.lbl_zipcode.Text = "Zipcode*";
            // 
            // lbl_residence
            // 
            this.lbl_residence.AutoSize = true;
            this.lbl_residence.Location = new System.Drawing.Point(618, 129);
            this.lbl_residence.Name = "lbl_residence";
            this.lbl_residence.Size = new System.Drawing.Size(62, 13);
            this.lbl_residence.TabIndex = 11;
            this.lbl_residence.Text = "Residence*";
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
            this.txt_residence.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_residence_KeyPress);
            // 
            // txt_zipcode
            // 
            this.txt_zipcode.Location = new System.Drawing.Point(686, 96);
            this.txt_zipcode.Name = "txt_zipcode";
            this.txt_zipcode.Size = new System.Drawing.Size(100, 20);
            this.txt_zipcode.TabIndex = 15;
            this.txt_zipcode.TextChanged += new System.EventHandler(this.txt_zipcode_TextChanged);
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
            this.txt_customername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_customername_KeyPress);
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
            this.lbl_contactperson.Size = new System.Drawing.Size(80, 13);
            this.lbl_contactperson.TabIndex = 19;
            this.lbl_contactperson.Text = "Contactperson*";
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
            this.lbl_telephonenumber.Size = new System.Drawing.Size(100, 13);
            this.lbl_telephonenumber.TabIndex = 22;
            this.lbl_telephonenumber.Text = "Telephone number*";
            // 
            // lbl_initials
            // 
            this.lbl_initials.AutoSize = true;
            this.lbl_initials.Location = new System.Drawing.Point(960, 73);
            this.lbl_initials.Name = "lbl_initials";
            this.lbl_initials.Size = new System.Drawing.Size(40, 13);
            this.lbl_initials.TabIndex = 23;
            this.lbl_initials.Text = "Initials*";
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
            this.lbl_email.Size = new System.Drawing.Size(39, 13);
            this.lbl_email.TabIndex = 26;
            this.lbl_email.Text = "E-mail*";
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
            this.txt_email.Size = new System.Drawing.Size(116, 20);
            this.txt_email.TabIndex = 28;
            // 
            // txt_faxnumber
            // 
            this.txt_faxnumber.Location = new System.Drawing.Point(1004, 148);
            this.txt_faxnumber.Name = "txt_faxnumber";
            this.txt_faxnumber.Size = new System.Drawing.Size(116, 20);
            this.txt_faxnumber.TabIndex = 29;
            this.txt_faxnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_faxnumber_KeyPress);
            // 
            // txt_secondtelephonenumber
            // 
            this.txt_secondtelephonenumber.Location = new System.Drawing.Point(1004, 121);
            this.txt_secondtelephonenumber.Name = "txt_secondtelephonenumber";
            this.txt_secondtelephonenumber.Size = new System.Drawing.Size(116, 20);
            this.txt_secondtelephonenumber.TabIndex = 30;
            this.txt_secondtelephonenumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_secondtelephonenumber_KeyPress);
            // 
            // txt_telephonenumber
            // 
            this.txt_telephonenumber.Location = new System.Drawing.Point(1004, 96);
            this.txt_telephonenumber.Name = "txt_telephonenumber";
            this.txt_telephonenumber.Size = new System.Drawing.Size(116, 20);
            this.txt_telephonenumber.TabIndex = 31;
            this.txt_telephonenumber.TextChanged += new System.EventHandler(this.txt_telephonenumber_TextChanged);
            this.txt_telephonenumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telephonenumber_KeyPress);
            // 
            // txt_initials
            // 
            this.txt_initials.Location = new System.Drawing.Point(1004, 70);
            this.txt_initials.Name = "txt_initials";
            this.txt_initials.Size = new System.Drawing.Size(116, 20);
            this.txt_initials.TabIndex = 32;
            this.txt_initials.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_initials_KeyPress);
            // 
            // txt_contactperson
            // 
            this.txt_contactperson.Location = new System.Drawing.Point(1004, 42);
            this.txt_contactperson.Name = "txt_contactperson";
            this.txt_contactperson.Size = new System.Drawing.Size(116, 20);
            this.txt_contactperson.TabIndex = 33;
            this.txt_contactperson.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contactperson_KeyPress);
            // 
            // txt_secondresidence
            // 
            this.txt_secondresidence.Location = new System.Drawing.Point(1004, 14);
            this.txt_secondresidence.Name = "txt_secondresidence";
            this.txt_secondresidence.Size = new System.Drawing.Size(116, 20);
            this.txt_secondresidence.TabIndex = 34;
            this.txt_secondresidence.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_secondresidence_KeyPress);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(470, 20);
            this.textBox1.TabIndex = 36;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "* Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(900, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "* Must be filled in";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(690, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Teun Aarts";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // adress_lbl
            // 
            this.adress_lbl.AutoSize = true;
            this.adress_lbl.BackColor = System.Drawing.SystemColors.Window;
            this.adress_lbl.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.adress_lbl.Location = new System.Drawing.Point(690, 70);
            this.adress_lbl.Name = "adress_lbl";
            this.adress_lbl.Size = new System.Drawing.Size(95, 13);
            this.adress_lbl.TabIndex = 40;
            this.adress_lbl.Text = "Terheideseweg 50";
            this.adress_lbl.Click += new System.EventHandler(this.adress_lbl_Click);
            // 
            // zipcode_lbl
            // 
            this.zipcode_lbl.AutoSize = true;
            this.zipcode_lbl.BackColor = System.Drawing.SystemColors.Window;
            this.zipcode_lbl.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.zipcode_lbl.Location = new System.Drawing.Point(690, 99);
            this.zipcode_lbl.Name = "zipcode_lbl";
            this.zipcode_lbl.Size = new System.Drawing.Size(48, 13);
            this.zipcode_lbl.TabIndex = 41;
            this.zipcode_lbl.Text = "0000 AA";
            this.zipcode_lbl.Click += new System.EventHandler(this.zipcode_lbl_Click);
            // 
            // residence_lbl
            // 
            this.residence_lbl.AutoSize = true;
            this.residence_lbl.BackColor = System.Drawing.SystemColors.Window;
            this.residence_lbl.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.residence_lbl.Location = new System.Drawing.Point(690, 125);
            this.residence_lbl.Name = "residence_lbl";
            this.residence_lbl.Size = new System.Drawing.Size(35, 13);
            this.residence_lbl.TabIndex = 42;
            this.residence_lbl.Text = "Breda";
            this.residence_lbl.Click += new System.EventHandler(this.residence_lbl_Click);
            // 
            // secondadress_lbl
            // 
            this.secondadress_lbl.AutoSize = true;
            this.secondadress_lbl.BackColor = System.Drawing.SystemColors.Window;
            this.secondadress_lbl.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.secondadress_lbl.Location = new System.Drawing.Point(690, 151);
            this.secondadress_lbl.Name = "secondadress_lbl";
            this.secondadress_lbl.Size = new System.Drawing.Size(75, 13);
            this.secondadress_lbl.TabIndex = 43;
            this.secondadress_lbl.Text = "Appelstraat 31";
            this.secondadress_lbl.Click += new System.EventHandler(this.secondadress_lbl_Click);
            // 
            // secondzipcode_lbl
            // 
            this.secondzipcode_lbl.AutoSize = true;
            this.secondzipcode_lbl.BackColor = System.Drawing.SystemColors.Window;
            this.secondzipcode_lbl.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.secondzipcode_lbl.Location = new System.Drawing.Point(690, 180);
            this.secondzipcode_lbl.Name = "secondzipcode_lbl";
            this.secondzipcode_lbl.Size = new System.Drawing.Size(48, 13);
            this.secondzipcode_lbl.TabIndex = 44;
            this.secondzipcode_lbl.Text = "0000 AA";
            this.secondzipcode_lbl.Click += new System.EventHandler(this.secondzipcode_lbl_Click);
            // 
            // contactperson_lbl
            // 
            this.contactperson_lbl.AutoSize = true;
            this.contactperson_lbl.BackColor = System.Drawing.SystemColors.Window;
            this.contactperson_lbl.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.contactperson_lbl.Location = new System.Drawing.Point(1006, 45);
            this.contactperson_lbl.Name = "contactperson_lbl";
            this.contactperson_lbl.Size = new System.Drawing.Size(59, 13);
            this.contactperson_lbl.TabIndex = 45;
            this.contactperson_lbl.Text = "Teun Aarts";
            this.contactperson_lbl.Click += new System.EventHandler(this.contactperson_lbl_Click);
            // 
            // secondresidence_lbl
            // 
            this.secondresidence_lbl.AutoSize = true;
            this.secondresidence_lbl.BackColor = System.Drawing.SystemColors.Window;
            this.secondresidence_lbl.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.secondresidence_lbl.Location = new System.Drawing.Point(1006, 17);
            this.secondresidence_lbl.Name = "secondresidence_lbl";
            this.secondresidence_lbl.Size = new System.Drawing.Size(34, 13);
            this.secondresidence_lbl.TabIndex = 46;
            this.secondresidence_lbl.Text = "Bavel";
            this.secondresidence_lbl.Click += new System.EventHandler(this.secondresidence_lbl_Click);
            // 
            // initials_lbl
            // 
            this.initials_lbl.AutoSize = true;
            this.initials_lbl.BackColor = System.Drawing.SystemColors.Window;
            this.initials_lbl.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.initials_lbl.Location = new System.Drawing.Point(1006, 73);
            this.initials_lbl.Name = "initials_lbl";
            this.initials_lbl.Size = new System.Drawing.Size(24, 13);
            this.initials_lbl.TabIndex = 47;
            this.initials_lbl.Text = "T.A";
            this.initials_lbl.Click += new System.EventHandler(this.initials_lbl_Click);
            // 
            // telephonenumber_lbl
            // 
            this.telephonenumber_lbl.AutoSize = true;
            this.telephonenumber_lbl.BackColor = System.Drawing.SystemColors.Window;
            this.telephonenumber_lbl.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.telephonenumber_lbl.Location = new System.Drawing.Point(1006, 99);
            this.telephonenumber_lbl.Name = "telephonenumber_lbl";
            this.telephonenumber_lbl.Size = new System.Drawing.Size(67, 13);
            this.telephonenumber_lbl.TabIndex = 48;
            this.telephonenumber_lbl.Text = "0644556677";
            this.telephonenumber_lbl.Click += new System.EventHandler(this.telephonenumber_lbl_Click);
            // 
            // secondtelephonenumber_lbl
            // 
            this.secondtelephonenumber_lbl.AutoSize = true;
            this.secondtelephonenumber_lbl.BackColor = System.Drawing.SystemColors.Window;
            this.secondtelephonenumber_lbl.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.secondtelephonenumber_lbl.Location = new System.Drawing.Point(1006, 125);
            this.secondtelephonenumber_lbl.Name = "secondtelephonenumber_lbl";
            this.secondtelephonenumber_lbl.Size = new System.Drawing.Size(67, 13);
            this.secondtelephonenumber_lbl.TabIndex = 49;
            this.secondtelephonenumber_lbl.Text = "0161435599";
            this.secondtelephonenumber_lbl.Click += new System.EventHandler(this.secondtelephonenumber_lbl_Click);
            // 
            // faxnumber_lbl
            // 
            this.faxnumber_lbl.AutoSize = true;
            this.faxnumber_lbl.BackColor = System.Drawing.SystemColors.Window;
            this.faxnumber_lbl.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.faxnumber_lbl.Location = new System.Drawing.Point(1006, 151);
            this.faxnumber_lbl.Name = "faxnumber_lbl";
            this.faxnumber_lbl.Size = new System.Drawing.Size(67, 13);
            this.faxnumber_lbl.TabIndex = 50;
            this.faxnumber_lbl.Text = "0056875421";
            this.faxnumber_lbl.Click += new System.EventHandler(this.faxnumber_lbl_Click);
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.BackColor = System.Drawing.SystemColors.Window;
            this.email_lbl.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.email_lbl.Location = new System.Drawing.Point(1006, 177);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(108, 13);
            this.email_lbl.TabIndex = 51;
            this.email_lbl.Text = "iemand@hotmail.com";
            this.email_lbl.Click += new System.EventHandler(this.email_lbl_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "* Double click to change a customer";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(578, 290);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.email_lbl);
            this.Controls.Add(this.faxnumber_lbl);
            this.Controls.Add(this.secondtelephonenumber_lbl);
            this.Controls.Add(this.telephonenumber_lbl);
            this.Controls.Add(this.initials_lbl);
            this.Controls.Add(this.secondresidence_lbl);
            this.Controls.Add(this.contactperson_lbl);
            this.Controls.Add(this.secondzipcode_lbl);
            this.Controls.Add(this.secondadress_lbl);
            this.Controls.Add(this.residence_lbl);
            this.Controls.Add(this.zipcode_lbl);
            this.Controls.Add(this.adress_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
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
            this.Controls.Add(this.lbl_residence);
            this.Controls.Add(this.lbl_zipcode);
            this.Controls.Add(this.lbl_secondadress);
            this.Controls.Add(this.lbl_adress);
            this.Controls.Add(this.lbl_Cutomername);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_invisible);
            this.Controls.Add(this.Customer_grid);
            this.Controls.Add(this.btn_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
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
        private System.Windows.Forms.Label lbl_Cutomername;
        private System.Windows.Forms.Label lbl_adress;
        private System.Windows.Forms.Label lbl_secondadress;
        private System.Windows.Forms.Label lbl_zipcode;
        private System.Windows.Forms.Label lbl_residence;
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
        private System.Windows.Forms.TextBox txt_initials;
        private System.Windows.Forms.TextBox txt_contactperson;
        private System.Windows.Forms.TextBox txt_secondresidence;
        private System.Windows.Forms.Button btn_toevoegen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_telephonenumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label adress_lbl;
        private System.Windows.Forms.Label zipcode_lbl;
        private System.Windows.Forms.Label residence_lbl;
        private System.Windows.Forms.Label secondadress_lbl;
        private System.Windows.Forms.Label secondzipcode_lbl;
        private System.Windows.Forms.Label contactperson_lbl;
        private System.Windows.Forms.Label secondresidence_lbl;
        private System.Windows.Forms.Label initials_lbl;
        private System.Windows.Forms.Label telephonenumber_lbl;
        private System.Windows.Forms.Label secondtelephonenumber_lbl;
        private System.Windows.Forms.Label faxnumber_lbl;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.Label label4;

    }
}