namespace FinalProject_QUANLYKHO.View.CustomerView
{
    partial class ManagerCustomer
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dataGridViewCustomer = new DataGridView();
            maKhachHang = new DataGridViewTextBoxColumn();
            tenKhachHang = new DataGridViewTextBoxColumn();
            diaChi = new DataGridViewTextBoxColumn();
            soDienThoai = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewCheckBoxColumn();
            Column5 = new DataGridViewImageColumn();
            Column6 = new DataGridViewImageColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel3 = new Panel();
            inputSearch = new TextBox();
            label5Loc = new Label();
            buttonCustom4 = new ComponentCustom.ButtonCustom();
            labelCustomerTitle = new Label();
            bindingSource1 = new BindingSource(components);
            btnSarch = new ComponentCustom.ButtonCustom();
            label2 = new Label();
            label4 = new Label();
            button2 = new Button();
            rjDatePicker1 = new ComponentCustom.RJDatePicker();
            rjToggle1 = new ComponentCustom.RJToggle();
            label3 = new Label();
            button3 = new Button();
            button4 = new Button();
            buttonCustom1 = new ComponentCustom.ButtonCustom();
            btnSearch = new Button();
            button1 = new Button();
            buttonCustom2 = new ComponentCustom.ButtonCustom();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label7 = new Label();
            selectNumberPage = new ComboBox();
            btnPrevPage = new ComponentCustom.ButtonCustom();
            numberPage = new Label();
            btnNextPage = new ComponentCustom.ButtonCustom();
            panel1 = new Panel();
            rjToggle2 = new ComponentCustom.RJToggle();
            btnRemoveSelected = new ComponentCustom.ButtonCustom();
            timerSearch = new System.Windows.Forms.Timer(components);
            rowShowNotification = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewCustomer
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Padding = new Padding(12);
            dataGridViewCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCustomer.BackgroundColor = Color.White;
            dataGridViewCustomer.BorderStyle = BorderStyle.None;
            dataGridViewCustomer.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCustomer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Padding = new Padding(0, 12, 0, 12);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomer.Columns.AddRange(new DataGridViewColumn[] { maKhachHang, tenKhachHang, diaChi, soDienThoai, Column4, Column5, Column6 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle3.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewCustomer.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCustomer.Dock = DockStyle.Fill;
            dataGridViewCustomer.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewCustomer.EnableHeadersVisualStyles = false;
            dataGridViewCustomer.GridColor = Color.White;
            dataGridViewCustomer.Location = new Point(0, 0);
            dataGridViewCustomer.Margin = new Padding(0);
            dataGridViewCustomer.Name = "dataGridViewCustomer";
            dataGridViewCustomer.ReadOnly = true;
            dataGridViewCustomer.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCustomer.RowHeadersWidth = 60;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCustomer.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCustomer.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCustomer.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dataGridViewCustomer.RowTemplate.DefaultCellStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCustomer.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewCustomer.RowTemplate.DefaultCellStyle.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCustomer.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.AliceBlue;
            dataGridViewCustomer.RowTemplate.Height = 60;
            dataGridViewCustomer.RowTemplate.ReadOnly = true;
            dataGridViewCustomer.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridViewCustomer.ShowEditingIcon = false;
            dataGridViewCustomer.Size = new Size(1093, 477);
            dataGridViewCustomer.StandardTab = true;
            dataGridViewCustomer.TabIndex = 0;
            dataGridViewCustomer.CellContentClick += dataGridViewCustomer_CellContentClick;
            dataGridViewCustomer.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // maKhachHang
            // 
            maKhachHang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maKhachHang.HeaderText = "Mã Khách Hàng";
            maKhachHang.MinimumWidth = 6;
            maKhachHang.Name = "maKhachHang";
            maKhachHang.ReadOnly = true;
            // 
            // tenKhachHang
            // 
            tenKhachHang.HeaderText = "Tên Khách Hàng";
            tenKhachHang.MinimumWidth = 6;
            tenKhachHang.Name = "tenKhachHang";
            tenKhachHang.ReadOnly = true;
            // 
            // diaChi
            // 
            diaChi.HeaderText = "Địa Chỉ";
            diaChi.MinimumWidth = 6;
            diaChi.Name = "diaChi";
            diaChi.ReadOnly = true;
            // 
            // soDienThoai
            // 
            soDienThoai.HeaderText = "Số điện thoại";
            soDienThoai.MinimumWidth = 6;
            soDienThoai.Name = "soDienThoai";
            soDienThoai.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Ẩn / hiện";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Resizable = DataGridViewTriState.True;
            Column4.SortMode = DataGridViewColumnSortMode.Automatic;
            Column4.Width = 119;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column5.HeaderText = "Chỉnh Sửa";
            Column5.Image = Properties.Resources.icons8_edit_24;
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Resizable = DataGridViewTriState.True;
            Column5.SortMode = DataGridViewColumnSortMode.Automatic;
            Column5.Width = 128;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column6.HeaderText = "Xóa";
            Column6.Image = Properties.Resources.icons8_remove_24;
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Resizable = DataGridViewTriState.True;
            Column6.SortMode = DataGridViewColumnSortMode.Automatic;
            Column6.Width = 74;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.AutoSize = true;
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(dataGridViewCustomer);
            panel3.Location = new Point(27, 211);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1093, 477);
            panel3.TabIndex = 5;
            // 
            // inputSearch
            // 
            inputSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputSearch.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inputSearch.Location = new Point(318, 67);
            inputSearch.Margin = new Padding(0);
            inputSearch.Name = "inputSearch";
            inputSearch.Size = new Size(643, 32);
            inputSearch.TabIndex = 8;
            inputSearch.TextChanged += yourTextBox_TextChanged;
            // 
            // label5Loc
            // 
            label5Loc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5Loc.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5Loc.ImageAlign = ContentAlignment.MiddleRight;
            label5Loc.Location = new Point(751, 114);
            label5Loc.Margin = new Padding(0);
            label5Loc.Name = "label5Loc";
            label5Loc.Size = new Size(210, 56);
            label5Loc.TabIndex = 27;
            label5Loc.Text = "Chỉ khách hàng hiện";
            label5Loc.TextAlign = ContentAlignment.MiddleRight;
            // 
            // buttonCustom4
            // 
            buttonCustom4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCustom4.BackColor = Color.LightSkyBlue;
            buttonCustom4.BackgroundColor = Color.LightSkyBlue;
            buttonCustom4.BorderColor = Color.PaleVioletRed;
            buttonCustom4.BorderRadius = 0;
            buttonCustom4.BorderSize = 0;
            buttonCustom4.FlatAppearance.BorderSize = 0;
            buttonCustom4.FlatStyle = FlatStyle.Flat;
            buttonCustom4.ForeColor = Color.Black;
            buttonCustom4.Image = Properties.Resources.add1;
            buttonCustom4.Location = new Point(965, 12);
            buttonCustom4.Margin = new Padding(3, 4, 3, 4);
            buttonCustom4.Name = "buttonCustom4";
            buttonCustom4.Size = new Size(128, 37);
            buttonCustom4.TabIndex = 2;
            buttonCustom4.Text = "Thêm";
            buttonCustom4.TextAlign = ContentAlignment.MiddleRight;
            buttonCustom4.TextColor = Color.Black;
            buttonCustom4.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCustom4.UseVisualStyleBackColor = false;
            buttonCustom4.Click += buttonCustom4_Click;
            // 
            // labelCustomerTitle
            // 
            labelCustomerTitle.AutoSize = true;
            labelCustomerTitle.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCustomerTitle.Location = new Point(3, 12);
            labelCustomerTitle.Name = "labelCustomerTitle";
            labelCustomerTitle.Size = new Size(263, 25);
            labelCustomerTitle.TabIndex = 0;
            labelCustomerTitle.Text = "Danh sách khách hàng";
            // 
            // btnSarch
            // 
            btnSarch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSarch.BackColor = Color.LightSkyBlue;
            btnSarch.BackgroundColor = Color.LightSkyBlue;
            btnSarch.BorderColor = Color.PaleVioletRed;
            btnSarch.BorderRadius = 0;
            btnSarch.BorderSize = 0;
            btnSarch.FlatAppearance.BorderSize = 0;
            btnSarch.FlatStyle = FlatStyle.Flat;
            btnSarch.ForeColor = Color.Black;
            btnSarch.Location = new Point(965, 65);
            btnSarch.Margin = new Padding(3, 4, 3, 4);
            btnSarch.Name = "btnSarch";
            btnSarch.Size = new Size(128, 37);
            btnSarch.TabIndex = 7;
            btnSarch.Text = "Làm mới";
            btnSarch.TextColor = Color.Black;
            btnSarch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSarch.UseVisualStyleBackColor = false;
            btnSarch.Click += btnSarch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 65);
            label2.Margin = new Padding(14, 0, 14, 0);
            label2.Name = "label2";
            label2.Size = new Size(250, 25);
            label2.TabIndex = 2;
            label2.Text = "Tìm kiếm khách hàng";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(1326, -37);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(217, 60);
            label4.TabIndex = 26;
            label4.Text = "Trạng thái (Hiện/Ẩn) : ";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Right;
            button2.BackColor = Color.LightSkyBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(1726, -21);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(82, 26);
            button2.TabIndex = 22;
            button2.Text = "Lọc";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // rjDatePicker1
            // 
            rjDatePicker1.Anchor = AnchorStyles.Right;
            rjDatePicker1.BorderColor = Color.Azure;
            rjDatePicker1.BorderSize = 1;
            rjDatePicker1.CalendarFont = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rjDatePicker1.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            rjDatePicker1.Location = new Point(1519, -22);
            rjDatePicker1.MinimumSize = new Size(0, 35);
            rjDatePicker1.Name = "rjDatePicker1";
            rjDatePicker1.Size = new Size(191, 35);
            rjDatePicker1.SkinColor = Color.LightSkyBlue;
            rjDatePicker1.TabIndex = 23;
            rjDatePicker1.TextColor = Color.Black;
            // 
            // rjToggle1
            // 
            rjToggle1.Anchor = AnchorStyles.Right;
            rjToggle1.Location = new Point(1356, -17);
            rjToggle1.Margin = new Padding(0);
            rjToggle1.MinimumSize = new Size(45, 22);
            rjToggle1.Name = "rjToggle1";
            rjToggle1.OffBackColor = Color.Gray;
            rjToggle1.OffToggleColor = Color.Gainsboro;
            rjToggle1.OnBackColor = Color.LightSkyBlue;
            rjToggle1.OnToggleColor = Color.WhiteSmoke;
            rjToggle1.Size = new Size(45, 22);
            rjToggle1.TabIndex = 24;
            rjToggle1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1415, -28);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(101, 45);
            label3.TabIndex = 25;
            label3.Text = "Ngày thêm : ";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.LightSkyBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Image = Properties.Resources.search;
            button3.Location = new Point(2451, 21);
            button3.Name = "button3";
            button3.Size = new Size(142, 27);
            button3.TabIndex = 1;
            button3.Text = "Tìm kiếm";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.BackColor = Color.LightSkyBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Image = Properties.Resources.search;
            button4.Location = new Point(3078, 37);
            button4.Name = "button4";
            button4.Size = new Size(142, 27);
            button4.TabIndex = 1;
            button4.Text = "Tìm kiếm";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            // 
            // buttonCustom1
            // 
            buttonCustom1.Anchor = AnchorStyles.Right;
            buttonCustom1.BackColor = Color.MediumSlateBlue;
            buttonCustom1.BackgroundColor = Color.MediumSlateBlue;
            buttonCustom1.BorderColor = Color.PaleVioletRed;
            buttonCustom1.BorderRadius = 0;
            buttonCustom1.BorderSize = 0;
            buttonCustom1.FlatAppearance.BorderSize = 0;
            buttonCustom1.FlatStyle = FlatStyle.Flat;
            buttonCustom1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCustom1.ForeColor = Color.White;
            buttonCustom1.Image = Properties.Resources.add1;
            buttonCustom1.Location = new Point(1648, -12);
            buttonCustom1.Margin = new Padding(0);
            buttonCustom1.Name = "buttonCustom1";
            buttonCustom1.Size = new Size(145, 30);
            buttonCustom1.TabIndex = 1;
            buttonCustom1.Text = "Thêm khách hàng";
            buttonCustom1.TextAlign = ContentAlignment.MiddleRight;
            buttonCustom1.TextColor = Color.White;
            buttonCustom1.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCustom1.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.LightSkyBlue;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Image = Properties.Resources.search;
            btnSearch.Location = new Point(1651, 21);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(142, 27);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.LightSkyBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = Properties.Resources.search;
            button1.Location = new Point(2272, 37);
            button1.Name = "button1";
            button1.Size = new Size(142, 27);
            button1.TabIndex = 1;
            button1.Text = "Tìm kiếm";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // buttonCustom2
            // 
            buttonCustom2.Anchor = AnchorStyles.Right;
            buttonCustom2.BackColor = Color.MediumSlateBlue;
            buttonCustom2.BackgroundColor = Color.MediumSlateBlue;
            buttonCustom2.BorderColor = Color.PaleVioletRed;
            buttonCustom2.BorderRadius = 0;
            buttonCustom2.BorderSize = 0;
            buttonCustom2.FlatAppearance.BorderSize = 0;
            buttonCustom2.FlatStyle = FlatStyle.Flat;
            buttonCustom2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCustom2.ForeColor = Color.White;
            buttonCustom2.Image = Properties.Resources.add1;
            buttonCustom2.Location = new Point(2438, -19);
            buttonCustom2.Margin = new Padding(0);
            buttonCustom2.Name = "buttonCustom2";
            buttonCustom2.Size = new Size(145, 30);
            buttonCustom2.TabIndex = 1;
            buttonCustom2.Text = "Thêm khách hàng";
            buttonCustom2.TextAlign = ContentAlignment.MiddleRight;
            buttonCustom2.TextColor = Color.White;
            buttonCustom2.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCustom2.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(label7);
            flowLayoutPanel1.Controls.Add(selectNumberPage);
            flowLayoutPanel1.Controls.Add(btnPrevPage);
            flowLayoutPanel1.Controls.Add(numberPage);
            flowLayoutPanel1.Controls.Add(btnNextPage);
            flowLayoutPanel1.Location = new Point(590, 704);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(530, 47);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ImageAlign = ContentAlignment.MiddleRight;
            label7.Location = new Point(0, 2);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(193, 47);
            label7.TabIndex = 32;
            label7.Text = "Số hàng hiển thị : ";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // selectNumberPage
            // 
            selectNumberPage.Anchor = AnchorStyles.None;
            selectNumberPage.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            selectNumberPage.FormattingEnabled = true;
            selectNumberPage.Items.AddRange(new object[] { "10", "20", "30", "40" });
            selectNumberPage.Location = new Point(196, 9);
            selectNumberPage.Margin = new Padding(3, 4, 3, 4);
            selectNumberPage.Name = "selectNumberPage";
            selectNumberPage.Size = new Size(58, 33);
            selectNumberPage.TabIndex = 2;
            selectNumberPage.Tag = "";
            selectNumberPage.SelectedIndexChanged += SelectNumberPage_SelectedIndexChanged;
            // 
            // btnPrevPage
            // 
            btnPrevPage.BackColor = Color.LightSkyBlue;
            btnPrevPage.BackgroundColor = Color.LightSkyBlue;
            btnPrevPage.BorderColor = Color.PaleVioletRed;
            btnPrevPage.BorderRadius = 0;
            btnPrevPage.BorderSize = 0;
            btnPrevPage.FlatAppearance.BorderSize = 0;
            btnPrevPage.FlatStyle = FlatStyle.Flat;
            btnPrevPage.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrevPage.ForeColor = Color.Black;
            btnPrevPage.Location = new Point(260, 4);
            btnPrevPage.Margin = new Padding(3, 4, 3, 4);
            btnPrevPage.Name = "btnPrevPage";
            btnPrevPage.Size = new Size(94, 43);
            btnPrevPage.TabIndex = 1;
            btnPrevPage.Text = "Trước";
            btnPrevPage.TextColor = Color.Black;
            btnPrevPage.UseVisualStyleBackColor = false;
            btnPrevPage.Click += btnPrevPage_Click;
            // 
            // numberPage
            // 
            numberPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            numberPage.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            numberPage.ForeColor = SystemColors.HotTrack;
            numberPage.Location = new Point(357, 2);
            numberPage.Margin = new Padding(0);
            numberPage.Name = "numberPage";
            numberPage.Size = new Size(74, 49);
            numberPage.TabIndex = 34;
            numberPage.Text = "1";
            numberPage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNextPage
            // 
            btnNextPage.BackColor = Color.LightSkyBlue;
            btnNextPage.BackgroundColor = Color.LightSkyBlue;
            btnNextPage.BorderColor = Color.PaleVioletRed;
            btnNextPage.BorderRadius = 0;
            btnNextPage.BorderSize = 0;
            btnNextPage.FlatAppearance.BorderSize = 0;
            btnNextPage.FlatStyle = FlatStyle.Flat;
            btnNextPage.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNextPage.ForeColor = Color.Black;
            btnNextPage.Location = new Point(434, 4);
            btnNextPage.Margin = new Padding(3, 4, 3, 4);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(90, 43);
            btnNextPage.TabIndex = 0;
            btnNextPage.Text = "Sau";
            btnNextPage.TextColor = Color.Black;
            btnNextPage.UseVisualStyleBackColor = false;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(rjToggle2);
            panel1.Controls.Add(inputSearch);
            panel1.Controls.Add(btnSarch);
            panel1.Controls.Add(buttonCustom4);
            panel1.Controls.Add(labelCustomerTitle);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5Loc);
            panel1.Location = new Point(27, 20);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1096, 172);
            panel1.TabIndex = 8;
            // 
            // rjToggle2
            // 
            rjToggle2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rjToggle2.AutoSize = true;
            rjToggle2.Location = new Point(997, 132);
            rjToggle2.Margin = new Padding(3, 4, 3, 4);
            rjToggle2.MinimumSize = new Size(51, 29);
            rjToggle2.Name = "rjToggle2";
            rjToggle2.OffBackColor = Color.Gray;
            rjToggle2.OffToggleColor = Color.Gainsboro;
            rjToggle2.OnBackColor = Color.LightSkyBlue;
            rjToggle2.OnToggleColor = Color.WhiteSmoke;
            rjToggle2.Size = new Size(51, 29);
            rjToggle2.TabIndex = 28;
            rjToggle2.UseVisualStyleBackColor = true;
            rjToggle2.CheckedChanged += rjToggle2_CheckedChanged;
            // 
            // btnRemoveSelected
            // 
            btnRemoveSelected.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRemoveSelected.BackColor = Color.LightSkyBlue;
            btnRemoveSelected.BackgroundColor = Color.LightSkyBlue;
            btnRemoveSelected.BorderColor = Color.PaleVioletRed;
            btnRemoveSelected.BorderRadius = 0;
            btnRemoveSelected.BorderSize = 0;
            btnRemoveSelected.FlatAppearance.BorderSize = 0;
            btnRemoveSelected.FlatStyle = FlatStyle.Flat;
            btnRemoveSelected.ForeColor = Color.Black;
            btnRemoveSelected.Image = Properties.Resources.icons8_remove_20;
            btnRemoveSelected.Location = new Point(27, 704);
            btnRemoveSelected.Margin = new Padding(3, 4, 3, 4);
            btnRemoveSelected.Name = "btnRemoveSelected";
            btnRemoveSelected.Size = new Size(297, 43);
            btnRemoveSelected.TabIndex = 10;
            btnRemoveSelected.Text = "   Xóa tất cả khách hàng đã chọn";
            btnRemoveSelected.TextAlign = ContentAlignment.MiddleRight;
            btnRemoveSelected.TextColor = Color.Black;
            btnRemoveSelected.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRemoveSelected.UseVisualStyleBackColor = false;
            btnRemoveSelected.Click += btnRemoveSelected_Click;
            // 
            // timerSearch
            // 
            timerSearch.Interval = 200;
            timerSearch.Tick += SearchTimer_Tick;
            // 
            // rowShowNotification
            // 
            rowShowNotification.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rowShowNotification.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rowShowNotification.ForeColor = SystemColors.HotTrack;
            rowShowNotification.ImageAlign = ContentAlignment.MiddleRight;
            rowShowNotification.Location = new Point(357, 694);
            rowShowNotification.Margin = new Padding(0);
            rowShowNotification.Name = "rowShowNotification";
            rowShowNotification.Size = new Size(193, 47);
            rowShowNotification.TabIndex = 33;
            rowShowNotification.Text = "row show";
            rowShowNotification.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ManagerCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 246, 249);
            ClientSize = new Size(1141, 771);
            Controls.Add(btnRemoveSelected);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(rowShowNotification);
            Controls.Add(panel3);
            ForeColor = SystemColors.InactiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManagerCustomer";
            Padding = new Padding(14, 16, 14, 16);
            Text = "ManagerCustomer";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel3;
        private DataGridView dataGridViewCustomer;
        private BindingSource bindingSource1;
        private Label label5Loc;
        private Button button2;
        private Label label4;
        private ComponentCustom.RJDatePicker rjDatePicker1;
        private ComponentCustom.RJToggle rjToggle1;
        private Label label3;
        private Button button3;
        private Button button4;
        private ComponentCustom.ButtonCustom buttonCustom1;
        private Label labelCustomerTitle;
        private Label label2;
        private Button btnSearch;
        private Button button1;
        private ComponentCustom.ButtonCustom buttonCustom2;
        private ComponentCustom.ButtonCustom buttonCustom4;
        private ComponentCustom.ButtonCustom btnSarch;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private TextBox inputSearch;
        private FlowLayoutPanel flowLayoutPanel1;
        private ComponentCustom.ButtonCustom btnNextPage;
        private ComponentCustom.ButtonCustom btnPrevPage;
        private ComboBox selectNumberPage;
        private Label label7;
        private Panel panel1;
        private ComponentCustom.RJToggle rjToggle2;
        private ComponentCustom.ButtonCustom btnRemoveSelected;
        private System.Windows.Forms.Timer timerSearch;
        private Label rowShowNotification;
        private Label numberPage;
        private DataGridViewTextBoxColumn maKhachHang;
        private DataGridViewTextBoxColumn tenKhachHang;
        private DataGridViewTextBoxColumn diaChi;
        private DataGridViewTextBoxColumn soDienThoai;
        private DataGridViewCheckBoxColumn Column4;
        private DataGridViewImageColumn Column5;
        private DataGridViewImageColumn Column6;
    }
}
