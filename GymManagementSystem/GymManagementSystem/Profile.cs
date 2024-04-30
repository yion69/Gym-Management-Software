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
    public partial class Profile : Form
    {
        private mainForm parentForm;
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Documents\GymMemberSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public ProfileEdit profileEdit;
        public HomePage homeForm;
        string user;

        public Profile(mainForm Parent, HomePage Home)
        {
            InitializeComponent();
            this.parentForm = Parent;

            homeForm = Home;
            homeForm.TopLevel = false;
            homeForm.TopMost = true;

            profileEdit = new ProfileEdit(parentForm, this);
            profileEdit.TopLevel = false;
            profileEdit.TopMost = true;

            user = parentForm.LoggedInUser;
        }
        public void displayData(string temp)
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM [User] where username ='"+temp+"'";
                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                txtName.Text = dt.Rows[0]["name"].ToString();
                txtUsername.Text = dt.Rows[0]["username"].ToString();
                txtPassword.Text = dt.Rows[0]["password"].ToString();
                txtEmail.Text = dt.Rows[0]["email"].ToString();
                txtNumber.Text = dt.Rows[0]["contact_number"].ToString();
                txtAge.Text = dt.Rows[0]["age"].ToString();
                txtGender.Text = dt.Rows[0]["gender"].ToString();
                DateTime date = (DateTime)dt.Rows[0]["date_of_birth"];
                txtDateOfBirth.Text = date.ToString("dd-MM-yyyy");
                if(dt.Rows[0]["user_image"] != DBNull.Value)
                {
                    byte[] imageData = (byte[])dt.Rows[0]["user_image"];
                    MemoryStream ms = new MemoryStream(imageData);
                    pictureBox.Image = Image.FromStream(ms);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Profile_Load(object sender, EventArgs e)
        {
            displayData(user);
        }

        private void kryptonLinkLabel1_LinkClicked(object sender, EventArgs e)
        {
            this.Hide();
            profileEdit.FormBorderStyle = FormBorderStyle.None;
            parentForm.contentPanel.Controls.Add(profileEdit);
            profileEdit.Show();
        }

        private void kryptonPictureBox1_Click(object sender, EventArgs e)
        {
            
            homeForm.FormBorderStyle = FormBorderStyle.None;
            parentForm.contentPanel.Controls.Add(homeForm);
            homeForm.displayProfileData(user);
            this.Hide();
            homeForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
