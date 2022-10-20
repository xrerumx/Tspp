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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            this.Timer.Start();
        }


        private void TimerProgress()
        {
            progressBar1.Value += 1;
            if (progressBar1.Value == 100)
            {
                Timer.Stop();
                this.Hide();
                Login log = new Login();
                log.Show();
            }
     
        }

        private void TimerTick(object sender, EventArgs e)
        {
            this.TimerProgress();
        }
    }
}