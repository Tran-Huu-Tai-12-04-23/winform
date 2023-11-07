namespace FinalProject_QUANLYKHO.View.Authentication
{
    partial class Login
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
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            btnLogin = new ComponentCustom.ButtonCustom();
            notificationPassword = new Label();
            label5 = new Label();
            inputPassword = new CustomControls.RJControls.RJTextBox();
            notificationUsername = new Label();
            label3 = new Label();
            inputUsername = new CustomControls.RJControls.RJTextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(241, 246, 249);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(notificationPassword);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(inputPassword);
            panel1.Controls.Add(notificationUsername);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(inputUsername);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(48, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(446, 506);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.MenuHighlight;
            label8.Location = new Point(187, 110);
            label8.Name = "label8";
            label8.Size = new Size(96, 13);
            label8.TabIndex = 11;
            label8.Text = "Đăng ký ngay";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.InfoText;
            label7.Location = new Point(37, 110);
            label7.Name = "label7";
            label7.Size = new Size(144, 13);
            label7.TabIndex = 10;
            label7.Text = "Bạn chưa có tài khoản? ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.MenuHighlight;
            label6.Location = new Point(323, 301);
            label6.Name = "label6";
            label6.Size = new Size(95, 13);
            label6.TabIndex = 9;
            label6.Text = "Quên mật khẩu";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightSkyBlue;
            btnLogin.BackgroundColor = Color.LightSkyBlue;
            btnLogin.BorderColor = Color.PaleVioletRed;
            btnLogin.BorderRadius = 6;
            btnLogin.BorderSize = 0;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(154, 360);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(144, 38);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Đăng nhập";
            btnLogin.TextColor = Color.White;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // notificationPassword
            // 
            notificationPassword.AutoSize = true;
            notificationPassword.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            notificationPassword.ForeColor = Color.Red;
            notificationPassword.Location = new Point(26, 301);
            notificationPassword.Name = "notificationPassword";
            notificationPassword.Size = new Size(64, 13);
            notificationPassword.TabIndex = 7;
            notificationPassword.Text = "thông báo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(26, 244);
            label5.Name = "label5";
            label5.Size = new Size(83, 18);
            label5.TabIndex = 6;
            label5.Text = "Mật khẩu";
            // 
            // inputPassword
            // 
            inputPassword.BackColor = SystemColors.Window;
            inputPassword.BorderColor = Color.LightSkyBlue;
            inputPassword.BorderFocusColor = Color.DodgerBlue;
            inputPassword.BorderRadius = 6;
            inputPassword.BorderSize = 2;
            inputPassword.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            inputPassword.ForeColor = Color.FromArgb(64, 64, 64);
            inputPassword.Location = new Point(26, 266);
            inputPassword.Margin = new Padding(4);
            inputPassword.Multiline = false;
            inputPassword.Name = "inputPassword";
            inputPassword.Padding = new Padding(10, 7, 10, 7);
            inputPassword.PasswordChar = true;
            inputPassword.PlaceholderColor = Color.DarkGray;
            inputPassword.PlaceholderText = "";
            inputPassword.Size = new Size(392, 31);
            inputPassword.TabIndex = 5;
            inputPassword.Texts = "";
            inputPassword.UnderlinedStyle = false;
            // 
            // notificationUsername
            // 
            notificationUsername.AutoSize = true;
            notificationUsername.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            notificationUsername.ForeColor = Color.Red;
            notificationUsername.Location = new Point(26, 210);
            notificationUsername.Name = "notificationUsername";
            notificationUsername.Size = new Size(64, 13);
            notificationUsername.TabIndex = 4;
            notificationUsername.Text = "thông báo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(26, 153);
            label3.Name = "label3";
            label3.Size = new Size(121, 18);
            label3.TabIndex = 3;
            label3.Text = "Tên tài khoản";
            // 
            // inputUsername
            // 
            inputUsername.BackColor = SystemColors.Window;
            inputUsername.BorderColor = Color.LightSkyBlue;
            inputUsername.BorderFocusColor = Color.DodgerBlue;
            inputUsername.BorderRadius = 6;
            inputUsername.BorderSize = 2;
            inputUsername.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            inputUsername.ForeColor = Color.FromArgb(64, 64, 64);
            inputUsername.Location = new Point(26, 175);
            inputUsername.Margin = new Padding(4);
            inputUsername.Multiline = false;
            inputUsername.Name = "inputUsername";
            inputUsername.Padding = new Padding(10, 7, 10, 7);
            inputUsername.PasswordChar = false;
            inputUsername.PlaceholderColor = Color.DarkGray;
            inputUsername.PlaceholderText = "";
            inputUsername.Size = new Size(392, 31);
            inputUsername.TabIndex = 2;
            inputUsername.Texts = "";
            inputUsername.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 68);
            label1.Name = "label1";
            label1.Size = new Size(176, 32);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.login__1_;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.ErrorImage = Properties.Resources.login__1_;
            pictureBox1.InitialImage = Properties.Resources.login__1_;
            pictureBox1.Location = new Point(538, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(435, 506);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.WaitOnLoad = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 548);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            MaximumSize = new Size(1016, 603);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Authentication";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private ComponentCustom.ButtonCustom btnLogin;
        private Label notificationPassword;
        private Label label5;
        private CustomControls.RJControls.RJTextBox inputPassword;
        private Label notificationUsername;
        private Label label3;
        private CustomControls.RJControls.RJTextBox inputUsername;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}