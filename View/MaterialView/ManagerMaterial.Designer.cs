namespace FinalProject_QUANLYKHO.View.MaterialView
{
    partial class ManagerMaterial
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
            btnAddMaterial = new ComponentCustom.ButtonCustom();
            panelCustom4 = new ComponentCustom.PanelCustom();
            dataGridViewMaterial = new DataGridView();
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
            panel1 = new Panel();
            panel2 = new Panel();
            buttonCustom3 = new ComponentCustom.ButtonCustom();
            edtFindMaterial = new TextBox();
            Active = new ComponentCustom.RJToggle();
            inputTypeMaterial = new ComboBox();
            label2 = new Label();
            label5Loc = new Label();
            btnDeleteSelectItem = new ComponentCustom.ButtonCustom();
            numberPage = new ComboBox();
            panelCustom6 = new ComponentCustom.PanelCustom();
            label1 = new Label();
            btnPrevPage = new ComponentCustom.ButtonCustom();
            notifiPagePresent = new Label();
            btnNextPage = new ComponentCustom.ButtonCustom();
            rowShowNotification = new Label();
            timerSearch = new System.Windows.Forms.Timer(components);
            panelCustom4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterial).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelCustom6.SuspendLayout();
            SuspendLayout();
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
            btnAddMaterial.Location = new Point(1114, 17);
            btnAddMaterial.Margin = new Padding(3, 4, 3, 4);
            btnAddMaterial.Name = "btnAddMaterial";
            btnAddMaterial.Size = new Size(79, 29);
            btnAddMaterial.TabIndex = 6;
            btnAddMaterial.Text = "Thêm ";
            btnAddMaterial.TextAlign = ContentAlignment.MiddleRight;
            btnAddMaterial.TextColor = Color.Transparent;
            btnAddMaterial.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddMaterial.UseVisualStyleBackColor = false;
            btnAddMaterial.Click += btnAddMaterial_Click;
            // 
            // panelCustom4
            // 
            panelCustom4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelCustom4.Controls.Add(dataGridViewMaterial);
            panelCustom4.Location = new Point(14, 76);
            panelCustom4.Name = "panelCustom4";
            panelCustom4.Size = new Size(1196, 399);
            panelCustom4.TabIndex = 9;
            // 
            // dataGridViewMaterial
            // 
            dataGridViewMaterial.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(28, 38, 45);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(12);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(28, 38, 45);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewMaterial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewMaterial.BackgroundColor = Color.FromArgb(39, 52, 62);
            dataGridViewMaterial.BorderStyle = BorderStyle.None;
            dataGridViewMaterial.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewMaterial.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewMaterial.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(63, 84, 100);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(0, 12, 0, 12);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(63, 84, 100);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewMaterial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewMaterial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMaterial.Columns.AddRange(new DataGridViewColumn[] { select, maKhachHang, diaChi, tenKhachHang, soDienThoai, Column1, Column2, Column4, Column5, Column6 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(63, 84, 100);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle3.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(63, 84, 100);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewMaterial.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewMaterial.Dock = DockStyle.Fill;
            dataGridViewMaterial.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewMaterial.EnableHeadersVisualStyles = false;
            dataGridViewMaterial.GridColor = Color.FromArgb(39, 52, 62);
            dataGridViewMaterial.ImeMode = ImeMode.On;
            dataGridViewMaterial.Location = new Point(0, 0);
            dataGridViewMaterial.Margin = new Padding(0);
            dataGridViewMaterial.Name = "dataGridViewMaterial";
            dataGridViewMaterial.ReadOnly = true;
            dataGridViewMaterial.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(39, 52, 62);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(39, 52, 62);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewMaterial.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewMaterial.RowHeadersVisible = false;
            dataGridViewMaterial.RowHeadersWidth = 60;
            dataGridViewMaterial.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(39, 52, 62);
            dataGridViewCellStyle5.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(63, 84, 100);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(51, 145, 238);
            dataGridViewMaterial.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewMaterial.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewMaterial.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(39, 52, 62);
            dataGridViewMaterial.RowTemplate.DefaultCellStyle.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewMaterial.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dataGridViewMaterial.RowTemplate.DefaultCellStyle.Padding = new Padding(6, 0, 0, 0);
            dataGridViewMaterial.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(63, 84, 100);
            dataGridViewMaterial.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(51, 145, 238);
            dataGridViewMaterial.RowTemplate.Height = 60;
            dataGridViewMaterial.RowTemplate.ReadOnly = true;
            dataGridViewMaterial.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridViewMaterial.ScrollBars = ScrollBars.Vertical;
            dataGridViewMaterial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMaterial.ShowEditingIcon = false;
            dataGridViewMaterial.Size = new Size(1196, 399);
            dataGridViewMaterial.StandardTab = true;
            dataGridViewMaterial.TabIndex = 44;
            dataGridViewMaterial.CellContentClick += dataGridViewMaterial_CellContentClick;
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
            maKhachHang.HeaderText = "Mã nguyên liệu";
            maKhachHang.MinimumWidth = 6;
            maKhachHang.Name = "maKhachHang";
            maKhachHang.ReadOnly = true;
            // 
            // diaChi
            // 
            diaChi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            diaChi.HeaderText = "Tên nguyên liệu";
            diaChi.MinimumWidth = 6;
            diaChi.Name = "diaChi";
            diaChi.ReadOnly = true;
            // 
            // tenKhachHang
            // 
            tenKhachHang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tenKhachHang.HeaderText = "Loại nguyên liệu";
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(Active);
            panel1.Controls.Add(inputTypeMaterial);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5Loc);
            panel1.Controls.Add(btnAddMaterial);
            panel1.Location = new Point(14, 2);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1196, 71);
            panel1.TabIndex = 0;
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
            Active.Location = new Point(671, 22);
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
            // inputTypeMaterial
            // 
            inputTypeMaterial.BackColor = Color.FromArgb(28, 38, 45);
            inputTypeMaterial.Cursor = Cursors.Hand;
            inputTypeMaterial.FlatStyle = FlatStyle.Flat;
            inputTypeMaterial.ForeColor = Color.White;
            inputTypeMaterial.FormattingEnabled = true;
            inputTypeMaterial.Location = new Point(858, 20);
            inputTypeMaterial.Name = "inputTypeMaterial";
            inputTypeMaterial.Size = new Size(96, 23);
            inputTypeMaterial.TabIndex = 39;
            inputTypeMaterial.SelectedIndexChanged += inputTypeMaterial_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(734, 24);
            label2.Name = "label2";
            label2.Size = new Size(118, 16);
            label2.TabIndex = 35;
            label2.Text = "Loại Nguyên Liệu";
            // 
            // label5Loc
            // 
            label5Loc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5Loc.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5Loc.ForeColor = Color.White;
            label5Loc.ImageAlign = ContentAlignment.MiddleRight;
            label5Loc.Location = new Point(463, 14);
            label5Loc.Margin = new Padding(0);
            label5Loc.Name = "label5Loc";
            label5Loc.Size = new Size(205, 32);
            label5Loc.TabIndex = 34;
            label5Loc.Text = "Danh Sách Nguyên Liệu Bị Ẩn";
            label5Loc.TextAlign = ContentAlignment.MiddleLeft;
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
            btnDeleteSelectItem.Size = new Size(227, 52);
            btnDeleteSelectItem.TabIndex = 42;
            btnDeleteSelectItem.Text = "  Xóa các nguyên liệu đã chọn";
            btnDeleteSelectItem.TextAlign = ContentAlignment.MiddleRight;
            btnDeleteSelectItem.TextColor = Color.White;
            btnDeleteSelectItem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeleteSelectItem.UseVisualStyleBackColor = false;
            btnDeleteSelectItem.Click += btnDeleteSelectItem_Click;
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
            numberPage.Location = new Point(882, 10);
            numberPage.Margin = new Padding(3, 4, 3, 4);
            numberPage.Name = "numberPage";
            numberPage.Size = new Size(58, 26);
            numberPage.TabIndex = 35;
            numberPage.Tag = "";
            numberPage.SelectedIndexChanged += numberPage_SelectedIndexChanged;
            // 
            // panelCustom6
            // 
            panelCustom6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelCustom6.Controls.Add(label1);
            panelCustom6.Controls.Add(btnDeleteSelectItem);
            panelCustom6.Controls.Add(btnPrevPage);
            panelCustom6.Controls.Add(notifiPagePresent);
            panelCustom6.Controls.Add(btnNextPage);
            panelCustom6.Controls.Add(rowShowNotification);
            panelCustom6.Controls.Add(numberPage);
            panelCustom6.Location = new Point(14, 478);
            panelCustom6.Name = "panelCustom6";
            panelCustom6.Size = new Size(1196, 42);
            panelCustom6.TabIndex = 36;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(695, 14);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(184, 18);
            label1.TabIndex = 45;
            label1.Text = "Số hàng hiển thị : ";
            label1.TextAlign = ContentAlignment.MiddleRight;
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
            btnPrevPage.Location = new Point(946, 5);
            btnPrevPage.Name = "btnPrevPage";
            btnPrevPage.Size = new Size(82, 32);
            btnPrevPage.TabIndex = 43;
            btnPrevPage.TextColor = Color.White;
            btnPrevPage.UseVisualStyleBackColor = false;
            btnPrevPage.Click += btnPrevPage_Click;
            // 
            // notifiPagePresent
            // 
            notifiPagePresent.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            notifiPagePresent.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            notifiPagePresent.ForeColor = Color.White;
            notifiPagePresent.Location = new Point(1033, 5);
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
            btnNextPage.Location = new Point(1114, 5);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(79, 32);
            btnNextPage.TabIndex = 42;
            btnNextPage.TextColor = Color.Wheat;
            btnNextPage.UseVisualStyleBackColor = false;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // rowShowNotification
            // 
            rowShowNotification.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            rowShowNotification.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rowShowNotification.ForeColor = SystemColors.ControlLight;
            rowShowNotification.ImageAlign = ContentAlignment.MiddleRight;
            rowShowNotification.Location = new Point(77, 517);
            rowShowNotification.Margin = new Padding(0);
            rowShowNotification.Name = "rowShowNotification";
            rowShowNotification.Size = new Size(212, 35);
            rowShowNotification.TabIndex = 40;
            rowShowNotification.Text = "row show";
            rowShowNotification.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timerSearch
            // 
            timerSearch.Interval = 200;
            timerSearch.Tick += timerSearch_Tick;
            // 
            // ManagerMaterial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 38, 45);
            ClientSize = new Size(1224, 529);
            ControlBox = false;
            Controls.Add(panelCustom6);
            Controls.Add(panel1);
            Controls.Add(panelCustom4);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.InactiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManagerMaterial";
            Padding = new Padding(14, 16, 14, 16);
            Text = "ManagerMaterial";
            panelCustom4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterial).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelCustom6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ComponentCustom.ButtonCustom btnAddMaterial;
        private ComponentCustom.PanelCustom panelCustom4;
        private ComponentCustom.PanelCustom panelCustom6;
        private ComboBox numberPage;
        private Panel panel1;
        private Label label5Loc;
        private ComboBox inputTypeMaterial;
        private Label label2;
        private ComponentCustom.ButtonCustom btnDeleteSelectItem;
        private DataGridView dataGridViewMaterial;
        private ComponentCustom.RJToggle Active;
        private Panel panel2;
        private ComponentCustom.ButtonCustom buttonCustom3;
        private TextBox edtFindMaterial;
        private Label label1;
        private ComponentCustom.ButtonCustom btnPrevPage;
        private Label notifiPagePresent;
        private ComponentCustom.ButtonCustom btnNextPage;
        private Label rowShowNotification;
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