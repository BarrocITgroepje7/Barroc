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
    public partial class DeleteFinancial : Form
    {
        ConnectionManager conn = new ConnectionManager();
        public DeleteFinancial()
        {
            InitializeComponent();
            conn.OpenConnection();

            SqlDataAdapter SQLda = new SqlDataAdapter("SELECT Customer_ID,CustomerName,Creditworthy,BankCode,Balance,Revenue_amount,Limit,Account_Number,BKR_Check FROM Customer", conn.GetConnection());

            DataTable dt = new DataTable();
            SQLda.Fill(dt);

            Financialgrid.DataSource = dt;
            conn.CloseConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = Financialgrid.SelectedRows[0];
            string id = row.Cells[0].Value.ToString();

            SqlCommand SQLda = new SqlCommand("DELETE FROM Customer WHERE Customer_id=" + id, conn.GetConnection());
            SQLda.Connection.Open();
            SQLda.ExecuteNonQuery();
            SQLda.Connection.Close();

            SqlDataAdapter SQLs = new SqlDataAdapter("SELECT Customer_ID,CustomerName,Creditworthy,BankCode,Balance,Revenue_amount,Limit,Account_Number,BKR_Check FROM Customer", conn.GetConnection());

            DataTable dt = new DataTable();
            SQLs.Fill(dt);

            Financialgrid.DataSource = dt;
            conn.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Finance financien = new Finance();
            financien.Show();
            this.Close();
        }
    }
}
