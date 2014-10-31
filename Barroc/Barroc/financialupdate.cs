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
    public partial class financialupdate : Form
    {
        ConnectionManager conn = new ConnectionManager();
        public financialupdate(ConnectionManager conn)
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
            this.Size = new Size(895, 323);
            int update;
            update = financialgrid.CurrentRow.Index;

            CustomerID_lbl.Text = financialgrid.Rows[update].Cells[0].Value.ToString();
            CustomerName_lbl.Text = financialgrid.Rows[update].Cells[1].Value.ToString();
            Creditworthy.Text = financialgrid.Rows[update].Cells[2].Value.ToString();
            bankcode.Text = financialgrid.Rows[update].Cells[3].Value.ToString();
            Balance.Text = financialgrid.Rows[update].Cells[4].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(575,323);
        }
    }
}
