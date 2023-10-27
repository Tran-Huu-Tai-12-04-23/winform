using System.Diagnostics;

namespace FinalProject_QUANLYKHO
{
    partial class Form1
    {
        public void hiddenBorderButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
        }
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
            panelFlowSidebar = new FlowLayoutPanel();
            panel3 = new Panel();
            panel2 = new Panel();
            btnActiveMainScreen = new Button();
            button7 = new Button();
            button8 = new Button();
            btnActiveCustomerScreen = new Button();
            btnActiveBakeScreen = new Button();
            btnActiveMaterialScreen = new Button();
            label3 = new Label();
            openFileDialog1 = new OpenFileDialog();
            panelMainForm = new Panel();
            labelActiveBar = new Label();
            panelHeader = new Panel();
            button1 = new Button();
            panelFlowSidebar.SuspendLayout();
            panel3.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelFlowSidebar
            // 
            panelFlowSidebar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelFlowSidebar.AutoScroll = true;
            panelFlowSidebar.BackColor = Color.White;
            panelFlowSidebar.Controls.Add(panel3);
            panelFlowSidebar.Controls.Add(panel2);
            panelFlowSidebar.Controls.Add(btnActiveMainScreen);
            panelFlowSidebar.Controls.Add(button7);
            panelFlowSidebar.Controls.Add(button8);
            panelFlowSidebar.Controls.Add(btnActiveCustomerScreen);
            panelFlowSidebar.Controls.Add(btnActiveBakeScreen);
            panelFlowSidebar.Controls.Add(btnActiveMaterialScreen);
            panelFlowSidebar.FlowDirection = FlowDirection.TopDown;
            panelFlowSidebar.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panelFlowSidebar.Location = new Point(0, 0);
            panelFlowSidebar.Margin = new Padding(0);
            panelFlowSidebar.Name = "panelFlowSidebar";
            panelFlowSidebar.Size = new Size(201, 595);
            panelFlowSidebar.TabIndex = 0;
            panelFlowSidebar.Paint += flowLayoutPanel1_Paint_1;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 46);
            panel3.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoSize = true;
            panel2.BackColor = Color.Silver;
            panel2.Location = new Point(3, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(194, 0);
            panel2.TabIndex = 1;
            // 
            // btnActiveMainScreen
            // 
            btnActiveMainScreen.AccessibleName = "";
            btnActiveMainScreen.BackColor = Color.FromArgb(241, 246, 249);
            btnActiveMainScreen.Dock = DockStyle.Top;
            btnActiveMainScreen.FlatAppearance.BorderSize = 0;
            btnActiveMainScreen.FlatStyle = FlatStyle.Flat;
            btnActiveMainScreen.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnActiveMainScreen.ForeColor = Color.Black;
            btnActiveMainScreen.Image = Properties.Resources.home;
            btnActiveMainScreen.ImageAlign = ContentAlignment.MiddleLeft;
            btnActiveMainScreen.Location = new Point(0, 52);
            btnActiveMainScreen.Margin = new Padding(0);
            btnActiveMainScreen.Name = "btnActiveMainScreen";
            btnActiveMainScreen.Padding = new Padding(12, 0, 0, 0);
            btnActiveMainScreen.RightToLeft = RightToLeft.No;
            btnActiveMainScreen.Size = new Size(200, 50);
            btnActiveMainScreen.TabIndex = 6;
            btnActiveMainScreen.Text = "  Màn hình chính";
            btnActiveMainScreen.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActiveMainScreen.UseVisualStyleBackColor = false;
            btnActiveMainScreen.Click += btnActiveMainScreen_Click;
            // 
            // button7
            // 
            button7.AccessibleName = "btnNguyenLieu";
            button7.BackColor = Color.Transparent;
            button7.Dock = DockStyle.Top;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.Black;
            button7.Image = Properties.Resources.hoadon;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(0, 102);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Padding = new Padding(12, 0, 0, 0);
            button7.Size = new Size(200, 50);
            button7.TabIndex = 9;
            button7.Text = "  Hóa đơn xuất";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.TextImageRelation = TextImageRelation.ImageBeforeText;
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.AccessibleName = "btnNguyenLieu";
            button8.BackColor = Color.Transparent;
            button8.Dock = DockStyle.Top;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.Black;
            button8.Image = Properties.Resources.hoadon;
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(0, 152);
            button8.Margin = new Padding(0);
            button8.Name = "button8";
            button8.Padding = new Padding(12, 0, 0, 0);
            button8.Size = new Size(200, 50);
            button8.TabIndex = 10;
            button8.Text = "  Hóa đơn nhập";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.TextImageRelation = TextImageRelation.ImageBeforeText;
            button8.UseVisualStyleBackColor = false;
            // 
            // btnActiveCustomerScreen
            // 
            btnActiveCustomerScreen.AccessibleName = "";
            btnActiveCustomerScreen.BackColor = Color.Transparent;
            btnActiveCustomerScreen.Dock = DockStyle.Top;
            btnActiveCustomerScreen.FlatAppearance.BorderSize = 0;
            btnActiveCustomerScreen.FlatStyle = FlatStyle.Flat;
            btnActiveCustomerScreen.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnActiveCustomerScreen.ForeColor = Color.Black;
            btnActiveCustomerScreen.Image = Properties.Resources.customer;
            btnActiveCustomerScreen.ImageAlign = ContentAlignment.MiddleLeft;
            btnActiveCustomerScreen.Location = new Point(0, 202);
            btnActiveCustomerScreen.Margin = new Padding(0);
            btnActiveCustomerScreen.Name = "btnActiveCustomerScreen";
            btnActiveCustomerScreen.Padding = new Padding(12, 0, 0, 0);
            btnActiveCustomerScreen.Size = new Size(200, 50);
            btnActiveCustomerScreen.TabIndex = 11;
            btnActiveCustomerScreen.Text = "  Khách  hàng";
            btnActiveCustomerScreen.TextAlign = ContentAlignment.MiddleLeft;
            btnActiveCustomerScreen.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActiveCustomerScreen.UseVisualStyleBackColor = false;
            btnActiveCustomerScreen.Click += btnActiveCustomerScreen_Click;
            // 
            // btnActiveBakeScreen
            // 
            btnActiveBakeScreen.AccessibleName = "";
            btnActiveBakeScreen.BackColor = Color.Transparent;
            btnActiveBakeScreen.Dock = DockStyle.Top;
            btnActiveBakeScreen.FlatAppearance.BorderSize = 0;
            btnActiveBakeScreen.FlatStyle = FlatStyle.Flat;
            btnActiveBakeScreen.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnActiveBakeScreen.ForeColor = Color.Black;
            btnActiveBakeScreen.Image = Properties.Resources.bake;
            btnActiveBakeScreen.ImageAlign = ContentAlignment.MiddleLeft;
            btnActiveBakeScreen.Location = new Point(0, 252);
            btnActiveBakeScreen.Margin = new Padding(0);
            btnActiveBakeScreen.Name = "btnActiveBakeScreen";
            btnActiveBakeScreen.Padding = new Padding(12, 0, 0, 0);
            btnActiveBakeScreen.Size = new Size(200, 50);
            btnActiveBakeScreen.TabIndex = 12;
            btnActiveBakeScreen.Text = "  Bánh";
            btnActiveBakeScreen.TextAlign = ContentAlignment.MiddleLeft;
            btnActiveBakeScreen.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActiveBakeScreen.UseVisualStyleBackColor = false;
            btnActiveBakeScreen.Click += btnActiveBakeScreen_Click;
            // 
            // btnActiveMaterialScreen
            // 
            btnActiveMaterialScreen.AccessibleName = "";
            btnActiveMaterialScreen.BackColor = Color.Transparent;
            btnActiveMaterialScreen.Dock = DockStyle.Top;
            btnActiveMaterialScreen.FlatAppearance.BorderSize = 0;
            btnActiveMaterialScreen.FlatStyle = FlatStyle.Flat;
            btnActiveMaterialScreen.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnActiveMaterialScreen.ForeColor = Color.Black;
            btnActiveMaterialScreen.Image = Properties.Resources.material;
            btnActiveMaterialScreen.ImageAlign = ContentAlignment.MiddleLeft;
            btnActiveMaterialScreen.Location = new Point(0, 302);
            btnActiveMaterialScreen.Margin = new Padding(0);
            btnActiveMaterialScreen.Name = "btnActiveMaterialScreen";
            btnActiveMaterialScreen.Padding = new Padding(12, 0, 0, 0);
            btnActiveMaterialScreen.Size = new Size(200, 50);
            btnActiveMaterialScreen.TabIndex = 13;
            btnActiveMaterialScreen.Text = "  Nguyên liệu";
            btnActiveMaterialScreen.TextAlign = ContentAlignment.MiddleLeft;
            btnActiveMaterialScreen.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActiveMaterialScreen.UseVisualStyleBackColor = false;
            btnActiveMaterialScreen.Click += btnActiveMaterialScreen_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(782, 16);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(144, 18);
            label3.TabIndex = 1;
            label3.Text = "Xin Chào, Admin";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // panelMainForm
            // 
            panelMainForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMainForm.BackColor = Color.FromArgb(241, 246, 249);
            panelMainForm.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panelMainForm.Location = new Point(201, 52);
            panelMainForm.Margin = new Padding(0);
            panelMainForm.Name = "panelMainForm";
            panelMainForm.Size = new Size(935, 543);
            panelMainForm.TabIndex = 2;
            // 
            // labelActiveBar
            // 
            labelActiveBar.Anchor = AnchorStyles.Left;
            labelActiveBar.AutoSize = true;
            labelActiveBar.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelActiveBar.Location = new Point(17, 16);
            labelActiveBar.Margin = new Padding(0);
            labelActiveBar.Name = "labelActiveBar";
            labelActiveBar.Size = new Size(131, 18);
            labelActiveBar.TabIndex = 0;
            labelActiveBar.Text = "Màn hình chính";
            // 
            // panelHeader
            // 
            panelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelHeader.Controls.Add(label3);
            panelHeader.Controls.Add(labelActiveBar);
            panelHeader.Location = new Point(201, 0);
            panelHeader.Margin = new Padding(0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(935, 52);
            panelHeader.TabIndex = 3;
            // 
            // button1
            // 
            button1.AccessibleName = "";
            button1.BackColor = Color.Transparent;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Image = Properties.Resources.icons8_online_store_40;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Padding = new Padding(12, 0, 0, 0);
            button1.Size = new Size(200, 50);
            button1.TabIndex = 12;
            button1.Text = "Quản lý";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1136, 595);
            Controls.Add(panelHeader);
            Controls.Add(panelMainForm);
            Controls.Add(panelFlowSidebar);
            HelpButton = true;
            MinimumSize = new Size(1152, 634);
            Name = "Form1";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            panelFlowSidebar.ResumeLayout(false);
            panelFlowSidebar.PerformLayout();
            panel3.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {
        }

        #endregion
        private FlowLayoutPanel panelFlowSidebar;
        private Panel panel2;
        private Panel panel3;
        private Panel panelMainForm;
        private Button btnActiveMainScreen;
        private Button btnActiveCustomerScreen;
        private Button btnActiveBakeScreen;
        private Button btnActiveMaterialScreen;
        private Button button6;
        private Button button7;
        private Button button8;
        private Panel panelText;
        private Button button12;
        private Button button11;
        private Button button10;
        private OpenFileDialog openFileDialog1;

        private Label label3;
        private Label labelActiveBar;
        private Panel panelHeader;
        private Panel panel1;
        private Button button4;
        private Panel panel4;
        private Button button5;
        private Button button9;
        private Panel panel;
        private Button button1;
    }


}