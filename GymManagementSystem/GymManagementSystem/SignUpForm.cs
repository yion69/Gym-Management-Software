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
    public partial class SignUpForm : Form
    {
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonButton btnSignup;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox txtAge;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonComboBox comboGender;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonCheckBox checkBoxTandS;
        private Krypton.Toolkit.KryptonTextBox txtPassword;
        private Krypton.Toolkit.KryptonTextBox txtNumber;
        private Krypton.Toolkit.KryptonTextBox txtEmail;
        private Krypton.Toolkit.KryptonTextBox txtUsername;
        private Krypton.Toolkit.KryptonTextBox txtName;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;

        public mainForm parentForm;
        private DateTimePicker dtpDob;
        public LoginForm loginForm;
        public SignUpForm(mainForm Parent, LoginForm Login)
        {
            InitializeComponent();
            parentForm = Parent;

            loginForm = Login;
            loginForm.TopLevel = false;
            loginForm.TopMost = true;
        }

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.txtPassword = new Krypton.Toolkit.KryptonTextBox();
            this.txtNumber = new Krypton.Toolkit.KryptonTextBox();
            this.txtEmail = new Krypton.Toolkit.KryptonTextBox();
            this.txtUsername = new Krypton.Toolkit.KryptonTextBox();
            this.txtName = new Krypton.Toolkit.KryptonTextBox();
            this.checkBoxTandS = new Krypton.Toolkit.KryptonCheckBox();
            this.comboGender = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.btnSignup = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.txtAge = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboGender)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.dtpDob);
            this.kryptonPanel1.Controls.Add(this.txtPassword);
            this.kryptonPanel1.Controls.Add(this.txtNumber);
            this.kryptonPanel1.Controls.Add(this.txtEmail);
            this.kryptonPanel1.Controls.Add(this.txtUsername);
            this.kryptonPanel1.Controls.Add(this.txtName);
            this.kryptonPanel1.Controls.Add(this.checkBoxTandS);
            this.kryptonPanel1.Controls.Add(this.comboGender);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel9);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel8);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel1.Controls.Add(this.btnSignup);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.txtAge);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Location = new System.Drawing.Point(15, 48);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(814, 508);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.kryptonPanel1.TabIndex = 1;
            this.kryptonPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonPanel1_Paint);
            // 
            // dtpDob
            // 
            this.dtpDob.CalendarFont = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDob.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpDob.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpDob.CustomFormat = "dd-MM-yyyy";
            this.dtpDob.Font = new System.Drawing.Font("Bell Centennial Std Address", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDob.Location = new System.Drawing.Point(89, 362);
            this.dtpDob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(306, 31);
            this.dtpDob.TabIndex = 33;
            this.dtpDob.Value = new System.DateTime(2024, 3, 31, 0, 0, 0, 0);
            this.dtpDob.ValueChanged += new System.EventHandler(this.dtpDob_ValueChanged_1);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(439, 195);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(308, 34);
            this.txtPassword.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtPassword.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtPassword.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.txtPassword.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtPassword.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txtPassword.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Semilight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, -1, -1);
            this.txtPassword.TabIndex = 32;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(439, 361);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(308, 34);
            this.txtNumber.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtNumber.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtNumber.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.txtNumber.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtNumber.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txtNumber.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Semilight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, -1, -1);
            this.txtNumber.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtNumber.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtNumber.TabIndex = 31;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(439, 275);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(308, 34);
            this.txtEmail.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtEmail.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtEmail.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.txtEmail.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtEmail.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txtEmail.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Semilight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, -1, -1);
            this.txtEmail.TabIndex = 30;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(439, 114);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(308, 34);
            this.txtUsername.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtUsername.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtUsername.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.txtUsername.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtUsername.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txtUsername.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Semilight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, -1, -1);
            this.txtUsername.TabIndex = 29;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(89, 114);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(308, 34);
            this.txtName.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtName.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtName.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.txtName.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtName.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txtName.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Semilight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, -1, -1);
            this.txtName.TabIndex = 28;
            // 
            // checkBoxTandS
            // 
            this.checkBoxTandS.Location = new System.Drawing.Point(309, 479);
            this.checkBoxTandS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxTandS.Name = "checkBoxTandS";
            this.checkBoxTandS.Size = new System.Drawing.Size(200, 26);
            this.checkBoxTandS.StateCommon.Padding = new System.Windows.Forms.Padding(-1, -1, -1, -3);
            this.checkBoxTandS.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.checkBoxTandS.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.checkBoxTandS.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTandS.TabIndex = 26;
            this.checkBoxTandS.Values.Text = "Terms and Condition";
            this.checkBoxTandS.CheckedChanged += new System.EventHandler(this.checkBoxTandS_CheckedChanged);
            // 
            // comboGender
            // 
            this.comboGender.DropDownWidth = 246;
            this.comboGender.InputControlStyle = Krypton.Toolkit.InputControlStyle.PanelAlternate;
            this.comboGender.IntegralHeight = false;
            this.comboGender.Items.AddRange(new object[] {
            "Male ",
            "Female",
            "Others"});
            this.comboGender.Location = new System.Drawing.Point(89, 275);
            this.comboGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(308, 34);
            this.comboGender.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboGender.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Transparent;
            this.comboGender.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboGender.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.White;
            this.comboGender.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI Semilight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGender.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.comboGender.StateCommon.DropBack.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboGender.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.comboGender.StateNormal.ComboBox.Border.Color1 = System.Drawing.Color.Transparent;
            this.comboGender.StateNormal.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboGender.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.comboGender.StateTracking.Item.Border.Color1 = System.Drawing.Color.Transparent;
            this.comboGender.StateTracking.Item.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboGender.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.comboGender.TabIndex = 24;
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(438, 320);
            this.kryptonLabel9.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(199, 39);
            this.kryptonLabel9.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.kryptonLabel9.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.kryptonLabel9.TabIndex = 23;
            this.kryptonLabel9.Values.Text = "Contact Number";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(439, 232);
            this.kryptonLabel8.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(74, 39);
            this.kryptonLabel8.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.kryptonLabel8.TabIndex = 21;
            this.kryptonLabel8.Values.Text = "Email";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(438, 155);
            this.kryptonLabel7.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(119, 39);
            this.kryptonLabel7.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.kryptonLabel7.TabIndex = 19;
            this.kryptonLabel7.Values.Text = "Password";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(439, 71);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(126, 39);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 17;
            this.kryptonLabel4.Values.Text = "Username";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(89, 320);
            this.kryptonLabel6.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(155, 39);
            this.kryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.kryptonLabel6.TabIndex = 15;
            this.kryptonLabel6.Values.Text = "Date of Birth";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(89, 232);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(96, 39);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.kryptonLabel5.TabIndex = 13;
            this.kryptonLabel5.Values.Text = "Gender";
            // 
            // btnSignup
            // 
            this.btnSignup.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            this.btnSignup.Location = new System.Drawing.Point(251, 431);
            this.btnSignup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSignup.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSignup.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSignup.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSignup.Size = new System.Drawing.Size(308, 45);
            this.btnSignup.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSignup.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSignup.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnSignup.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSignup.StateCommon.Border.Rounding = 10F;
            this.btnSignup.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.btnSignup.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSignup.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSignup.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnSignup.StatePressed.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnSignup.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSignup.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(115)))), ((int)(((byte)(119)))));
            this.btnSignup.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(115)))), ((int)(((byte)(119)))));
            this.btnSignup.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnSignup.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnSignup.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSignup.StateTracking.Border.Rounding = 10F;
            this.btnSignup.StateTracking.Border.Width = 1;
            this.btnSignup.TabIndex = 10;
            this.btnSignup.Values.Text = "SIGN UP";
            this.btnSignup.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(89, 149);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(59, 39);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.kryptonLabel1.TabIndex = 7;
            this.kryptonLabel1.Values.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(89, 195);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(308, 34);
            this.txtAge.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtAge.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtAge.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.txtAge.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtAge.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txtAge.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Semilight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, -1, -1);
            this.txtAge.TabIndex = 6;
            this.txtAge.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(89, 71);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(81, 39);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 5;
            this.kryptonLabel2.Values.Text = "Name";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(84, 11);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(357, 61);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 4;
            this.kryptonLabel3.Values.Text = "CREATE ACCOUNT";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(855, 570);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SignUpForm";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboGender)).EndInit();
            this.ResumeLayout(false);

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            btnSignup.Enabled = false;
            dtpDob.Format = DateTimePickerFormat.Custom;
            dtpDob.CustomFormat = "dd/MM/yyyy";
        }

        private void dtpDob_ValueChanged(object sender, EventArgs e)
        {

        }
   
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Documents\GymMemberSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if( string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtAge.Text) ||
                string.IsNullOrEmpty(comboGender.Text) ||
                string.IsNullOrEmpty(dtpDob.Text) ||
                string.IsNullOrEmpty(txtUsername.Text) ||
                string.IsNullOrEmpty(txtPassword.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtNumber.Text)
                )
            {
                MessageBox.Show("Please input necessary information to continue");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    //cmd.CommandText = "insert into User (name, age, gender, date_of_birth, username, password, email, contact_number, user_type, user_image) values ('" + txtName.Text + "', '" + int.Parse(txtAge.Text) + "', '" + comboGender.Text + "', '" + dtpDob.Value + "', '" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + txtEmail.Text + "', '" + long.Parse(txtNumber.Text) + "','Member', NULL)";
                    cmd.CommandText = "insert into [User] (name,age,gender,date_of_birth,username,password,email,contact_number,user_type) values ('"+txtName.Text+"','"+int.Parse(txtAge.Text)+"', '"+comboGender.Text+"', '"+dtpDob.Value+"', '"+txtUsername.Text+"', '"+txtPassword.Text+"', '"+txtEmail.Text+"', '"+long.Parse(txtNumber.Text)+"','Member')";
                    //cmd.Parameters.AddWithValue("@Value", null);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Inserted Successfully");
                    this.Hide();
                    loginForm.FormBorderStyle = FormBorderStyle.None;
                    parentForm.contentPanel.Controls.Add(loginForm);
                    loginForm.Show();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void kryptonDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBoxTandS_CheckedChanged(object sender, EventArgs e)
        {
            bool checkTemp = checkBoxTandS.Checked;
            btnSignup.Enabled = checkTemp;
        }

        private void checkBoxSP_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void dtpDob_ValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
