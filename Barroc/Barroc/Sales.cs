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
            Appointment appointment = new Appointment(conn);
            appointment.Show();
            this.Hide();
        }

        private void Managecustomer_btn_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(conn);
            customer.Show();
            this.Hide();
        }
    }
}
