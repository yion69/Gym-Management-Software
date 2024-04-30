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
    public partial class Classes : Form
    {

        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Documents\GymMemberSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public delegate void ClassFormHandler(object sender, EventArgs e);
        public event ClassFormHandler classFormOpen;

        mainForm MainForm;
        public void OnClassEnroll()
        {
            classFormOpen?.Invoke(this, EventArgs.Empty);
         }
        private void displayData()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select class_name as Name, category as Type, duration as Duration, fees as Fees, start_date as StartDate from Class";
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
        public void checkBoxReset()
        {
            rdbDance.Checked = false;
            rdbCadio.Checked = false;
            rdbStrength.Checked = false;
            rdbFeatured.Checked = false;
            rdb45.Checked = false;
            rdb60.Checked = false;
            rdb75.Checked = false;
            rdb90.Checked = false;
        }
        public Classes(mainForm Parent)
        {
            InitializeComponent();
            MainForm = Parent;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string TypeOfClass = null;
            string Duration = null;
            
            if (rdbDance.Checked) { TypeOfClass = rdbDance.Text.ToString().ToLower(); }
            else if (rdbCadio.Checked) { TypeOfClass = rdbCadio.Text.ToString().ToLower(); }
            else if (rdbStrength.Checked) { TypeOfClass = rdbStrength.Text.ToString().ToLower(); }
            else if (rdbFeatured.Checked) { TypeOfClass = rdbFeatured.Text.ToString().ToLower(); }; 
                
            if (rdb45.Checked) { Duration = "45"; }
            else if (rdb60.Checked) { Duration = "60";  }
            else if (rdb75.Checked) { Duration = "75"; }
            else if (rdb90.Checked) { Duration = "90"; };

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT class_name AS Name, category AS Type, duration AS Duration, fees AS Fees, start_date AS StartDate FROM Class";
                StringBuilder queryBuilder = new StringBuilder(cmd.CommandText);
                if (!string.IsNullOrEmpty(TypeOfClass))
                {
                    queryBuilder.Append(" WHERE category = '"+TypeOfClass+"' ");

                    if (!string.IsNullOrEmpty(Duration))
                    {
                        queryBuilder.Append(" AND duration = '"+Duration+"' ");
                    }
                    cmd.CommandText = queryBuilder.ToString();
                }
                else if (!string.IsNullOrEmpty(Duration))
                {
                    queryBuilder.Append(" WHERE duration = '"+Duration+"' ");
                    cmd.CommandText = queryBuilder.ToString();
                
                }
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                dgv.DataSource = dt;
                con.Close();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Classes_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string tempName = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Class where class_name ='"+tempName+"' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);

                txtName.Text = dt.Rows[0]["class_name"].ToString();
                txtCategory.Text = dt.Rows[0]["category"].ToString();
                txtDuration.Text = dt.Rows[0]["duration"].ToString() + " mins";
                txtFees.Text = "$"+ dt.Rows[0]["fees"].ToString();
                
                DateTime startDate = (DateTime)dt.Rows[0]["start_date"];
                txtStartDate.Text = startDate.ToString("dd-MM-yyyy");

                DateTime endDate = (DateTime)dt.Rows[0]["end_date"];
                
                txtEndDate.Text = endDate.ToString("dd-MM-yyyy");
                txtDescription.Text = dt.Rows[0]["description"].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void kryptonCheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 

        }

        private void kryptonPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonPictureBox1_Click(object sender, EventArgs e)
        {
            checkBoxReset();
            displayData();
        }

        private void kryptonLabel4_Click(object sender, EventArgs e)
        {

        }

        private void kryptonLabel5_Click(object sender, EventArgs e)
        {

        }

        private void kryptonLabel6_Click(object sender, EventArgs e)
        {

        }

        private void kryptonLabel11_Click(object sender, EventArgs e)
        {

        }

        private void linkSignUp_LinkClicked(object sender, EventArgs e)
        {

        }

        private void txtDuration_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFees_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            if (MainForm.LoggedInUser != null)
            {
                if(txtName.Text == null)
                {
                    MessageBox.Show("Select a class");
                }
                else
                {
                    MainForm.className = txtName.Text;
                    this.Hide();
                    OnClassEnroll();
                }
            }
            else
            {
                MessageBox.Show("Please log in or sign up to perform this action");
            }
        }

        private void kryptonLabel10_Click(object sender, EventArgs e)
        {

        }
    }
}
