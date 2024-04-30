
namespace GymManagementSystem
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.pictureBox = new Krypton.Toolkit.KryptonPictureBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.btnLogin = new Krypton.Toolkit.KryptonButton();
            this.linkSignUp = new Krypton.Toolkit.KryptonLinkLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.txtPassword = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.txtUsername = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.pictureBox);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Controls.Add(this.btnLogin);
            this.kryptonPanel1.Controls.Add(this.linkSignUp);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.txtPassword);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.txtUsername);
            this.kryptonPanel1.Controls.Add(this.kryptonPictureBox1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Location = new System.Drawing.Point(186, 60);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(292, 387);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.kryptonPanel1.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox.Image = global::GymManagementSystem.Properties.Resources.eye_regular;
            this.pictureBox.Location = new System.Drawing.Point(241, 253);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(25, 20);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 12;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.kryptonPictureBox2_Click);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(49, 333);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(137, 22);
            this.kryptonLabel4.StateCommon.Padding = new System.Windows.Forms.Padding(-1, -1, -4, -1);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 11;
            this.kryptonLabel4.Values.Text = "Don\'t have a Account?";
            // 
            // btnLogin
            // 
            this.btnLogin.ButtonStyle = Krypton.Toolkit.ButtonStyle.Cluster;
            this.btnLogin.Location = new System.Drawing.Point(22, 292);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLogin.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLogin.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLogin.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLogin.Size = new System.Drawing.Size(246, 36);
            this.btnLogin.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLogin.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLogin.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnLogin.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogin.StateCommon.Border.Rounding = 10F;
            this.btnLogin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.btnLogin.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLogin.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLogin.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnLogin.StatePressed.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnLogin.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogin.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(115)))), ((int)(((byte)(119)))));
            this.btnLogin.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(115)))), ((int)(((byte)(119)))));
            this.btnLogin.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnLogin.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnLogin.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogin.StateTracking.Border.Rounding = 10F;
            this.btnLogin.StateTracking.Border.Width = 1;
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Values.Text = "LOGIN";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // linkSignUp
            // 
            this.linkSignUp.LabelStyle = Krypton.Toolkit.LabelStyle.Custom1;
            this.linkSignUp.LinkBehavior = Krypton.Toolkit.KryptonLinkBehavior.NeverUnderline;
            this.linkSignUp.Location = new System.Drawing.Point(181, 333);
            this.linkSignUp.Name = "linkSignUp";
            this.linkSignUp.Size = new System.Drawing.Size(57, 22);
            this.linkSignUp.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.linkSignUp.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.linkSignUp.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSignUp.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.linkSignUp.StateNormal.ShortText.Color2 = System.Drawing.Color.White;
            this.linkSignUp.TabIndex = 9;
            this.linkSignUp.Values.Text = "Sign Up";
            this.linkSignUp.LinkClicked += new System.EventHandler(this.linkSignUp_LinkClicked);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(22, 211);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(99, 29);
            this.kryptonLabel1.StateCommon.Padding = new System.Windows.Forms.Padding(-1, -1, -1, -3);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 7;
            this.kryptonLabel1.Values.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(22, 245);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(246, 31);
            this.txtPassword.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtPassword.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(115)))), ((int)(((byte)(119)))));
            this.txtPassword.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(115)))), ((int)(((byte)(119)))));
            this.txtPassword.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtPassword.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txtPassword.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, -1, -1);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(22, 141);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(105, 29);
            this.kryptonLabel2.StateCommon.Padding = new System.Windows.Forms.Padding(-1, -1, -1, -3);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 5;
            this.kryptonLabel2.Values.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(22, 175);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(246, 31);
            this.txtUsername.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtUsername.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(115)))), ((int)(((byte)(119)))));
            this.txtUsername.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(115)))), ((int)(((byte)(119)))));
            this.txtUsername.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtUsername.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txtUsername.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, -1, -1);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // kryptonPictureBox1
            // 
            this.kryptonPictureBox1.Image = global::GymManagementSystem.Properties.Resources.dumbbell_solid;
            this.kryptonPictureBox1.Location = new System.Drawing.Point(116, 17);
            this.kryptonPictureBox1.Name = "kryptonPictureBox1";
            this.kryptonPictureBox1.Size = new System.Drawing.Size(70, 50);
            this.kryptonPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kryptonPictureBox1.TabIndex = 1;
            this.kryptonPictureBox1.TabStop = false;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(80, 72);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(147, 49);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 4;
            this.kryptonLabel3.Values.Text = "Welcome";
            this.kryptonLabel3.Click += new System.EventHandler(this.kryptonLabel3_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(700, 495);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox txtPassword;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox txtUsername;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonButton btnLogin;
        public Krypton.Toolkit.KryptonLinkLabel linkSignUp;
        private Krypton.Toolkit.KryptonPictureBox pictureBox;
    }
}