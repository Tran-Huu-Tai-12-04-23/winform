using FinalProject_QUANLYKHO.Contanst;
namespace FinalProject_QUANLYKHO.View.BakeView
{
    partial class AddBakeForm
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
            buttonCustom2 = new ComponentCustom.ButtonCustom();
            panel2 = new Panel();
            btnSubmit = new ComponentCustom.ButtonCustom();
            inputId = new CustomControls.RJControls.RJTextBox();
            label6 = new Label();
            inputDonVi = new CustomControls.RJControls.RJTextBox();
            label5 = new Label();
            inputGiaTien = new CustomControls.RJControls.RJTextBox();
            label4 = new Label();
            inputSoLuong = new CustomControls.RJControls.RJTextBox();
            label3 = new Label();
            inputName = new CustomControls.RJControls.RJTextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(buttonCustom2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(905, 600);
            panel1.TabIndex = 0;
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
            buttonCustom2.Location = new Point(851, 1);
            buttonCustom2.Margin = new Padding(0);
            buttonCustom2.Name = "buttonCustom2";
            buttonCustom2.Size = new Size(51, 43);
            buttonCustom2.TabIndex = 1;
            buttonCustom2.TextColor = Color.White;
            buttonCustom2.UseVisualStyleBackColor = false;
            buttonCustom2.Click += buttonCustom2_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(btnSubmit);
            panel2.Controls.Add(inputId);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(inputDonVi);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(inputGiaTien);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(inputSoLuong);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(inputName);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(26, 50);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(847, 530);
            panel2.TabIndex = 1;
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
            btnSubmit.Location = new Point(359, 480);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(128, 40);
            btnSubmit.TabIndex = 30;
            btnSubmit.Text = "Lưu lại";
            btnSubmit.TextColor = Color.White;
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // inputId
            // 
            inputId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputId.BackColor = SystemColors.Window;
            inputId.BorderColor = Color.LightSkyBlue;
            inputId.BorderFocusColor = Color.CornflowerBlue;
            inputId.BorderRadius = 0;
            inputId.BorderSize = 2;
            inputId.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            inputId.ForeColor = Color.FromArgb(64, 64, 64);
            inputId.Location = new Point(74, 420);
            inputId.Margin = new Padding(5);
            inputId.Multiline = false;
            inputId.Name = "inputId";
            inputId.Padding = new Padding(11, 9, 11, 9);
            inputId.PasswordChar = false;
            inputId.PlaceholderColor = Color.DarkGray;
            inputId.PlaceholderText = "";
            inputId.Size = new Size(688, 39);
            inputId.TabIndex = 29;
            inputId.Texts = "";
            inputId.UnderlinedStyle = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(241, 246, 249);
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(74, 390);
            label6.Name = "label6";
            label6.Size = new Size(141, 25);
            label6.TabIndex = 28;
            label6.Text = "Mã loại bánh";
            // 
            // inputDonVi
            // 
            inputDonVi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputDonVi.BackColor = SystemColors.Window;
            inputDonVi.BorderColor = Color.LightSkyBlue;
            inputDonVi.BorderFocusColor = Color.CornflowerBlue;
            inputDonVi.BorderRadius = 0;
            inputDonVi.BorderSize = 2;
            inputDonVi.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            inputDonVi.ForeColor = Color.FromArgb(64, 64, 64);
            inputDonVi.Location = new Point(74, 340);
            inputDonVi.Margin = new Padding(5);
            inputDonVi.Multiline = false;
            inputDonVi.Name = "inputDonVi";
            inputDonVi.Padding = new Padding(11, 9, 11, 9);
            inputDonVi.PasswordChar = false;
            inputDonVi.PlaceholderColor = Color.DarkGray;
            inputDonVi.PlaceholderText = "";
            inputDonVi.Size = new Size(688, 39);
            inputDonVi.TabIndex = 27;
            inputDonVi.Texts = "";
            inputDonVi.UnderlinedStyle = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(241, 246, 249);
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(74, 310);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 26;
            label5.Text = "Đơn vị";
            // 
            // inputGiaTien
            // 
            inputGiaTien.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputGiaTien.BackColor = SystemColors.Window;
            inputGiaTien.BorderColor = Color.LightSkyBlue;
            inputGiaTien.BorderFocusColor = Color.CornflowerBlue;
            inputGiaTien.BorderRadius = 0;
            inputGiaTien.BorderSize = 2;
            inputGiaTien.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            inputGiaTien.ForeColor = Color.FromArgb(64, 64, 64);
            inputGiaTien.Location = new Point(74, 260);
            inputGiaTien.Margin = new Padding(5);
            inputGiaTien.Multiline = false;
            inputGiaTien.Name = "inputGiaTien";
            inputGiaTien.Padding = new Padding(11, 9, 11, 9);
            inputGiaTien.PasswordChar = false;
            inputGiaTien.PlaceholderColor = Color.DarkGray;
            inputGiaTien.PlaceholderText = "";
            inputGiaTien.Size = new Size(688, 39);
            inputGiaTien.TabIndex = 25;
            inputGiaTien.Texts = "";
            inputGiaTien.UnderlinedStyle = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(241, 246, 249);
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(74, 230);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 24;
            label4.Text = "Giá tiền";
            // 
            // inputSoLuong
            // 
            inputSoLuong.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputSoLuong.BackColor = SystemColors.Window;
            inputSoLuong.BorderColor = Color.LightSkyBlue;
            inputSoLuong.BorderFocusColor = Color.CornflowerBlue;
            inputSoLuong.BorderRadius = 0;
            inputSoLuong.BorderSize = 2;
            inputSoLuong.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            inputSoLuong.ForeColor = Color.FromArgb(64, 64, 64);
            inputSoLuong.Location = new Point(74, 180);
            inputSoLuong.Margin = new Padding(5);
            inputSoLuong.Multiline = false;
            inputSoLuong.Name = "inputSoLuong";
            inputSoLuong.Padding = new Padding(11, 9, 11, 9);
            inputSoLuong.PasswordChar = false;
            inputSoLuong.PlaceholderColor = Color.DarkGray;
            inputSoLuong.PlaceholderText = "";
            inputSoLuong.Size = new Size(688, 39);
            inputSoLuong.TabIndex = 23;
            inputSoLuong.Texts = "";
            inputSoLuong.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(241, 246, 249);
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(74, 150);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 22;
            label3.Text = "Số lượng";
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
            inputName.Location = new Point(74, 100);
            inputName.Margin = new Padding(5);
            inputName.Multiline = false;
            inputName.Name = "inputName";
            inputName.Padding = new Padding(11, 9, 11, 9);
            inputName.PasswordChar = false;
            inputName.PlaceholderColor = Color.DarkGray;
            inputName.PlaceholderText = "";
            inputName.Size = new Size(688, 39);
            inputName.TabIndex = 21;
            inputName.Texts = "";
            inputName.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(241, 246, 249);
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(74, 70);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 20;
            label2.Text = "Tên bánh";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(74, 10);
            label1.Name = "label1";
            label1.Size = new Size(219, 29);
            label1.TabIndex = 18;
            label1.Text = "Thêm bánh mới";
            // 
            // AddBakeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 246, 249);
            ClientSize = new Size(906, 600);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddBakeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBakeForm";
            TopMost = true;
            Load += AddBakeForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ComponentCustom.ButtonCustom buttonCustom2;
        private Label label1;
        private Label label2;
        private CustomControls.RJControls.RJTextBox inputName;
        private Label label3;
        private CustomControls.RJControls.RJTextBox inputGiaTien;
        private Label label4;
        private CustomControls.RJControls.RJTextBox inputSoLuong;
        private CustomControls.RJControls.RJTextBox inputDonVi;
        private Label label5;
        private Label label6;
        private CustomControls.RJControls.RJTextBox inputId;
        private ComponentCustom.ButtonCustom btnSubmit;
    }
}