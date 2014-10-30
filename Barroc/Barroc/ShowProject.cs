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
    public partial class ShowProject : Form
    {
        ConnectionManager conn = new ConnectionManager();
        string project_id;
        public ShowProject(string project_id)
        {
            InitializeComponent();
            this.project_id = project_id;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string sqlupdate = "Update [Projects] Set [Customer_ID] = @Customer_ID, " +
            "[Project_name] = @Project_name, [Status] = @Status, [Applications] = @Applications, " +
            "[Hardware] = @Hardware, [Software] = @Software, [Offer_number] = @Offer_number, " +
            "[Internal_contact_person] = @Internal_contact_person, [Start_date] = @Start_date, [End_date] = @End_date, " +
            "[Nmber_of_invoices] = @Nmber_of_invoices WHERE Project_ID=" + project_id;
            SqlCommand cmd = new SqlCommand(sqlupdate, conn.GetConnection());
            cmd.Parameters.AddWithValue("@Customer_ID", txt_customerid.Text);
            cmd.Parameters.AddWithValue("@Project_name", txt_projectname.Text);
            cmd.Parameters.AddWithValue("@Status", txt_status.Text);
            cmd.Parameters.AddWithValue("@Applications", txt_applications.Text);
            cmd.Parameters.AddWithValue("@Hardware", txt_hardware.Text);
            cmd.Parameters.AddWithValue("@Software", txt_software.Text);
            cmd.Parameters.AddWithValue("@Offer_number", txt_offernumber.Text);
            cmd.Parameters.AddWithValue("@Internal_contact_person", txt_internalcontactperson.Text);
            cmd.Parameters.AddWithValue("@Start_date", txt_startdate.Text);
            cmd.Parameters.AddWithValue("@End_date", txt_enddate.Text);
            cmd.Parameters.AddWithValue("@Nmber_of_invoices", txt_numberofinvoices.Text);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            Project Project = new Project(conn);
            Project.Show();
            this.Close();
        }
    }
}
