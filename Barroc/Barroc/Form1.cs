﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            //using (ConnectionManager Conn = new ConnectionManager())
            //{
            //    Conn.openConnection();
            //    ///////////////testen!
            //    //Conn.GetDataSet("SELECT * FROM Users");
            string Username = Username_txt.Text;
            string Password = Password_txt.Text;

            //if (Username == "Admin" && Username == Password)
            //{
            //    //Ga naar het Admin scherm
            //    Admin admin = new Admin();
            //    admin.Show();
            //    this.Hide();
            //}
            if (Username == "Sales" && Username == Password)
            {
                //Ga naar het Sales scherm
                Sales sales = new Sales();
                sales.Show();
                this.Hide();
            }
            //else if (Username == "Financien" && Username == Password)
            //{
            //    //Ga naar het Finanicen scherm
            //    Financiën financien = new Financiën();
            //    financien.Show();
            //    this.Hide();
            //}
            //else if (Username == "Development" && Username == Password)
            //{
            //    //Ga naar het Development scherm
            //    Development development = new Development();
            //    development.Show();
            //    this.Hide();
            //}
            else
            {
                MessageBox.Show("You can't login in");
            }
        }
    }
}
