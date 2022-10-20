using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTSPP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void AdminLoginClick(object sender, EventArgs e)
        {
            if (UidTb.Text == "" || PassTb.Text == "")
            {
                MessageBox.Show("Enter  user name or password!");

            }
             else if (UidTb.Text == "admin" || PassTb.Text == "admin")
            {
                this.Hide();
                Home home = new Home();
                home.Show();
            }
             else
            {
                MessageBox.Show("Wrong user name or password!");
            }
        }

        private void ExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
