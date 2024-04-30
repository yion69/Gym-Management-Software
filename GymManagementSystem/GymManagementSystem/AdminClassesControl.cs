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
    public partial class AdminClassesControl : Form
    {
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Documents\GymMemberSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        private mainForm parentform;

        public AdminClassesControl()
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
                cmd.CommandText = "select cid as ClassID, class_name as Name, category as Category, duration as Duration, fees as Fees, start_date as StartDate, end_date as EndDate FROM [Class]";
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
        private void kryptonLabel10_Click(object sender, EventArgs e)
        {

        }

        private void AdminClassesControl_Load(object sender, EventArgs e)
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
                cmd.CommandText = "SELECT c.*, t.tid, t.name FROM Class c, Trainer t where c.cid='" + tempName + "' AND t.tid = c.tid ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);

                txtID.Text = dt.Rows[0]["cid"].ToString();
                txtName.Text = dt.Rows[0]["class_name"].ToString();
                txtCategory.Text = dt.Rows[0]["category"].ToString();
                txtFees.Text = dt.Rows[0]["fees"].ToString();
                txtDuration.Text = dt.Rows[0]["duration"].ToString();

                DateTime startDate = (DateTime)dt.Rows[0]["start_date"];
                txtStartDate.Text = startDate.ToString("MM-dd-yyyy");
                DateTime endDate = (DateTime)dt.Rows[0]["end_date"];
                txtEndDate.Text = endDate.ToString("MM-dd-yyyy");
                txtDescription.Text = dt.Rows[0]["description"].ToString();

                txtTID.Text = dt.Rows[0]["tid"].ToString();
                txtTName.Text = dt.Rows[0]["name"].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            timer();
            try
            {
                if (txtID.Text != "" )
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT c.*, t.tid, t.name FROM Class c, Trainer t where c.cid='" + txtID.Text + "' AND t.tid = c.tid "; 
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(dt);

                    txtID.Text = dt.Rows[0]["cid"].ToString();
                    txtName.Text = dt.Rows[0]["class_name"].ToString();
                    txtCategory.Text = dt.Rows[0]["category"].ToString();
                    txtFees.Text = dt.Rows[0]["fees"].ToString();
                    txtDuration.Text = dt.Rows[0]["duration"].ToString();

                    DateTime startDate = (DateTime)dt.Rows[0]["start_date"];
                    txtStartDate.Text = startDate.ToString("MM-dd-yyyy");
                    DateTime endDate = (DateTime)dt.Rows[0]["end_date"];
                    txtEndDate.Text = endDate.ToString("MM-dd-yyyy");
                    txtDescription.Text = dt.Rows[0]["description"].ToString();

                    txtTID.Text = dt.Rows[0]["tid"].ToString();
                    txtTName.Text = dt.Rows[0]["name"].ToString();
                    con.Close();
                    timer();
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
                cmd.CommandText = "delete from [Class] where cid = '" + txtID.Text+"'";
                cmd.ExecuteNonQuery();
                con.Close();
                displayData();
                timer();
            } catch(Exception ex)
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
                    cmd.CommandText = "insert into [Class] (cid, class_name, category, duration, fees, start_date, end_date, description, tid) values ('"+txtID.Text+"', '"+txtName.Text+"', '"+txtCategory.Text+"', '"+int.Parse(txtDuration.Text)+"', '"+int.Parse(txtFees.Text)+"', '"+txtStartDate.Text+"', '"+txtEndDate.Text+"', '"+txtDescription.Text+"', '"+txtTID.Text+"')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    displayData();
                    timer();
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
                cmd.CommandText = "update [Class] set cid ='"+txtID.Text+"', class_name='"+txtName.Text+"', category='"+txtCategory.Text+"', duration='"+int.Parse(txtDuration.Text)+"', fees='"+int.Parse(txtFees.Text)+"', start_date='"+txtStartDate.Text+"', end_date = '"+txtEndDate.Text+"', description='"+txtDescription.Text+"', tid ='"+txtTID.Text+"' where cid ='"+tempName+"'";
                cmd.ExecuteNonQuery();
                con.Close();
                displayData();
                timer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
