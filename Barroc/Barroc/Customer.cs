﻿using Barroc_it;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barroc
{
    public partial class Customer : Form
    {
        ConnectionManager conn = new ConnectionManager();
        showcustomer form = new showcustomer();
        public Customer(ConnectionManager conn)
        {
            InitializeComponent();
            this.conn = conn;
            conn.OpenConnection();
            btn_back.Visible = false;

            SqlDataAdapter SQLda = new SqlDataAdapter("SELECT Customer_ID,CustomerName,Adress,Zipcode,Residence,Second_Adress,Second_Zipcode,Seconde_Residence,Contactperson,Initials,Telephone_number,Second_Telephone_Number,Fax_number,Email FROM Customer", conn.GetConnection());

            DataTable dt = new DataTable();
            SQLda.Fill(dt);

            Customer_grid.DataSource = dt;
            conn.CloseConnection();
        }

        private void Customer_grid_DoubleClick(object sender, EventArgs e)
        {
            int update;
            update = Customer_grid.CurrentRow.Index;

            form.CustomerName_txt.Text = Customer_grid.Rows[update].Cells[1].Value.ToString();
            form.Adress_txt.Text = Customer_grid.Rows[update].Cells[2].Value.ToString();
            form.Zipcode_txt.Text = Customer_grid.Rows[update].Cells[3].Value.ToString();
            form.Residence.Text = Customer_grid.Rows[update].Cells[4].Value.ToString();
            form.tele_txt.Text = Customer_grid.Rows[update].Cells[6].Value.ToString();
            form.faxnumber_txt.Text = Customer_grid.Rows[update].Cells[7].Value.ToString();
            form.email.Text = Customer_grid.Rows[update].Cells[8].Value.ToString();
            form.ShowDialog();
            this.Close();
        }

        private void btn_invisible_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = Customer_grid.SelectedRows[0];
            string id = row.Cells[0].Value.ToString();

            SqlCommand SQLda = new SqlCommand("DELETE FROM Customer WHERE Customer_id=" + id, conn.GetConnection());
            SQLda.Connection.Open();
            SQLda.ExecuteNonQuery();
            SQLda.Connection.Close();

            SqlDataAdapter SQLs = new SqlDataAdapter("SELECT * FROM Customer", conn.GetConnection());

            DataTable dt = new DataTable();
            SQLs.Fill(dt);

            Customer_grid.DataSource = dt;
            conn.CloseConnection();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1286, 315);
            btn_add.Visible = false;
            btn_back.Visible = true;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Size = new Size(594, 315);
            btn_add.Visible = true;
            btn_back.Visible = false;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
            this.Hide();
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_toevoegen_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Customer(Customer_ID,CustomerName,Adress,Zipcode,Residence,Second_Adress,Second_Zipcode,Seconde_Residence,Contactperson,Initials,Telephone_number,Second_Telephone_Number,Fax_number,Email) values (@Customer_ID,@CustomerName,@Adress,@Zipcode,@Residence,@Second_Adress,@Second_Zipcode,@Seconde_Residence,@Contactperson,@Initials,@Telephone_number,@Second_Telephone_Number,@Fax_number,@Email)";
            SqlCommand cmd = new SqlCommand(sql, conn.GetConnection());
            cmd.Parameters.Add(new SqlParameter("@Customer_ID", txt_customerid.Text));
            cmd.Parameters.Add(new SqlParameter("@CustomerName", txt_customername.Text));
            cmd.Parameters.Add(new SqlParameter("@Adress", txt_adress.Text));
            cmd.Parameters.Add(new SqlParameter("@Zipcode", txt_zipcode.Text));
            cmd.Parameters.Add(new SqlParameter("@Residence", txt_residence.Text));
            cmd.Parameters.Add(new SqlParameter("@Second_Adress", txt_secondadress.Text));
            cmd.Parameters.Add(new SqlParameter("@Second_Zipcode", txt_secondzipcode.Text));
            cmd.Parameters.Add(new SqlParameter("@Seconde_Residence", txt_secondresidence.Text));
            cmd.Parameters.Add(new SqlParameter("@Contactperson", txt_contactperson.Text));
            cmd.Parameters.Add(new SqlParameter("@Initials", txt_initials.Text));
            cmd.Parameters.Add(new SqlParameter("@Telephone_number", txt_telephonenumber.Text));
            cmd.Parameters.Add(new SqlParameter("@Second_Telephone_Number", txt_secondtelephonenumber.Text));
            cmd.Parameters.Add(new SqlParameter("@Fax_number", txt_faxnumber.Text));
            cmd.Parameters.Add(new SqlParameter("@Email", txt_email.Text));

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            conn.OpenConnection();

            SqlDataAdapter SQLda = new SqlDataAdapter("SELECT * FROM Customer", conn.GetConnection());

            DataTable dt = new DataTable();
            SQLda.Fill(dt);

            Customer_grid.DataSource = dt;
            conn.CloseConnection();
        }
    }
}
