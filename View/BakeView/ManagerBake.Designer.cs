namespace FinalProject_QUANLYKHO.View.BakeView
{
    partial class ManagerBake
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
            label1 = new Label();
            rjToggle1 = new ComponentCustom.RJToggle();
            rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            rjDatePicker1 = new ComponentCustom.RJDatePicker();
            buttonCustom1 = new ComponentCustom.ButtonCustom();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(347, 140);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // rjToggle1
            // 
            rjToggle1.AutoSize = true;
            rjToggle1.Location = new Point(560, 160);
            rjToggle1.MinimumSize = new Size(45, 22);
            rjToggle1.Name = "rjToggle1";
            rjToggle1.OffBackColor = Color.Gray;
            rjToggle1.OffToggleColor = Color.Gainsboro;
            rjToggle1.OnBackColor = Color.MediumSlateBlue;
            rjToggle1.OnToggleColor = Color.WhiteSmoke;
            rjToggle1.Size = new Size(45, 22);
            rjToggle1.TabIndex = 1;
            rjToggle1.UseVisualStyleBackColor = true;
            // 
            // rjTextBox1
            // 
            rjTextBox1.BackColor = SystemColors.Window;
            rjTextBox1.BorderColor = Color.MediumSlateBlue;
            rjTextBox1.BorderFocusColor = Color.HotPink;
            rjTextBox1.BorderRadius = 0;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            rjTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox1.Location = new Point(535, 280);
            rjTextBox1.Margin = new Padding(4);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "";
            rjTextBox1.Size = new Size(250, 31);
            rjTextBox1.TabIndex = 2;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            // 
            // rjDatePicker1
            // 
            rjDatePicker1.BorderColor = Color.PaleVioletRed;
            rjDatePicker1.BorderSize = 0;
            rjDatePicker1.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            rjDatePicker1.Location = new Point(526, 58);
            rjDatePicker1.MinimumSize = new Size(0, 35);
            rjDatePicker1.Name = "rjDatePicker1";
            rjDatePicker1.Size = new Size(200, 35);
            rjDatePicker1.SkinColor = Color.MediumSlateBlue;
            rjDatePicker1.TabIndex = 3;
            rjDatePicker1.TextColor = Color.White;
            // 
            // buttonCustom1
            // 
            buttonCustom1.BackColor = Color.MediumSlateBlue;
            buttonCustom1.BackgroundColor = Color.MediumSlateBlue;
            buttonCustom1.BorderColor = Color.PaleVioletRed;
            buttonCustom1.BorderRadius = 20;
            buttonCustom1.BorderSize = 0;
            buttonCustom1.FlatAppearance.BorderSize = 0;
            buttonCustom1.FlatStyle = FlatStyle.Flat;
            buttonCustom1.ForeColor = Color.White;
            buttonCustom1.Location = new Point(81, 88);
            buttonCustom1.Name = "buttonCustom1";
            buttonCustom1.Size = new Size(192, 136);
            buttonCustom1.TabIndex = 4;
            buttonCustom1.Text = "buttonCustom1";
            buttonCustom1.TextColor = Color.White;
            buttonCustom1.UseVisualStyleBackColor = false;
            // 
            // ManagerBake
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCustom1);
            Controls.Add(rjDatePicker1);
            Controls.Add(rjTextBox1);
            Controls.Add(rjToggle1);
            Controls.Add(label1);
            Name = "ManagerBake";
            Text = "ManagerBake";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComponentCustom.RJToggle rjToggle1;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private ComponentCustom.RJDatePicker rjDatePicker1;
        private ComponentCustom.ButtonCustom buttonCustom1;
    }
}