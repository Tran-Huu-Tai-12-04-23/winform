namespace WinFormsApp1
{
    partial class Register
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
            label3 = new Label();
            panel1 = new Panel();
            inputPhone = new TextBox();
            label4 = new Label();
            inputUsername = new TextBox();
            label6 = new Label();
            inputConformPassword = new TextBox();
            label5 = new Label();
            btnLogin = new Label();
            inputPassword = new TextBox();
            label1 = new Label();
            inputEmail = new TextBox();
            label2 = new Label();
            btnRegister = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(336, 9);
            label3.Name = "label3";
            label3.Size = new Size(281, 54);
            label3.TabIndex = 7;
            label3.Text = "Register form";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(inputPhone);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(inputUsername);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(inputConformPassword);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(inputPassword);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(inputEmail);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(106, 67);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(703, 578);
            panel1.TabIndex = 6;
            // 
            // inputPhone
            // 
            inputPhone.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            inputPhone.Location = new Point(21, 179);
            inputPhone.Margin = new Padding(3, 4, 3, 4);
            inputPhone.Name = "inputPhone";
            inputPhone.Size = new Size(662, 42);
            inputPhone.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 138);
            label4.Name = "label4";
            label4.Size = new Size(191, 37);
            label4.TabIndex = 11;
            label4.Text = "Phone number";
            label4.Click += label4_Click_1;
            // 
            // inputUsername
            // 
            inputUsername.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            inputUsername.Location = new Point(21, 269);
            inputUsername.Margin = new Padding(3, 4, 3, 4);
            inputUsername.Name = "inputUsername";
            inputUsername.Size = new Size(662, 42);
            inputUsername.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(21, 225);
            label6.Name = "label6";
            label6.Size = new Size(136, 37);
            label6.TabIndex = 9;
            label6.Text = "Username";
            // 
            // inputConformPassword
            // 
            inputConformPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            inputConformPassword.Location = new Point(18, 452);
            inputConformPassword.Margin = new Padding(3, 4, 3, 4);
            inputConformPassword.Name = "inputConformPassword";
            inputConformPassword.Size = new Size(662, 42);
            inputConformPassword.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(18, 408);
            label5.Name = "label5";
            label5.Size = new Size(232, 37);
            label5.TabIndex = 7;
            label5.Text = "Confirm password";
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = true;
            btnLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.DodgerBlue;
            btnLogin.Location = new Point(174, 512);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(336, 32);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "You have account, Login now?";
            btnLogin.Click += label4_Click;
            // 
            // inputPassword
            // 
            inputPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            inputPassword.Location = new Point(21, 357);
            inputPassword.Margin = new Padding(3, 4, 3, 4);
            inputPassword.Name = "inputPassword";
            inputPassword.Size = new Size(662, 42);
            inputPassword.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 320);
            label1.Name = "label1";
            label1.Size = new Size(128, 37);
            label1.TabIndex = 4;
            label1.Text = "Password";
            // 
            // inputEmail
            // 
            inputEmail.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            inputEmail.Location = new Point(18, 77);
            inputEmail.Margin = new Padding(3, 4, 3, 4);
            inputEmail.Name = "inputEmail";
            inputEmail.Size = new Size(662, 42);
            inputEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 36);
            label2.Name = "label2";
            label2.Size = new Size(82, 37);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Location = new Point(373, 653);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(191, 64);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 733);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(btnRegister);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Register";
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Panel panel1;
        private Label btnLogin;
        private TextBox inputPassword;
        private Label label1;
        private TextBox inputEmail;
        private Label label2;
        private Button btnRegister;
        private TextBox inputConformPassword;
        private Label label5;
        private TextBox inputUsername;
        private Label label6;
        private TextBox textBox1;
        private Label label4;
        private TextBox inputFormNumber;
        private TextBox inputPhone;
    }
}