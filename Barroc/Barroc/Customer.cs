using Barroc_it;
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

            SqlDataAdapter SQLda = new SqlDataAdapter("SELECT Customer_ID,CustomerName,Adress,Zipcode,Residence,Telephone_number,Fax_number,Email FROM Customer", conn.GetConnection());

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
            form.tele_txt.Text = Customer_grid.Rows[update].Cells[5].Value.ToString();
            form.faxnumber_txt.Text = Customer_grid.Rows[update].Cells[6].Value.ToString();
            form.email.Text = Customer_grid.Rows[update].Cells[7].Value.ToString();
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
        }
    }
}
