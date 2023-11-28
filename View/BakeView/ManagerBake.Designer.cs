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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            panel1 = new Panel();
            buttonCustom1 = new ComponentCustom.ButtonCustom();
            label5Loc = new Label();
            panel2 = new Panel();
            buttonCustom3 = new ComponentCustom.ButtonCustom();
            edtFindMaterial = new TextBox();
            Active = new ComponentCustom.RJToggle();
            inputTypebake = new ComboBox();
            label2 = new Label();
            btnAddMaterial = new ComponentCustom.ButtonCustom();
            panelCustom4 = new ComponentCustom.PanelCustom();
            dataGridViewBake = new DataGridView();
            select = new DataGridViewCheckBoxColumn();
            maKhachHang = new DataGridViewTextBoxColumn();
            diaChi = new DataGridViewTextBoxColumn();
            tenKhachHang = new DataGridViewTextBoxColumn();
            soDienThoai = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewCheckBoxColumn();
            Column5 = new DataGridViewImageColumn();
            Column6 = new DataGridViewImageColumn();
            panelCustom6 = new ComponentCustom.PanelCustom();
            label3 = new Label();
            buttonCustom2 = new ComponentCustom.ButtonCustom();
            btnPrev = new ComponentCustom.ButtonCustom();
            label4 = new Label();
            btnNext = new ComponentCustom.ButtonCustom();
            amountRowShow = new ComboBox();
            label1 = new Label();
            btnDeleteSelectItem = new ComponentCustom.ButtonCustom();
            btnPrevPage = new ComponentCustom.ButtonCustom();
            notifiPagePresent = new Label();
            btnNextPage = new ComponentCustom.ButtonCustom();
            rowShowNotification = new Label();
            numberPage = new ComboBox();
            timerSearch = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelCustom4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBake).BeginInit();
            panelCustom6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(buttonCustom1);
            panel1.Controls.Add(label5Loc);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(Active);
            panel1.Controls.Add(inputTypebake);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnAddMaterial);
            panel1.Location = new Point(12, 12);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1170, 71);
            panel1.TabIndex = 1;
            // 
            // buttonCustom1
            // 
            buttonCustom1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCustom1.BackColor = Color.FromArgb(51, 145, 238);
            buttonCustom1.BackgroundColor = Color.FromArgb(51, 145, 238);
            buttonCustom1.BorderColor = Color.PaleVioletRed;
            buttonCustom1.BorderRadius = 0;
            buttonCustom1.BorderSize = 0;
            buttonCustom1.FlatAppearance.BorderSize = 0;
            buttonCustom1.FlatStyle = FlatStyle.Flat;
            buttonCustom1.ForeColor = Color.Transparent;
            buttonCustom1.Image = Properties.Resources.add1;
            buttonCustom1.Location = new Point(1091, 14);
            buttonCustom1.Margin = new Padding(3, 4, 3, 4);
            buttonCustom1.Name = "buttonCustom1";
            buttonCustom1.Size = new Size(79, 29);
            buttonCustom1.TabIndex = 45;
            buttonCustom1.Text = "Thêm ";
            buttonCustom1.TextAlign = ContentAlignment.MiddleRight;
            buttonCustom1.TextColor = Color.Transparent;
            buttonCustom1.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCustom1.UseVisualStyleBackColor = false;
            buttonCustom1.Click += buttonCustom1_Click;
            // 
            // label5Loc
            // 
            label5Loc.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5Loc.ForeColor = Color.White;
            label5Loc.ImageAlign = ContentAlignment.MiddleRight;
            label5Loc.Location = new Point(442, 13);
            label5Loc.Margin = new Padding(0);
            label5Loc.Name = "label5Loc";
            label5Loc.Size = new Size(211, 32);
            label5Loc.TabIndex = 34;
            label5Loc.Text = "Danh Sách Nguyên Liệu Bị Ẩn";
            label5Loc.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(39, 52, 62);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(buttonCustom3);
            panel2.Controls.Add(edtFindMaterial);
            panel2.Location = new Point(0, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(438, 28);
            panel2.TabIndex = 44;
            // 
            // buttonCustom3
            // 
            buttonCustom3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCustom3.BackColor = Color.FromArgb(39, 52, 62);
            buttonCustom3.BackgroundColor = Color.FromArgb(39, 52, 62);
            buttonCustom3.BorderColor = Color.PaleVioletRed;
            buttonCustom3.BorderRadius = 6;
            buttonCustom3.BorderSize = 0;
            buttonCustom3.FlatAppearance.BorderSize = 0;
            buttonCustom3.FlatStyle = FlatStyle.Flat;
            buttonCustom3.ForeColor = Color.Black;
            buttonCustom3.Image = Properties.Resources.search1;
            buttonCustom3.Location = new Point(-1, 1);
            buttonCustom3.Name = "buttonCustom3";
            buttonCustom3.Size = new Size(29, 26);
            buttonCustom3.TabIndex = 32;
            buttonCustom3.TextAlign = ContentAlignment.MiddleRight;
            buttonCustom3.TextColor = Color.Black;
            buttonCustom3.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCustom3.UseVisualStyleBackColor = false;
            // 
            // edtFindMaterial
            // 
            edtFindMaterial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            edtFindMaterial.BackColor = Color.FromArgb(39, 52, 62);
            edtFindMaterial.BorderStyle = BorderStyle.None;
            edtFindMaterial.Cursor = Cursors.IBeam;
            edtFindMaterial.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            edtFindMaterial.ForeColor = Color.White;
            edtFindMaterial.Location = new Point(31, 6);
            edtFindMaterial.Margin = new Padding(0);
            edtFindMaterial.Name = "edtFindMaterial";
            edtFindMaterial.PlaceholderText = "Nhập từ khóa";
            edtFindMaterial.Size = new Size(405, 16);
            edtFindMaterial.TabIndex = 31;
            edtFindMaterial.TextChanged += edtFindMaterial_TextChanged;
            // 
            // Active
            // 
            Active.AutoSize = true;
            Active.BackColor = Color.FromArgb(28, 38, 45);
            Active.BackgroundImage = Properties.Resources.add1;
            Active.ForeColor = Color.FromArgb(28, 38, 45);
            Active.Location = new Point(656, 20);
            Active.MinimumSize = new Size(40, 18);
            Active.Name = "Active";
            Active.OffBackColor = Color.Gray;
            Active.OffToggleColor = Color.Gainsboro;
            Active.OnBackColor = Color.LightSkyBlue;
            Active.OnToggleColor = Color.WhiteSmoke;
            Active.Size = new Size(40, 18);
            Active.TabIndex = 43;
            Active.UseVisualStyleBackColor = false;
            Active.CheckedChanged += Active_CheckedChanged;
            // 
            // inputTypebake
            // 
            inputTypebake.BackColor = Color.FromArgb(28, 38, 45);
            inputTypebake.Cursor = Cursors.Hand;
            inputTypebake.FlatStyle = FlatStyle.Flat;
            inputTypebake.ForeColor = Color.White;
            inputTypebake.FormattingEnabled = true;
            inputTypebake.Location = new Point(778, 18);
            inputTypebake.Name = "inputTypebake";
            inputTypebake.Size = new Size(96, 23);
            inputTypebake.TabIndex = 39;
            inputTypebake.SelectedIndexChanged += inputTypebake_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(702, 21);
            label2.Name = "label2";
            label2.Size = new Size(70, 16);
            label2.TabIndex = 35;
            label2.Text = "Loại bánh";
            // 
            // btnAddMaterial
            // 
            btnAddMaterial.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddMaterial.BackColor = Color.FromArgb(51, 145, 238);
            btnAddMaterial.BackgroundColor = Color.FromArgb(51, 145, 238);
            btnAddMaterial.BorderColor = Color.PaleVioletRed;
            btnAddMaterial.BorderRadius = 0;
            btnAddMaterial.BorderSize = 0;
            btnAddMaterial.FlatAppearance.BorderSize = 0;
            btnAddMaterial.FlatStyle = FlatStyle.Flat;
            btnAddMaterial.ForeColor = Color.Transparent;
            btnAddMaterial.Image = Properties.Resources.add1;
            btnAddMaterial.Location = new Point(2084, 17);
            btnAddMaterial.Margin = new Padding(3, 4, 3, 4);
            btnAddMaterial.Name = "btnAddMaterial";
            btnAddMaterial.Size = new Size(79, 29);
            btnAddMaterial.TabIndex = 6;
            btnAddMaterial.Text = "Thêm ";
            btnAddMaterial.TextAlign = ContentAlignment.MiddleRight;
            btnAddMaterial.TextColor = Color.Transparent;
            btnAddMaterial.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddMaterial.UseVisualStyleBackColor = false;
            // 
            // panelCustom4
            // 
            panelCustom4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelCustom4.Controls.Add(dataGridViewBake);
            panelCustom4.Location = new Point(12, 83);
            panelCustom4.Name = "panelCustom4";
            panelCustom4.Size = new Size(1170, 423);
            panelCustom4.TabIndex = 10;
            // 
            // dataGridViewBake
            // 
            dataGridViewBake.AllowUserToAddRows = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(28, 38, 45);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.Padding = new Padding(12);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(28, 38, 45);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewBake.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewBake.BackgroundColor = Color.FromArgb(39, 52, 62);
            dataGridViewBake.BorderStyle = BorderStyle.None;
            dataGridViewBake.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewBake.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewBake.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(63, 84, 100);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.Padding = new Padding(0, 12, 0, 12);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(63, 84, 100);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewBake.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewBake.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBake.Columns.AddRange(new DataGridViewColumn[] { select, maKhachHang, diaChi, tenKhachHang, soDienThoai, Column1, Column2, Column4, Column5, Column6 });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(63, 84, 100);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle8.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(63, 84, 100);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridViewBake.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewBake.Dock = DockStyle.Fill;
            dataGridViewBake.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewBake.EnableHeadersVisualStyles = false;
            dataGridViewBake.GridColor = Color.FromArgb(39, 52, 62);
            dataGridViewBake.ImeMode = ImeMode.On;
            dataGridViewBake.Location = new Point(0, 0);
            dataGridViewBake.Margin = new Padding(0);
            dataGridViewBake.Name = "dataGridViewBake";
            dataGridViewBake.ReadOnly = true;
            dataGridViewBake.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(39, 52, 62);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(39, 52, 62);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewBake.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewBake.RowHeadersVisible = false;
            dataGridViewBake.RowHeadersWidth = 60;
            dataGridViewBake.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(39, 52, 62);
            dataGridViewCellStyle10.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(63, 84, 100);
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(51, 145, 238);
            dataGridViewBake.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewBake.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewBake.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(39, 52, 62);
            dataGridViewBake.RowTemplate.DefaultCellStyle.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewBake.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dataGridViewBake.RowTemplate.DefaultCellStyle.Padding = new Padding(6, 0, 0, 0);
            dataGridViewBake.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(63, 84, 100);
            dataGridViewBake.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(51, 145, 238);
            dataGridViewBake.RowTemplate.Height = 60;
            dataGridViewBake.RowTemplate.ReadOnly = true;
            dataGridViewBake.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridViewBake.ScrollBars = ScrollBars.Vertical;
            dataGridViewBake.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBake.ShowEditingIcon = false;
            dataGridViewBake.Size = new Size(1170, 423);
            dataGridViewBake.StandardTab = true;
            dataGridViewBake.TabIndex = 44;
            dataGridViewBake.CellContentClick += dataGridViewBake_CellContentClick;
            // 
            // select
            // 
            select.FillWeight = 30F;
            select.HeaderText = "Chọn";
            select.Name = "select";
            select.ReadOnly = true;
            select.Resizable = DataGridViewTriState.True;
            select.SortMode = DataGridViewColumnSortMode.Automatic;
            select.Width = 46;
            // 
            // maKhachHang
            // 
            maKhachHang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maKhachHang.FillWeight = 30F;
            maKhachHang.HeaderText = "Mã bánh";
            maKhachHang.MinimumWidth = 6;
            maKhachHang.Name = "maKhachHang";
            maKhachHang.ReadOnly = true;
            // 
            // diaChi
            // 
            diaChi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            diaChi.HeaderText = "Tên bánh";
            diaChi.MinimumWidth = 6;
            diaChi.Name = "diaChi";
            diaChi.ReadOnly = true;
            // 
            // tenKhachHang
            // 
            tenKhachHang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tenKhachHang.HeaderText = "Loại bánh";
            tenKhachHang.MinimumWidth = 6;
            tenKhachHang.Name = "tenKhachHang";
            tenKhachHang.ReadOnly = true;
            // 
            // soDienThoai
            // 
            soDienThoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            soDienThoai.HeaderText = "Đơn vị";
            soDienThoai.MinimumWidth = 6;
            soDienThoai.Name = "soDienThoai";
            soDienThoai.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Giá tiền";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Số lượng";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
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
            Column4.ToolTipText = "Ân hiện khách hàng";
            Column4.Width = 83;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column5.HeaderText = "Chỉnh Sửa";
            Column5.Image = Properties.Resources.icons8_edit_241;
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Resizable = DataGridViewTriState.True;
            Column5.SortMode = DataGridViewColumnSortMode.Automatic;
            Column5.ToolTipText = "Chỉnh sửa khách hàng";
            Column5.Width = 89;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column6.HeaderText = "Xóa";
            Column6.Image = Properties.Resources.icons8_remove_241;
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Resizable = DataGridViewTriState.True;
            Column6.SortMode = DataGridViewColumnSortMode.Automatic;
            Column6.ToolTipText = "Xóa khách hàng";
            Column6.Width = 54;
            // 
            // panelCustom6
            // 
            panelCustom6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelCustom6.Controls.Add(label3);
            panelCustom6.Controls.Add(buttonCustom2);
            panelCustom6.Controls.Add(btnPrev);
            panelCustom6.Controls.Add(label4);
            panelCustom6.Controls.Add(btnNext);
            panelCustom6.Controls.Add(amountRowShow);
            panelCustom6.Controls.Add(label1);
            panelCustom6.Controls.Add(btnDeleteSelectItem);
            panelCustom6.Controls.Add(btnPrevPage);
            panelCustom6.Controls.Add(notifiPagePresent);
            panelCustom6.Controls.Add(btnNextPage);
            panelCustom6.Controls.Add(rowShowNotification);
            panelCustom6.Controls.Add(numberPage);
            panelCustom6.Location = new Point(12, 512);
            panelCustom6.Name = "panelCustom6";
            panelCustom6.Size = new Size(1170, 42);
            panelCustom6.TabIndex = 37;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(669, 14);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(184, 18);
            label3.TabIndex = 51;
            label3.Text = "Số hàng hiển thị : ";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // buttonCustom2
            // 
            buttonCustom2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCustom2.BackColor = Color.FromArgb(28, 38, 45);
            buttonCustom2.BackgroundColor = Color.FromArgb(28, 38, 45);
            buttonCustom2.BorderColor = Color.PaleVioletRed;
            buttonCustom2.BorderRadius = 0;
            buttonCustom2.BorderSize = 0;
            buttonCustom2.FlatAppearance.BorderSize = 0;
            buttonCustom2.FlatStyle = FlatStyle.Flat;
            buttonCustom2.ForeColor = Color.White;
            buttonCustom2.Image = Properties.Resources.icons8_remove_24;
            buttonCustom2.Location = new Point(3, -5);
            buttonCustom2.Margin = new Padding(3, 4, 3, 4);
            buttonCustom2.Name = "buttonCustom2";
            buttonCustom2.Size = new Size(227, 52);
            buttonCustom2.TabIndex = 48;
            buttonCustom2.Text = "  Xóa các nguyên liệu đã chọn";
            buttonCustom2.TextAlign = ContentAlignment.MiddleRight;
            buttonCustom2.TextColor = Color.White;
            buttonCustom2.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCustom2.UseVisualStyleBackColor = false;
            buttonCustom2.Click += buttonCustom2_Click;
            // 
            // btnPrev
            // 
            btnPrev.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrev.BackColor = Color.Transparent;
            btnPrev.BackgroundColor = Color.Transparent;
            btnPrev.BorderColor = Color.PaleVioletRed;
            btnPrev.BorderRadius = 6;
            btnPrev.BorderSize = 0;
            btnPrev.FlatAppearance.BorderSize = 0;
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrev.ForeColor = Color.White;
            btnPrev.Image = Properties.Resources.icons8_next_prev;
            btnPrev.Location = new Point(920, 5);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(82, 32);
            btnPrev.TabIndex = 50;
            btnPrev.TextColor = Color.White;
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(1007, 5);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(80, 34);
            label4.TabIndex = 52;
            label4.Text = "1";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNext.BackColor = Color.Transparent;
            btnNext.BackgroundColor = Color.Transparent;
            btnNext.BorderColor = Color.PaleVioletRed;
            btnNext.BorderRadius = 6;
            btnNext.BorderSize = 0;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.ForeColor = Color.Wheat;
            btnNext.Image = Properties.Resources.icons8_next_241;
            btnNext.Location = new Point(1088, 5);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(79, 32);
            btnNext.TabIndex = 49;
            btnNext.TextColor = Color.Wheat;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // amountRowShow
            // 
            amountRowShow.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            amountRowShow.BackColor = Color.FromArgb(28, 38, 45);
            amountRowShow.Cursor = Cursors.Hand;
            amountRowShow.FlatStyle = FlatStyle.Flat;
            amountRowShow.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            amountRowShow.ForeColor = Color.White;
            amountRowShow.FormattingEnabled = true;
            amountRowShow.Items.AddRange(new object[] { "10", "20", "30", "40" });
            amountRowShow.Location = new Point(856, 10);
            amountRowShow.Margin = new Padding(3, 4, 3, 4);
            amountRowShow.Name = "amountRowShow";
            amountRowShow.Size = new Size(58, 26);
            amountRowShow.TabIndex = 47;
            amountRowShow.Tag = "";
            amountRowShow.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(1665, -44);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(184, 18);
            label1.TabIndex = 45;
            label1.Text = "Số hàng hiển thị : ";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnDeleteSelectItem
            // 
            btnDeleteSelectItem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeleteSelectItem.BackColor = Color.FromArgb(28, 38, 45);
            btnDeleteSelectItem.BackgroundColor = Color.FromArgb(28, 38, 45);
            btnDeleteSelectItem.BorderColor = Color.PaleVioletRed;
            btnDeleteSelectItem.BorderRadius = 0;
            btnDeleteSelectItem.BorderSize = 0;
            btnDeleteSelectItem.FlatAppearance.BorderSize = 0;
            btnDeleteSelectItem.FlatStyle = FlatStyle.Flat;
            btnDeleteSelectItem.ForeColor = Color.White;
            btnDeleteSelectItem.Image = Properties.Resources.icons8_remove_24;
            btnDeleteSelectItem.Location = new Point(12, -4);
            btnDeleteSelectItem.Margin = new Padding(3, 4, 3, 4);
            btnDeleteSelectItem.Name = "btnDeleteSelectItem";
            btnDeleteSelectItem.Size = new Size(227, 0);
            btnDeleteSelectItem.TabIndex = 42;
            btnDeleteSelectItem.Text = "  Xóa các nguyên liệu đã chọn";
            btnDeleteSelectItem.TextAlign = ContentAlignment.MiddleRight;
            btnDeleteSelectItem.TextColor = Color.White;
            btnDeleteSelectItem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeleteSelectItem.UseVisualStyleBackColor = false;
            // 
            // btnPrevPage
            // 
            btnPrevPage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrevPage.BackColor = Color.Transparent;
            btnPrevPage.BackgroundColor = Color.Transparent;
            btnPrevPage.BorderColor = Color.PaleVioletRed;
            btnPrevPage.BorderRadius = 6;
            btnPrevPage.BorderSize = 0;
            btnPrevPage.FlatAppearance.BorderSize = 0;
            btnPrevPage.FlatStyle = FlatStyle.Flat;
            btnPrevPage.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrevPage.ForeColor = Color.White;
            btnPrevPage.Image = Properties.Resources.icons8_next_prev;
            btnPrevPage.Location = new Point(1916, 5);
            btnPrevPage.Name = "btnPrevPage";
            btnPrevPage.Size = new Size(82, 32);
            btnPrevPage.TabIndex = 43;
            btnPrevPage.TextColor = Color.White;
            btnPrevPage.UseVisualStyleBackColor = false;
            // 
            // notifiPagePresent
            // 
            notifiPagePresent.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            notifiPagePresent.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            notifiPagePresent.ForeColor = Color.White;
            notifiPagePresent.Location = new Point(2003, -53);
            notifiPagePresent.Margin = new Padding(0);
            notifiPagePresent.Name = "notifiPagePresent";
            notifiPagePresent.Size = new Size(80, 34);
            notifiPagePresent.TabIndex = 46;
            notifiPagePresent.Text = "1";
            notifiPagePresent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNextPage
            // 
            btnNextPage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNextPage.BackColor = Color.Transparent;
            btnNextPage.BackgroundColor = Color.Transparent;
            btnNextPage.BorderColor = Color.PaleVioletRed;
            btnNextPage.BorderRadius = 6;
            btnNextPage.BorderSize = 0;
            btnNextPage.FlatAppearance.BorderSize = 0;
            btnNextPage.FlatStyle = FlatStyle.Flat;
            btnNextPage.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNextPage.ForeColor = Color.Wheat;
            btnNextPage.Image = Properties.Resources.icons8_next_241;
            btnNextPage.Location = new Point(2084, 5);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(79, 32);
            btnNextPage.TabIndex = 42;
            btnNextPage.TextColor = Color.Wheat;
            btnNextPage.UseVisualStyleBackColor = false;
            // 
            // rowShowNotification
            // 
            rowShowNotification.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            rowShowNotification.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rowShowNotification.ForeColor = SystemColors.ControlLight;
            rowShowNotification.ImageAlign = ContentAlignment.MiddleRight;
            rowShowNotification.Location = new Point(77, 459);
            rowShowNotification.Margin = new Padding(0);
            rowShowNotification.Name = "rowShowNotification";
            rowShowNotification.Size = new Size(212, 35);
            rowShowNotification.TabIndex = 40;
            rowShowNotification.Text = "row show";
            rowShowNotification.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numberPage
            // 
            numberPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            numberPage.BackColor = Color.FromArgb(28, 38, 45);
            numberPage.Cursor = Cursors.Hand;
            numberPage.FlatStyle = FlatStyle.Flat;
            numberPage.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numberPage.ForeColor = Color.White;
            numberPage.FormattingEnabled = true;
            numberPage.Items.AddRange(new object[] { "10", "20", "30", "40" });
            numberPage.Location = new Point(1852, -48);
            numberPage.Margin = new Padding(3, 4, 3, 4);
            numberPage.Name = "numberPage";
            numberPage.Size = new Size(58, 26);
            numberPage.TabIndex = 35;
            numberPage.Tag = "";
            // 
            // timerSearch
            // 
            timerSearch.Interval = 200;
            timerSearch.Tick += timerSearch_Tick;
            // 
            // ManagerBake
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 38, 45);
            ClientSize = new Size(1194, 564);
            Controls.Add(panelCustom6);
            Controls.Add(panelCustom4);
            Controls.Add(panel1);
            ForeColor = SystemColors.InactiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManagerBake";
            Padding = new Padding(12);
            Text = "ManagerBake";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelCustom4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBake).EndInit();
            panelCustom6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ComponentCustom.ButtonCustom buttonCustom3;
        private TextBox edtFindMaterial;
        private ComponentCustom.RJToggle Active;
        private ComboBox inputTypebake;
        private Label label2;
        private Label label5Loc;
        private ComponentCustom.ButtonCustom btnAddMaterial;
        private ComponentCustom.ButtonCustom buttonCustom1;
        private ComponentCustom.PanelCustom panelCustom4;
        private DataGridView dataGridViewBake;
        private ComponentCustom.PanelCustom panelCustom6;
        private Label label1;
        private ComponentCustom.ButtonCustom btnDeleteSelectItem;
        private ComponentCustom.ButtonCustom btnPrevPage;
        private Label notifiPagePresent;
        private ComponentCustom.ButtonCustom btnNextPage;
        private Label rowShowNotification;
        private ComboBox numberPage;
        private Label label3;
        private ComponentCustom.ButtonCustom buttonCustom2;
        private ComponentCustom.ButtonCustom btnPrev;
        private Label label4;
        private ComponentCustom.ButtonCustom btnNext;
        private ComboBox amountRowShow;
        private DataGridViewCheckBoxColumn select;
        private DataGridViewTextBoxColumn maKhachHang;
        private DataGridViewTextBoxColumn diaChi;
        private DataGridViewTextBoxColumn tenKhachHang;
        private DataGridViewTextBoxColumn soDienThoai;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewCheckBoxColumn Column4;
        private DataGridViewImageColumn Column5;
        private DataGridViewImageColumn Column6;
        private System.Windows.Forms.Timer timerSearch;
    }
}