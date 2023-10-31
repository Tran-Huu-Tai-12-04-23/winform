namespace FinalProject_QUANLYKHO.View.CustomerView
{
    partial class ModalEditCustomer
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
            buttonCustom2 = new ComponentCustom.ButtonCustom();
            panel1 = new Panel();
            panel2 = new Panel();
            label4 = new Label();
            inputPhoneNumber = new CustomControls.RJControls.RJTextBox();
            btnSubmit = new ComponentCustom.ButtonCustom();
            label3 = new Label();
            inputAddress = new CustomControls.RJControls.RJTextBox();
            label2 = new Label();
            inputName = new CustomControls.RJControls.RJTextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCustom2
            // 
            buttonCustom2.BackColor = Color.Transparent;
            buttonCustom2.BackgroundColor = Color.Transparent;
            buttonCustom2.BorderColor = Color.Transparent;
            buttonCustom2.BorderRadius = 0;
            buttonCustom2.BorderSize = 0;
            buttonCustom2.FlatAppearance.BorderSize = 0;
            buttonCustom2.FlatStyle = FlatStyle.Flat;
            buttonCustom2.ForeColor = Color.White;
            buttonCustom2.Image = Properties.Resources.icons8_close_24;
            buttonCustom2.Location = new Point(745, 1);
            buttonCustom2.Margin = new Padding(0);
            buttonCustom2.Name = "buttonCustom2";
            buttonCustom2.Size = new Size(45, 32);
            buttonCustom2.TabIndex = 1;
            buttonCustom2.TextColor = Color.White;
            buttonCustom2.UseVisualStyleBackColor = false;
            buttonCustom2.Click += buttonCustom2_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(buttonCustom2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(792, 383);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(inputPhoneNumber);
            panel2.Controls.Add(btnSubmit);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(inputAddress);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(inputName);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(23, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(741, 299);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(241, 246, 249);
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(65, 201);
            label4.Name = "label4";
            label4.Size = new Size(216, 18);
            label4.TabIndex = 23;
            label4.Text = "Số điện thoại khách hàng";
            // 
            // inputPhoneNumber
            // 
            inputPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputPhoneNumber.BackColor = SystemColors.Window;
            inputPhoneNumber.BorderColor = Color.LightSkyBlue;
            inputPhoneNumber.BorderFocusColor = Color.CornflowerBlue;
            inputPhoneNumber.BorderRadius = 0;
            inputPhoneNumber.BorderSize = 2;
            inputPhoneNumber.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            inputPhoneNumber.ForeColor = Color.FromArgb(64, 64, 64);
            inputPhoneNumber.Location = new Point(65, 223);
            inputPhoneNumber.Margin = new Padding(4);
            inputPhoneNumber.Multiline = false;
            inputPhoneNumber.Name = "inputPhoneNumber";
            inputPhoneNumber.Padding = new Padding(10, 7, 10, 7);
            inputPhoneNumber.PasswordChar = false;
            inputPhoneNumber.PlaceholderColor = Color.DarkGray;
            inputPhoneNumber.PlaceholderText = "";
            inputPhoneNumber.Size = new Size(602, 31);
            inputPhoneNumber.TabIndex = 22;
            inputPhoneNumber.Texts = "";
            inputPhoneNumber.UnderlinedStyle = false;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Bottom;
            btnSubmit.BackColor = Color.LightSkyBlue;
            btnSubmit.BackgroundColor = Color.LightSkyBlue;
            btnSubmit.BorderColor = Color.PaleVioletRed;
            btnSubmit.BorderRadius = 6;
            btnSubmit.BorderSize = 0;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(310, 262);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 30);
            btnSubmit.TabIndex = 24;
            btnSubmit.Text = "Lưu lại";
            btnSubmit.TextColor = Color.White;
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(241, 246, 249);
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(65, 139);
            label3.Name = "label3";
            label3.Size = new Size(163, 18);
            label3.TabIndex = 21;
            label3.Text = "Địa chỉ khách hàng";
            // 
            // inputAddress
            // 
            inputAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputAddress.BackColor = SystemColors.Window;
            inputAddress.BorderColor = Color.LightSkyBlue;
            inputAddress.BorderFocusColor = Color.CornflowerBlue;
            inputAddress.BorderRadius = 0;
            inputAddress.BorderSize = 2;
            inputAddress.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            inputAddress.ForeColor = Color.FromArgb(64, 64, 64);
            inputAddress.Location = new Point(65, 161);
            inputAddress.Margin = new Padding(4);
            inputAddress.Multiline = false;
            inputAddress.Name = "inputAddress";
            inputAddress.Padding = new Padding(10, 7, 10, 7);
            inputAddress.PasswordChar = false;
            inputAddress.PlaceholderColor = Color.DarkGray;
            inputAddress.PlaceholderText = "";
            inputAddress.Size = new Size(602, 31);
            inputAddress.TabIndex = 20;
            inputAddress.Texts = "";
            inputAddress.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(241, 246, 249);
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(65, 74);
            label2.Name = "label2";
            label2.Size = new Size(137, 18);
            label2.TabIndex = 19;
            label2.Text = "Tên khách hàng";
            // 
            // inputName
            // 
            inputName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputName.BackColor = SystemColors.Window;
            inputName.BorderColor = Color.LightSkyBlue;
            inputName.BorderFocusColor = Color.CornflowerBlue;
            inputName.BorderRadius = 0;
            inputName.BorderSize = 2;
            inputName.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            inputName.ForeColor = Color.FromArgb(64, 64, 64);
            inputName.Location = new Point(65, 96);
            inputName.Margin = new Padding(4);
            inputName.Multiline = false;
            inputName.Name = "inputName";
            inputName.Padding = new Padding(10, 7, 10, 7);
            inputName.PasswordChar = false;
            inputName.PlaceholderColor = Color.DarkGray;
            inputName.PlaceholderText = "";
            inputName.Size = new Size(602, 31);
            inputName.TabIndex = 18;
            inputName.Texts = "";
            inputName.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(65, 19);
            label1.Name = "label1";
            label1.Size = new Size(358, 23);
            label1.TabIndex = 17;
            label1.Text = "Chỉnh sửa thông tin khách hàng";
            // 
            // ModalEditCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 246, 249);
            ClientSize = new Size(793, 383);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ModalEditCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModalEditCustomer";
            TopMost = true;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComponentCustom.ButtonCustom buttonCustom2;
        private Panel panel1;
        private Panel panel2;
        private ComponentCustom.ButtonCustom btnSubmit;
        private Label label4;
        private CustomControls.RJControls.RJTextBox inputPhoneNumber;
        private Label label3;
        private CustomControls.RJControls.RJTextBox inputAddress;
        private Label label2;
        private CustomControls.RJControls.RJTextBox inputName;
        private Label label1;
    }
}