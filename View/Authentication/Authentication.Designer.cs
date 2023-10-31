namespace FinalProject_QUANLYKHO.View.Authentication
{
    partial class Authentication
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
            label1 = new Label();
            btnClose = new ComponentCustom.ButtonCustom();
            buttonCustom1 = new ComponentCustom.ButtonCustom();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(46, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(397, 473);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 14);
            label1.Name = "label1";
            label1.Size = new Size(134, 45);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundColor = Color.Transparent;
            btnClose.BorderColor = Color.PaleVioletRed;
            btnClose.BorderRadius = 20;
            btnClose.BorderSize = 0;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Image = Properties.Resources.icons8_close_24;
            btnClose.Location = new Point(934, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(66, 56);
            btnClose.TabIndex = 1;
            btnClose.TextColor = Color.White;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // buttonCustom1
            // 
            buttonCustom1.BackColor = Color.Transparent;
            buttonCustom1.BackgroundColor = Color.Transparent;
            buttonCustom1.BorderColor = Color.Transparent;
            buttonCustom1.BorderRadius = 8;
            buttonCustom1.BorderSize = 0;
            buttonCustom1.FlatAppearance.BorderSize = 0;
            buttonCustom1.FlatStyle = FlatStyle.Flat;
            buttonCustom1.ForeColor = Color.White;
            buttonCustom1.Image = Properties.Resources.login__1_;
            buttonCustom1.Location = new Point(449, 0);
            buttonCustom1.MaximumSize = new Size(500, 565);
            buttonCustom1.Name = "buttonCustom1";
            buttonCustom1.Size = new Size(500, 565);
            buttonCustom1.TabIndex = 2;
            buttonCustom1.Text = "buttonCustom1";
            buttonCustom1.TextColor = Color.White;
            buttonCustom1.UseVisualStyleBackColor = false;    
            // 
            // Authentication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 564);
            ControlBox = false;
            Controls.Add(buttonCustom1);
            Controls.Add(btnClose);
            Controls.Add(panel1);
            MaximumSize = new Size(1016, 603);
            Name = "Authentication";
            Text = "Authentication";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComponentCustom.ButtonCustom btnClose;
        private ComponentCustom.ButtonCustom buttonCustom1;
        private Label label1;
    }
}