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
    public partial class Appointment : Form
    {
        private ConnectionManager conn;
        public Appointment(ConnectionManager conn)
        {
            InitializeComponent();
            this.conn = conn;
            back_btn.Visible = false;



            conn.OpenConnection();

            SqlDataAdapter SQLda = new SqlDataAdapter("SELECT * FROM Appointments", conn.GetConnection());

            DataTable dt = new DataTable();
            SQLda.Fill(dt);

            Appointment_grid.DataSource = dt;
            conn.CloseConnection();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            this.Size = new Size(837, 315);
            Add_btn.Visible = false;
            back_btn.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Appointments (Appointments_ID, Customer_ID, Date_of_Action, Last_contact, Next_Action, Subject) values (@APPOINTMENT_ID,@CUSTOMER_ID,@DATE_OF_ACTION,@LAST_CONTACT,@NEXT_ACTION,@SUBJECT)";
            SqlCommand cmd = new SqlCommand(sql, conn.GetConnection());
            cmd.Parameters.Add(new SqlParameter("@APPOINTMENT_ID", Appointment_txt.Text));
            cmd.Parameters.Add(new SqlParameter("@CUSTOMER_ID", Customer_txt.Text));
            cmd.Parameters.Add(new SqlParameter("@DATE_OF_ACTION", Action_txt.Text));
            cmd.Parameters.Add(new SqlParameter("@LAST_CONTACT", Contact_txt.Text));
            cmd.Parameters.Add(new SqlParameter("@NEXT_ACTION", Next_txt.Text));
            cmd.Parameters.Add(new SqlParameter("@SUBJECT", Subject_txt.Text));

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            conn.OpenConnection();

            SqlDataAdapter SQLda = new SqlDataAdapter("SELECT * FROM Appointments", conn.GetConnection());

            DataTable dt = new DataTable();
            SQLda.Fill(dt);

            Appointment_grid.DataSource = dt;
            conn.CloseConnection();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            back_btn.Visible = false;
            Add_btn.Visible = true;
            this.Size = new Size(650, 315);
        }
    }
}
