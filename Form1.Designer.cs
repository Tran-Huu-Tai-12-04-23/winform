namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            label2 = new Label();
            panel1 = new Panel();
            btnRegister = new Label();
            inputPassword = new TextBox();
            label1 = new Label();
            inputEmail = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(316, 279);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(167, 48);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 12);
            label2.Name = "label2";
            label2.Size = new Size(63, 30);
            label2.TabIndex = 2;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(inputPassword);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(inputEmail);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(95, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(615, 201);
            panel1.TabIndex = 3;
            // 
            // btnRegister
            // 
            btnRegister.AutoSize = true;
            btnRegister.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.DodgerBlue;
            btnRegister.Location = new Point(259, 165);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(334, 25);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "You don't have accounţ, Register now?";
            btnRegister.Click += label4_Click;
            // 
            // inputPassword
            // 
            inputPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            inputPassword.Location = new Point(16, 117);
            inputPassword.Name = "inputPassword";
            inputPassword.Size = new Size(580, 35);
            inputPassword.TabIndex = 5;
            inputPassword.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 84);
            label1.Name = "label1";
            label1.Size = new Size(99, 30);
            label1.TabIndex = 4;
            label1.Text = "Password";
            label1.Click += label1_Click;
            // 
            // inputEmail
            // 
            inputEmail.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            inputEmail.Location = new Point(13, 45);
            inputEmail.Name = "inputEmail";
            inputEmail.Size = new Size(580, 35);
            inputEmail.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(296, 24);
            label3.Name = "label3";
            label3.Size = new Size(187, 45);
            label3.TabIndex = 4;
            label3.Text = "Login form";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 346);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(btnLogin);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private TextBox inputPassword;
        private Label label1;
        private TextBox inputEmail;
        private Label btnRegister;
    }
}