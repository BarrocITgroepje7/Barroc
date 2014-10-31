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
    public partial class ViewStatus : Form
    {
        ConnectionManager conn = new ConnectionManager();
        public ViewStatus()
        {
            InitializeComponent();

            conn.OpenConnection();

            SqlDataAdapter SQLda = new SqlDataAdapter("SELECT Project_ID,Customer_ID,Project_name,Status,Start_date,End_date FROM Projects", conn.GetConnection());

            DataTable dt = new DataTable();
            SQLda.Fill(dt);

            viewstatus_grid.DataSource = dt;
            conn.CloseConnection();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Development development = new Development();
            development.Show();
            this.Hide();
        }

        private void viewstatus_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
