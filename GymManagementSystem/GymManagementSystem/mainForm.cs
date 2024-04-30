using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem
{

    public partial class mainForm : Form
    {
        public string LoggedInUser; //this is used to stroe logged in user's username
        public string LoggedInAdmin; // this is used to store the username of admin
        public string className;

        private void LoginForm_LoginSuccess(object sender, EventArgs e, string username)
        {
            LoginForm loginForm = (LoginForm)sender;
            loginForm.Close();
            LoggedInUser = username;
            OpenHomePageForm();
        }
        private void AdminLogin_AdminLoginSuccess(object sender, EventArgs e, string username)
        {
            AdminLogin adminLogin = (AdminLogin)sender;
            adminLogin.Close();
            LoggedInAdmin = username;
            OpenAdminHomePage();
        }
        private void ClassForm_OpenEnrollment(object sender, EventArgs e)
        {
            Classes enrollForm = (Classes)sender;
            openEnrollmentForm();
        }
        private void OpenLoginForm()
        {
            LoginForm login = new LoginForm(this) { TopLevel = false, TopMost = true };
            login.LoginSuccess += LoginForm_LoginSuccess;

            login.FormBorderStyle = FormBorderStyle.None;
            contentPanel.Controls.Add(login);
            login.Show();
        }
        
        private void OpenContact()
        {
            Contact contactForm = new Contact() { TopLevel = false, TopMost = true };
            contactForm.FormBorderStyle = FormBorderStyle.None;
            contentPanel.Controls.Add(contactForm);
            contactForm.Show();
        }
        private void OpenAdminLoginForm()
        {
            AdminLogin Adminlogin = new AdminLogin(this) { TopLevel = false, TopMost = true };
            Adminlogin.AdminLoginSuccess += AdminLogin_AdminLoginSuccess;
            Adminlogin.FormBorderStyle = FormBorderStyle.None;
            contentPanel.Controls.Add(Adminlogin);
            Adminlogin.Show();
        }
        private void OpenAdminHomePage()
        {
            AdminHomePage aHomePage = new AdminHomePage(this) { TopLevel = false, TopMost = true };
            aHomePage.FormBorderStyle = FormBorderStyle.None;
            contentPanel.Controls.Add(aHomePage);
            aHomePage.Show();
        }
        private void OpenAdminEnrollment()
        {
            AdminEnrollmentControl adminEnroll = new AdminEnrollmentControl() { TopLevel = false, TopMost = true };
            adminEnroll.FormBorderStyle = FormBorderStyle.None;
            contentPanel.Controls.Add(adminEnroll);
            adminEnroll.Show();
        }
        private void OpenAdminClasses()
        {
            AdminClassesControl adminClass = new AdminClassesControl() { TopLevel = false, TopMost = true };
            adminClass.FormBorderStyle = FormBorderStyle.None;
            contentPanel.Controls.Add(adminClass);
            adminClass.Show();
        }
        private void OpenAdminTrainer()
        {
            AdminTrainerControl adminTrainer = new AdminTrainerControl(this) { TopLevel = false, TopMost = true };
            adminTrainer.FormBorderStyle = FormBorderStyle.None;
            contentPanel.Controls.Add(adminTrainer);
            adminTrainer.Show();
        }
        private void OpenHomePageForm()
        {
            HomePage Home = new HomePage(this) { TopLevel = false, TopMost = true };
            Home.FormBorderStyle = FormBorderStyle.None;
            contentPanel.Controls.Add(Home);
            Home.Show();
        }
        private void OpenClassesForm()
        {
            Classes Class = new Classes(this) { TopLevel = false, TopMost = true };
            Class.classFormOpen += ClassForm_OpenEnrollment;
            Class.FormBorderStyle = FormBorderStyle.None;
            contentPanel.Controls.Add(Class);
            Class.Show();
        }
        private void OpenProfile()
        {
            HomePage Home = new HomePage(this) { TopLevel = false, TopMost = true };
            Profile profile = new Profile(this, Home) { TopLevel = false, TopMost = true };
            profile.FormBorderStyle = FormBorderStyle.None;
            contentPanel.Controls.Add(profile);
            profile.Show();
        }
        private void openTrainerForm()
        {
            Trainer TrainerForm = new Trainer() { TopLevel = false, TopMost = true };
            TrainerForm.FormBorderStyle = FormBorderStyle.None;
            contentPanel.Controls.Add(TrainerForm);
            TrainerForm.Show();
        }
        private void openEnrollmentForm()
        {
            Enrollment EnrollForm = new Enrollment(this) { TopLevel = false, TopMost = true };
            EnrollForm.FormBorderStyle = FormBorderStyle.None;
            contentPanel.Controls.Add(EnrollForm);
            EnrollForm.Show();
        }
        public void CloseForm()
        {
            contentPanel.Controls.Clear();
        }

        
        public mainForm()
        {
            InitializeComponent();
            MouseDown += kryptonPanel2_MouseDown;
            MouseMove += kryptonPanel2_MouseMove;
            MouseUp += kryptonPanel2_MouseUp;
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void kryptonPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            OpenLoginForm();       
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            if(LoggedInUser == null && LoggedInAdmin == null)
            {
                CloseForm();
                OpenLoginForm(); 
            }
            else if(LoggedInUser != null && LoggedInAdmin == null)
            {
                CloseForm();
                OpenHomePageForm();
            }
            else if(LoggedInUser == null && LoggedInAdmin != null)
            {
                CloseForm();
                OpenAdminHomePage();
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void kryptonPictureBox2_Click_1(object sender, EventArgs e)
        {
            if (LoggedInUser == null)
            {
                CloseForm();
                OpenAdminLoginForm(); 
            }
            else
            {
                MessageBox.Show("Login Using Admin Credentials");
            }
        }

        private void kryptonPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        //Form dragging 
        private bool isDragging;
        private Point lastLocation;
        private void kryptonPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastLocation = e.Location;
        }

        private void kryptonPanel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X,
                    (Location.Y - lastLocation.Y) + e.Y);
                Update();
            }
        }

        private void kryptonPanel2_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void kryptonPictureBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void kryptonPictureBox2_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
             if(LoggedInUser == null && LoggedInAdmin == null)
            {
                CloseForm();
                OpenClassesForm();
            }
            else if(LoggedInUser != null && LoggedInAdmin == null)
            {
                CloseForm();
                OpenClassesForm();    
            }
            else if(LoggedInUser == null && LoggedInAdmin != null)
            {
                CloseForm();
                OpenAdminClasses();
            }
            else
            {
                MessageBox.Show("ERR");
            }
        }

        private void btnTrainer_Click(object sender, EventArgs e)
        {   
            if(LoggedInUser == null && LoggedInAdmin == null)
            {
                CloseForm();
                openTrainerForm();    
            }
            else if(LoggedInUser != null && LoggedInAdmin == null)
            {
                CloseForm();
                openTrainerForm();
            }
            else if(LoggedInUser == null && LoggedInAdmin != null)
            {
                CloseForm();
                OpenAdminTrainer();
            }
            else
            {
                MessageBox.Show("ERR");
            }
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            if(LoggedInUser == null && LoggedInAdmin == null)
            {
                MessageBox.Show("Please log in or sign up to use this feature");
            }
            else if(LoggedInUser != null && LoggedInAdmin == null)
            {
                CloseForm();
                openEnrollmentForm();
            }
            else if(LoggedInUser == null && LoggedInAdmin != null)
            {
                CloseForm();
                OpenAdminEnrollment();
            }
            else
            {
                MessageBox.Show("ERR");
            }
        }

        private void picboxContact_Click(object sender, EventArgs e)
        {
            CloseForm();
            OpenContact();
        }
    }
}
