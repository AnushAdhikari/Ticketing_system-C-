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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "admin" && txtpassword.Text == "anush")
                {
                this.Hide();
                MenuForm home = new MenuForm();
                home.Show();
            }
            else
            {
                MessageBox.Show("Invalid!!", "Username or Password is Invalid",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
