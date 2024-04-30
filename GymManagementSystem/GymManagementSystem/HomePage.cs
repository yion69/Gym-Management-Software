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
using System.Timers;

namespace GymManagementSystem
{
    public partial class HomePage : Form
    {
        private mainForm parentForm;
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Documents\GymMemberSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public delegate void LoginSuccessEventHandler(object sender, EventArgs e, string username);
        public event LoginSuccessEventHandler LogOut;

        public LoginForm login;
        public Profile profile;
        public HomePage(mainForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;

            profile = new Profile(parentForm, this);
            profile.TopLevel = false;
            profile.TopMost = true;

            login = new LoginForm(parentForm);
            login.TopLevel = false;
            login.TopMost = true;
        }
        public void OnLogOut()
        {
            string username = null;
            LogOut?.Invoke(this, EventArgs.Empty, username);
        }
        public void displayProfileData(string temp)
        {
                con.Open();
                string query = "SELECT * FROM [User] where username ='"+temp+"'";
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
        private void kryptonTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            string user = parentForm.LoggedInUser;
            timer1.Start();
            try
            {
                displayProfileData(user);

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select e.class_name, c.category, c.duration from [Enrollment] e, [Class] c where e.user_name = '" + user + "' and e.class_name = c.class_name ";
                cmd.ExecuteNonQuery();
                DataTable dt2 = new DataTable();
                SqlDataAdapter adp2 = new SqlDataAdapter(cmd);
                adp2.Fill(dt2);

                if(dt2.Rows.Count == 1)
                {
                    txtClassName1.Text = dt2.Rows[0]["class_name"].ToString();
                    txtClassCategory1.Text = dt2.Rows[0]["category"].ToString();
                    txtClassDuration1.Text = dt2.Rows[0]["duration"].ToString() + " mins";
                    picBox2.Hide();
                }
                else if(dt2.Rows.Count == 2)
                {
                    txtClassName1.Text = dt2.Rows[0]["class_name"].ToString();
                    txtClassCategory1.Text = dt2.Rows[0]["category"].ToString();
                    txtClassDuration1.Text = dt2.Rows[0]["duration"].ToString() + " mins";

                    txtClassName2.Text = dt2.Rows[1]["class_name"].ToString();
                    txtClassCategory2.Text = dt2.Rows[1]["category"].ToString();
                    txtClassDuration2.Text = dt2.Rows[1]["duration"].ToString() + " mins";
                }
                else
                {
                    picBox1.Hide();
                    picBox2.Hide();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            txtTime.Text = currentTime.ToString("hh:mm:ss tt");
            txtDate.Text = currentTime.Date.ToString("dd/MM/yyyy");
        }

        private void kryptonLinkLabel1_LinkClicked(object sender, EventArgs e)
        {
            this.Hide();
            profile.FormBorderStyle = FormBorderStyle.None;
            parentForm.contentPanel.Controls.Add(profile);
            profile.Show();
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkSignUp_LinkClicked(object sender, EventArgs e)
        {
            this.Hide();
            parentForm.LoggedInUser = null;
            login.FormBorderStyle = FormBorderStyle.None;
            parentForm.contentPanel.Controls.Add(login);
            login.Show();
        }

        private void txtClassName1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtClassDuration2_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteBox1_Click(object sender, EventArgs e)
        {
            kryptonPanel7.Controls.Clear();
            kryptonPanel7.Controls.Add(notiPanel2);
            kryptonPanel8.Controls.Clear();
            kryptonPanel8.Controls.Add(notiPanel3);         
            kryptonPanel9.Controls.Clear(); 
        }

        private void deleteBox2_Click(object sender, EventArgs e)
        {
            if (kryptonPanel7.Controls.Contains(notiPanel1))
            {
                kryptonPanel7.Controls.Clear();
                kryptonPanel7.Controls.Add(notiPanel2);
                kryptonPanel8.Controls.Clear();
                kryptonPanel8.Controls.Add(notiPanel3);
            }
            else if (kryptonPanel7.Controls.Contains(notiPanel2))
            {
                kryptonPanel7.Controls.Clear();
                kryptonPanel7.Controls.Add(notiPanel3);
            }
        }

        private void deleteBox3_Click(object sender, EventArgs e)
        {
            if (kryptonPanel7.Controls.Contains(notiPanel3))
            {
                kryptonPanel7.Controls.Clear();
            }
            else if (kryptonPanel7.Controls.Contains(notiPanel2))
            {
                kryptonPanel8.Controls.Clear();
            }
            else if (kryptonPanel7.Controls.Contains(notiPanel1))
            {
                kryptonPanel9.Controls.Clear();
            }
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
