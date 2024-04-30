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
    public partial class AdminTrainerControl : Form
    {
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Documents\GymMemberSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        private mainForm parentform;

        public AdminTrainerControl(mainForm Parent)
        {
            InitializeComponent();
            parentform = Parent;
        }

        private byte[] getMemory()
        {
            MemoryStream stream = new MemoryStream();
            pictureBox.Image.Save(stream, pictureBox.Image.RawFormat);
            return stream.GetBuffer();
        }

        private void displayData()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select tid as TrainerID, name as Name, age as Age, gender as Gender, specialization as Specialization, experience as Experience, description as Description, contact_number as Telephone from [Trainer]";
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
        public void timeOut()
        {
            txtAction.Text = "Action Completed !";
            var time = new Timer();
            time.Interval = 4000;
            time.Start();

            time.Tick += (sender, e) =>
            {
                txtAction.Text = "";
                time.Stop();
                time.Dispose();
            };
        }
        private void txtGender_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonLabel5_Click(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonLabel3_Click(object sender, EventArgs e)
        {

        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminTrainerControl_Load(object sender, EventArgs e)
        {
            displayData();
            txtAction.Text = "";
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
                cmd.CommandText = "select * from [Trainer] where tid ='"+tempName+"' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);

                txtID.Text = dt.Rows[0]["tid"].ToString();
                txtName.Text = dt.Rows[0]["name"].ToString();
                txtGender.Text = dt.Rows[0]["gender"].ToString();
                txtSpecialization.Text = dt.Rows[0]["specialization"].ToString();
                txtAge.Text = dt.Rows[0]["age"].ToString();
                txtExperience.Text = dt.Rows[0]["experience"].ToString();
                txtDescription.Text = dt.Rows[0]["description"].ToString();
                txtNumber.Text = dt.Rows[0][7].ToString();

                if(dt.Rows[0]["trainer_image"] != DBNull.Value)
                {
                    byte[] imageData = (byte[])dt.Rows[0]["trainer_image"];
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

        private void kryptonLinkLabel1_LinkClicked(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {   
            if(txtID.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update [Trainer] set tid='"+txtID.Text+"', name ='"+txtName.Text+"', specialization='"+txtSpecialization.Text+"', experience='"+txtExperience.Text+"', contact_number='"+long.Parse(txtNumber.Text)+"', age='"+int.Parse(txtAge.Text)+"', gender='"+txtGender.Text+"', description='"+txtDescription.Text+"', trainer_image = @photo where tid ='"+tempName+"' ";
                    cmd.Parameters.AddWithValue("@photo", getMemory());
                    cmd.ExecuteNonQuery();
                    con.Close();
                    timeOut();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 
            }
            else
            {
                MessageBox.Show("Please input ID to continue the process");
            }
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            try { 
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from [Trainer] where tid = '" + txtID.Text+"'";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted Successfully");
                displayData();
                timeOut();

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text != "")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM [Trainer] where tid ='" + txtID.Text + "' ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(dt);

                    txtID.Text = dt.Rows[0]["tid"].ToString();
                    txtName.Text = dt.Rows[0]["name"].ToString();
                    txtGender.Text = dt.Rows[0]["gender"].ToString();
                    txtSpecialization.Text = dt.Rows[0]["specialization"].ToString();
                    txtAge.Text = dt.Rows[0]["age"].ToString();
                    txtExperience.Text = dt.Rows[0]["experience"].ToString();
                    txtDescription.Text = dt.Rows[0]["description"].ToString();
                    txtNumber.Text = dt.Rows[0][7].ToString();

                    if(dt.Rows[0]["trainer_image"] != DBNull.Value)
                    {
                        byte[] imageData = (byte[])dt.Rows[0]["trainer_image"];
                        MemoryStream ms = new MemoryStream(imageData);
                        pictureBox.Image = Image.FromStream(ms);
                    }
                    con.Close();
                    timeOut();
                    }
                else
                {
                    MessageBox.Show("Put Input ID in the ID field");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [Trainer] (tid, name, gender, specialization, age, experience, description, contact_number) values ('"+txtID.Text+"','"+txtName.Text+"','"+txtGender.Text+"','"+txtSpecialization.Text+"','"+int.Parse(txtAge.Text)+"','"+txtExperience.Text+"','"+txtDescription.Text+"','"+long.Parse(txtNumber.Text)+"')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Inserted Successfully");
                displayData();
                timeOut();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
