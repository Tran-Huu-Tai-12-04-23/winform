using FinalProject_QUANLYKHO.Contanst;
namespace FinalProject_QUANLYKHO.View.Bake
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(279, 167);
            label1.Name = "label1";
            label1.Size = new Size(151, 30);
            label1.TabIndex = 0;
            label1.Text = "Form add bake";
            label1.Click += label1_Click;
            // 
            // AddBakeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Name = "AddBakeForm";
            Text = "AddBakeForm";
            ResumeLayout(false);
            PerformLayout();

            this.BackColor = ContanstApp.BODY_COLOR;
        }

        #endregion

        private Label label1;
    }
}