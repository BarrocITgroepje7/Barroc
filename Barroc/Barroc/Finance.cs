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
using Excel = Microsoft.Office.Interop.Excel;

namespace Barroc
{
    public partial class Finance : Form
    {
        ConnectionManager conn = new ConnectionManager();
        string project_id;
        public Finance()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp = new Excel.Application();  // create new Excel application
            xlApp.Visible = true;                               // application becomes visible
            xlApp.Workbooks.Open(@"C:\Users\michael\Documents\GitHub\Barroc\Barroc\Barroc\Factuur.xls");
            xlApp.Application.DisplayFullScreen = true;
        }

        private void financial_btn_Click(object sender, EventArgs e)
        {
            financial financial = new financial(conn);
            financial.Show();
            this.Close();
        }

        private void customervieuw_Click(object sender, EventArgs e)
        {
            vieuwcustomerFinance vieuwcustomerfinance = new vieuwcustomerFinance();
            vieuwcustomerfinance.Show();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            financialupdate update = new financialupdate(conn,project_id);
            update.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteFinancial delete = new DeleteFinancial();
            delete.Show();
            this.Close();
        }
    }
}