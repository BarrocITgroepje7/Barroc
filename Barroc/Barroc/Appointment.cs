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
        ConnectionManager conn = new ConnectionManager();
        showappointment showappointment;
        sure sures;
        public Appointment(ConnectionManager conn)
        {
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Now.Date;
            dateTimePicker2.MinDate = DateTime.Now.Date;
            dateTimePicker3.MinDate = DateTime.Now.Date;

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
            this.Size = new Size(929, 315);
            Add_btn.Visible = false;
            back_btn.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Appointments (Customer_ID, Date_of_Action, Last_contact, Next_Action, Subject) values (@CUSTOMER_ID,@DATE_OF_ACTION,@LAST_CONTACT,@NEXT_ACTION,@SUBJECT)";
            SqlCommand cmd = new SqlCommand(sql, conn.GetConnection());
            cmd.Parameters.Add(new SqlParameter("@CUSTOMER_ID", Customer_txt.Text));
            cmd.Parameters.Add(new SqlParameter("@DATE_OF_ACTION", this.dateTimePicker1.Text));
            cmd.Parameters.Add(new SqlParameter("@LAST_CONTACT", this.dateTimePicker2.Text));
            cmd.Parameters.Add(new SqlParameter("@NEXT_ACTION", this.dateTimePicker3.Text));
            cmd.Parameters.Add(new SqlParameter("@SUBJECT", Subject_txt.Text));

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            MessageBox.Show("You added a appointment");

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

        private void btn_back_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
            this.Hide();
        }

        private void Appointment_grid_DoubleClick(object sender, EventArgs e)
        {
            int update;
            update = Appointment_grid.CurrentRow.Index;

            DataGridViewRow row = Appointment_grid.SelectedRows[0];
            string id = row.Cells[0].Value.ToString();

            showappointment = new showappointment(id);

            showappointment.dateTimePicker1.Text = Appointment_grid.Rows[update].Cells[2].Value.ToString();
            showappointment.dateTimePicker2.Text = Appointment_grid.Rows[update].Cells[3].Value.ToString();
            showappointment.dateTimePicker3.Text = Appointment_grid.Rows[update].Cells[4].Value.ToString();
            showappointment.txt_subject.Text = Appointment_grid.Rows[update].Cells[5].Value.ToString();
            showappointment.ShowDialog();
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            sures = new sure();
            DialogResult dialog = sures.ShowDialog();

            if (dialog == DialogResult.OK)
            {
                DataGridViewRow row = Appointment_grid.SelectedRows[0];
                string id = row.Cells[0].Value.ToString();

                SqlCommand SQLda = new SqlCommand("DELETE FROM Appointments WHERE Appointments_id=" + id, conn.GetConnection());
                SQLda.Connection.Open();
                SQLda.ExecuteNonQuery();
                SQLda.Connection.Close();

                SqlDataAdapter SQLs = new SqlDataAdapter("SELECT Appointments_id, Customer_id, Date_of_Action, Last_contact, Next_Action, Subject FROM Appointments", conn.GetConnection());

                DataTable dt = new DataTable();
                SQLs.Fill(dt);

                Appointment_grid.DataSource = dt;
                conn.CloseConnection();
            }
            else if (dialog == DialogResult.Cancel)
            {
                sures.Close();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
        }
    }
}
