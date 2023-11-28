namespace FinalProject_QUANLYKHO.View.CustomerView
{
    partial class ModalAddCustomer
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(28, 38, 45);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
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
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(65, 201);
            label4.Name = "label4";
            label4.Size = new Size(175, 16);
            label4.TabIndex = 23;
            label4.Text = "Số điện thoại khách hàng";
            // 
            // inputPhoneNumber
            // 
            inputPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputPhoneNumber.BackColor = Color.FromArgb(39, 52, 62);
            inputPhoneNumber.BorderColor = Color.LightSlateGray;
            inputPhoneNumber.BorderFocusColor = Color.Gray;
            inputPhoneNumber.BorderRadius = 6;
            inputPhoneNumber.BorderSize = 1;
            inputPhoneNumber.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            inputPhoneNumber.ForeColor = Color.White;
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
            btnSubmit.BackColor = Color.FromArgb(77, 147, 213);
            btnSubmit.BackgroundColor = Color.FromArgb(77, 147, 213);
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
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(65, 139);
            label3.Name = "label3";
            label3.Size = new Size(132, 16);
            label3.TabIndex = 21;
            label3.Text = "Địa chỉ khách hàng";
            // 
            // inputAddress
            // 
            inputAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputAddress.BackColor = Color.FromArgb(39, 52, 62);
            inputAddress.BorderColor = Color.LightSlateGray;
            inputAddress.BorderFocusColor = Color.Gray;
            inputAddress.BorderRadius = 6;
            inputAddress.BorderSize = 1;
            inputAddress.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            inputAddress.ForeColor = Color.White;
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
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(65, 74);
            label2.Name = "label2";
            label2.Size = new Size(113, 16);
            label2.TabIndex = 19;
            label2.Text = "Tên khách hàng";
            // 
            // inputName
            // 
            inputName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputName.BackColor = Color.FromArgb(39, 52, 62);
            inputName.BorderColor = Color.LightSlateGray;
            inputName.BorderFocusColor = Color.Gray;
            inputName.BorderRadius = 6;
            inputName.BorderSize = 1;
            inputName.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            inputName.ForeColor = Color.White;
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
            label1.ForeColor = Color.White;
            label1.Location = new Point(65, 19);
            label1.Name = "label1";
            label1.Size = new Size(250, 23);
            label1.TabIndex = 17;
            label1.Text = "Thêm khách hàng mới";
            // 
            // ModalAddMaterial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 246, 249);
            ClientSize = new Size(793, 383);
            Controls.Add(panel1);
            HelpButton = true;
            Name = "ModalAddMaterial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModalAddCustomer";
            TopMost = true;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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