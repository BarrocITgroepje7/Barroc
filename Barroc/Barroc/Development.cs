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
    public partial class Development : Form
    {
        ConnectionManager conn = new ConnectionManager();
        public Development()
        {
            InitializeComponent();
        }

        private void btn_AddProject_Click(object sender, EventArgs e)
        {
            conn.CloseConnection();
            Project project = new Project(conn);
            project.Show();
            this.Hide();
        }

        private void btn_ManageProject_Click(object sender, EventArgs e)
        {

        }

        private void btn_DeleteProject_Click(object sender, EventArgs e)
        {

        }

        private void btn_ViewStatus_Click(object sender, EventArgs e)
        {

        }

        private void btn_ManageCustomers_Click(object sender, EventArgs e)
        {

        }
    }
}
