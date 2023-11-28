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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelFlowSidebar = new FlowLayoutPanel();
            panel3 = new Panel();
            bntHome = new Button();
            panel2 = new Panel();
            btnActiveMainScreen = new Button();
            btnActiveCustomerScreen = new Button();
            btnActiveBakeScreen = new Button();
            btnActiveMaterialScreen = new Button();
            btnActiveManagerInvoce = new Button();
            btnActiveDecentrialtion = new Button();
            panelMainForm = new Panel();
            panel9 = new Panel();
            chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btn1 = new ComponentCustom.ButtonCustom();
            btn2 = new ComponentCustom.ButtonCustom();
            pickDateStart = new ComponentCustom.RJDatePicker();
            btn3 = new ComponentCustom.ButtonCustom();
            pickDateEnd = new ComponentCustom.RJDatePicker();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel5 = new Panel();
            btn4 = new ComponentCustom.ButtonCustom();
            lbTonKhoBanh = new Label();
            label1 = new Label();
            panel6 = new Panel();
            btn5 = new ComponentCustom.ButtonCustom();
            lbTonKhoNguyenLieu = new Label();
            label5 = new Label();
            panel1 = new Panel();
            btn6 = new ComponentCustom.ButtonCustom();
            lbTotalExportMaterial = new Label();
            lb3 = new Label();
            panel4 = new Panel();
            btn7 = new ComponentCustom.ButtonCustom();
            label7 = new Label();
            label8 = new Label();
            panel7 = new Panel();
            btn8 = new ComponentCustom.ButtonCustom();
            lbTotalExportBake = new Label();
            lb5 = new Label();
            panel8 = new Panel();
            btn9 = new ComponentCustom.ButtonCustom();
            label9 = new Label();
            label10 = new Label();
            panelHeader = new Panel();
            btnExit = new ComponentCustom.ButtonCustom();
            labelActiveBar = new Label();
            btnMenu = new ComponentCustom.ButtonCustom();
            panelFlowSidebar.SuspendLayout();
            panel3.SuspendLayout();
            panelMainForm.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelFlowSidebar
            // 
            panelFlowSidebar.AutoScroll = true;
            panelFlowSidebar.BackColor = Color.FromArgb(20, 27, 31);
            panelFlowSidebar.Controls.Add(panel3);
            panelFlowSidebar.Controls.Add(panel2);
            panelFlowSidebar.Controls.Add(btnActiveMainScreen);
            panelFlowSidebar.Controls.Add(btnActiveCustomerScreen);
            panelFlowSidebar.Controls.Add(btnActiveBakeScreen);
            panelFlowSidebar.Controls.Add(btnActiveMaterialScreen);
            panelFlowSidebar.Controls.Add(btnActiveManagerInvoce);
            panelFlowSidebar.Controls.Add(btnActiveDecentrialtion);
            panelFlowSidebar.Dock = DockStyle.Left;
            panelFlowSidebar.FlowDirection = FlowDirection.TopDown;
            panelFlowSidebar.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panelFlowSidebar.ForeColor = SystemColors.Control;
            panelFlowSidebar.Location = new Point(0, 0);
            panelFlowSidebar.Margin = new Padding(0);
            panelFlowSidebar.MaximumSize = new Size(230, 975);
            panelFlowSidebar.MinimumSize = new Size(50, 595);
            panelFlowSidebar.Name = "panelFlowSidebar";
            panelFlowSidebar.Size = new Size(230, 761);
            panelFlowSidebar.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(bntHome);
            panel3.ForeColor = SystemColors.Control;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 46);
            panel3.TabIndex = 5;
            // 
            // bntHome
            // 
            bntHome.AccessibleName = "";
            bntHome.BackColor = Color.Transparent;
            bntHome.Dock = DockStyle.Top;
            bntHome.FlatAppearance.BorderSize = 0;
            bntHome.FlatStyle = FlatStyle.Flat;
            bntHome.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bntHome.ForeColor = SystemColors.ActiveBorder;
            bntHome.Image = Properties.Resources.icons8_online_store_40;
            bntHome.ImageAlign = ContentAlignment.MiddleLeft;
            bntHome.Location = new Point(0, 0);
            bntHome.Margin = new Padding(0);
            bntHome.Name = "bntHome";
            bntHome.Size = new Size(230, 50);
            bntHome.TabIndex = 12;
            bntHome.Text = "   Quản lý";
            bntHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            bntHome.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoSize = true;
            panel2.BackColor = Color.Silver;
            panel2.ForeColor = SystemColors.Control;
            panel2.Location = new Point(3, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(224, 0);
            panel2.TabIndex = 1;
            // 
            // btnActiveMainScreen
            // 
            btnActiveMainScreen.AccessibleName = "";
            btnActiveMainScreen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnActiveMainScreen.BackColor = Color.Transparent;
            btnActiveMainScreen.FlatAppearance.BorderSize = 0;
            btnActiveMainScreen.FlatStyle = FlatStyle.Flat;
            btnActiveMainScreen.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnActiveMainScreen.ForeColor = SystemColors.Control;
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
            btnActiveCustomerScreen.ForeColor = SystemColors.Control;
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
            btnActiveBakeScreen.ForeColor = SystemColors.Control;
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
            btnActiveMaterialScreen.ForeColor = SystemColors.Control;
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
            btnActiveManagerInvoce.ForeColor = SystemColors.Control;
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
            btnActiveDecentrialtion.ForeColor = SystemColors.Control;
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
            // panelMainForm
            // 
            panelMainForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMainForm.BackColor = Color.FromArgb(28, 38, 45);
            panelMainForm.Controls.Add(panel9);
            panelMainForm.Controls.Add(flowLayoutPanel2);
            panelMainForm.Controls.Add(flowLayoutPanel1);
            panelMainForm.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panelMainForm.Location = new Point(230, 52);
            panelMainForm.Margin = new Padding(0);
            panelMainForm.Name = "panelMainForm";
            panelMainForm.Size = new Size(1154, 709);
            panelMainForm.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel9.BackColor = Color.Transparent;
            panel9.Controls.Add(chart);
            panel9.Location = new Point(17, 356);
            panel9.Name = "panel9";
            panel9.Size = new Size(1115, 341);
            panel9.TabIndex = 13;
            // 
            // chart
            // 
            chart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart.Legends.Add(legend1);
            chart.Location = new Point(1, 0);
            chart.Margin = new Padding(0, 40, 0, 0);
            chart.MinimumSize = new Size(1112, 300);
            chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart.Series.Add(series1);
            chart.Size = new Size(1112, 341);
            chart.TabIndex = 9;
            chart.Text = "chart1";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btn1);
            flowLayoutPanel2.Controls.Add(btn2);
            flowLayoutPanel2.Controls.Add(pickDateStart);
            flowLayoutPanel2.Controls.Add(btn3);
            flowLayoutPanel2.Controls.Add(pickDateEnd);
            flowLayoutPanel2.Location = new Point(17, 4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1115, 40);
            flowLayoutPanel2.TabIndex = 12;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Transparent;
            btn1.BackgroundColor = Color.Transparent;
            btn1.BorderColor = Color.PaleVioletRed;
            btn1.BorderRadius = 20;
            btn1.BorderSize = 0;
            btn1.FlatAppearance.BorderSize = 0;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.ForeColor = Color.White;
            btn1.Location = new Point(3, 3);
            btn1.Name = "btn1";
            btn1.Size = new Size(117, 34);
            btn1.TabIndex = 0;
            btn1.Text = "Thống kê";
            btn1.TextColor = Color.White;
            btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Transparent;
            btn2.BackgroundColor = Color.Transparent;
            btn2.BorderColor = Color.PaleVioletRed;
            btn2.BorderRadius = 20;
            btn2.BorderSize = 0;
            btn2.FlatAppearance.BorderSize = 0;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.ForeColor = Color.White;
            btn2.Location = new Point(126, 3);
            btn2.Name = "btn2";
            btn2.Size = new Size(117, 34);
            btn2.TabIndex = 1;
            btn2.Text = "Từ : ";
            btn2.TextColor = Color.White;
            btn2.UseVisualStyleBackColor = false;
            // 
            // pickDateStart
            // 
            pickDateStart.BorderColor = Color.PaleVioletRed;
            pickDateStart.BorderSize = 0;
            pickDateStart.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            pickDateStart.Location = new Point(249, 3);
            pickDateStart.MinimumSize = new Size(4, 35);
            pickDateStart.Name = "pickDateStart";
            pickDateStart.Size = new Size(272, 35);
            pickDateStart.SkinColor = Color.FromArgb(39, 52, 62);
            pickDateStart.TabIndex = 41;
            pickDateStart.TextColor = Color.White;
            pickDateStart.ValueChanged += pickDateStart_ValueChanged_1;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Transparent;
            btn3.BackgroundColor = Color.Transparent;
            btn3.BorderColor = Color.PaleVioletRed;
            btn3.BorderRadius = 20;
            btn3.BorderSize = 0;
            btn3.FlatAppearance.BorderSize = 0;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.ForeColor = Color.White;
            btn3.Location = new Point(527, 3);
            btn3.Name = "btn3";
            btn3.Size = new Size(117, 34);
            btn3.TabIndex = 2;
            btn3.Text = "Đến : ";
            btn3.TextColor = Color.White;
            btn3.UseVisualStyleBackColor = false;
            // 
            // pickDateEnd
            // 
            pickDateEnd.BorderColor = Color.PaleVioletRed;
            pickDateEnd.BorderSize = 0;
            pickDateEnd.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            pickDateEnd.Location = new Point(650, 3);
            pickDateEnd.MinimumSize = new Size(4, 35);
            pickDateEnd.Name = "pickDateEnd";
            pickDateEnd.Size = new Size(272, 35);
            pickDateEnd.SkinColor = Color.FromArgb(39, 52, 62);
            pickDateEnd.TabIndex = 42;
            pickDateEnd.TextColor = Color.White;
            pickDateEnd.ValueChanged += pickDateEnd_ValueChanged_1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel7);
            flowLayoutPanel1.Controls.Add(panel8);
            flowLayoutPanel1.Location = new Point(17, 50);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1116, 300);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(32, 42, 49);
            panel5.Controls.Add(btn4);
            panel5.Controls.Add(lbTonKhoBanh);
            panel5.Controls.Add(label1);
            panel5.ForeColor = Color.White;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(267, 144);
            panel5.TabIndex = 2;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Transparent;
            btn4.BackgroundColor = Color.Transparent;
            btn4.BorderColor = Color.PaleVioletRed;
            btn4.BorderRadius = 20;
            btn4.BorderSize = 0;
            btn4.FlatAppearance.BorderSize = 0;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.ForeColor = Color.White;
            btn4.Image = Properties.Resources.icons8_inventory_32;
            btn4.Location = new Point(3, 10);
            btn4.Name = "btn4";
            btn4.Size = new Size(49, 45);
            btn4.TabIndex = 3;
            btn4.Text = "Đến : ";
            btn4.TextColor = Color.White;
            btn4.UseVisualStyleBackColor = false;
            // 
            // lbTonKhoBanh
            // 
            lbTonKhoBanh.AutoSize = true;
            lbTonKhoBanh.ForeColor = Color.White;
            lbTonKhoBanh.Location = new Point(66, 52);
            lbTonKhoBanh.Name = "lbTonKhoBanh";
            lbTonKhoBanh.Size = new Size(94, 19);
            lbTonKhoBanh.TabIndex = 1;
            lbTonKhoBanh.Text = "400 hóa đơn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(66, 17);
            label1.Name = "label1";
            label1.Size = new Size(141, 19);
            label1.TabIndex = 0;
            label1.Text = "Tổng tồn kho bánh";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(32, 42, 49);
            panel6.Controls.Add(btn5);
            panel6.Controls.Add(lbTonKhoNguyenLieu);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(276, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(267, 144);
            panel6.TabIndex = 3;
            // 
            // btn5
            // 
            btn5.BackColor = Color.Transparent;
            btn5.BackgroundColor = Color.Transparent;
            btn5.BorderColor = Color.PaleVioletRed;
            btn5.BorderRadius = 20;
            btn5.BorderSize = 0;
            btn5.FlatAppearance.BorderSize = 0;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.ForeColor = Color.White;
            btn5.Image = Properties.Resources.icons8_inventory_32;
            btn5.Location = new Point(14, 10);
            btn5.Name = "btn5";
            btn5.Size = new Size(49, 45);
            btn5.TabIndex = 4;
            btn5.Text = "Đến : ";
            btn5.TextColor = Color.White;
            btn5.UseVisualStyleBackColor = false;
            // 
            // lbTonKhoNguyenLieu
            // 
            lbTonKhoNguyenLieu.AutoSize = true;
            lbTonKhoNguyenLieu.ForeColor = Color.White;
            lbTonKhoNguyenLieu.Location = new Point(66, 44);
            lbTonKhoNguyenLieu.Name = "lbTonKhoNguyenLieu";
            lbTonKhoNguyenLieu.Size = new Size(94, 19);
            lbTonKhoNguyenLieu.TabIndex = 1;
            lbTonKhoNguyenLieu.Text = "400 hóa đơn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(66, 10);
            label5.Name = "label5";
            label5.Size = new Size(187, 19);
            label5.TabIndex = 0;
            label5.Text = "Tổng tồn kho nguyên liệu";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(32, 42, 49);
            panel1.Controls.Add(btn6);
            panel1.Controls.Add(lbTotalExportMaterial);
            panel1.Controls.Add(lb3);
            panel1.Location = new Point(549, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 144);
            panel1.TabIndex = 4;
            // 
            // btn6
            // 
            btn6.BackColor = Color.Transparent;
            btn6.BackgroundColor = Color.Transparent;
            btn6.BorderColor = Color.PaleVioletRed;
            btn6.BorderRadius = 20;
            btn6.BorderSize = 0;
            btn6.FlatAppearance.BorderSize = 0;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.ForeColor = Color.White;
            btn6.Image = Properties.Resources.icons8_revenue_32;
            btn6.Location = new Point(3, 4);
            btn6.Name = "btn6";
            btn6.Size = new Size(49, 45);
            btn6.TabIndex = 5;
            btn6.TextColor = Color.White;
            btn6.UseVisualStyleBackColor = false;
            // 
            // lbTotalExportMaterial
            // 
            lbTotalExportMaterial.AutoSize = true;
            lbTotalExportMaterial.ForeColor = Color.White;
            lbTotalExportMaterial.Location = new Point(66, 44);
            lbTotalExportMaterial.Name = "lbTotalExportMaterial";
            lbTotalExportMaterial.Size = new Size(94, 19);
            lbTotalExportMaterial.TabIndex = 1;
            lbTotalExportMaterial.Text = "400 hóa đơn";
            // 
            // lb3
            // 
            lb3.AutoSize = true;
            lb3.ForeColor = Color.White;
            lb3.Location = new Point(66, 10);
            lb3.Name = "lb3";
            lb3.Size = new Size(187, 19);
            lb3.TabIndex = 0;
            lb3.Text = "Tổng tiền thu nguyên liệu";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(32, 42, 49);
            panel4.Controls.Add(btn7);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(822, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(267, 144);
            panel4.TabIndex = 5;
            // 
            // btn7
            // 
            btn7.BackColor = Color.Transparent;
            btn7.BackgroundColor = Color.Transparent;
            btn7.BorderColor = Color.PaleVioletRed;
            btn7.BorderRadius = 20;
            btn7.BorderSize = 0;
            btn7.FlatAppearance.BorderSize = 0;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.ForeColor = Color.White;
            btn7.Image = Properties.Resources.icons8_revenue_32;
            btn7.Location = new Point(7, 4);
            btn7.Name = "btn7";
            btn7.Size = new Size(49, 45);
            btn7.TabIndex = 6;
            btn7.TextColor = Color.White;
            btn7.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(66, 44);
            label7.Name = "label7";
            label7.Size = new Size(94, 19);
            label7.TabIndex = 1;
            label7.Text = "400 hóa đơn";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(62, 13);
            label8.Name = "label8";
            label8.Size = new Size(221, 19);
            label8.TabIndex = 0;
            label8.Text = "Tổng tiền chi mua nguyên liệu";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(32, 42, 49);
            panel7.Controls.Add(btn8);
            panel7.Controls.Add(lbTotalExportBake);
            panel7.Controls.Add(lb5);
            panel7.Location = new Point(3, 153);
            panel7.Name = "panel7";
            panel7.Size = new Size(267, 144);
            panel7.TabIndex = 6;
            // 
            // btn8
            // 
            btn8.BackColor = Color.Transparent;
            btn8.BackgroundColor = Color.Transparent;
            btn8.BorderColor = Color.PaleVioletRed;
            btn8.BorderRadius = 20;
            btn8.BorderSize = 0;
            btn8.FlatAppearance.BorderSize = 0;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.ForeColor = Color.White;
            btn8.Image = Properties.Resources.icons8_revenue_32;
            btn8.Location = new Point(3, 3);
            btn8.Name = "btn8";
            btn8.Size = new Size(49, 45);
            btn8.TabIndex = 6;
            btn8.TextColor = Color.White;
            btn8.UseVisualStyleBackColor = false;
            // 
            // lbTotalExportBake
            // 
            lbTotalExportBake.AutoSize = true;
            lbTotalExportBake.ForeColor = Color.White;
            lbTotalExportBake.Location = new Point(66, 44);
            lbTotalExportBake.Name = "lbTotalExportBake";
            lbTotalExportBake.Size = new Size(94, 19);
            lbTotalExportBake.TabIndex = 1;
            lbTotalExportBake.Text = "400 hóa đơn";
            // 
            // lb5
            // 
            lb5.AutoSize = true;
            lb5.ForeColor = Color.White;
            lb5.Location = new Point(62, 13);
            lb5.Name = "lb5";
            lb5.Size = new Size(141, 19);
            lb5.TabIndex = 0;
            lb5.Text = "Tổng tiền thu bánh";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(32, 42, 49);
            panel8.Controls.Add(btn9);
            panel8.Controls.Add(label9);
            panel8.Controls.Add(label10);
            panel8.Location = new Point(276, 153);
            panel8.Name = "panel8";
            panel8.Size = new Size(267, 144);
            panel8.TabIndex = 7;
            // 
            // btn9
            // 
            btn9.BackColor = Color.Transparent;
            btn9.BackgroundColor = Color.Transparent;
            btn9.BorderColor = Color.PaleVioletRed;
            btn9.BorderRadius = 20;
            btn9.BorderSize = 0;
            btn9.FlatAppearance.BorderSize = 0;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.ForeColor = Color.White;
            btn9.Image = Properties.Resources.icons8_revenue_32;
            btn9.Location = new Point(6, 3);
            btn9.Name = "btn9";
            btn9.Size = new Size(49, 45);
            btn9.TabIndex = 7;
            btn9.TextColor = Color.White;
            btn9.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(66, 44);
            label9.Name = "label9";
            label9.Size = new Size(94, 19);
            label9.TabIndex = 1;
            label9.Text = "400 hóa đơn";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(62, 13);
            label10.Name = "label10";
            label10.Size = new Size(169, 19);
            label10.TabIndex = 0;
            label10.Text = "Tổng tiền chi cho bánh";
            // 
            // panelHeader
            // 
            panelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelHeader.BackColor = Color.FromArgb(20, 27, 31);
            panelHeader.Controls.Add(btnExit);
            panelHeader.Controls.Add(labelActiveBar);
            panelHeader.Controls.Add(btnMenu);
            panelHeader.Location = new Point(230, 0);
            panelHeader.Margin = new Padding(0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1154, 52);
            panelHeader.TabIndex = 3;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.Transparent;
            btnExit.BackgroundColor = Color.Transparent;
            btnExit.BorderColor = Color.PaleVioletRed;
            btnExit.BorderRadius = 20;
            btnExit.BorderSize = 0;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.White;
            btnExit.Image = Properties.Resources.export_out;
            btnExit.Location = new Point(1085, 9);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(58, 34);
            btnExit.TabIndex = 44;
            btnExit.TextColor = Color.White;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // labelActiveBar
            // 
            labelActiveBar.Anchor = AnchorStyles.Left;
            labelActiveBar.AutoSize = true;
            labelActiveBar.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelActiveBar.ForeColor = SystemColors.Control;
            labelActiveBar.Location = new Point(72, 17);
            labelActiveBar.Margin = new Padding(0);
            labelActiveBar.Name = "labelActiveBar";
            labelActiveBar.Size = new Size(131, 18);
            labelActiveBar.TabIndex = 0;
            labelActiveBar.Text = "Màn hình chính";
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Transparent;
            btnMenu.BackgroundColor = Color.Transparent;
            btnMenu.BorderColor = Color.PaleVioletRed;
            btnMenu.BorderRadius = 20;
            btnMenu.BorderSize = 0;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.ForeColor = Color.White;
            btnMenu.Image = Properties.Resources.icons8_menu_24;
            btnMenu.Location = new Point(11, 10);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(58, 34);
            btnMenu.TabIndex = 43;
            btnMenu.TextColor = Color.White;
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(20, 27, 31);
            ClientSize = new Size(1384, 761);
            Controls.Add(panelHeader);
            Controls.Add(panelMainForm);
            Controls.Add(panelFlowSidebar);
            HelpButton = true;
            MinimumSize = new Size(1399, 798);
            Name = "Form1";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            panelFlowSidebar.ResumeLayout(false);
            panelFlowSidebar.PerformLayout();
            panel3.ResumeLayout(false);
            panelMainForm.ResumeLayout(false);
            panelMainForm.PerformLayout();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
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
        private Panel panelHeader;
        private Panel panel1;
        private Panel panel4;
        private Button button5;
        private Button button9;
        private Panel panel;
        private Button bntHome;
        private Label labelActiveBar;
        private Button btnActiveDecentrialtion;
        private Button btnActiveManagerInvoce;
        private Panel panel6;
        private Label lbTonKhoNguyenLieu;
        private Label label5;
        private Panel panel5;
        private Label lbTonKhoBanh;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lbTotalExportMaterial;
        private Label lb3;
        private ComponentCustom.ButtonCustom btnIcon4;
        private Label label7;
        private Label label8;
        private FlowLayoutPanel flowLayoutPanel2;
        private ComponentCustom.RJDatePicker pickDateStart;
        private ComponentCustom.RJDatePicker pickDateEnd;
        private Panel panel7;
        private ComponentCustom.ButtonCustom btn4;
        private Label lbTotalExportBake;
        private Label lb5;
        private Panel panel8;
        private ComponentCustom.ButtonCustom btn5;
        private Label label9;
        private Label label10;
        private ComponentCustom.ButtonCustom btn1;
        private ComponentCustom.ButtonCustom btn2;
        private ComponentCustom.ButtonCustom btn3;
        private ComponentCustom.ButtonCustom btn6;
        private ComponentCustom.ButtonCustom btn7;
        private ComponentCustom.ButtonCustom btn8;
        private ComponentCustom.ButtonCustom btn9;
        private ComponentCustom.ButtonCustom btnMenu;
        private ComponentCustom.ButtonCustom btnExit;
        private Panel panel9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }


}