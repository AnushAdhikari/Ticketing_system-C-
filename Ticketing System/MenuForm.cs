using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recreation_Center_Ticketing_Method
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {           
            InitializeComponent();
        }

        private void panelDisplay_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void btnVisit_Click(object sender, EventArgs e)
        {
            panelDisplay.Controls.Clear();
            AddVisitors adVisitor = new AddVisitors();
            panelDisplay.Controls.Add(adVisitor);
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            panelDisplay.Controls.Clear();
            AddPrice adprice = new AddPrice();
            panelDisplay.Controls.Add(adprice);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            panelDisplay.Controls.Clear();
            Report report = new Report();
            panelDisplay.Controls.Add(report);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            panelDisplay.Controls.Clear();
            Check_out_Visitor exit = new Check_out_Visitor();
            panelDisplay.Controls.Add(exit);
        }
    }
}
