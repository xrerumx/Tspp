namespace ProjectTSPP
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmployeesPicture = new System.Windows.Forms.PictureBox();
            this.SalaryPicture = new System.Windows.Forms.PictureBox();
            this.ViewPicture = new System.Windows.Forms.PictureBox();
            this.Salary = new System.Windows.Forms.Label();
            this.View = new System.Windows.Forms.Label();
            this.Employees = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.LoginPicture = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.EmployeesPicture);
            this.panel1.Controls.Add(this.SalaryPicture);
            this.panel1.Controls.Add(this.ViewPicture);
            this.panel1.Controls.Add(this.Salary);
            this.panel1.Controls.Add(this.View);
            this.panel1.Controls.Add(this.Employees);
            this.panel1.Location = new System.Drawing.Point(0, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 325);
            this.panel1.TabIndex = 0;
            // 
            // EmployeesPicture
            // 
            this.EmployeesPicture.Image = ((System.Drawing.Image)(resources.GetObject("EmployeesPicture.Image")));
            this.EmployeesPicture.Location = new System.Drawing.Point(91, 58);
            this.EmployeesPicture.Name = "EmployeesPicture";
            this.EmployeesPicture.Size = new System.Drawing.Size(150, 150);
            this.EmployeesPicture.TabIndex = 1;
            this.EmployeesPicture.TabStop = false;
            this.EmployeesPicture.Click += new System.EventHandler(this.EmployeesPictureClick);
            // 
            // SalaryPicture
            // 
            this.SalaryPicture.Image = ((System.Drawing.Image)(resources.GetObject("SalaryPicture.Image")));
            this.SalaryPicture.Location = new System.Drawing.Point(715, 58);
            this.SalaryPicture.Name = "SalaryPicture";
            this.SalaryPicture.Size = new System.Drawing.Size(150, 150);
            this.SalaryPicture.TabIndex = 1;
            this.SalaryPicture.TabStop = false;
            this.SalaryPicture.Click += new System.EventHandler(this.SalaryPictureClick);
            // 
            // ViewPicture
            // 
            this.ViewPicture.Image = ((System.Drawing.Image)(resources.GetObject("ViewPicture.Image")));
            this.ViewPicture.Location = new System.Drawing.Point(415, 58);
            this.ViewPicture.Name = "ViewPicture";
            this.ViewPicture.Size = new System.Drawing.Size(150, 150);
            this.ViewPicture.TabIndex = 1;
            this.ViewPicture.TabStop = false;
            this.ViewPicture.Click += new System.EventHandler(this.ViewPictureClick);
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.BackColor = System.Drawing.Color.Transparent;
            this.Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Salary.ForeColor = System.Drawing.Color.ForestGreen;
            this.Salary.Location = new System.Drawing.Point(696, 228);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(194, 42);
            this.Salary.TabIndex = 2;
            this.Salary.Text = "Salary info";
            this.Salary.Click += new System.EventHandler(this.SalaryClick);
            // 
            // View
            // 
            this.View.AutoSize = true;
            this.View.BackColor = System.Drawing.Color.Transparent;
            this.View.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.View.ForeColor = System.Drawing.Color.ForestGreen;
            this.View.Location = new System.Drawing.Point(405, 228);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(169, 42);
            this.View.TabIndex = 2;
            this.View.Text = "View info";
            this.View.Click += new System.EventHandler(this.ViewClick);
            // 
            // Employees
            // 
            this.Employees.AutoSize = true;
            this.Employees.BackColor = System.Drawing.Color.Transparent;
            this.Employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Employees.ForeColor = System.Drawing.Color.ForestGreen;
            this.Employees.Location = new System.Drawing.Point(67, 228);
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(203, 42);
            this.Employees.TabIndex = 2;
            this.Employees.Text = "Employees";
            this.Employees.Click += new System.EventHandler(this.EmployeesClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(879, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "@RerumCorp2022";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(107, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 37);
            this.label5.TabIndex = 2;
            this.label5.Text = "Home";
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.BackColor = System.Drawing.Color.Transparent;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Location = new System.Drawing.Point(871, 69);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(116, 37);
            this.Login.TabIndex = 2;
            this.Login.Text = "Logout";
            this.Login.Click += new System.EventHandler(this.LoginClick);
            // 
            // LoginPicture
            // 
            this.LoginPicture.Image = ((System.Drawing.Image)(resources.GetObject("LoginPicture.Image")));
            this.LoginPicture.Location = new System.Drawing.Point(815, 56);
            this.LoginPicture.Name = "LoginPicture";
            this.LoginPicture.Size = new System.Drawing.Size(50, 50);
            this.LoginPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginPicture.TabIndex = 1;
            this.LoginPicture.TabStop = false;
            this.LoginPicture.Click += new System.EventHandler(this.LoginPictureClick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.LoginPicture);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox EmployeesPicture;
        private PictureBox SalaryPicture;
        private PictureBox ViewPicture;
        private Label Salary;
        private Label View;
        private Label Employees;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private Label Login;
        private PictureBox LoginPicture;
    }
}