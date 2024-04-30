using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GymManagementSystem
{
    public partial class AdminHomePage : Form
    {
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Documents\GymMemberSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        private mainForm parentForm;
        private AdminUserControl adminUser;
        private AdminTrainerControl adminTrainer;
        private AdminClassesControl adminClass;
        private AdminLogin adminLogin;
        string admin;

        public AdminHomePage(mainForm Parent)
        {
            InitializeComponent();
            parentForm = Parent;
            admin = parentForm.LoggedInAdmin;

            adminUser = new AdminUserControl(parentForm);
            adminUser.TopLevel = false;
            adminUser.TopMost = true;

            adminTrainer = new AdminTrainerControl(parentForm);
            adminTrainer.TopLevel = false;
            adminTrainer.TopMost = true;

            adminClass = new AdminClassesControl();
            adminClass.TopLevel = false;
            adminClass.TopMost = true;

            adminLogin = new AdminLogin(parentForm);
            adminLogin.TopLevel = false;
            adminLogin.TopMost = true;
        }
        private void displayProfileData()
        {
                con.Open();
                string query = "SELECT * FROM [User] where username ='"+admin+"'";
                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                txtName.Text = dt.Rows[0]["name"].ToString();
                txtStatus.Text = dt.Rows[0]["user_type"].ToString();
                if(dt.Rows[0]["user_image"] != DBNull.Value)
                {
                    byte[] imageData = (byte[])dt.Rows[0]["user_image"];
                    MemoryStream ms = new MemoryStream(imageData);
                    pictureBox.Image = Image.FromStream(ms);
                }
                con.Close();
        }
        private void displayStats()
        {
            con.Open();
            string query = "Select (SELECT COUNT(*) FROM [User]) AS UserCount, (SELECT COUNT(*) FROM [Trainer]) AS TrainerCount, (SELECT COUNT(*) FROM [Class]) AS ClassCount;";
            SqlDataAdapter adp = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            txtNumberMember.Text = dt.Rows[0][0].ToString() + " members";
            txtNumberTrainer.Text = dt.Rows[0][1].ToString() + " trainers";
            txtNumberClass.Text = dt.Rows[0][2].ToString() + " classes";
            con.Close();
        }
        private void AdminHomePage_Load(object sender, EventArgs e)
        {
            timer1.Start();
            displayStats();
            displayProfileData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            txtTime.Text = currentTime.ToString("hh:mm:ss tt");
            txtDate.Text = currentTime.Date.ToString("dd/MM/yyyy");
        }

        private void kryptonPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonLinkLabel3_LinkClicked(object sender, EventArgs e)
        {

        }

        private void kryptonPanel5_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminUser.FormBorderStyle = FormBorderStyle.None;
            parentForm.contentPanel.Controls.Add(adminUser);
            adminUser.Show();
        }

        private void kryptonPanel6_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminTrainer.FormBorderStyle = FormBorderStyle.None;
            parentForm.contentPanel.Controls.Add(adminTrainer);
            adminTrainer.Show();
        }

        private void kryptonPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonPanel7_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminClass.FormBorderStyle = FormBorderStyle.None;
            parentForm.contentPanel.Controls.Add(adminClass);
            adminClass.Show();
        }

        private void linkSignUp_LinkClicked(object sender, EventArgs e)
        {
            this.Hide();
            parentForm.LoggedInAdmin = null;
            adminLogin.FormBorderStyle = FormBorderStyle.None;
            parentForm.contentPanel.Controls.Add(adminLogin);
            adminLogin.Show();
        }

        private void kryptonLinkLabel1_LinkClicked(object sender, EventArgs e)
        {
            this.Hide();
            adminUser.FormBorderStyle = FormBorderStyle.None;
            parentForm.contentPanel.Controls.Add(adminUser);
            adminUser.Show();
        }
    }
}
