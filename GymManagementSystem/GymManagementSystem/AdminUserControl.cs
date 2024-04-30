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
    public partial class AdminUserControl : Form
    {
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Documents\GymMemberSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        private mainForm parentform;
        private string admin;

        public AdminUserControl(mainForm Parent)
        {
            InitializeComponent();
            parentform = Parent;
            admin = parentform.LoggedInAdmin;
        }
        private void displayData()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select mid as MemeberID, name as Name, age as Age, gender as Gender, date_of_birth as DateOfBirth, email as Email, contact_number as Telephone from [User]";
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
        private byte[] getMemory()
        {
            MemoryStream stream = new MemoryStream();
            pictureBox.Image.Save(stream, pictureBox.Image.RawFormat);
            return stream.GetBuffer();
        }
        private void AdminUserControl_Load(object sender, EventArgs e)
        {
            displayData();
            txtAction.Text = "";
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        string tempName;
        private void dgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            tempName = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [User] where mid ='"+tempName+"' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);

                txtID.Text = dt.Rows[0]["mid"].ToString();
                txtName.Text = dt.Rows[0]["name"].ToString();
                txtUsername.Text = dt.Rows[0]["username"].ToString();
                txtAge.Text = dt.Rows[0]["age"].ToString();
                txtGender.Text = dt.Rows[0]["gender"].ToString();
                txtEmail.Text = dt.Rows[0]["email"].ToString();
                txtNumber.Text = dt.Rows[0]["contact_number"].ToString();
                DateTime birthDate = (DateTime)dt.Rows[0]["date_of_birth"];
                txtDateofBirth.Text = birthDate.ToString("MM-dd-yyyy");
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

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
               try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into [User] (name, age, gender, date_of_birth, username, password, email, contact_number, user_type) values ('" + txtName.Text + "', '" + int.Parse(txtAge.Text) + "', '" + txtGender.Text + "', '" + txtDateofBirth.Text + "', '" + txtUsername.Text + "', '" + txtUsername.Text + "', '" + txtEmail.Text + "', '" + long.Parse(txtNumber.Text) + "','Member' )";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    timeOut();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update [User] set name ='"+txtName.Text+"', email='"+txtEmail.Text+"', contact_number='"+long.Parse(txtNumber.Text)+"', age='"+int.Parse(txtAge.Text)+"', gender='"+txtGender.Text+"', date_of_birth='"+txtDateofBirth.Text+"', user_image = @photo where mid ='"+tempName+"' ";
                cmd.Parameters.AddWithValue("@photo", getMemory());
                cmd.ExecuteNonQuery();
                con.Close();
                displayData();
                timeOut();
            }
            catch (Exception ex)
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
                    cmd.CommandText = "SELECT * FROM [User] where mid ='" + txtID.Text + "' ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(dt);

                    txtID.Text = dt.Rows[0]["mid"].ToString();
                    txtName.Text = dt.Rows[0]["name"].ToString();
                    txtUsername.Text = dt.Rows[0]["username"].ToString();
                    txtAge.Text = dt.Rows[0]["age"].ToString();
                    txtGender.Text = dt.Rows[0]["gender"].ToString();
                    txtEmail.Text = dt.Rows[0]["email"].ToString();
                    txtNumber.Text = dt.Rows[0]["contact_number"].ToString();

                    DateTime birthDate = (DateTime)dt.Rows[0]["date_of_birth"];
                    txtDateofBirth.Text = birthDate.ToString("MM-dd-yyyy");

                    if (dt.Rows[0]["user_image"] != DBNull.Value)
                    {
                        byte[] imageData = (byte[])dt.Rows[0]["user_image"];
                        MemoryStream ms = new MemoryStream(imageData);
                        pictureBox.Image = Image.FromStream(ms);
                    }
                    timeOut();
                    con.Close();
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

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            try { 
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from [User] where mid = '" + txtID.Text+"'";
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

        private void kryptonLinkLabel1_LinkClicked(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(openFileDialog.FileName);
            }
        }
    }
    }

