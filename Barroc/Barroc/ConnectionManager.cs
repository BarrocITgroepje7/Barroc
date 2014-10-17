using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barroc_it
{
    public class ConnectionManager
    {
        private SqlConnection conn;
        
        public ConnectionManager()
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\michael\Documents\GitHub\Barroc\Barroc\Barroc\Barroc-IT.mdf;Integrated Security=True";
            //conn.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\BarrocDB.mdf;Integrated Security=True;";
        }

        public ConnectionManager(string connectionString)
        {
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
        }

        public void OpenConnection()
        {
            conn.Open();
        }

        public void CloseConnection()
        {
            conn.Close();
        }

        public SqlConnection GetConnection()
        {
            return this.conn;
        }

        /*
        string connection = ConfigurationManager.ConnectionStrings["Barroc-IT"].ConnectionString;
        //opens the connection
        public void openConnection()
        {
            string connection = ConfigurationManager.ConnectionStrings["Barroc-IT"].ConnectionString;
            conn.ConnectionString = connection;
            //conn.Open();
            //if (conn.State == ConnectionState.Open)
            //{
            //    MessageBox.Show("Connection has been succesfull.");
            //}
            //else
            //{
            //    MessageBox.Show("Connection has been failed.");
            //}

        }
        public void closeConnection()
        {
            conn.Close();
        }

        public void sqlCommand(string command)
        {
            SqlCommand comm = new SqlCommand(command, conn);
        }

        public DataSet GetDataSet(string sqlCommand)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sqlCommand;
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();

            conn.Open();
            da.Fill(ds);
            conn.Close();

            return ds;
        }

        public void Dispose()
        {
            conn.Close();
        }

        public SqlConnection GetConnection()
        {
            return this.conn;
        }
    }
         * */
    }
}
