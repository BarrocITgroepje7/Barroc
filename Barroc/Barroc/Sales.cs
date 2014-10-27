using Barroc_it;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barroc
{
    public partial class Sales : Form
    {
        ConnectionManager conn = new ConnectionManager();
        public Sales()
        {
            InitializeComponent();
        }

        private void appointment_btn_Click(object sender, EventArgs e)
        {
            conn.CloseConnection();
            Appointment appointment = new Appointment(conn);
            appointment.Show();
            this.Hide();
        }

        private void Managecustomer_btn_Click(object sender, EventArgs e)
        {
            conn.CloseConnection();
            Customer customer = new Customer(conn);
            customer.Show();
            this.Hide();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Sales_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
