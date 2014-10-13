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
        public showcustomer()
        {
            InitializeComponent();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            string sqlupdate = "Update [Customer] Set [CustomerName] = @CustomerName,[Adress] = @Adress,[Zipcode] = @Zipcode,[Residence] = @Residence,[Telephone_number] = @TELEPHONE,[Fax_number] = @FAX,[Email] = @EMAIL";
            SqlCommand cmd = new SqlCommand(sqlupdate, conn.GetConnection());
            cmd.Parameters.AddWithValue("@CustomerName", CustomerName_txt.Text);
            cmd.Parameters.AddWithValue("@Adress", Adress_txt.Text);
            cmd.Parameters.AddWithValue("@Zipcode", Zipcode_txt.Text);
            cmd.Parameters.AddWithValue("@Residence", Residence_txt.Text);
            cmd.Parameters.AddWithValue("@TELEPHONE", tele_txt.Text);
            cmd.Parameters.AddWithValue("@FAX", fax_txt.Text);
            cmd.Parameters.AddWithValue("@EMAIL", Email_txt.Text);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            Customer customer = new Customer(conn);
            customer.Show();
            this.Close();
        }
    }
}
