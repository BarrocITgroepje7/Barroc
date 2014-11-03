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
        string project_id;
        public financialupdate(ConnectionManager conn,string project_id)
        {
            InitializeComponent();
            this.project_id = project_id;
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
            amount.Text = financialgrid.Rows[update].Cells[5].Value.ToString();
            limit.Text = financialgrid.Rows[update].Cells[6].Value.ToString();
            number.Text = financialgrid.Rows[update].Cells[7].Value.ToString();
            CHECK.Text = financialgrid.Rows[update].Cells[8].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(575,323);
            string sqlupdate = "Update [Customer] Set [Creditworthy] = @Credit, [BankCode] = @BANKCODE, [Balance] = @BALANCE, [Revenue_amount] = @Amount, [Limit] = @LIMIT, [Account_Number] =@NUMBER,[BKR_Check] =@CHECK"+project_id;
            SqlCommand cmd = new SqlCommand(sqlupdate, conn.GetConnection());
            cmd.Parameters.AddWithValue("@Credit", Creditworthy.Text);
            cmd.Parameters.AddWithValue("@BANKCODE", bankcode.Text);
            cmd.Parameters.AddWithValue("@BALANCE", Balance.Text);
            cmd.Parameters.AddWithValue("@Amount", amount.Text);
            cmd.Parameters.AddWithValue("@LIMIT", limit.Text);
            cmd.Parameters.AddWithValue("@NUMBER", number.Text);
            cmd.Parameters.AddWithValue("@CHECK", CHECK.Text);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            conn.OpenConnection();


            SqlDataAdapter SQLda = new SqlDataAdapter("SELECT Customer_ID,CustomerName,Creditworthy,BankCode,Balance,Revenue_amount,Limit,Account_Number,BKR_Check FROM Customer", conn.GetConnection());

            DataTable dt = new DataTable();
            SQLda.Fill(dt);

            financialgrid.DataSource = dt;
            conn.CloseConnection();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Finance finance = new Finance();
            finance.Show();
            this.Hide();
        }
    }
}
