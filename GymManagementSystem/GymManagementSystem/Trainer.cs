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
    public partial class Trainer : Form
    {

        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Documents\GymMemberSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public void displayData()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select name as Name, gender as Gender, experience as Experience, specialization as Specialization, contact_number as Number from Trainer";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                dgv.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void resetTextbox()
        {
            txtName.Text = "";
            txtGender.Text = "";
            txtSpecialization.Text = "";
            txtAge.Text = "";
            txtExperience.Text = "";
            txtNumber.Text = "";
            txtDescription.Text = "";
            pictureBox.Image = null;
        }
        public Trainer()
        {
            InitializeComponent();
        }

        private void Trainer_Load(object sender, EventArgs e)
        {
            displayData();
        }
        string tempName;
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tempName = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select tid, name, gender, specialization, age, experience, description, contact_number, trainer_image from [Trainer] where name='"+tempName+"'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);

                txtName.Text = dt.Rows[0]["name"].ToString();
                txtGender.Text = dt.Rows[0]["gender"].ToString();
                txtSpecialization.Text = dt.Rows[0]["specialization"].ToString();
                txtAge.Text = dt.Rows[0]["age"].ToString();
                txtExperience.Text = dt.Rows[0]["experience"].ToString();
                txtDescription.Text = dt.Rows[0]["description"].ToString();
                txtNumber.Text = dt.Rows[0]["contact_number"].ToString();

                if(dt.Rows[0]["trainer_image"] != DBNull.Value)
                {
                    byte[] imageData = (byte[])dt.Rows[0]["trainer_image"];
                    MemoryStream ms = new MemoryStream(imageData);
                    pictureBox.Image = Image.FromStream(ms);
                }           
                else
                {
                    pictureBox.Image = null;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void kryptonPictureBox2_Click(object sender, EventArgs e)
        {
            resetTextbox();
        }
    }
}
