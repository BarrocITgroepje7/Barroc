using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Barroc_it;

namespace Barroc
{
    public partial class showcustomer : Form
    {
        ConnectionManager conn = new ConnectionManager();
        string customer_id;

        public showcustomer(string customer_id)
        {
            InitializeComponent();
            this.customer_id = customer_id;
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            string sqlupdate = "Update [Customer] Set [CustomerName] = @CustomerName,[Adress] = @Adress,[Zipcode] = @Zipcode,[Residence] = @Residence,[Second_Adress] = @Second_Adress,[Second_Zipcode] = @Second_Zipcode,[Seconde_Residence] = @Seconde_Residence,[Contactperson] = @Contactperson,[Initials] = @Initials,[Telephone_number] = @TELEPHONE,[Second_Telephone_Number] = @Second_Telephone_Number,[Fax_number] = @FAX,[Email] = @EMAIL WHERE Customer_ID="+customer_id;
            SqlCommand cmd = new SqlCommand(sqlupdate, conn.GetConnection());
            cmd.Parameters.AddWithValue("@CustomerName", CustomerName_txt.Text);
            cmd.Parameters.AddWithValue("@Adress", Adress_txt.Text);
            cmd.Parameters.AddWithValue("@Zipcode", Zipcode_txt.Text);
            cmd.Parameters.AddWithValue("@Residence", Residence_txt.Text);
            cmd.Parameters.AddWithValue("@Second_Adress", txt_secondadress.Text);
            cmd.Parameters.AddWithValue("@Second_Zipcode", txt_secondzipcode.Text);
            cmd.Parameters.AddWithValue("@Seconde_Residence", txt_secondresidence.Text);
            cmd.Parameters.AddWithValue("@Contactperson", txt_contactperson.Text);
            cmd.Parameters.AddWithValue("@Initials", txt_initials.Text);          
            cmd.Parameters.AddWithValue("@TELEPHONE", tele_txt.Text);
            cmd.Parameters.AddWithValue("@Second_Telephone_Number", txt_secondtelephonenumber.Text);
            cmd.Parameters.AddWithValue("@FAX", fax_txt.Text);
            cmd.Parameters.AddWithValue("@EMAIL", Email_txt.Text);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            Customer customer = new Customer(conn);
            customer.Show();
            this.Close();
        }

        private void lbl_secondadress_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(conn);
            customer.Show();
            this.Close();
        }

        private void faxnumber_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tele_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void CustomerName_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void Residence_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txt_contactperson_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txt_initials_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txt_secondresidence_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txt_secondtelephonenumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
