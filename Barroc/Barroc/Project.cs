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
    public partial class Project : Form
    {
        ConnectionManager conn = new ConnectionManager();
        ShowProject form;
        sure projectsure;
        public Project(ConnectionManager conn)
        {
            InitializeComponent();
            comboBox1.Items.Add("True");
            comboBox1.Items.Add("False");
            dateTimePicker1.MinDate = DateTime.Now.Date;
            dateTimePicker2.MinDate = DateTime.Now.Date;
            this.conn = conn;
            back_btn.Visible = false;

            conn.OpenConnection();

            SqlDataAdapter SQLda = new SqlDataAdapter("SELECT * FROM Projects", conn.GetConnection());

            DataTable dt = new DataTable();
            SQLda.Fill(dt);

            Project_grid.DataSource = dt;
            conn.CloseConnection();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Development dev = new Development();
            dev.Show();
            this.Hide();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1237, 360);
            add_btn.Visible = false;
            back_btn.Visible = true;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            back_btn.Visible = false;
            add_btn.Visible = true;
            this.Size = new Size(650, 360);
        }

        private void btn_toevoegen_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Projects (Customer_ID, Maintenance_Contract, Project_name, Status, Applications, Hardware, Software, Offer_number, Internal_contact_person, Start_date, End_date, Nmber_of_invoices) values (@Customer_ID,@Maintenance_Contract,@Project_name,@Status,@Applications,@Hardware,@Software,@Offer_number,@Internal_contact_person,@Start_date,@End_date,@Nmber_of_invoices)";
            SqlCommand cmd = new SqlCommand(sql, conn.GetConnection());
            cmd.Parameters.Add(new SqlParameter("@Customer_ID", txt_customerid.Text));
            cmd.Parameters.Add(new SqlParameter("@Maintenance_Contract", comboBox1.Text));
            cmd.Parameters.Add(new SqlParameter("@Project_name", txt_projectname.Text));
            cmd.Parameters.Add(new SqlParameter("@Status", txt_status.Text));
            cmd.Parameters.Add(new SqlParameter("@Applications", txt_applications.Text));
            cmd.Parameters.Add(new SqlParameter("@Hardware", txt_hardware.Text));
            cmd.Parameters.Add(new SqlParameter("@Software", txt_software.Text));
            cmd.Parameters.Add(new SqlParameter("@Offer_number", txt_offernumber.Text));
            cmd.Parameters.Add(new SqlParameter("@Internal_contact_person", txt_internalcontactperson.Text));
            cmd.Parameters.Add(new SqlParameter("@Start_date", this.dateTimePicker1.Text));
            cmd.Parameters.Add(new SqlParameter("@End_date", this.dateTimePicker2.Text));
            cmd.Parameters.Add(new SqlParameter("@Nmber_of_invoices", txt_numberofinvoices.Text));

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            MessageBox.Show("You added a project");

            conn.OpenConnection();

            SqlDataAdapter SQLda = new SqlDataAdapter("SELECT * FROM Projects", conn.GetConnection());

            DataTable dt = new DataTable();
            SQLda.Fill(dt);

            Project_grid.DataSource = dt;
            conn.CloseConnection();
        }

        private void Project_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Project_grid_DoubleClick(object sender, EventArgs e)
        {
            int update;
            update = Project_grid.CurrentRow.Index;

            DataGridViewRow row = Project_grid.SelectedRows[0];
            string id = row.Cells[0].Value.ToString();

            form = new ShowProject(id);

            form.txt_customerid.Text = Project_grid.Rows[update].Cells[1].Value.ToString();
            form.txt_projectname.Text = Project_grid.Rows[update].Cells[2].Value.ToString();
            form.comboBox1.Text = Project_grid.Rows[update].Cells[3].Value.ToString();
            form.txt_status.Text = Project_grid.Rows[update].Cells[4].Value.ToString();
            form.txt_applications.Text = Project_grid.Rows[update].Cells[5].Value.ToString();
            form.txt_hardware.Text = Project_grid.Rows[update].Cells[6].Value.ToString();
            form.txt_software.Text = Project_grid.Rows[update].Cells[7].Value.ToString();
            form.txt_offernumber.Text = Project_grid.Rows[update].Cells[8].Value.ToString();
            form.txt_internalcontactperson.Text = Project_grid.Rows[update].Cells[9].Value.ToString();
            form.dateTimePicker1.Text = Project_grid.Rows[update].Cells[10].Value.ToString();
            form.dateTimePicker2.Text = Project_grid.Rows[update].Cells[11].Value.ToString();
            form.txt_numberofinvoices.Text = Project_grid.Rows[update].Cells[12].Value.ToString();
            form.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = Project_grid.DataSource;
            bs.Filter = "Project_name like '%" + textBox1.Text + "%'";
            Project_grid.DataSource = bs;
        }

        private void projectid_lbl_Click(object sender, EventArgs e)
        {
        }

        private void txt_projectid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_customerid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_offernumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_offernumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_numberofinvoices_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void projectname_lbl_Click(object sender, EventArgs e)
        {
            projectname_lbl.Visible = false;
        }

        private void status_lbl_Click(object sender, EventArgs e)
        {
            status_lbl.Visible = false;
        }

        private void applications_lbl_Click(object sender, EventArgs e)
        {
            applications_lbl.Visible = false;
        }

        private void hardware_lbl_Click(object sender, EventArgs e)
        {
            hardware_lbl.Visible = false;
        }

        private void software_lbl_Click(object sender, EventArgs e)
        {
            software_lbl.Visible = false;
        }

        private void offernumber_lbl_Click(object sender, EventArgs e)
        {
            offernumber_lbl.Visible = false;
        }

        private void internalcontactperson_lbl_Click(object sender, EventArgs e)
        {
            internalcontactperson_lbl.Visible = false;
        }

        private void numberofinvooices_lbl_Click(object sender, EventArgs e)
        {
            numberofinvooices_lbl.Visible = false;
        }

        private void customerid_lbl_Click(object sender, EventArgs e)
        {
            customerid_lbl.Visible = false;
        }

        private void txt_projectname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txt_status_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txt_applications_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txt_hardware_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txt_software_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txt_internalcontactperson_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            projectsure = new sure();
            DialogResult dialog = projectsure.ShowDialog();
            
            if(dialog == DialogResult.OK)
            {
                DataGridViewRow row = Project_grid.SelectedRows[0];
                string id = row.Cells[0].Value.ToString();

                SqlCommand SQLda = new SqlCommand("DELETE FROM Projects WHERE Project_id=" + id, conn.GetConnection());
                SQLda.Connection.Open();
                SQLda.ExecuteNonQuery();
                SQLda.Connection.Close();

                SqlDataAdapter SQLs = new SqlDataAdapter("SELECT * FROM Projects", conn.GetConnection());

                DataTable dt = new DataTable();
                SQLs.Fill(dt);

                Project_grid.DataSource = dt;
                conn.CloseConnection();
            }
            else if (dialog == DialogResult.Cancel)
            {
                projectsure.Close();
            }
            
        }
    }
}
