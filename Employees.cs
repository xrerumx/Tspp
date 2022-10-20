using System.Data;
using System.Data.SqlClient;

namespace ProjectTSPP
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private SqlConnection Con = null;
        
        private void AddClick(object sender, EventArgs e)
        {
            if (EmpIDTb.Text == "" || EmpNameTb.Text == "" || EmpSurTb.Text == "" || EmpAddTb.Text == "" || EmpPhoneTb.Text == "")
            {
                MessageBox.Show("Missing information about employee!");           
            }
            else
            {
                try
                {
                    if(Con.State == ConnectionState.Closed)
                    {
                        Con.Open();
                    }
                    string query = "insert into [Table] (EmpId, EmpName, EmpSur, EmpPos, EmpAdd, EmpPhone, EmpGen, EmpDob) values('"+EmpIDTb.Text+"', '"+EmpNameTb.Text+"','"+EmpSurTb.Text+ "', '" + EmpPosTb.SelectedItem.ToString()+"','" + EmpAddTb.Text+ "', '"+EmpPhoneTb.Text+"','"+EmpGenTb.SelectedItem.ToString()+"', '"+EmpDobTb.Value.ToString("yyyy-MM-dd") +"')";
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee successfully added!");
                    this.RefreshEmp();
                    Con.Close();
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void RefreshEmp()
        {
            
            Con = new SqlConnection(@"Data Source=DESKTOP-E75QKB\TEW_SQLEXPRESS;Initial Catalog=empdb;Integrated Security=True");
            Con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [Table]", Con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            this.RefreshEmp();
        }

        private void DeleteClick(object sender, EventArgs e)
        {
            if (EmpIDTb.Text == "") 
            {
                MessageBox.Show("Please enter the employee Id");
            }
            else
            {
                try
                {
                    if (Con.State == ConnectionState.Closed)
                    {
                        Con.Open();
                    }
                    string query = "DELETE FROM [Table] WHERE EmpId ='" + EmpIDTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee successfully deleted!");
                    this.RefreshEmp();
                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EditClick(object sender, EventArgs e)
        {
            if (EmpIDTb.Text == "" || EmpNameTb.Text == "" || EmpSurTb.Text == "" || EmpAddTb.Text == "" || EmpPhoneTb.Text == "")
            {
                MessageBox.Show("Missing information about employee!");
            }
            else
            {
                try
                {
                    if (Con.State == ConnectionState.Closed)
                    {
                        Con.Open();
                    }
                    string query = "UPDATE [Table] SET EmpName = '" + EmpNameTb.Text + "', EmpSur = '" + EmpSurTb.Text + "', EmpPos = '" + EmpPosTb.SelectedItem.ToString() + "', EmpAdd = '" + EmpAddTb.Text + "', EmpPhone = '" + EmpPhoneTb.Text + "', EmpGen = '" + EmpGenTb.SelectedItem.ToString() + "', EmpDob = '" + EmpDobTb.Value.Date.ToString() + "'WHERE EmpId='"+EmpIDTb.Text+"';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee successfully updated!");
                    this.RefreshEmp();
                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpIDTb.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            EmpPosTb.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            EmpNameTb.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            EmpSurTb.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            EmpGenTb.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            EmpAddTb.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            EmpPhoneTb.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            EmpDobTb.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void HomeClick(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
