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
    public partial class vieuwcustomerFinance : Form
    {
        ConnectionManager conn = new ConnectionManager();
        public vieuwcustomerFinance()
        {
            InitializeComponent();
            conn.OpenConnection();

            SqlDataAdapter SQLda = new SqlDataAdapter("SELECT * FROM Customer", conn.GetConnection());

            DataTable dt = new DataTable();
            SQLda.Fill(dt);

            viewcustomer_grid.DataSource = dt;
            conn.CloseConnection();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Finance finance = new Finance();
            finance.Show();
            this.Close();
        }
    }
}
