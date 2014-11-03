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
    public partial class financial : Form
    {
        ConnectionManager conn = new ConnectionManager();
        financialADD form;
        public financial(ConnectionManager conn)
        {
            InitializeComponent();

            this.conn = conn;
            conn.OpenConnection();


            SqlDataAdapter SQLda = new SqlDataAdapter("SELECT Customer_ID,CustomerName,Creditworthy,BankCode,Balance,Revenue_amount,Limit,Account_Number,BKR_Check FROM Customer", conn.GetConnection());

            DataTable dt = new DataTable();
            SQLda.Fill(dt);

            financialgrid.DataSource = dt;
            conn.CloseConnection();
        }

        private void financialgrid_DoubleClick(object sender, EventArgs e)
        {
            int update;
            update = financialgrid.CurrentRow.Index;

            DataGridViewRow row = financialgrid.SelectedRows[0];
            string id = row.Cells[0].Value.ToString();

            form = new financialADD(id,conn);

            form.CustomerID_lbl.Text = financialgrid.Rows[update].Cells[0].Value.ToString();
            form.CustomerName_lbl.Text = financialgrid.Rows[update].Cells[1].Value.ToString();
            form.ShowDialog();
            this.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Finance financien = new Finance();
            financien.Show();
            this.Close();
        }
    }
}
