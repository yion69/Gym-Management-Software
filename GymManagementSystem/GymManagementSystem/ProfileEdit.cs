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
    public partial class ProfileEdit : Form
    {
        
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Documents\GymMemberSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        
        public Profile profileForm;
        public mainForm mainform;
        string user;
        public ProfileEdit(mainForm Main, Profile profile)
        {
            InitializeComponent();
            mainform = Main;

            profileForm = profile;
            profileForm.TopLevel = false;
            profileForm.TopMost = true;

            user = mainform.LoggedInUser;
        }
        private byte[] getMemory()
        {
            MemoryStream stream = new MemoryStream();
            pictureBox.Image.Save(stream, pictureBox.Image.RawFormat);
            return stream.GetBuffer();

        }
        private void showData()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [User] where username = '" + user + "' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);

                txtNName.Text = dt.Rows[0]["name"].ToString();
                txtUsername.Text = dt.Rows[0]["username"].ToString();
                txtPassword.Text = dt.Rows[0]["password"].ToString();
                txtNumber.Text = dt.Rows[0]["contact_number"].ToString();
                txtEmail.Text = dt.Rows[0]["email"].ToString();
                txtAge.Text = dt.Rows[0]["age"].ToString();
                txtGender.Text = dt.Rows[0]["gender"].ToString();
                dateTimePicker1.Text = dt.Rows[0]["date_of_birth"].ToString();
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
        private void btnClasses_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void kryptonGroupBox1_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            profileForm.FormBorderStyle = FormBorderStyle.None;
            this.Hide();
            mainform.contentPanel.Controls.Add(profileForm);
            profileForm.Show();
        }

        private void ProfileEdit_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            showData();
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update [User] set name ='"+txtNName.Text+"', email='"+txtEmail.Text+"', contact_number='"+long.Parse(txtNumber.Text)+"', age='"+int.Parse(txtAge.Text)+"', gender='"+txtGender.Text+"', date_of_birth='"+dateTimePicker1.Value+"', password='"+txtPassword.Text+"', user_image = @photo where username ='"+user+"' ";
                cmd.Parameters.AddWithValue("@photo", getMemory());
                cmd.ExecuteNonQuery();
                con.Close();
                profileForm.FormBorderStyle = FormBorderStyle.None;
                this.Hide();
                mainform.contentPanel.Controls.Add(profileForm);
                profileForm.Show();
                profileForm.displayData(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
