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
    public partial class AdminEnrollmentControl : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Documents\GymMemberSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            
        public AdminEnrollmentControl()
        {
            InitializeComponent();
        }
        private void displayData()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select eid as EID, name as Name, user_name as Username, age as Age, gender as Gender, weight as Weight, height as Height, class_name as ClassName FROM [Enrollment]";
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
        private void timeOut()
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
        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonLabel5_Click(object sender, EventArgs e)
        {

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
                cmd.CommandText = "SELECT * FROM [Enrollment] where eid = '"+tempName+"' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);

                txtEid.Text = dt.Rows[0]["eid"].ToString();
                txtNname.Text = dt.Rows[0]["name"].ToString();
                txtUsername.Text = dt.Rows[0]["user_name"].ToString();
                txtClassname.Text = dt.Rows[0]["class_name"].ToString();
                txtGender.Text = dt.Rows[0]["gender"].ToString();
                txtAge.Text = dt.Rows[0]["age"].ToString();
                txtNumber.Text = dt.Rows[0]["contact_number"].ToString();
                txtHeight.Text = dt.Rows[0]["height"].ToString();
                txtWeight.Text = dt.Rows[0]["weight"].ToString();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdminEnrollmentControl_Load(object sender, EventArgs e)
        {
            displayData();
            txtAction.Text = "";
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            if(txtEid.Text != null)
            {
                try { 
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from [Enrollment] where eid = '" + txtEid.Text+"'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    displayData();
                    timeOut();
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Input ID to perform this action");              
            }
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEid.Text != "")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM [Enrollment] where eid = '" + tempName + "' ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(dt);

                    txtEid.Text = dt.Rows[0]["eid"].ToString();
                    txtNname.Text = dt.Rows[0]["name"].ToString();
                    txtUsername.Text = dt.Rows[0]["user_name"].ToString();
                    txtClassname.Text = dt.Rows[0]["class_name"].ToString();
                    txtGender.Text = dt.Rows[0]["gender"].ToString();
                    txtAge.Text = dt.Rows[0]["age"].ToString();
                    txtNumber.Text = dt.Rows[0]["contact_number"].ToString();
                    txtHeight.Text = dt.Rows[0]["height"].ToString();
                    txtWeight.Text = dt.Rows[0]["weight"].ToString();

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

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update [Enrollment] set name='"+txtNname.Text+"', user_name='"+txtUsername.Text+"', class_name='"+txtClassname.Text+"', weight='"+float.Parse(txtWeight.Text)+"', height='"+float.Parse(txtHeight.Text)+"', contact_number ='"+long.Parse(txtNumber.Text)+"', age='"+int.Parse(txtAge.Text)+"', gender='"+txtGender.Text+"' where eid ='"+tempName+"'";
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

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [Enrollment] (name, user_name, class_name, weight, height, contact_number, age, gender) values ('"+txtNname.Text+"','"+txtUsername.Text+"', '"+txtClassname.Text+"', '"+int.Parse(txtWeight.Text)+"', '"+int.Parse(txtHeight.Text)+"', '"+long.Parse(txtNumber.Text)+"', '"+int.Parse(txtAge.Text)+"', '"+txtGender.Text+"')";
                cmd.ExecuteNonQuery();
                con.Close();
                timeOut();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
