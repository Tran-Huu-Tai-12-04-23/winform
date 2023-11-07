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
            panelMainForm = new Panel();
            btnClose = new ComponentCustom.ButtonCustom();
            SuspendLayout();
            // 
            // panelMainForm
            // 
            panelMainForm.BackColor = Color.Transparent;
            panelMainForm.Location = new Point(1, 41);
            panelMainForm.Name = "panelMainForm";
            panelMainForm.Size = new Size(1000, 554);
            panelMainForm.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundColor = Color.Transparent;
            btnClose.BorderColor = Color.PaleVioletRed;
            btnClose.BorderRadius = 6;
            btnClose.BorderSize = 0;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Image = Properties.Resources.icons8_close_24;
            btnClose.Location = new Point(948, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 27);
            btnClose.TabIndex = 2;
            btnClose.TextColor = Color.White;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click_1;
            // 
            // Authentication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 616);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(panelMainForm);
            MaximumSize = new Size(1016, 800);
            Name = "Authentication";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Authentication";
            Load += Authentication_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMainForm;
        private ComponentCustom.ButtonCustom btnClose;
    }
}