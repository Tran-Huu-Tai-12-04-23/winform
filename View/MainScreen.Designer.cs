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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelFlowSidebar = new FlowLayoutPanel();
            panel3 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            btnActiveMainScreen = new Button();
            btnActiveCustomerScreen = new Button();
            btnActiveBakeScreen = new Button();
            btnActiveMaterialScreen = new Button();
            btnActiveDecentrialtion = new Button();
            btnActiveManagerInvoce = new Button();
            label3 = new Label();
            panelMainForm = new Panel();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel9 = new Panel();
            label10 = new Label();
            label11 = new Label();
            panel10 = new Panel();
            label12 = new Label();
            label13 = new Label();
            panel11 = new Panel();
            label14 = new Label();
            label15 = new Label();
            panel12 = new Panel();
            label16 = new Label();
            label17 = new Label();
            panel8 = new Panel();
            label8 = new Label();
            label9 = new Label();
            panel7 = new Panel();
            label6 = new Label();
            label7 = new Label();
            panel6 = new Panel();
            label4 = new Label();
            label5 = new Label();
            panel5 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panelHeader = new Panel();
            buttonCustom1 = new ComponentCustom.ButtonCustom();
            btnMenu = new ComponentCustom.ButtonCustom();
            labelActiveBar = new Label();
            panelFlowSidebar.SuspendLayout();
            panel3.SuspendLayout();
            panelMainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
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
            panelFlowSidebar.Controls.Add(btnActiveManagerInvoce);
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
            btnActiveMainScreen.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
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
            btnActiveCustomerScreen.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
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
            btnActiveBakeScreen.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
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
            btnActiveMaterialScreen.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
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
            // btnActiveManagerInvoce
            // 
            btnActiveManagerInvoce.AccessibleName = "btnNguyenLieu";
            btnActiveManagerInvoce.BackColor = Color.Transparent;
            btnActiveManagerInvoce.Dock = DockStyle.Top;
            btnActiveManagerInvoce.FlatAppearance.BorderSize = 0;
            btnActiveManagerInvoce.FlatStyle = FlatStyle.Flat;
            btnActiveManagerInvoce.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnActiveManagerInvoce.ForeColor = Color.Black;
            btnActiveManagerInvoce.Image = Properties.Resources.hoadon;
            btnActiveManagerInvoce.ImageAlign = ContentAlignment.MiddleLeft;
            btnActiveManagerInvoce.Location = new Point(0, 252);
            btnActiveManagerInvoce.Margin = new Padding(0);
            btnActiveManagerInvoce.Name = "btnActiveManagerInvoce";
            btnActiveManagerInvoce.Padding = new Padding(6, 0, 0, 0);
            btnActiveManagerInvoce.Size = new Size(230, 50);
            btnActiveManagerInvoce.TabIndex = 15;
            btnActiveManagerInvoce.Text = "  Quản lý hóa đơn";
            btnActiveManagerInvoce.TextAlign = ContentAlignment.MiddleLeft;
            btnActiveManagerInvoce.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActiveManagerInvoce.UseVisualStyleBackColor = false;
            btnActiveManagerInvoce.Click += btnActiveManagerInvoce_click;
            // 
            // btnActiveDecentrialtion
            // 
            btnActiveDecentrialtion.AccessibleName = "";
            btnActiveDecentrialtion.BackColor = Color.Transparent;
            btnActiveDecentrialtion.Dock = DockStyle.Top;
            btnActiveDecentrialtion.FlatAppearance.BorderSize = 0;
            btnActiveDecentrialtion.FlatStyle = FlatStyle.Flat;
            btnActiveDecentrialtion.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnActiveDecentrialtion.ForeColor = Color.Black;
            btnActiveDecentrialtion.Image = Properties.Resources.authentication;
            btnActiveDecentrialtion.ImageAlign = ContentAlignment.MiddleLeft;
            btnActiveDecentrialtion.Location = new Point(0, 302);
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
            label3.Location = new Point(871, 18);
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
            panelMainForm.Controls.Add(chart1);
            panelMainForm.Controls.Add(panel9);
            panelMainForm.Controls.Add(panel10);
            panelMainForm.Controls.Add(panel11);
            panelMainForm.Controls.Add(panel12);
            panelMainForm.Controls.Add(panel8);
            panelMainForm.Controls.Add(panel7);
            panelMainForm.Controls.Add(panel6);
            panelMainForm.Controls.Add(panel5);
            panelMainForm.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panelMainForm.Location = new Point(230, 52);
            panelMainForm.Margin = new Padding(0);
            panelMainForm.Name = "panelMainForm";
            panelMainForm.Size = new Size(1154, 709);
            panelMainForm.TabIndex = 2;
            // 
            // chart1
            // 
            chart1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(17, 243);
            chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart1.Series.Add(series2);
            chart1.Size = new Size(1115, 454);
            chart1.TabIndex = 10;
            chart1.Text = "chart1";
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(128, 255, 255);
            panel9.Controls.Add(label10);
            panel9.Controls.Add(label11);
            panel9.Location = new Point(669, 131);
            panel9.Name = "panel9";
            panel9.Size = new Size(195, 100);
            panel9.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(54, 52);
            label10.Name = "label10";
            label10.Size = new Size(91, 19);
            label10.TabIndex = 1;
            label10.Text = "400.00 vnd";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(54, 17);
            label11.Name = "label11";
            label11.Size = new Size(84, 19);
            label11.TabIndex = 0;
            label11.Text = "Doanh thu";
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(128, 255, 255);
            panel10.Controls.Add(label12);
            panel10.Controls.Add(label13);
            panel10.Location = new Point(451, 131);
            panel10.Name = "panel10";
            panel10.Size = new Size(195, 100);
            panel10.TabIndex = 8;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(54, 52);
            label12.Name = "label12";
            label12.Size = new Size(91, 19);
            label12.TabIndex = 1;
            label12.Text = "400.00 vnd";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(54, 17);
            label13.Name = "label13";
            label13.Size = new Size(84, 19);
            label13.TabIndex = 0;
            label13.Text = "Doanh thu";
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(128, 255, 255);
            panel11.Controls.Add(label14);
            panel11.Controls.Add(label15);
            panel11.Location = new Point(232, 131);
            panel11.Name = "panel11";
            panel11.Size = new Size(195, 100);
            panel11.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(54, 52);
            label14.Name = "label14";
            label14.Size = new Size(91, 19);
            label14.TabIndex = 1;
            label14.Text = "400.00 vnd";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(54, 17);
            label15.Name = "label15";
            label15.Size = new Size(84, 19);
            label15.TabIndex = 0;
            label15.Text = "Doanh thu";
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(128, 255, 255);
            panel12.Controls.Add(label16);
            panel12.Controls.Add(label17);
            panel12.Location = new Point(17, 131);
            panel12.Name = "panel12";
            panel12.Size = new Size(195, 100);
            panel12.TabIndex = 6;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(54, 52);
            label16.Name = "label16";
            label16.Size = new Size(91, 19);
            label16.TabIndex = 1;
            label16.Text = "400.00 vnd";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(54, 17);
            label17.Name = "label17";
            label17.Size = new Size(84, 19);
            label17.TabIndex = 0;
            label17.Text = "Doanh thu";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(128, 255, 255);
            panel8.Controls.Add(label8);
            panel8.Controls.Add(label9);
            panel8.Location = new Point(669, 14);
            panel8.Name = "panel8";
            panel8.Size = new Size(195, 100);
            panel8.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(54, 52);
            label8.Name = "label8";
            label8.Size = new Size(91, 19);
            label8.TabIndex = 1;
            label8.Text = "400.00 vnd";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(54, 17);
            label9.Name = "label9";
            label9.Size = new Size(84, 19);
            label9.TabIndex = 0;
            label9.Text = "Doanh thu";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(128, 255, 255);
            panel7.Controls.Add(label6);
            panel7.Controls.Add(label7);
            panel7.Location = new Point(451, 14);
            panel7.Name = "panel7";
            panel7.Size = new Size(195, 100);
            panel7.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 52);
            label6.Name = "label6";
            label6.Size = new Size(91, 19);
            label6.TabIndex = 1;
            label6.Text = "400.00 vnd";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(54, 17);
            label7.Name = "label7";
            label7.Size = new Size(84, 19);
            label7.TabIndex = 0;
            label7.Text = "Doanh thu";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(128, 255, 255);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(232, 14);
            panel6.Name = "panel6";
            panel6.Size = new Size(195, 100);
            panel6.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 52);
            label4.Name = "label4";
            label4.Size = new Size(91, 19);
            label4.TabIndex = 1;
            label4.Text = "400.00 vnd";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 17);
            label5.Name = "label5";
            label5.Size = new Size(84, 19);
            label5.TabIndex = 0;
            label5.Text = "Doanh thu";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(128, 255, 255);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(17, 14);
            panel5.Name = "panel5";
            panel5.Size = new Size(195, 100);
            panel5.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 52);
            label2.Name = "label2";
            label2.Size = new Size(91, 19);
            label2.TabIndex = 1;
            label2.Text = "400.00 vnd";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 17);
            label1.Name = "label1";
            label1.Size = new Size(84, 19);
            label1.TabIndex = 0;
            label1.Text = "Doanh thu";
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
            panelHeader.Size = new Size(1154, 52);
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
            buttonCustom1.Location = new Point(1028, 7);
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
            ClientSize = new Size(1384, 761);
            Controls.Add(panelHeader);
            Controls.Add(panelMainForm);
            Controls.Add(panelFlowSidebar);
            HelpButton = true;
            MinimumSize = new Size(1400, 800);
            Name = "Form1";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            panelFlowSidebar.ResumeLayout(false);
            panelFlowSidebar.PerformLayout();
            panel3.ResumeLayout(false);
            panelMainForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
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
        private Panel panelText;
        private Button button12;
        private Button button11;
        private Button button10;

        private Label label3;
        private Panel panelHeader;
        private Panel panel1;
        private Panel panel4;
        private Button button5;
        private Button button9;
        private Panel panel;
        private Button button1;
        private ComponentCustom.ButtonCustom btnMenu;
        private Label labelActiveBar;
        private ComponentCustom.ButtonCustom buttonCustom1;
        private Button btnActiveDecentrialtion;
        private Button btnActiveManagerInvoce;
        private Panel panel9;
        private Label label10;
        private Label label11;
        private Panel panel10;
        private Label label12;
        private Label label13;
        private Panel panel11;
        private Label label14;
        private Label label15;
        private Panel panel12;
        private Label label16;
        private Label label17;
        private Panel panel8;
        private Label label8;
        private Label label9;
        private Panel panel7;
        private Label label6;
        private Label label7;
        private Panel panel6;
        private Label label4;
        private Label label5;
        private Panel panel5;
        private Label label2;
        private Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }


}