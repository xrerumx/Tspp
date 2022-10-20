using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace ProjectTSPP
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-E75QKB\TEW_SQLEXPRESS;Initial Catalog=empdb;Integrated Security=True");

        private void Find()
        {
            Con.Open();
            string query = "SELECT * FROM [Table] where EmpId = '"+EmpIDTb.Text+"'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            var cultureInfo = new CultureInfo("en-US");
            foreach (DataRow dr in dt.Rows)
            {
                empidlbl.Text = dr["EmpId"].ToString();
                empnamelbl.Text = dr["EmpName"].ToString();
                empsurlbl.Text = dr["EmpSur"].ToString();
                empgenlbl.Text = dr["EmpGen"].ToString();
                empdoblbl.Text = DateTime.Parse(dr["EmpDob"].ToString(), cultureInfo).ToString("d");
                empposlbl.Text = dr["EmpPos"].ToString();
                empphonelbl.Text = dr["EmpPhone"].ToString();
                empaddlbl.Text = dr["EmpAdd"].ToString();
            }
            Con.Close();
        }


        private void HomeClick(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void View_Load(object sender, EventArgs e)
        {

        }

        private void SearchClick(object sender, EventArgs e)
        {
            Find();
        }

        private void ExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
