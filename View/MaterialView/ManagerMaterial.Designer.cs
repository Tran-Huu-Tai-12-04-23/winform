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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            label1 = new Label();
            label4 = new Label();
            btnAddMaterial = new ComponentCustom.ButtonCustom();
            panelCustom1 = new ComponentCustom.PanelCustom();
            panelCustom2 = new ComponentCustom.PanelCustom();
            panelCustom3 = new ComponentCustom.PanelCustom();
            buttonCustom5 = new ComponentCustom.ButtonCustom();
            edtFindMaterial = new CustomControls.RJControls.RJTextBox();
            panelCustom5 = new ComponentCustom.PanelCustom();
            label2 = new Label();
            buttonCustom6 = new ComponentCustom.ButtonCustom();
            rjToggle2 = new ComponentCustom.RJToggle();
            rjDatePicker2 = new ComponentCustom.RJDatePicker();
            label6 = new Label();
            panelCustom4 = new ComponentCustom.PanelCustom();
            panelCustom6 = new ComponentCustom.PanelCustom();
            buttonCustom7 = new ComponentCustom.ButtonCustom();
            buttonCustom8 = new ComponentCustom.ButtonCustom();
            comboBox1 = new ComboBox();
            label7 = new Label();
            dataGridViewMaterial = new DataGridView();
            maNguyenLieu = new DataGridViewTextBoxColumn();
            tenLoaiNguyenLieu = new DataGridViewTextBoxColumn();
            tenNguyenLieu = new DataGridViewTextBoxColumn();
            doVi = new DataGridViewTextBoxColumn();
            giaTien = new DataGridViewTextBoxColumn();
            soLuong = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewCheckBoxColumn();
            Column5 = new DataGridViewImageColumn();
            Column6 = new DataGridViewImageColumn();
            panelCustom1.SuspendLayout();
            panelCustom2.SuspendLayout();
            panelCustom3.SuspendLayout();
            panelCustom5.SuspendLayout();
            panelCustom4.SuspendLayout();
            panelCustom6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterial).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 25);
            label1.Name = "label1";
            label1.Size = new Size(276, 25);
            label1.TabIndex = 0;
            label1.Text = "Danh Sách Nguyên Liệu";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 21);
            label4.Name = "label4";
            label4.Size = new Size(263, 25);
            label4.TabIndex = 3;
            label4.Text = "Tìm Kiếm Nguyên Liệu";
            // 
            // btnAddMaterial
            // 
            btnAddMaterial.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddMaterial.BackColor = Color.LightSkyBlue;
            btnAddMaterial.BackgroundColor = Color.LightSkyBlue;
            btnAddMaterial.BorderColor = Color.PaleVioletRed;
            btnAddMaterial.BorderRadius = 0;
            btnAddMaterial.BorderSize = 0;
            btnAddMaterial.FlatAppearance.BorderSize = 0;
            btnAddMaterial.FlatStyle = FlatStyle.Flat;
            btnAddMaterial.ForeColor = Color.Black;
            btnAddMaterial.Image = Properties.Resources.add1;
            btnAddMaterial.Location = new Point(1061, 15);
            btnAddMaterial.Margin = new Padding(3, 4, 3, 4);
            btnAddMaterial.Name = "btnAddMaterial";
            btnAddMaterial.Size = new Size(190, 50);
            btnAddMaterial.TabIndex = 6;
            btnAddMaterial.Text = "Thêm Nguyên Liệu";
            btnAddMaterial.TextColor = Color.Black;
            btnAddMaterial.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddMaterial.UseVisualStyleBackColor = false;
            btnAddMaterial.Click += btnAddMaterial_Click;
            // 
            // panelCustom1
            // 
            panelCustom1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelCustom1.BorderStyle = BorderStyle.FixedSingle;
            panelCustom1.Controls.Add(label1);
            panelCustom1.Controls.Add(btnAddMaterial);
            panelCustom1.ForeColor = SystemColors.ActiveCaptionText;
            panelCustom1.Location = new Point(-14, -11);
            panelCustom1.Name = "panelCustom1";
            panelCustom1.Size = new Size(1277, 78);
            panelCustom1.TabIndex = 7;
            // 
            // panelCustom2
            // 
            panelCustom2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelCustom2.BorderStyle = BorderStyle.FixedSingle;
            panelCustom2.Controls.Add(label4);
            panelCustom2.Controls.Add(panelCustom3);
            panelCustom2.Location = new Point(-14, 62);
            panelCustom2.Name = "panelCustom2";
            panelCustom2.Size = new Size(1277, 73);
            panelCustom2.TabIndex = 8;
            // 
            // panelCustom3
            // 
            panelCustom3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelCustom3.Controls.Add(buttonCustom5);
            panelCustom3.Controls.Add(edtFindMaterial);
            panelCustom3.Location = new Point(720, 3);
            panelCustom3.Name = "panelCustom3";
            panelCustom3.Size = new Size(539, 59);
            panelCustom3.TabIndex = 9;
            // 
            // buttonCustom5
            // 
            buttonCustom5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCustom5.BackColor = Color.LightSkyBlue;
            buttonCustom5.BackgroundColor = Color.LightSkyBlue;
            buttonCustom5.BorderColor = Color.PaleVioletRed;
            buttonCustom5.BorderRadius = 0;
            buttonCustom5.BorderSize = 0;
            buttonCustom5.FlatAppearance.BorderSize = 0;
            buttonCustom5.FlatStyle = FlatStyle.Flat;
            buttonCustom5.ForeColor = Color.Black;
            buttonCustom5.Image = Properties.Resources.search;
            buttonCustom5.Location = new Point(430, 8);
            buttonCustom5.Margin = new Padding(3, 4, 3, 4);
            buttonCustom5.Name = "buttonCustom5";
            buttonCustom5.Size = new Size(100, 50);
            buttonCustom5.TabIndex = 8;
            buttonCustom5.Text = "Tìm";
            buttonCustom5.TextColor = Color.Black;
            buttonCustom5.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCustom5.UseVisualStyleBackColor = false;
            // 
            // edtFindMaterial
            // 
            edtFindMaterial.BackColor = SystemColors.Window;
            edtFindMaterial.BorderColor = Color.MediumSlateBlue;
            edtFindMaterial.BorderFocusColor = Color.HotPink;
            edtFindMaterial.BorderRadius = 0;
            edtFindMaterial.BorderSize = 2;
            edtFindMaterial.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            edtFindMaterial.ForeColor = Color.FromArgb(64, 64, 64);
            edtFindMaterial.Location = new Point(13, 18);
            edtFindMaterial.Margin = new Padding(4);
            edtFindMaterial.Multiline = false;
            edtFindMaterial.Name = "edtFindMaterial";
            edtFindMaterial.Padding = new Padding(10, 7, 10, 7);
            edtFindMaterial.PasswordChar = false;
            edtFindMaterial.PlaceholderColor = Color.DarkGray;
            edtFindMaterial.PlaceholderText = "";
            edtFindMaterial.Size = new Size(396, 35);
            edtFindMaterial.TabIndex = 5;
            edtFindMaterial.Texts = "";
            edtFindMaterial.UnderlinedStyle = false;
            // 
            // panelCustom5
            // 
            panelCustom5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelCustom5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelCustom5.BorderStyle = BorderStyle.FixedSingle;
            panelCustom5.Controls.Add(label2);
            panelCustom5.Controls.Add(buttonCustom6);
            panelCustom5.Controls.Add(rjToggle2);
            panelCustom5.Controls.Add(rjDatePicker2);
            panelCustom5.Controls.Add(label6);
            panelCustom5.Location = new Point(-14, 134);
            panelCustom5.Name = "panelCustom5";
            panelCustom5.Size = new Size(1277, 76);
            panelCustom5.TabIndex = 34;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(442, 9);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(249, 59);
            label2.TabIndex = 29;
            label2.Text = "Trạng thái (ẩn / hiện) :";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // buttonCustom6
            // 
            buttonCustom6.Anchor = AnchorStyles.Right;
            buttonCustom6.BackColor = Color.LightSkyBlue;
            buttonCustom6.BackgroundColor = Color.LightSkyBlue;
            buttonCustom6.BorderColor = Color.PaleVioletRed;
            buttonCustom6.BorderRadius = 0;
            buttonCustom6.BorderSize = 0;
            buttonCustom6.FlatAppearance.BorderSize = 0;
            buttonCustom6.FlatStyle = FlatStyle.Flat;
            buttonCustom6.ForeColor = Color.Black;
            buttonCustom6.Location = new Point(1149, 16);
            buttonCustom6.Margin = new Padding(3, 4, 3, 4);
            buttonCustom6.Name = "buttonCustom6";
            buttonCustom6.Size = new Size(101, 50);
            buttonCustom6.TabIndex = 33;
            buttonCustom6.Text = "Lọc";
            buttonCustom6.TextColor = Color.Black;
            buttonCustom6.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCustom6.UseVisualStyleBackColor = false;
            // 
            // rjToggle2
            // 
            rjToggle2.Anchor = AnchorStyles.Right;
            rjToggle2.AutoSize = true;
            rjToggle2.Location = new Point(694, 28);
            rjToggle2.Margin = new Padding(3, 4, 3, 4);
            rjToggle2.MinimumSize = new Size(51, 29);
            rjToggle2.Name = "rjToggle2";
            rjToggle2.OffBackColor = Color.Gray;
            rjToggle2.OffToggleColor = Color.Gainsboro;
            rjToggle2.OnBackColor = Color.LightSkyBlue;
            rjToggle2.OnToggleColor = Color.WhiteSmoke;
            rjToggle2.Size = new Size(51, 29);
            rjToggle2.TabIndex = 30;
            rjToggle2.UseVisualStyleBackColor = true;
            // 
            // rjDatePicker2
            // 
            rjDatePicker2.Anchor = AnchorStyles.Right;
            rjDatePicker2.BorderColor = Color.PaleVioletRed;
            rjDatePicker2.BorderSize = 0;
            rjDatePicker2.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            rjDatePicker2.Location = new Point(889, 23);
            rjDatePicker2.Margin = new Padding(3, 4, 3, 4);
            rjDatePicker2.MinimumSize = new Size(4, 35);
            rjDatePicker2.Name = "rjDatePicker2";
            rjDatePicker2.Size = new Size(240, 35);
            rjDatePicker2.SkinColor = Color.LightSkyBlue;
            rjDatePicker2.TabIndex = 32;
            rjDatePicker2.TextColor = Color.Black;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ImageAlign = ContentAlignment.MiddleRight;
            label6.Location = new Point(748, 13);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(141, 55);
            label6.TabIndex = 31;
            label6.Text = "Ngày thêm :";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelCustom4
            // 
            panelCustom4.Controls.Add(panelCustom6);
            panelCustom4.Controls.Add(dataGridViewMaterial);
            panelCustom4.Controls.Add(panelCustom5);
            panelCustom4.Controls.Add(panelCustom1);
            panelCustom4.Controls.Add(panelCustom2);
            panelCustom4.Dock = DockStyle.Fill;
            panelCustom4.Location = new Point(0, 0);
            panelCustom4.Name = "panelCustom4";
            panelCustom4.Size = new Size(1250, 870);
            panelCustom4.TabIndex = 9;
            // 
            // panelCustom6
            // 
            panelCustom6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panelCustom6.Controls.Add(buttonCustom7);
            panelCustom6.Controls.Add(buttonCustom8);
            panelCustom6.Controls.Add(comboBox1);
            panelCustom6.Controls.Add(label7);
            panelCustom6.Location = new Point(630, 812);
            panelCustom6.Name = "panelCustom6";
            panelCustom6.Size = new Size(611, 55);
            panelCustom6.TabIndex = 36;
            // 
            // buttonCustom7
            // 
            buttonCustom7.Anchor = AnchorStyles.None;
            buttonCustom7.BackColor = Color.LightSkyBlue;
            buttonCustom7.BackgroundColor = Color.LightSkyBlue;
            buttonCustom7.BorderColor = Color.PaleVioletRed;
            buttonCustom7.BorderRadius = 0;
            buttonCustom7.BorderSize = 0;
            buttonCustom7.FlatAppearance.BorderSize = 0;
            buttonCustom7.FlatStyle = FlatStyle.Flat;
            buttonCustom7.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCustom7.ForeColor = Color.Black;
            buttonCustom7.Location = new Point(498, 10);
            buttonCustom7.Margin = new Padding(3, 4, 3, 4);
            buttonCustom7.Name = "buttonCustom7";
            buttonCustom7.Size = new Size(108, 35);
            buttonCustom7.TabIndex = 33;
            buttonCustom7.Text = "Trước";
            buttonCustom7.TextColor = Color.Black;
            buttonCustom7.UseVisualStyleBackColor = false;
            // 
            // buttonCustom8
            // 
            buttonCustom8.Anchor = AnchorStyles.None;
            buttonCustom8.BackColor = Color.LightSkyBlue;
            buttonCustom8.BackgroundColor = Color.LightSkyBlue;
            buttonCustom8.BorderColor = Color.PaleVioletRed;
            buttonCustom8.BorderRadius = 0;
            buttonCustom8.BorderSize = 0;
            buttonCustom8.FlatAppearance.BorderSize = 0;
            buttonCustom8.FlatStyle = FlatStyle.Flat;
            buttonCustom8.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCustom8.ForeColor = Color.Black;
            buttonCustom8.Location = new Point(380, 10);
            buttonCustom8.Margin = new Padding(3, 4, 3, 4);
            buttonCustom8.Name = "buttonCustom8";
            buttonCustom8.Size = new Size(104, 35);
            buttonCustom8.TabIndex = 34;
            buttonCustom8.Text = "Sau";
            buttonCustom8.TextColor = Color.Black;
            buttonCustom8.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "10", "20", "30", "40" });
            comboBox1.Location = new Point(304, 12);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(61, 33);
            comboBox1.TabIndex = 35;
            comboBox1.Tag = "";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ImageAlign = ContentAlignment.MiddleRight;
            label7.Location = new Point(75, 19);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(201, 26);
            label7.TabIndex = 36;
            label7.Text = "Số hàng hiển thị : ";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dataGridViewMaterial
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Padding = new Padding(12);
            dataGridViewMaterial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewMaterial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewMaterial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMaterial.BackgroundColor = Color.White;
            dataGridViewMaterial.BorderStyle = BorderStyle.None;
            dataGridViewMaterial.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewMaterial.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Padding = new Padding(0, 12, 0, 12);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewMaterial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewMaterial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMaterial.Columns.AddRange(new DataGridViewColumn[] { maNguyenLieu, tenLoaiNguyenLieu, tenNguyenLieu, doVi, giaTien, soLuong, Column4, Column5, Column6 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle3.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewMaterial.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewMaterial.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewMaterial.EnableHeadersVisualStyles = false;
            dataGridViewMaterial.GridColor = Color.White;
            dataGridViewMaterial.Location = new Point(9, 211);
            dataGridViewMaterial.Margin = new Padding(0);
            dataGridViewMaterial.Name = "dataGridViewMaterial";
            dataGridViewMaterial.ReadOnly = true;
            dataGridViewMaterial.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewMaterial.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewMaterial.RowHeadersWidth = 60;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(6, 0, 0, 0);
            dataGridViewMaterial.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewMaterial.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewMaterial.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dataGridViewMaterial.RowTemplate.DefaultCellStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewMaterial.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewMaterial.RowTemplate.DefaultCellStyle.Padding = new Padding(6, 0, 0, 0);
            dataGridViewMaterial.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.AliceBlue;
            dataGridViewMaterial.RowTemplate.Height = 60;
            dataGridViewMaterial.RowTemplate.ReadOnly = true;
            dataGridViewMaterial.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridViewMaterial.ShowEditingIcon = false;
            dataGridViewMaterial.Size = new Size(1228, 594);
            dataGridViewMaterial.StandardTab = true;
            dataGridViewMaterial.TabIndex = 35;
            dataGridViewMaterial.CellContentClick += dataGridViewMaterial_CellContentClick;
            // 
            // maNguyenLieu
            // 
            maNguyenLieu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maNguyenLieu.HeaderText = "Mã Nguyên Liệu";
            maNguyenLieu.MinimumWidth = 6;
            maNguyenLieu.Name = "maNguyenLieu";
            maNguyenLieu.ReadOnly = true;
            // 
            // tenLoaiNguyenLieu
            // 
            tenLoaiNguyenLieu.HeaderText = "Loại Nguyên Liệu";
            tenLoaiNguyenLieu.MinimumWidth = 6;
            tenLoaiNguyenLieu.Name = "tenLoaiNguyenLieu";
            tenLoaiNguyenLieu.ReadOnly = true;
            // 
            // tenNguyenLieu
            // 
            tenNguyenLieu.HeaderText = "Tên Nguyên Liệu";
            tenNguyenLieu.MinimumWidth = 6;
            tenNguyenLieu.Name = "tenNguyenLieu";
            tenNguyenLieu.ReadOnly = true;
            // 
            // doVi
            // 
            doVi.HeaderText = "Đơn Vị";
            doVi.MinimumWidth = 6;
            doVi.Name = "doVi";
            doVi.ReadOnly = true;
            // 
            // giaTien
            // 
            giaTien.HeaderText = "Giá Tiền";
            giaTien.MinimumWidth = 6;
            giaTien.Name = "giaTien";
            giaTien.ReadOnly = true;
            // 
            // soLuong
            // 
            soLuong.HeaderText = "Số Lượng";
            soLuong.MinimumWidth = 6;
            soLuong.Name = "soLuong";
            soLuong.ReadOnly = true;
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
            // ManagerMaterial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1250, 870);
            ControlBox = false;
            Controls.Add(panelCustom4);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManagerMaterial";
            panelCustom1.ResumeLayout(false);
            panelCustom1.PerformLayout();
            panelCustom2.ResumeLayout(false);
            panelCustom2.PerformLayout();
            panelCustom3.ResumeLayout(false);
            panelCustom5.ResumeLayout(false);
            panelCustom5.PerformLayout();
            panelCustom4.ResumeLayout(false);
            panelCustom6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterial).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label4;
        private ComponentCustom.ButtonCustom btnAddMaterial;
        private ComponentCustom.PanelCustom panelCustom1;
        private ComponentCustom.PanelCustom panelCustom2;
        private ComponentCustom.ButtonCustom buttonCustom5;
        private ComponentCustom.PanelCustom panelCustom3;
        private CustomControls.RJControls.RJTextBox edtFindMaterial;
        private ComponentCustom.PanelCustom panelCustom4;
        private Label label2;
        private ComponentCustom.RJToggle rjToggle2;
        private Label label6;
        private ComponentCustom.RJDatePicker rjDatePicker2;
        private ComponentCustom.ButtonCustom buttonCustom6;
        private ComponentCustom.PanelCustom panelCustom5;
        private DataGridView dataGridViewMaterial;
        private ComponentCustom.PanelCustom panelCustom6;
        private ComponentCustom.ButtonCustom buttonCustom7;
        private ComponentCustom.ButtonCustom buttonCustom8;
        private ComboBox comboBox1;
        private Label label7;
        private DataGridViewTextBoxColumn maNguyenLieu;
        private DataGridViewTextBoxColumn tenLoaiNguyenLieu;
        private DataGridViewTextBoxColumn tenNguyenLieu;
        private DataGridViewTextBoxColumn doVi;
        private DataGridViewTextBoxColumn giaTien;
        private DataGridViewTextBoxColumn soLuong;
        private DataGridViewCheckBoxColumn Column4;
        private DataGridViewImageColumn Column5;
        private DataGridViewImageColumn Column6;
    }
}