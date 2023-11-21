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
            btnFind = new ComponentCustom.ButtonCustom();
            btnTreatment = new ComponentCustom.ButtonCustom();
            Active = new ComponentCustom.RJToggle();
            panelCustom4 = new ComponentCustom.PanelCustom();
            panel1 = new Panel();
            buttonDeleteType = new ComponentCustom.ButtonCustom();
            btnRefreshType = new ComponentCustom.ButtonCustom();
            btnAddType = new ComponentCustom.ButtonCustom();
            inputTypeMaterial = new ComboBox();
            label2 = new Label();
            label5Loc = new Label();
            edtFindMaterial = new TextBox();
            panelCustom6 = new ComponentCustom.PanelCustom();
            btnDeleteSelect = new ComponentCustom.ButtonCustom();
            SumPage = new Label();
            btnAfter = new ComponentCustom.ButtonCustom();
            btnBefore = new ComponentCustom.ButtonCustom();
            numberPage = new ComboBox();
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
            panelCustom4.SuspendLayout();
            panel1.SuspendLayout();
            panelCustom6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterial).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(276, 25);
            label1.TabIndex = 0;
            label1.Text = "Danh Sách Nguyên Liệu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 65);
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
            btnAddMaterial.Location = new Point(1008, 12);
            btnAddMaterial.Margin = new Padding(3, 4, 3, 4);
            btnAddMaterial.Name = "btnAddMaterial";
            btnAddMaterial.Size = new Size(128, 37);
            btnAddMaterial.TabIndex = 6;
            btnAddMaterial.Text = "Thêm ";
            btnAddMaterial.TextAlign = ContentAlignment.MiddleRight;
            btnAddMaterial.TextColor = Color.Black;
            btnAddMaterial.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddMaterial.UseVisualStyleBackColor = false;
            btnAddMaterial.Click += btnAddMaterial_Click;
            // 
            // btnFind
            // 
            btnFind.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFind.BackColor = Color.LightSkyBlue;
            btnFind.BackgroundColor = Color.LightSkyBlue;
            btnFind.BorderColor = Color.PaleVioletRed;
            btnFind.BorderRadius = 0;
            btnFind.BorderSize = 0;
            btnFind.FlatAppearance.BorderSize = 0;
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.ForeColor = Color.Black;
            btnFind.Image = Properties.Resources.refresh__1_;
            btnFind.Location = new Point(1008, 65);
            btnFind.Margin = new Padding(3, 4, 3, 4);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(128, 37);
            btnFind.TabIndex = 8;
            btnFind.Text = "Làm mới";
            btnFind.TextAlign = ContentAlignment.MiddleRight;
            btnFind.TextColor = Color.Black;
            btnFind.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // btnTreatment
            // 
            btnTreatment.Anchor = AnchorStyles.Right;
            btnTreatment.BackColor = Color.LightSkyBlue;
            btnTreatment.BackgroundColor = Color.LightSkyBlue;
            btnTreatment.BorderColor = Color.PaleVioletRed;
            btnTreatment.BorderRadius = 0;
            btnTreatment.BorderSize = 0;
            btnTreatment.FlatAppearance.BorderSize = 0;
            btnTreatment.FlatStyle = FlatStyle.Flat;
            btnTreatment.ForeColor = Color.Black;
            btnTreatment.Image = Properties.Resources.search;
            btnTreatment.Location = new Point(606, 113);
            btnTreatment.Margin = new Padding(3, 4, 3, 4);
            btnTreatment.Name = "btnTreatment";
            btnTreatment.RightToLeft = RightToLeft.No;
            btnTreatment.Size = new Size(128, 37);
            btnTreatment.TabIndex = 33;
            btnTreatment.Text = "  Lọc";
            btnTreatment.TextAlign = ContentAlignment.MiddleRight;
            btnTreatment.TextColor = Color.Black;
            btnTreatment.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTreatment.UseVisualStyleBackColor = false;
            btnTreatment.Click += btnTreatment_Click;
            // 
            // Active
            // 
            Active.Anchor = AnchorStyles.Right;
            Active.Location = new Point(1028, 164);
            Active.Margin = new Padding(3, 4, 3, 4);
            Active.MinimumSize = new Size(51, 29);
            Active.Name = "Active";
            Active.OffBackColor = Color.Gray;
            Active.OffToggleColor = Color.Gainsboro;
            Active.OnBackColor = Color.LightSkyBlue;
            Active.OnToggleColor = Color.WhiteSmoke;
            Active.Size = new Size(66, 35);
            Active.TabIndex = 30;
            Active.UseVisualStyleBackColor = true;
            Active.CheckedChanged += Active_CheckedChanged;
            // 
            // panelCustom4
            // 
            panelCustom4.Controls.Add(panel1);
            panelCustom4.Controls.Add(panelCustom6);
            panelCustom4.Controls.Add(dataGridViewMaterial);
            panelCustom4.Dock = DockStyle.Fill;
            panelCustom4.Location = new Point(14, 16);
            panelCustom4.Name = "panelCustom4";
            panelCustom4.Size = new Size(1196, 748);
            panelCustom4.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(buttonDeleteType);
            panel1.Controls.Add(btnRefreshType);
            panel1.Controls.Add(btnAddType);
            panel1.Controls.Add(inputTypeMaterial);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnTreatment);
            panel1.Controls.Add(label5Loc);
            panel1.Controls.Add(Active);
            panel1.Controls.Add(btnFind);
            panel1.Controls.Add(edtFindMaterial);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnAddMaterial);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(27, 20);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1139, 215);
            panel1.TabIndex = 0;
            // 
            // buttonDeleteType
            // 
            buttonDeleteType.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDeleteType.BackColor = Color.LightSkyBlue;
            buttonDeleteType.BackgroundColor = Color.LightSkyBlue;
            buttonDeleteType.BorderColor = Color.PaleVioletRed;
            buttonDeleteType.BorderRadius = 0;
            buttonDeleteType.BorderSize = 0;
            buttonDeleteType.FlatAppearance.BorderSize = 0;
            buttonDeleteType.FlatStyle = FlatStyle.Flat;
            buttonDeleteType.ForeColor = Color.Black;
            buttonDeleteType.Image = Properties.Resources.icons8_remove_24;
            buttonDeleteType.Location = new Point(1008, 113);
            buttonDeleteType.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteType.Name = "buttonDeleteType";
            buttonDeleteType.Size = new Size(128, 37);
            buttonDeleteType.TabIndex = 42;
            buttonDeleteType.Text = "  Xóa";
            buttonDeleteType.TextAlign = ContentAlignment.MiddleRight;
            buttonDeleteType.TextColor = Color.Black;
            buttonDeleteType.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonDeleteType.UseVisualStyleBackColor = false;
            // 
            // btnRefreshType
            // 
            btnRefreshType.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefreshType.BackColor = Color.LightSkyBlue;
            btnRefreshType.BackgroundColor = Color.LightSkyBlue;
            btnRefreshType.BorderColor = Color.PaleVioletRed;
            btnRefreshType.BorderRadius = 0;
            btnRefreshType.BorderSize = 0;
            btnRefreshType.FlatAppearance.BorderSize = 0;
            btnRefreshType.FlatStyle = FlatStyle.Flat;
            btnRefreshType.ForeColor = Color.Black;
            btnRefreshType.Image = Properties.Resources.refresh__1_;
            btnRefreshType.Location = new Point(740, 113);
            btnRefreshType.Margin = new Padding(3, 4, 3, 4);
            btnRefreshType.Name = "btnRefreshType";
            btnRefreshType.Size = new Size(128, 37);
            btnRefreshType.TabIndex = 41;
            btnRefreshType.Text = "Làm mới";
            btnRefreshType.TextAlign = ContentAlignment.MiddleRight;
            btnRefreshType.TextColor = Color.Black;
            btnRefreshType.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefreshType.UseVisualStyleBackColor = false;
            btnRefreshType.Click += btnRefreshType_Click;
            // 
            // btnAddType
            // 
            btnAddType.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddType.BackColor = Color.LightSkyBlue;
            btnAddType.BackgroundColor = Color.LightSkyBlue;
            btnAddType.BorderColor = Color.PaleVioletRed;
            btnAddType.BorderRadius = 0;
            btnAddType.BorderSize = 0;
            btnAddType.FlatAppearance.BorderSize = 0;
            btnAddType.FlatStyle = FlatStyle.Flat;
            btnAddType.ForeColor = Color.Black;
            btnAddType.Image = Properties.Resources.add1;
            btnAddType.Location = new Point(874, 113);
            btnAddType.Margin = new Padding(3, 4, 3, 4);
            btnAddType.Name = "btnAddType";
            btnAddType.Size = new Size(128, 37);
            btnAddType.TabIndex = 40;
            btnAddType.Text = "Thêm ";
            btnAddType.TextAlign = ContentAlignment.MiddleRight;
            btnAddType.TextColor = Color.Black;
            btnAddType.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddType.UseVisualStyleBackColor = false;
            // 
            // inputTypeMaterial
            // 
            inputTypeMaterial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputTypeMaterial.FormattingEnabled = true;
            inputTypeMaterial.Location = new Point(322, 118);
            inputTypeMaterial.Name = "inputTypeMaterial";
            inputTypeMaterial.Size = new Size(261, 28);
            inputTypeMaterial.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 121);
            label2.Name = "label2";
            label2.Size = new Size(205, 25);
            label2.TabIndex = 35;
            label2.Text = "Loại Nguyên Liệu";
            // 
            // label5Loc
            // 
            label5Loc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5Loc.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5Loc.ImageAlign = ContentAlignment.MiddleRight;
            label5Loc.Location = new Point(683, 162);
            label5Loc.Margin = new Padding(0);
            label5Loc.Name = "label5Loc";
            label5Loc.Size = new Size(319, 45);
            label5Loc.TabIndex = 34;
            label5Loc.Text = "Danh Sách Nguyên Liệu Bị Ẩn";
            label5Loc.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // edtFindMaterial
            // 
            edtFindMaterial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            edtFindMaterial.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            edtFindMaterial.Location = new Point(322, 70);
            edtFindMaterial.Margin = new Padding(0);
            edtFindMaterial.Name = "edtFindMaterial";
            edtFindMaterial.Size = new Size(680, 32);
            edtFindMaterial.TabIndex = 33;
            edtFindMaterial.TextChanged += edtFindMaterial_TextChanged;
            // 
            // panelCustom6
            // 
            panelCustom6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panelCustom6.Controls.Add(btnDeleteSelect);
            panelCustom6.Controls.Add(SumPage);
            panelCustom6.Controls.Add(btnAfter);
            panelCustom6.Controls.Add(btnBefore);
            panelCustom6.Controls.Add(numberPage);
            panelCustom6.Controls.Add(label7);
            panelCustom6.Location = new Point(30, 693);
            panelCustom6.Name = "panelCustom6";
            panelCustom6.Size = new Size(1136, 55);
            panelCustom6.TabIndex = 36;
            // 
            // btnDeleteSelect
            // 
            btnDeleteSelect.Anchor = AnchorStyles.None;
            btnDeleteSelect.BackColor = Color.LightSkyBlue;
            btnDeleteSelect.BackgroundColor = Color.LightSkyBlue;
            btnDeleteSelect.BorderColor = Color.PaleVioletRed;
            btnDeleteSelect.BorderRadius = 0;
            btnDeleteSelect.BorderSize = 0;
            btnDeleteSelect.FlatAppearance.BorderSize = 0;
            btnDeleteSelect.FlatStyle = FlatStyle.Flat;
            btnDeleteSelect.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteSelect.ForeColor = Color.Black;
            btnDeleteSelect.Image = Properties.Resources.icons8_remove_24;
            btnDeleteSelect.Location = new Point(130, 12);
            btnDeleteSelect.Margin = new Padding(3, 4, 3, 4);
            btnDeleteSelect.Name = "btnDeleteSelect";
            btnDeleteSelect.RightToLeft = RightToLeft.Yes;
            btnDeleteSelect.Size = new Size(358, 35);
            btnDeleteSelect.TabIndex = 37;
            btnDeleteSelect.Text = "Xóa tất cả nguyên liệu đã chọn";
            btnDeleteSelect.TextColor = Color.Black;
            btnDeleteSelect.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDeleteSelect.UseVisualStyleBackColor = false;
            btnDeleteSelect.Click += btnDeleteSelect_Click;
            // 
            // SumPage
            // 
            SumPage.Anchor = AnchorStyles.None;
            SumPage.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SumPage.ForeColor = SystemColors.Highlight;
            SumPage.Location = new Point(896, 12);
            SumPage.Name = "SumPage";
            SumPage.Size = new Size(123, 36);
            SumPage.TabIndex = 37;
            SumPage.Text = "ded";
            SumPage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAfter
            // 
            btnAfter.Anchor = AnchorStyles.None;
            btnAfter.BackColor = Color.LightSkyBlue;
            btnAfter.BackgroundColor = Color.LightSkyBlue;
            btnAfter.BorderColor = Color.PaleVioletRed;
            btnAfter.BorderRadius = 0;
            btnAfter.BorderSize = 0;
            btnAfter.FlatAppearance.BorderSize = 0;
            btnAfter.FlatStyle = FlatStyle.Flat;
            btnAfter.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAfter.ForeColor = Color.Black;
            btnAfter.Location = new Point(1025, 13);
            btnAfter.Margin = new Padding(3, 4, 3, 4);
            btnAfter.Name = "btnAfter";
            btnAfter.Size = new Size(108, 35);
            btnAfter.TabIndex = 33;
            btnAfter.Text = "Sau";
            btnAfter.TextColor = Color.Black;
            btnAfter.UseVisualStyleBackColor = false;
            btnAfter.Click += btnAfter_Click;
            // 
            // btnBefore
            // 
            btnBefore.Anchor = AnchorStyles.None;
            btnBefore.BackColor = Color.LightSkyBlue;
            btnBefore.BackgroundColor = Color.LightSkyBlue;
            btnBefore.BorderColor = Color.PaleVioletRed;
            btnBefore.BorderRadius = 0;
            btnBefore.BorderSize = 0;
            btnBefore.FlatAppearance.BorderSize = 0;
            btnBefore.FlatStyle = FlatStyle.Flat;
            btnBefore.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBefore.ForeColor = Color.Black;
            btnBefore.Location = new Point(772, 14);
            btnBefore.Margin = new Padding(3, 4, 3, 4);
            btnBefore.Name = "btnBefore";
            btnBefore.Size = new Size(108, 35);
            btnBefore.TabIndex = 34;
            btnBefore.Text = "Trước";
            btnBefore.TextColor = Color.Black;
            btnBefore.UseVisualStyleBackColor = false;
            btnBefore.Click += btnBefore_Click;
            // 
            // numberPage
            // 
            numberPage.Anchor = AnchorStyles.None;
            numberPage.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numberPage.FormattingEnabled = true;
            numberPage.Items.AddRange(new object[] { "10", "20", "30", "40" });
            numberPage.Location = new Point(696, 15);
            numberPage.Margin = new Padding(3, 4, 3, 4);
            numberPage.Name = "numberPage";
            numberPage.Size = new Size(61, 33);
            numberPage.TabIndex = 35;
            numberPage.Tag = "";
            numberPage.SelectedIndexChanged += numberPage_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ImageAlign = ContentAlignment.MiddleRight;
            label7.Location = new Point(491, 17);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(202, 26);
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
            dataGridViewMaterial.Location = new Point(27, 259);
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
            dataGridViewMaterial.Size = new Size(1139, 431);
            dataGridViewMaterial.StandardTab = true;
            dataGridViewMaterial.TabIndex = 35;
            dataGridViewMaterial.CellContentClick += dataGridViewMaterial_CellContentClick;
            dataGridViewMaterial.SelectionChanged += dataGridViewMaterial_SelectionChanged;

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
            ClientSize = new Size(1224, 780);
            ControlBox = false;
            Controls.Add(panelCustom4);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.InactiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManagerMaterial";
            Padding = new Padding(14, 16, 14, 16);
            Text = "ManagerMaterial";
            panelCustom4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelCustom6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterial).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label4;
        private ComponentCustom.ButtonCustom btnAddMaterial;
        private ComponentCustom.ButtonCustom btnFind;
        private ComponentCustom.PanelCustom panelCustom4;
        private ComponentCustom.RJToggle Active;
        private ComponentCustom.ButtonCustom btnTreatment;
        private DataGridView dataGridViewMaterial;
        private ComponentCustom.PanelCustom panelCustom6;
        private ComponentCustom.ButtonCustom btnAfter;
        private ComponentCustom.ButtonCustom btnBefore;
        private ComboBox numberPage;
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
        private Panel panel1;
        private TextBox edtFindMaterial;
        private Label label5Loc;
        private ComboBox inputTypeMaterial;
        private Label label2;
        private Label SumPage;
        private ComponentCustom.ButtonCustom buttonDeleteType;
        private ComponentCustom.ButtonCustom btnRefreshType;
        private ComponentCustom.ButtonCustom btnAddType;
        private ComponentCustom.ButtonCustom btnDeleteSelect;
    }
}