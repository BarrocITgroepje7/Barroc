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
    }
}