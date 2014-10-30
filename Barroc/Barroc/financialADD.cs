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
    public partial class financialADD : Form
    {
        ConnectionManager conn = new ConnectionManager();
        string customer_id;
        public financialADD(string customer_id,ConnectionManager conn)
        {
            InitializeComponent();
            this.conn = conn;
            this.customer_id = customer_id;

        }
        private void ADD_btn_Click(object sender, EventArgs e)
        {
            string credit = Creditworthy.Text;
            string check = CHECK.Text;
            

            if(credit == "True"&& check == "True")
            {
                string sqlupdate = "Update [Customer] Set [Creditworthy] = @CREITWORTHY,[BankCode] = @BANKCODE,[Balance] = @BALANCE,[Revenue_amount] = @REVENUE_AMOUNT,[Limit] = @LIMIT,[Account_Number] = @ACCOUNT_NUMBER, [BKR_Check] = @BKR_CHECK WHERE Customer_ID=" + customer_id;
                SqlCommand cmd = new SqlCommand(sqlupdate, conn.GetConnection());
                cmd.Parameters.AddWithValue("@CREITWORTHY", Creditworthy.Text);
                cmd.Parameters.AddWithValue("@BANKCODE", bankcode.Text);
                cmd.Parameters.AddWithValue("@BALANCE", Balance.Text);
                cmd.Parameters.AddWithValue("@REVENUE_AMOUNT", amount.Text);
                cmd.Parameters.AddWithValue("@LIMIT", limit.Text);
                cmd.Parameters.AddWithValue("@ACCOUNT_NUMBER", number.Text);
                cmd.Parameters.AddWithValue("@BKR_CHECK", CHECK.Text);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                financial form = new financial(conn);
                form.Show();
                this.Close();
            }
            else if(credit =="False"&& check == "False")
            {
                string sqlupdate = "Update [Customer] Set [Creditworthy] = @CREITWORTHY,[BankCode] = @BANKCODE,[Balance] = @BALANCE,[Revenue_amount] = @REVENUE_AMOUNT,[Limit] = @LIMIT,[Account_Number] = @ACCOUNT_NUMBER, [BKR_Check] = @BKR_CHECK WHERE Customer_ID=" + customer_id;
                SqlCommand cmd = new SqlCommand(sqlupdate, conn.GetConnection());
                cmd.Parameters.AddWithValue("@CREITWORTHY", Creditworthy.Text);
                cmd.Parameters.AddWithValue("@BANKCODE", bankcode.Text);
                cmd.Parameters.AddWithValue("@BALANCE", Balance.Text);
                cmd.Parameters.AddWithValue("@REVENUE_AMOUNT", amount.Text);
                cmd.Parameters.AddWithValue("@LIMIT", limit.Text);
                cmd.Parameters.AddWithValue("@ACCOUNT_NUMBER", number.Text);
                cmd.Parameters.AddWithValue("@BKR_CHECK", CHECK.Text);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                financial form = new financial(conn);
                form.Show();
                this.Close();
            }
            else if(credit=="True"&& check== "False")
            {
                string sqlupdate = "Update [Customer] Set [Creditworthy] = @CREITWORTHY,[BankCode] = @BANKCODE,[Balance] = @BALANCE,[Revenue_amount] = @REVENUE_AMOUNT,[Limit] = @LIMIT,[Account_Number] = @ACCOUNT_NUMBER, [BKR_Check] = @BKR_CHECK WHERE Customer_ID=" + customer_id;
                SqlCommand cmd = new SqlCommand(sqlupdate, conn.GetConnection());
                cmd.Parameters.AddWithValue("@CREITWORTHY", Creditworthy.Text);
                cmd.Parameters.AddWithValue("@BANKCODE", bankcode.Text);
                cmd.Parameters.AddWithValue("@BALANCE", Balance.Text);
                cmd.Parameters.AddWithValue("@REVENUE_AMOUNT", amount.Text);
                cmd.Parameters.AddWithValue("@LIMIT", limit.Text);
                cmd.Parameters.AddWithValue("@ACCOUNT_NUMBER", number.Text);
                cmd.Parameters.AddWithValue("@BKR_CHECK", CHECK.Text);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                financial form = new financial(conn);
                form.Show();
                this.Close();
            }
            else if (credit=="False" && check == "True")
            {
                string sqlupdate = "Update [Customer] Set [Creditworthy] = @CREITWORTHY,[BankCode] = @BANKCODE,[Balance] = @BALANCE,[Revenue_amount] = @REVENUE_AMOUNT,[Limit] = @LIMIT,[Account_Number] = @ACCOUNT_NUMBER, [BKR_Check] = @BKR_CHECK WHERE Customer_ID=" + customer_id;
                SqlCommand cmd = new SqlCommand(sqlupdate, conn.GetConnection());
                cmd.Parameters.AddWithValue("@CREITWORTHY", Creditworthy.Text);
                cmd.Parameters.AddWithValue("@BANKCODE", bankcode.Text);
                cmd.Parameters.AddWithValue("@BALANCE", Balance.Text);
                cmd.Parameters.AddWithValue("@REVENUE_AMOUNT", amount.Text);
                cmd.Parameters.AddWithValue("@LIMIT", limit.Text);
                cmd.Parameters.AddWithValue("@ACCOUNT_NUMBER", number.Text);
                cmd.Parameters.AddWithValue("@BKR_CHECK", CHECK.Text);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                financial form = new financial(conn);
                form.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("please answer right value at BKR-check and creditworthy");

            }
        }

        private void financialADD_FormClosing(object sender, FormClosingEventArgs e)
        {
            Finance financien = new Finance();
            financien.Show();
            this.Close();
        }
    }
}
