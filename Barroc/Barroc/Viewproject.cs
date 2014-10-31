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
    public partial class Viewproject : Form
    {
        ConnectionManager conn = new ConnectionManager();
        public Viewproject()
        {
            InitializeComponent();

            conn.OpenConnection();

            SqlDataAdapter SQLda = new SqlDataAdapter("SELECT * FROM Projects", conn.GetConnection());

            DataTable dt = new DataTable();
            SQLda.Fill(dt);

            viewporject_grid.DataSource = dt;
            conn.CloseConnection();
        }

        private void viewporject_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
            this.Hide();
        }
    }
}
