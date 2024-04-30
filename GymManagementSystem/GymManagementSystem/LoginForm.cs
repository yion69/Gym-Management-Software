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
    public partial class LoginForm : Form
    {
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Documents\GymMemberSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public delegate void LoginSuccessEventHandler(object sender, EventArgs e, string username);
        public event LoginSuccessEventHandler LoginSuccess;
      
        private mainForm parentForm;
        private SignUpForm signUpForm;

        public LoginForm(mainForm parent)
        {
            InitializeComponent();
            parentForm = parent;

            signUpForm = new SignUpForm(parentForm,this);
            signUpForm.TopLevel = false;
            signUpForm.TopMost = true;

        }
        public void OnLoginSuccess()
        {
            string username = txtUsername.Text;
            LoginSuccess?.Invoke(this, EventArgs.Empty, username);
         }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) && string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please Input Username & Password to continue");
            }
            else if(string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Please Input Password to continue");
            }
            else if(string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please Input Username to continue");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM [User] WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "' AND user_type = 'member'";
                    SqlDataAdapter adp = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {
                        this.Hide();
                        OnLoginSuccess();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or Password (If you are admin go to Admin Login)");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                MessageBox.Show(ex.Message);
                }
            }
        }

        private void linkSignUp_LinkClicked(object sender, EventArgs e)
        {
            this.Hide();
            signUpForm.FormBorderStyle = FormBorderStyle.None;
            parentForm.contentPanel.Controls.Add(signUpForm);
            signUpForm.Show();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private Boolean temp;
        private void kryptonPictureBox2_Click(object sender, EventArgs e)
        {
            temp = !temp;
            if (temp) { txtPassword.PasswordChar = '\0'; pictureBox.Image = Properties.Resources.eye_slash; }
            else { txtPassword.PasswordChar = '*'; pictureBox.Image = Properties.Resources.eye_regular; };
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void kryptonLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
