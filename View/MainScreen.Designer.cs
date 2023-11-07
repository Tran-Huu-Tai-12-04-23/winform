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
            button1 = new Button();
            panel2 = new Panel();
            btnActiveMainScreen = new Button();
            btnActiveCustomerScreen = new Button();
            btnActiveBakeScreen = new Button();
            btnActiveMaterialScreen = new Button();
            btnActiveImportInvoceMaterial = new Button();
            btnActiveExportInvoceMaterial = new Button();
            btnActiveExportInvoceBake = new Button();
            btnActiveImportInvoceBake = new Button();
            btnActiveDecentrialtion = new Button();
            label3 = new Label();
            panelMainForm = new Panel();
            panelHeader = new Panel();
            buttonCustom1 = new ComponentCustom.ButtonCustom();
            btnMenu = new ComponentCustom.ButtonCustom();
            labelActiveBar = new Label();
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
            panelFlowSidebar.Controls.Add(btnActiveCustomerScreen);
            panelFlowSidebar.Controls.Add(btnActiveBakeScreen);
            panelFlowSidebar.Controls.Add(btnActiveMaterialScreen);
            panelFlowSidebar.Controls.Add(btnActiveImportInvoceMaterial);
            panelFlowSidebar.Controls.Add(btnActiveExportInvoceMaterial);
            panelFlowSidebar.Controls.Add(btnActiveExportInvoceBake);
            panelFlowSidebar.Controls.Add(btnActiveImportInvoceBake);
            panelFlowSidebar.Controls.Add(btnActiveDecentrialtion);
            panelFlowSidebar.FlowDirection = FlowDirection.TopDown;
            panelFlowSidebar.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panelFlowSidebar.Location = new Point(0, 0);
            panelFlowSidebar.Margin = new Padding(0);
            panelFlowSidebar.MaximumSize = new Size(230, 595);
            panelFlowSidebar.MinimumSize = new Size(50, 595);
            panelFlowSidebar.Name = "panelFlowSidebar";
            panelFlowSidebar.Size = new Size(230, 595);
            panelFlowSidebar.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 46);
            panel3.TabIndex = 5;
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
            button1.Size = new Size(230, 50);
            button1.TabIndex = 12;
            button1.Text = "   Quản lý";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoSize = true;
            panel2.BackColor = Color.Silver;
            panel2.Location = new Point(3, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(224, 0);
            panel2.TabIndex = 1;
            // 
            // btnActiveMainScreen
            // 
            btnActiveMainScreen.AccessibleName = "";
            btnActiveMainScreen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnActiveMainScreen.BackColor = Color.FromArgb(241, 246, 249);
            btnActiveMainScreen.FlatAppearance.BorderSize = 0;
            btnActiveMainScreen.FlatStyle = FlatStyle.Flat;
            btnActiveMainScreen.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnActiveMainScreen.ForeColor = Color.Black;
            btnActiveMainScreen.Image = Properties.Resources.home;
            btnActiveMainScreen.ImageAlign = ContentAlignment.MiddleLeft;
            btnActiveMainScreen.Location = new Point(0, 52);
            btnActiveMainScreen.Margin = new Padding(0);
            btnActiveMainScreen.Name = "btnActiveMainScreen";
            btnActiveMainScreen.Padding = new Padding(6, 0, 0, 0);
            btnActiveMainScreen.RightToLeft = RightToLeft.No;
            btnActiveMainScreen.Size = new Size(230, 50);
            btnActiveMainScreen.TabIndex = 6;
            btnActiveMainScreen.Text = "  Màn hình chính";
            btnActiveMainScreen.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActiveMainScreen.UseVisualStyleBackColor = false;
            btnActiveMainScreen.Click += btnActiveMainScreen_Click;
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
            btnActiveCustomerScreen.Location = new Point(0, 102);
            btnActiveCustomerScreen.Margin = new Padding(0);
            btnActiveCustomerScreen.Name = "btnActiveCustomerScreen";
            btnActiveCustomerScreen.Padding = new Padding(6, 0, 0, 0);
            btnActiveCustomerScreen.Size = new Size(230, 50);
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
            btnActiveBakeScreen.Location = new Point(0, 152);
            btnActiveBakeScreen.Margin = new Padding(0);
            btnActiveBakeScreen.Name = "btnActiveBakeScreen";
            btnActiveBakeScreen.Padding = new Padding(6, 0, 0, 0);
            btnActiveBakeScreen.Size = new Size(230, 50);
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
            btnActiveMaterialScreen.Location = new Point(0, 202);
            btnActiveMaterialScreen.Margin = new Padding(0);
            btnActiveMaterialScreen.Name = "btnActiveMaterialScreen";
            btnActiveMaterialScreen.Padding = new Padding(6, 0, 0, 0);
            btnActiveMaterialScreen.Size = new Size(230, 50);
            btnActiveMaterialScreen.TabIndex = 13;
            btnActiveMaterialScreen.Text = "  Nguyên liệu";
            btnActiveMaterialScreen.TextAlign = ContentAlignment.MiddleLeft;
            btnActiveMaterialScreen.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActiveMaterialScreen.UseVisualStyleBackColor = false;
            btnActiveMaterialScreen.Click += btnActiveMaterialScreen_Click;
            // 
            // btnActiveImportInvoceMaterial
            // 
            btnActiveImportInvoceMaterial.AccessibleName = "btnNguyenLieu";
            btnActiveImportInvoceMaterial.BackColor = Color.Transparent;
            btnActiveImportInvoceMaterial.Dock = DockStyle.Top;
            btnActiveImportInvoceMaterial.FlatAppearance.BorderSize = 0;
            btnActiveImportInvoceMaterial.FlatStyle = FlatStyle.Flat;
            btnActiveImportInvoceMaterial.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnActiveImportInvoceMaterial.ForeColor = Color.Black;
            btnActiveImportInvoceMaterial.Image = Properties.Resources.hoadon;
            btnActiveImportInvoceMaterial.ImageAlign = ContentAlignment.MiddleLeft;
            btnActiveImportInvoceMaterial.Location = new Point(0, 252);
            btnActiveImportInvoceMaterial.Margin = new Padding(0);
            btnActiveImportInvoceMaterial.Name = "btnActiveImportInvoceMaterial";
            btnActiveImportInvoceMaterial.Padding = new Padding(6, 0, 0, 0);
            btnActiveImportInvoceMaterial.Size = new Size(230, 50);
            btnActiveImportInvoceMaterial.TabIndex = 15;
            btnActiveImportInvoceMaterial.Text = "  HD nhập nguyên liệu";
            btnActiveImportInvoceMaterial.TextAlign = ContentAlignment.MiddleLeft;
            btnActiveImportInvoceMaterial.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActiveImportInvoceMaterial.UseVisualStyleBackColor = false;
            // 
            // btnActiveExportInvoceMaterial
            // 
            btnActiveExportInvoceMaterial.AccessibleName = "btnNguyenLieu";
            btnActiveExportInvoceMaterial.BackColor = Color.Transparent;
            btnActiveExportInvoceMaterial.Dock = DockStyle.Top;
            btnActiveExportInvoceMaterial.FlatAppearance.BorderSize = 0;
            btnActiveExportInvoceMaterial.FlatStyle = FlatStyle.Flat;
            btnActiveExportInvoceMaterial.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnActiveExportInvoceMaterial.ForeColor = Color.Black;
            btnActiveExportInvoceMaterial.Image = Properties.Resources.hoadon;
            btnActiveExportInvoceMaterial.ImageAlign = ContentAlignment.MiddleLeft;
            btnActiveExportInvoceMaterial.Location = new Point(0, 302);
            btnActiveExportInvoceMaterial.Margin = new Padding(0);
            btnActiveExportInvoceMaterial.Name = "btnActiveExportInvoceMaterial";
            btnActiveExportInvoceMaterial.Padding = new Padding(6, 0, 0, 0);
            btnActiveExportInvoceMaterial.Size = new Size(230, 50);
            btnActiveExportInvoceMaterial.TabIndex = 9;
            btnActiveExportInvoceMaterial.Text = "  HD xuất nguyên liệu";
            btnActiveExportInvoceMaterial.TextAlign = ContentAlignment.MiddleLeft;
            btnActiveExportInvoceMaterial.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActiveExportInvoceMaterial.UseVisualStyleBackColor = false;
            // 
            // btnActiveExportInvoceBake
            // 
            btnActiveExportInvoceBake.AccessibleName = "btnNguyenLieu";
            btnActiveExportInvoceBake.BackColor = Color.Transparent;
            btnActiveExportInvoceBake.Dock = DockStyle.Top;
            btnActiveExportInvoceBake.FlatAppearance.BorderSize = 0;
            btnActiveExportInvoceBake.FlatStyle = FlatStyle.Flat;
            btnActiveExportInvoceBake.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnActiveExportInvoceBake.ForeColor = Color.Black;
            btnActiveExportInvoceBake.Image = Properties.Resources.hoadon;
            btnActiveExportInvoceBake.ImageAlign = ContentAlignment.MiddleLeft;
            btnActiveExportInvoceBake.Location = new Point(0, 352);
            btnActiveExportInvoceBake.Margin = new Padding(0);
            btnActiveExportInvoceBake.Name = "btnActiveExportInvoceBake";
            btnActiveExportInvoceBake.Padding = new Padding(6, 0, 0, 0);
            btnActiveExportInvoceBake.Size = new Size(230, 50);
            btnActiveExportInvoceBake.TabIndex = 16;
            btnActiveExportInvoceBake.Text = "  HD xuất bánh";
            btnActiveExportInvoceBake.TextAlign = ContentAlignment.MiddleLeft;
            btnActiveExportInvoceBake.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActiveExportInvoceBake.UseVisualStyleBackColor = false;
            // 
            // btnActiveImportInvoceBake
            // 
            btnActiveImportInvoceBake.AccessibleName = "btnNguyenLieu";
            btnActiveImportInvoceBake.BackColor = Color.Transparent;
            btnActiveImportInvoceBake.Dock = DockStyle.Top;
            btnActiveImportInvoceBake.FlatAppearance.BorderSize = 0;
            btnActiveImportInvoceBake.FlatStyle = FlatStyle.Flat;
            btnActiveImportInvoceBake.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnActiveImportInvoceBake.ForeColor = Color.Black;
            btnActiveImportInvoceBake.Image = Properties.Resources.hoadon;
            btnActiveImportInvoceBake.ImageAlign = ContentAlignment.MiddleLeft;
            btnActiveImportInvoceBake.Location = new Point(0, 402);
            btnActiveImportInvoceBake.Margin = new Padding(0);
            btnActiveImportInvoceBake.Name = "btnActiveImportInvoceBake";
            btnActiveImportInvoceBake.Padding = new Padding(6, 0, 0, 0);
            btnActiveImportInvoceBake.Size = new Size(230, 50);
            btnActiveImportInvoceBake.TabIndex = 17;
            btnActiveImportInvoceBake.Text = "  HD nhập bánh";
            btnActiveImportInvoceBake.TextAlign = ContentAlignment.MiddleLeft;
            btnActiveImportInvoceBake.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActiveImportInvoceBake.UseVisualStyleBackColor = false;
            // 
            // btnActiveDecentrialtion
            // 
            btnActiveDecentrialtion.AccessibleName = "";
            btnActiveDecentrialtion.BackColor = Color.Transparent;
            btnActiveDecentrialtion.Dock = DockStyle.Top;
            btnActiveDecentrialtion.FlatAppearance.BorderSize = 0;
            btnActiveDecentrialtion.FlatStyle = FlatStyle.Flat;
            btnActiveDecentrialtion.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnActiveDecentrialtion.ForeColor = Color.Black;
            btnActiveDecentrialtion.Image = Properties.Resources.authentication;
            btnActiveDecentrialtion.ImageAlign = ContentAlignment.MiddleLeft;
            btnActiveDecentrialtion.Location = new Point(0, 452);
            btnActiveDecentrialtion.Margin = new Padding(0);
            btnActiveDecentrialtion.Name = "btnActiveDecentrialtion";
            btnActiveDecentrialtion.Padding = new Padding(6, 0, 0, 0);
            btnActiveDecentrialtion.Size = new Size(230, 50);
            btnActiveDecentrialtion.TabIndex = 14;
            btnActiveDecentrialtion.Text = "  Phân quyền";
            btnActiveDecentrialtion.TextAlign = ContentAlignment.MiddleLeft;
            btnActiveDecentrialtion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActiveDecentrialtion.UseVisualStyleBackColor = false;
            btnActiveDecentrialtion.Click += btnActiveDecentrialtion_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(623, 18);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(144, 18);
            label3.TabIndex = 1;
            label3.Text = "Xin Chào, Admin";
            // 
            // panelMainForm
            // 
            panelMainForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMainForm.BackColor = Color.FromArgb(241, 246, 249);
            panelMainForm.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panelMainForm.Location = new Point(230, 52);
            panelMainForm.Margin = new Padding(0);
            panelMainForm.Name = "panelMainForm";
            panelMainForm.Size = new Size(906, 543);
            panelMainForm.TabIndex = 2;
            // 
            // panelHeader
            // 
            panelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelHeader.Controls.Add(buttonCustom1);
            panelHeader.Controls.Add(btnMenu);
            panelHeader.Controls.Add(label3);
            panelHeader.Controls.Add(labelActiveBar);
            panelHeader.Location = new Point(230, 0);
            panelHeader.Margin = new Padding(0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(906, 52);
            panelHeader.TabIndex = 3;
            // 
            // buttonCustom1
            // 
            buttonCustom1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCustom1.BackColor = Color.LightSkyBlue;
            buttonCustom1.BackgroundColor = Color.LightSkyBlue;
            buttonCustom1.BorderColor = Color.PaleVioletRed;
            buttonCustom1.BorderRadius = 6;
            buttonCustom1.BorderSize = 0;
            buttonCustom1.FlatAppearance.BorderSize = 0;
            buttonCustom1.FlatStyle = FlatStyle.Flat;
            buttonCustom1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCustom1.ForeColor = Color.White;
            buttonCustom1.Location = new Point(780, 7);
            buttonCustom1.Name = "buttonCustom1";
            buttonCustom1.Size = new Size(104, 39);
            buttonCustom1.TabIndex = 0;
            buttonCustom1.Text = "Đăng xuất";
            buttonCustom1.TextColor = Color.White;
            buttonCustom1.UseVisualStyleBackColor = false;
            buttonCustom1.Click += buttonCustom1_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.White;
            btnMenu.BackgroundColor = Color.White;
            btnMenu.BorderColor = Color.PaleVioletRed;
            btnMenu.BorderRadius = 8;
            btnMenu.BorderSize = 0;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.ForeColor = Color.White;
            btnMenu.Image = Properties.Resources.icons8_menu_241;
            btnMenu.Location = new Point(3, 10);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(46, 32);
            btnMenu.TabIndex = 0;
            btnMenu.TextColor = Color.White;
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // labelActiveBar
            // 
            labelActiveBar.Anchor = AnchorStyles.Left;
            labelActiveBar.AutoSize = true;
            labelActiveBar.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelActiveBar.Location = new Point(52, 18);
            labelActiveBar.Margin = new Padding(0);
            labelActiveBar.Name = "labelActiveBar";
            labelActiveBar.Size = new Size(131, 18);
            labelActiveBar.TabIndex = 0;
            labelActiveBar.Text = "Màn hình chính";
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
        private Button btnActiveExportInvoceMaterial;
        private Panel panelText;
        private Button button12;
        private Button button11;
        private Button button10;

        private Label label3;
        private Panel panelHeader;
        private Panel panel1;
        private Button btnActiveImportInvoceBake;
        private Panel panel4;
        private Button button5;
        private Button button9;
        private Panel panel;
        private Button button1;
        private ComponentCustom.ButtonCustom btnMenu;
        private Label labelActiveBar;
        private ComponentCustom.ButtonCustom buttonCustom1;
        private Button btnActiveDecentrialtion;
        private Button btnActiveImportInvoceMaterial;
        private Button btnActiveExportInvoceBake;
    }


}