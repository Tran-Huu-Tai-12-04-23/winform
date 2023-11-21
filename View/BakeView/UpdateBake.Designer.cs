namespace FinalProject_QUANLYKHO.View.BakeView
{
    partial class UpdateBake
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
            btnSubmit = new ComponentCustom.ButtonCustom();
            inputTypeBake = new ComboBox();
            label6 = new Label();
            InputNumber = new CustomControls.RJControls.RJTextBox();
            label5 = new Label();
            inputPrice = new CustomControls.RJControls.RJTextBox();
            label4 = new Label();
            inputUnit = new CustomControls.RJControls.RJTextBox();
            label3 = new Label();
            inputNameBake = new CustomControls.RJControls.RJTextBox();
            label2 = new Label();
            label1 = new Label();
            buttonCustom2 = new ComponentCustom.ButtonCustom();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(241, 246, 249);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(buttonCustom2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 659);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSubmit);
            panel2.Controls.Add(inputTypeBake);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(InputNumber);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(inputPrice);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(inputUnit);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(inputNameBake);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(31, 61);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(847, 560);
            panel2.TabIndex = 4;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Bottom;
            btnSubmit.BackColor = Color.LightSkyBlue;
            btnSubmit.BackgroundColor = Color.LightSkyBlue;
            btnSubmit.BorderColor = Color.PaleVioletRed;
            btnSubmit.BorderRadius = 0;
            btnSubmit.BorderSize = 0;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(360, 502);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(147, 51);
            btnSubmit.TabIndex = 51;
            btnSubmit.Text = "Lưu lại";
            btnSubmit.TextColor = Color.White;
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // inputTypeBake
            // 
            inputTypeBake.FormattingEnabled = true;
            inputTypeBake.Location = new Point(83, 450);
            inputTypeBake.Name = "inputTypeBake";
            inputTypeBake.Size = new Size(151, 28);
            inputTypeBake.TabIndex = 50;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(241, 246, 249);
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(83, 422);
            label6.Name = "label6";
            label6.Size = new Size(112, 25);
            label6.TabIndex = 49;
            label6.Text = "Loại Bánh";
            // 
            // InputNumber
            // 
            InputNumber.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            InputNumber.BackColor = SystemColors.Window;
            InputNumber.BorderColor = Color.LightSkyBlue;
            InputNumber.BorderFocusColor = Color.CornflowerBlue;
            InputNumber.BorderRadius = 0;
            InputNumber.BorderSize = 2;
            InputNumber.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            InputNumber.ForeColor = Color.FromArgb(64, 64, 64);
            InputNumber.Location = new Point(83, 362);
            InputNumber.Margin = new Padding(5);
            InputNumber.Multiline = false;
            InputNumber.Name = "InputNumber";
            InputNumber.Padding = new Padding(11, 9, 11, 9);
            InputNumber.PasswordChar = false;
            InputNumber.PlaceholderColor = Color.DarkGray;
            InputNumber.PlaceholderText = "";
            InputNumber.Size = new Size(629, 39);
            InputNumber.TabIndex = 48;
            InputNumber.Texts = "";
            InputNumber.UnderlinedStyle = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(241, 246, 249);
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(83, 332);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 47;
            label5.Text = "Số lượng";
            // 
            // inputPrice
            // 
            inputPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            inputPrice.BackColor = SystemColors.Window;
            inputPrice.BorderColor = Color.LightSkyBlue;
            inputPrice.BorderFocusColor = Color.CornflowerBlue;
            inputPrice.BorderRadius = 0;
            inputPrice.BorderSize = 2;
            inputPrice.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            inputPrice.ForeColor = Color.FromArgb(64, 64, 64);
            inputPrice.Location = new Point(83, 272);
            inputPrice.Margin = new Padding(5);
            inputPrice.Multiline = false;
            inputPrice.Name = "inputPrice";
            inputPrice.Padding = new Padding(11, 9, 11, 9);
            inputPrice.PasswordChar = false;
            inputPrice.PlaceholderColor = Color.DarkGray;
            inputPrice.PlaceholderText = "";
            inputPrice.Size = new Size(629, 39);
            inputPrice.TabIndex = 46;
            inputPrice.Texts = "";
            inputPrice.UnderlinedStyle = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(241, 246, 249);
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(83, 242);
            label4.Name = "label4";
            label4.Size = new Size(96, 25);
            label4.TabIndex = 45;
            label4.Text = "Giá Tiền";
            // 
            // inputUnit
            // 
            inputUnit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            inputUnit.BackColor = SystemColors.Window;
            inputUnit.BorderColor = Color.LightSkyBlue;
            inputUnit.BorderFocusColor = Color.CornflowerBlue;
            inputUnit.BorderRadius = 0;
            inputUnit.BorderSize = 2;
            inputUnit.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            inputUnit.ForeColor = Color.FromArgb(64, 64, 64);
            inputUnit.Location = new Point(83, 182);
            inputUnit.Margin = new Padding(5);
            inputUnit.Multiline = false;
            inputUnit.Name = "inputUnit";
            inputUnit.Padding = new Padding(11, 9, 11, 9);
            inputUnit.PasswordChar = false;
            inputUnit.PlaceholderColor = Color.DarkGray;
            inputUnit.PlaceholderText = "";
            inputUnit.Size = new Size(629, 39);
            inputUnit.TabIndex = 44;
            inputUnit.Texts = "";
            inputUnit.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(241, 246, 249);
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(83, 152);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 43;
            label3.Text = "Đơn Vị";
            // 
            // inputNameBake
            // 
            inputNameBake.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            inputNameBake.BackColor = SystemColors.Window;
            inputNameBake.BorderColor = Color.LightSkyBlue;
            inputNameBake.BorderFocusColor = Color.CornflowerBlue;
            inputNameBake.BorderRadius = 0;
            inputNameBake.BorderSize = 2;
            inputNameBake.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            inputNameBake.ForeColor = Color.FromArgb(64, 64, 64);
            inputNameBake.Location = new Point(83, 92);
            inputNameBake.Margin = new Padding(5);
            inputNameBake.Multiline = false;
            inputNameBake.Name = "inputNameBake";
            inputNameBake.Padding = new Padding(11, 9, 11, 9);
            inputNameBake.PasswordChar = false;
            inputNameBake.PlaceholderColor = Color.DarkGray;
            inputNameBake.PlaceholderText = "";
            inputNameBake.Size = new Size(629, 39);
            inputNameBake.TabIndex = 42;
            inputNameBake.Texts = "";
            inputNameBake.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(241, 246, 249);
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(83, 62);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 41;
            label2.Text = "Tên Bánh";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(83, 22);
            label1.Name = "label1";
            label1.Size = new Size(220, 29);
            label1.TabIndex = 40;
            label1.Text = "Chỉnh sửa bánh";
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
            buttonCustom2.TabIndex = 3;
            buttonCustom2.TextColor = Color.White;
            buttonCustom2.UseVisualStyleBackColor = false;
            buttonCustom2.Click += buttonCustom2_Click;
            // 
            // UpdateBake
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 668);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateBake";
            Text = "UpdateBake";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComponentCustom.ButtonCustom buttonCustom2;
        private Panel panel2;
        private ComponentCustom.ButtonCustom btnSubmit;
        private ComboBox inputTypeBake;
        private Label label6;
        private CustomControls.RJControls.RJTextBox InputNumber;
        private Label label5;
        private CustomControls.RJControls.RJTextBox inputPrice;
        private Label label4;
        private CustomControls.RJControls.RJTextBox inputUnit;
        private Label label3;
        private CustomControls.RJControls.RJTextBox inputNameBake;
        private Label label2;
        private Label label1;
    }
}