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
    public partial class showappointment : Form
    {
        ConnectionManager conn = new ConnectionManager();
        string appointment_id;
        public showappointment(string appointment_id)
        {
            InitializeComponent();
            this.appointment_id = appointment_id;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string sqlupdate = "Update [Appointments] Set [Date_of_Action] = @Date_of_Action,[Last_contact] = @Last_contact,[Next_Action] = @Next_Action,[Subject] = @Subject WHERE Appointments_id=" + appointment_id;
            SqlCommand cmd = new SqlCommand(sqlupdate, conn.GetConnection());
            cmd.Parameters.AddWithValue("@Date_of_Action", txt_datofaction.Text);
            cmd.Parameters.AddWithValue("@Last_contact", txt_lastcontact.Text);
            cmd.Parameters.AddWithValue("@Next_Action", txt_nextcontact.Text);
            cmd.Parameters.AddWithValue("@Subject", txt_subject.Text);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            Appointment appointment = new Appointment(conn);
            appointment.Show();
            this.Hide();
        }

        private void showappointment_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment(conn);
            appointment.Show();
            this.Hide();
        }
    }
}
