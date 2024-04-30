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

namespace GymManagementSystem
{
    public partial class Enrollment : Form
    {
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Documents\GymMemberSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        
        private string user;
        private string receievedName;

        private mainForm parentform;
        public Enrollment(mainForm Parent)
        {
            InitializeComponent();
            parentform = Parent;
            user = parentform.LoggedInUser;
            receievedName = parentform.className;
        }
        private void textBoxReset()
        {
            txtClassName.Text = "";
            txtWeight.Text = "";
            txtHeight.Text = "";
        }
        private void timer()
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
        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void kryptonLabel5_Click(object sender, EventArgs e)
        {

        }

        private void Enrollment_Load(object sender, EventArgs e)
        {
            txtAction.Hide();
            enrollPanel.Hide();
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select name,username,contact_number,age,gender from [User] where username = '" + user + "' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    txtName.Text = dt.Rows[0]["name"].ToString();
                    txtAge.Text = dt.Rows[0]["age"].ToString();
                    txtGender.Text = dt.Rows[0]["gender"].ToString();
                    txtUsername.Text = dt.Rows[0]["username"].ToString();
                    txtNumber.Text = dt.Rows[0]["contact_number"].ToString();
                    txtName.Text = dt.Rows[0]["name"] != DBNull.Value ? dt.Rows[0]["name"].ToString() : "";
                    txtAge.Text = dt.Rows[0]["age"] != DBNull.Value ? dt.Rows[0]["age"].ToString() : "";
                    txtGender.Text = dt.Rows[0]["gender"] != DBNull.Value ? dt.Rows[0]["gender"].ToString() : "";
                    txtUsername.Text = dt.Rows[0]["username"] != DBNull.Value ? dt.Rows[0]["username"].ToString() : "";
                    txtNumber.Text = dt.Rows[0]["contact_number"] != DBNull.Value ? dt.Rows[0]["contact_number"].ToString() : "";
                }
                con.Close();

                if (receievedName == null)
                {
                    txtClassName.Text = "";
                }
                else
                {
                    txtClassName.Text = receievedName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {

        }

        private void btnEnroll_Click_1(object sender, EventArgs e)
        {
            if (
                txtName.Text == "" ||
                txtUsername.Text == "" ||
                txtClassName.Text == "" ||
                txtWeight.Text == "" ||
                txtHeight.Text == "" ||
                txtNumber.Text == "" ||
                txtAge.Text == "" ||
                txtGender.Text == ""
                )
            {
                enrollPanel.Show();
                txtAction.Text = "Please Input Necessary Information";
                txtAction.Show();
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into [Enrollment] (name, user_name, class_name, weight, height, contact_number, age, gender) values ('" + txtName.Text + "', '" + txtUsername.Text + "', '" + txtClassName.Text + "', '" + float.Parse(txtWeight.Text) + "', '" + float.Parse(txtHeight.Text) + "', '" + long.Parse(txtNumber.Text) + "', '" + int.Parse(txtAge.Text) + "', '" + txtGender.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    txtAction.Text = "You have enrolled successfully!";
                    txtAction.Show();
                    enrollPanel.Show();
                    textBoxReset();
                    timer();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void enrollabel_Click(object sender, EventArgs e)
        {

        }
    }
}
