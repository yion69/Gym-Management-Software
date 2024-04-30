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
    public partial class AdminLogin : Form
    {
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Documents\GymMemberSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public delegate void AdminLoginEventtHandler(object sender, EventArgs e, string username);
        public event AdminLoginEventtHandler AdminLoginSuccess;

        private mainForm parentForm;

        public AdminLogin(mainForm Parent)
        {
            InitializeComponent();
            parentForm = Parent;
        }

        public void OnAdminLoginSuccess()
        {
            string adminUsername = txtUsername.Text;
            AdminLoginSuccess?.Invoke(this, EventArgs.Empty, adminUsername);
         }

        private Boolean temp;
        private void kryptonPictureBox2_Click(object sender, EventArgs e)
        {
            temp = !temp;
            if (temp) { txtPassword.PasswordChar = '\0'; pictureBox.Image = Properties.Resources.eye_slash; }
            else { txtPassword.PasswordChar = '*'; pictureBox.Image = Properties.Resources.eye_regular; };
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) && string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please Input Username & Password to continue");
            }
            else if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Please Input Password to continue");
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please Input Username to continue");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM [User] WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "' AND user_type = 'Admin'";
                    SqlDataAdapter adp = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {
                        this.Hide();
                        OnAdminLoginSuccess();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or Password");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
