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
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-E75QKB\TEW_SQLEXPRESS;Initial Catalog=empdb;Integrated Security=True");

        private void FetchEmp()
        {
            if (EmpIDTb.Text == "")
            {
                MessageBox.Show("Enter Employee ID!");
            }
            else {
                Con.Open();
                string query = "SELECT * FROM [Table] where EmpId = '" + EmpIDTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                var cultureInfo = new CultureInfo("en-US");
                foreach (DataRow dr in dt.Rows)
                {
                    EmpIDTb.Text = dr["EmpId"].ToString();
                    EmpNameTb.Text = dr["EmpName"].ToString();
                    EmpSurTb.Text = dr["EmpSur"].ToString();
                    EmpPosTb.Text = dr["EmpPos"].ToString();
                }
                Con.Close();
            }
        }

        int DailySalary, Total;
     
        private void ExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomeClick(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void CalculateClick(object sender, EventArgs e)
        {
            if (EmpPosTb.Text == "")
            {
                MessageBox.Show("Select Employee!");
            }
            else if (EmpWdTb.Text == "" || Convert.ToInt32(EmpWdTb.Text) > 28)
            {
                MessageBox.Show("Enter a valid number of days!");
            }
            else
            {
                if (EmpPosTb.Text == "TeamLead")
                {
                    DailySalary = 200;
                }
                else if (EmpPosTb.Text == "Senior")
                {
                    DailySalary = 150;
                }
                else if (EmpPosTb.Text == "Middle")
                {
                    DailySalary = 100;
                }
                else if (EmpPosTb.Text == "Junior")
                {
                    DailySalary = 50;
                }
                else if (EmpPosTb.Text == "Trainee")
                {
                    DailySalary = 20;
                }
                Total = DailySalary * Convert.ToInt32(EmpWdTb.Text);
                SalaryReport.Text = "Employee ID:  " + EmpIDTb.Text + "\n" + "Employee Name:  " + EmpNameTb.Text + "\n" + "Employee Surname:  " + EmpSurTb.Text + "\n" + "Employee Position:  " + EmpPosTb.Text + "\n" + "Worked days:  " + EmpWdTb.Text + "\n" + "Daily Salary:  " + DailySalary + "\n" + "Total amount:  " + Total;
            }
        }

        private void FetchClick(object sender, EventArgs e)
        {
            FetchEmp();
        }
    }
}
