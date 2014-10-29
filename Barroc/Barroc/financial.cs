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
    public partial class financial : Form
    {
        ConnectionManager conn = new ConnectionManager();
        public financial(ConnectionManager conn)
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
    }
}
