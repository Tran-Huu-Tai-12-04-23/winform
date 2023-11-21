namespace FinalProject_QUANLYKHO.View.MaterialView
{
    partial class AddMaterial
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
            btnTurnOff = new ComponentCustom.ButtonCustom();
            label4 = new Label();
            inputPrice = new CustomControls.RJControls.RJTextBox();
            btnSubmit = new ComponentCustom.ButtonCustom();
            label3 = new Label();
            inputUnit = new CustomControls.RJControls.RJTextBox();
            label2 = new Label();
            inputNameMaterial = new CustomControls.RJControls.RJTextBox();
            label1 = new Label();
            panelCustom1 = new ComponentCustom.PanelCustom();
            inputTypeMaterial = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            InputNumber = new CustomControls.RJControls.RJTextBox();
            panelCustom2 = new ComponentCustom.PanelCustom();
            panelCustom1.SuspendLayout();
            panelCustom2.SuspendLayout();
            SuspendLayout();
            // 
            // btnTurnOff
            // 
            btnTurnOff.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTurnOff.BackColor = Color.Transparent;
            btnTurnOff.BackgroundColor = Color.Transparent;
            btnTurnOff.BorderColor = Color.Transparent;
            btnTurnOff.BorderRadius = 0;
            btnTurnOff.BorderSize = 0;
            btnTurnOff.FlatAppearance.BorderSize = 0;
            btnTurnOff.FlatStyle = FlatStyle.Flat;
            btnTurnOff.ForeColor = Color.White;
            btnTurnOff.Image = Properties.Resources.icons8_close_24;
            btnTurnOff.Location = new Point(995, 0);
            btnTurnOff.Margin = new Padding(0);
            btnTurnOff.Name = "btnTurnOff";
            btnTurnOff.Size = new Size(51, 43);
            btnTurnOff.TabIndex = 2;
            btnTurnOff.TextColor = Color.White;
            btnTurnOff.UseVisualStyleBackColor = false;
            btnTurnOff.Click += btnTurnOff_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(241, 246, 249);
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(94, 238);
            label4.Name = "label4";
            label4.Size = new Size(96, 25);
            label4.TabIndex = 31;
            label4.Text = "Giá Tiền";
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
            inputPrice.Location = new Point(94, 266);
            inputPrice.Margin = new Padding(5);
            inputPrice.Multiline = false;
            inputPrice.Name = "inputPrice";
            inputPrice.Padding = new Padding(11, 9, 11, 9);
            inputPrice.PasswordChar = false;
            inputPrice.PlaceholderColor = Color.DarkGray;
            inputPrice.PlaceholderText = "";
            inputPrice.Size = new Size(629, 39);
            inputPrice.TabIndex = 30;
            inputPrice.Texts = "";
            inputPrice.UnderlinedStyle = false;
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
            btnSubmit.Location = new Point(319, 490);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(147, 51);
            btnSubmit.TabIndex = 32;
            btnSubmit.Text = "Lưu lại";
            btnSubmit.TextColor = Color.White;
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(241, 246, 249);
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(94, 155);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 29;
            label3.Text = "Đơn Vị";
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
            inputUnit.Location = new Point(94, 184);
            inputUnit.Margin = new Padding(5);
            inputUnit.Multiline = false;
            inputUnit.Name = "inputUnit";
            inputUnit.Padding = new Padding(11, 9, 11, 9);
            inputUnit.PasswordChar = false;
            inputUnit.PlaceholderColor = Color.DarkGray;
            inputUnit.PlaceholderText = "";
            inputUnit.Size = new Size(629, 39);
            inputUnit.TabIndex = 28;
            inputUnit.Texts = "";
            inputUnit.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(241, 246, 249);
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(94, 69);
            label2.Name = "label2";
            label2.Size = new Size(182, 25);
            label2.TabIndex = 27;
            label2.Text = "Tên Nguyên Liệu";
            // 
            // inputNameMaterial
            // 
            inputNameMaterial.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            inputNameMaterial.BackColor = SystemColors.Window;
            inputNameMaterial.BorderColor = Color.LightSkyBlue;
            inputNameMaterial.BorderFocusColor = Color.CornflowerBlue;
            inputNameMaterial.BorderRadius = 0;
            inputNameMaterial.BorderSize = 2;
            inputNameMaterial.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            inputNameMaterial.ForeColor = Color.FromArgb(64, 64, 64);
            inputNameMaterial.Location = new Point(94, 97);
            inputNameMaterial.Margin = new Padding(5);
            inputNameMaterial.Multiline = false;
            inputNameMaterial.Name = "inputNameMaterial";
            inputNameMaterial.Padding = new Padding(11, 9, 11, 9);
            inputNameMaterial.PasswordChar = false;
            inputNameMaterial.PlaceholderColor = Color.DarkGray;
            inputNameMaterial.PlaceholderText = "";
            inputNameMaterial.Size = new Size(629, 39);
            inputNameMaterial.TabIndex = 26;
            inputNameMaterial.Texts = "";
            inputNameMaterial.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(94, 12);
            label1.Name = "label1";
            label1.Size = new Size(314, 29);
            label1.TabIndex = 25;
            label1.Text = "Thêm nguyên Liệu Mới";
            // 
            // panelCustom1
            // 
            panelCustom1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelCustom1.Controls.Add(inputTypeMaterial);
            panelCustom1.Controls.Add(label6);
            panelCustom1.Controls.Add(label5);
            panelCustom1.Controls.Add(InputNumber);
            panelCustom1.Controls.Add(inputNameMaterial);
            panelCustom1.Controls.Add(label4);
            panelCustom1.Controls.Add(label1);
            panelCustom1.Controls.Add(inputPrice);
            panelCustom1.Controls.Add(label2);
            panelCustom1.Controls.Add(btnSubmit);
            panelCustom1.Controls.Add(inputUnit);
            panelCustom1.Controls.Add(label3);
            panelCustom1.Location = new Point(123, 47);
            panelCustom1.Name = "panelCustom1";
            panelCustom1.Size = new Size(851, 573);
            panelCustom1.TabIndex = 33;
            panelCustom1.Paint += panelCustom1_Paint;
            // 
            // inputTypeMaterial
            // 
            inputTypeMaterial.FormattingEnabled = true;
            inputTypeMaterial.Location = new Point(94, 447);
            inputTypeMaterial.Name = "inputTypeMaterial";
            inputTypeMaterial.Size = new Size(151, 28);
            inputTypeMaterial.TabIndex = 37;
            inputTypeMaterial.SelectedIndexChanged += inputTypeMaterial_SelectedIndexChanged_1;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(241, 246, 249);
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(94, 410);
            label6.Name = "label6";
            label6.Size = new Size(186, 25);
            label6.TabIndex = 36;
            label6.Text = "Loại Nguyên Liệu";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(241, 246, 249);
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(94, 324);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 34;
            label5.Text = "Số lượng";
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
            InputNumber.Location = new Point(94, 352);
            InputNumber.Margin = new Padding(5);
            InputNumber.Multiline = false;
            InputNumber.Name = "InputNumber";
            InputNumber.Padding = new Padding(11, 9, 11, 9);
            InputNumber.PasswordChar = false;
            InputNumber.PlaceholderColor = Color.DarkGray;
            InputNumber.PlaceholderText = "";
            InputNumber.Size = new Size(629, 39);
            InputNumber.TabIndex = 33;
            InputNumber.Texts = "";
            InputNumber.UnderlinedStyle = false;
            // 
            // panelCustom2
            // 
            panelCustom2.Controls.Add(panelCustom1);
            panelCustom2.Controls.Add(btnTurnOff);
            panelCustom2.Dock = DockStyle.Fill;
            panelCustom2.Location = new Point(0, 0);
            panelCustom2.Name = "panelCustom2";
            panelCustom2.Size = new Size(1046, 632);
            panelCustom2.TabIndex = 34;
            // 
            // AddMaterial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 632);
            ControlBox = false;
            Controls.Add(panelCustom2);
            Name = "AddMaterial";
            panelCustom1.ResumeLayout(false);
            panelCustom1.PerformLayout();
            panelCustom2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComponentCustom.ButtonCustom btnTurnOff;
        private Label label4;
        private CustomControls.RJControls.RJTextBox inputPrice;
        private ComponentCustom.ButtonCustom btnSubmit;
        private Label label3;
        private CustomControls.RJControls.RJTextBox inputUnit;
        private Label label2;
        private CustomControls.RJControls.RJTextBox inputNameMaterial;
        private Label label1;
        private ComponentCustom.PanelCustom panelCustom1;
        private Label label5;
        private CustomControls.RJControls.RJTextBox InputNumber;
        private ComponentCustom.PanelCustom panelCustom2;
        private Label label6;
        private ComboBox inputTypeMaterial;
    }
}