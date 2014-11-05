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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            financial financial = new financial(conn);
            financial.Show();
            this.Close();
            
        }

        private void creditworthy_lbl_Click(object sender, EventArgs e)
        {
            creditworthy_lbl.Visible = false;
        }

        private void balance_lbl_Click(object sender, EventArgs e)
        {
            balance_lbl.Visible = false;
        }

        private void revenueamount_lbl_Click(object sender, EventArgs e)
        {
            revenueamount_lbl.Visible = false;
        }

        private void limit_lbl_Click(object sender, EventArgs e)
        {
            limit_lbl.Visible = false;
        }

        private void accountnumber_lbl_Click(object sender, EventArgs e)
        {
            accountnumber_lbl.Visible = false;
        }

        private void bkrcheck_lbl_Click(object sender, EventArgs e)
        {
            bkrcheck_lbl.Visible = false;
        }

        private void bankcode_lbl_Click(object sender, EventArgs e)
        {
            bankcode_lbl.Visible = false;
        }

        private void Balance_TextChanged(object sender, EventArgs e)
        {
        }

        private void amount_TextChanged(object sender, EventArgs e)
        {
        }

        private void limit_TextChanged(object sender, EventArgs e)
        {

        }

        private void Balance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void limit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void number_TextChanged(object sender, EventArgs e)
        {

        }

        private void number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void CHECK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void bankcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void Creditworthy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            e.Handled = true;
        }
    }
}
