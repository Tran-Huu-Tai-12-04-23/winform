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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            panel1 = new Panel();
            edtFindBake = new TextBox();
            inputTypeBake = new ComboBox();
            btnTreatment = new ComponentCustom.ButtonCustom();
            btnRefreshType = new ComponentCustom.ButtonCustom();
            btnAddType = new ComponentCustom.ButtonCustom();
            buttonDeleteType = new ComponentCustom.ButtonCustom();
            btnFind = new ComponentCustom.ButtonCustom();
            btnAddBake = new ComponentCustom.ButtonCustom();
            Active = new ComponentCustom.RJToggle();
            label5Loc = new Label();
            label1 = new Label();
            label2 = new Label();
            labelCustomerTitle = new Label();
            dataGridViewBake = new DataGridView();
            maBanh = new DataGridViewTextBoxColumn();
            tenLoaiBanh = new DataGridViewTextBoxColumn();
            tenBanh = new DataGridViewTextBoxColumn();
            doVi = new DataGridViewTextBoxColumn();
            giaTien = new DataGridViewTextBoxColumn();
            soLuong = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewCheckBoxColumn();
            Column5 = new DataGridViewImageColumn();
            Column6 = new DataGridViewImageColumn();
            panel2 = new Panel();
            SumPage = new Label();
            btnAfter = new ComponentCustom.ButtonCustom();
            btnBefore = new ComponentCustom.ButtonCustom();
            numberPage = new ComboBox();
            label7 = new Label();
            btnDeleteSelect = new ComponentCustom.ButtonCustom();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBake).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(edtFindBake);
            panel1.Controls.Add(inputTypeBake);
            panel1.Controls.Add(btnTreatment);
            panel1.Controls.Add(btnRefreshType);
            panel1.Controls.Add(btnAddType);
            panel1.Controls.Add(buttonDeleteType);
            panel1.Controls.Add(btnFind);
            panel1.Controls.Add(btnAddBake);
            panel1.Controls.Add(Active);
            panel1.Controls.Add(label5Loc);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(labelCustomerTitle);
            panel1.Location = new Point(25, 20);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1144, 215);
            panel1.TabIndex = 0;
            // 
            // edtFindBake
            // 
            edtFindBake.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            edtFindBake.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            edtFindBake.Location = new Point(217, 68);
            edtFindBake.Margin = new Padding(0);
            edtFindBake.Name = "edtFindBake";
            edtFindBake.Size = new Size(790, 32);
            edtFindBake.TabIndex = 48;
            edtFindBake.TextChanged += edtFindBake_TextChanged;
            // 
            // inputTypeBake
            // 
            inputTypeBake.FormattingEnabled = true;
            inputTypeBake.Location = new Point(217, 126);
            inputTypeBake.Name = "inputTypeBake";
            inputTypeBake.Size = new Size(378, 28);
            inputTypeBake.TabIndex = 47;
            // 
            // btnTreatment
            // 
            btnTreatment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTreatment.BackColor = Color.LightSkyBlue;
            btnTreatment.BackgroundColor = Color.LightSkyBlue;
            btnTreatment.BorderColor = Color.PaleVioletRed;
            btnTreatment.BorderRadius = 0;
            btnTreatment.BorderSize = 0;
            btnTreatment.FlatAppearance.BorderSize = 0;
            btnTreatment.FlatStyle = FlatStyle.Flat;
            btnTreatment.ForeColor = Color.Black;
            btnTreatment.Image = Properties.Resources.search;
            btnTreatment.Location = new Point(609, 121);
            btnTreatment.Margin = new Padding(3, 4, 3, 4);
            btnTreatment.Name = "btnTreatment";
            btnTreatment.RightToLeft = RightToLeft.No;
            btnTreatment.Size = new Size(128, 37);
            btnTreatment.TabIndex = 46;
            btnTreatment.Text = "  Lọc";
            btnTreatment.TextAlign = ContentAlignment.MiddleRight;
            btnTreatment.TextColor = Color.Black;
            btnTreatment.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTreatment.UseVisualStyleBackColor = false;
            btnTreatment.Click += btnTreatment_Click;
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
            btnRefreshType.Location = new Point(743, 121);
            btnRefreshType.Margin = new Padding(3, 4, 3, 4);
            btnRefreshType.Name = "btnRefreshType";
            btnRefreshType.Size = new Size(128, 37);
            btnRefreshType.TabIndex = 45;
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
            btnAddType.Location = new Point(877, 121);
            btnAddType.Margin = new Padding(3, 4, 3, 4);
            btnAddType.Name = "btnAddType";
            btnAddType.Size = new Size(128, 37);
            btnAddType.TabIndex = 44;
            btnAddType.Text = "Thêm ";
            btnAddType.TextAlign = ContentAlignment.MiddleRight;
            btnAddType.TextColor = Color.Black;
            btnAddType.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddType.UseVisualStyleBackColor = false;
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
            buttonDeleteType.Location = new Point(1013, 121);
            buttonDeleteType.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteType.Name = "buttonDeleteType";
            buttonDeleteType.Size = new Size(128, 37);
            buttonDeleteType.TabIndex = 43;
            buttonDeleteType.Text = "  Xóa";
            buttonDeleteType.TextAlign = ContentAlignment.MiddleRight;
            buttonDeleteType.TextColor = Color.Black;
            buttonDeleteType.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonDeleteType.UseVisualStyleBackColor = false;
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
            btnFind.Location = new Point(1013, 65);
            btnFind.Margin = new Padding(3, 4, 3, 4);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(128, 37);
            btnFind.TabIndex = 9;
            btnFind.Text = "Làm mới";
            btnFind.TextAlign = ContentAlignment.MiddleRight;
            btnFind.TextColor = Color.Black;
            btnFind.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // btnAddBake
            // 
            btnAddBake.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddBake.BackColor = Color.LightSkyBlue;
            btnAddBake.BackgroundColor = Color.LightSkyBlue;
            btnAddBake.BorderColor = Color.PaleVioletRed;
            btnAddBake.BorderRadius = 0;
            btnAddBake.BorderSize = 0;
            btnAddBake.FlatAppearance.BorderSize = 0;
            btnAddBake.FlatStyle = FlatStyle.Flat;
            btnAddBake.ForeColor = Color.Black;
            btnAddBake.Image = Properties.Resources.add1;
            btnAddBake.Location = new Point(1013, 12);
            btnAddBake.Margin = new Padding(3, 4, 3, 4);
            btnAddBake.Name = "btnAddBake";
            btnAddBake.Size = new Size(128, 37);
            btnAddBake.TabIndex = 39;
            btnAddBake.Text = "Thêm ";
            btnAddBake.TextAlign = ContentAlignment.MiddleRight;
            btnAddBake.TextColor = Color.Black;
            btnAddBake.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddBake.UseVisualStyleBackColor = false;
            btnAddBake.Click += btnAddBake_Click;
            // 
            // Active
            // 
            Active.Anchor = AnchorStyles.Right;
            Active.Location = new Point(1055, 164);
            Active.Margin = new Padding(3, 4, 3, 4);
            Active.MinimumSize = new Size(51, 29);
            Active.Name = "Active";
            Active.OffBackColor = Color.Gray;
            Active.OffToggleColor = Color.Gainsboro;
            Active.OnBackColor = Color.LightSkyBlue;
            Active.OnToggleColor = Color.WhiteSmoke;
            Active.Size = new Size(66, 35);
            Active.TabIndex = 38;
            Active.UseVisualStyleBackColor = true;
            Active.CheckedChanged += Active_CheckedChanged;
            // 
            // label5Loc
            // 
            label5Loc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5Loc.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5Loc.ImageAlign = ContentAlignment.MiddleRight;
            label5Loc.Location = new Point(787, 160);
            label5Loc.Margin = new Padding(0);
            label5Loc.Name = "label5Loc";
            label5Loc.Size = new Size(319, 45);
            label5Loc.TabIndex = 37;
            label5Loc.Text = "Danh Sách Bánh Bị Ẩn";
            label5Loc.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 124);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 36;
            label1.Text = "Loại Bánh";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 68);
            label2.Margin = new Padding(14, 0, 14, 0);
            label2.Name = "label2";
            label2.Size = new Size(177, 25);
            label2.TabIndex = 3;
            label2.Text = "Tìm kiếm bánh";
            // 
            // labelCustomerTitle
            // 
            labelCustomerTitle.AutoSize = true;
            labelCustomerTitle.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCustomerTitle.Location = new Point(3, 15);
            labelCustomerTitle.Name = "labelCustomerTitle";
            labelCustomerTitle.Size = new Size(190, 25);
            labelCustomerTitle.TabIndex = 1;
            labelCustomerTitle.Text = "Danh sách bánh";
            // 
            // dataGridViewBake
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Padding = new Padding(12);
            dataGridViewBake.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewBake.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewBake.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBake.BackgroundColor = Color.White;
            dataGridViewBake.BorderStyle = BorderStyle.None;
            dataGridViewBake.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewBake.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.Padding = new Padding(0, 12, 0, 12);
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewBake.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewBake.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBake.Columns.AddRange(new DataGridViewColumn[] { maBanh, tenLoaiBanh, tenBanh, doVi, giaTien, soLuong, Column4, Column5, Column6 });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle8.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridViewBake.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewBake.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewBake.EnableHeadersVisualStyles = false;
            dataGridViewBake.GridColor = Color.White;
            dataGridViewBake.Location = new Point(27, 249);
            dataGridViewBake.Margin = new Padding(0);
            dataGridViewBake.Name = "dataGridViewBake";
            dataGridViewBake.ReadOnly = true;
            dataGridViewBake.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewBake.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewBake.RowHeadersWidth = 60;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Padding = new Padding(6, 0, 0, 0);
            dataGridViewBake.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewBake.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewBake.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dataGridViewBake.RowTemplate.DefaultCellStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewBake.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewBake.RowTemplate.DefaultCellStyle.Padding = new Padding(6, 0, 0, 0);
            dataGridViewBake.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.AliceBlue;
            dataGridViewBake.RowTemplate.Height = 60;
            dataGridViewBake.RowTemplate.ReadOnly = true;
            dataGridViewBake.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridViewBake.ShowEditingIcon = false;
            dataGridViewBake.Size = new Size(1142, 341);
            dataGridViewBake.StandardTab = true;
            dataGridViewBake.TabIndex = 36;
            dataGridViewBake.CellContentClick += dataGridViewBake_CellContentClick;
            dataGridViewBake.SelectionChanged += dataGridViewBake_SelectionChanged;
            // 
            // maBanh
            // 
            maBanh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maBanh.HeaderText = "Mã Bánh";
            maBanh.MinimumWidth = 6;
            maBanh.Name = "maBanh";
            maBanh.ReadOnly = true;
            // 
            // tenLoaiBanh
            // 
            tenLoaiBanh.HeaderText = "Loại Bánh";
            tenLoaiBanh.MinimumWidth = 6;
            tenLoaiBanh.Name = "tenLoaiBanh";
            tenLoaiBanh.ReadOnly = true;
            // 
            // tenBanh
            // 
            tenBanh.HeaderText = "Tên Bánh";
            tenBanh.MinimumWidth = 6;
            tenBanh.Name = "tenBanh";
            tenBanh.ReadOnly = true;
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
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(SumPage);
            panel2.Controls.Add(btnAfter);
            panel2.Controls.Add(btnBefore);
            panel2.Controls.Add(numberPage);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btnDeleteSelect);
            panel2.Location = new Point(42, 593);
            panel2.Name = "panel2";
            panel2.Size = new Size(1126, 58);
            panel2.TabIndex = 39;
            // 
            // SumPage
            // 
            SumPage.Anchor = AnchorStyles.None;
            SumPage.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SumPage.ForeColor = SystemColors.Highlight;
            SumPage.Location = new Point(869, 12);
            SumPage.Name = "SumPage";
            SumPage.Size = new Size(123, 36);
            SumPage.TabIndex = 43;
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
            btnAfter.Location = new Point(999, 12);
            btnAfter.Margin = new Padding(3, 4, 3, 4);
            btnAfter.Name = "btnAfter";
            btnAfter.Size = new Size(108, 35);
            btnAfter.TabIndex = 42;
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
            btnBefore.Location = new Point(753, 12);
            btnBefore.Margin = new Padding(3, 4, 3, 4);
            btnBefore.Name = "btnBefore";
            btnBefore.Size = new Size(108, 35);
            btnBefore.TabIndex = 41;
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
            numberPage.Location = new Point(667, 14);
            numberPage.Margin = new Padding(3, 4, 3, 4);
            numberPage.Name = "numberPage";
            numberPage.Size = new Size(61, 33);
            numberPage.TabIndex = 40;
            numberPage.Tag = "";
            numberPage.SelectedIndexChanged += numberPage_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ImageAlign = ContentAlignment.MiddleRight;
            label7.Location = new Point(462, 16);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(202, 26);
            label7.TabIndex = 39;
            label7.Text = "Số hàng hiển thị : ";
            label7.TextAlign = ContentAlignment.MiddleRight;
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
            btnDeleteSelect.Location = new Point(154, 12);
            btnDeleteSelect.Margin = new Padding(3, 4, 3, 4);
            btnDeleteSelect.Name = "btnDeleteSelect";
            btnDeleteSelect.RightToLeft = RightToLeft.Yes;
            btnDeleteSelect.Size = new Size(305, 35);
            btnDeleteSelect.TabIndex = 38;
            btnDeleteSelect.Text = "Xóa tất cả bánh đã chọn";
            btnDeleteSelect.TextColor = Color.Black;
            btnDeleteSelect.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDeleteSelect.UseVisualStyleBackColor = false;
            btnDeleteSelect.Click += btnDeleteSelect_Click;
            // 
            // ManagerBake
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 246, 249);
            ClientSize = new Size(1187, 649);
            Controls.Add(panel2);
            Controls.Add(dataGridViewBake);
            Controls.Add(panel1);
            ForeColor = SystemColors.InactiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManagerBake";
            Padding = new Padding(14, 16, 14, 16);
            Text = "ManagerBake";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBake).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelCustomerTitle;
        private Label label2;
        private ComponentCustom.ButtonCustom btnAddBake;
        private ComponentCustom.RJToggle Active;
        private Label label5Loc;
        private Label label1;
        private ComponentCustom.ButtonCustom btnFind;
        private ComboBox inputTypeBake;
        private ComponentCustom.ButtonCustom btnTreatment;
        private ComponentCustom.ButtonCustom btnRefreshType;
        private ComponentCustom.ButtonCustom btnAddType;
        private ComponentCustom.ButtonCustom buttonDeleteType;
        private TextBox edtFindBake;
        private DataGridView dataGridViewBake;
        private DataGridViewTextBoxColumn maBanh;
        private DataGridViewTextBoxColumn tenLoaiBanh;
        private DataGridViewTextBoxColumn tenBanh;
        private DataGridViewTextBoxColumn doVi;
        private DataGridViewTextBoxColumn giaTien;
        private DataGridViewTextBoxColumn soLuong;
        private DataGridViewCheckBoxColumn Column4;
        private DataGridViewImageColumn Column5;
        private DataGridViewImageColumn Column6;
        private Panel panel2;
        private Label SumPage;
        private ComponentCustom.ButtonCustom btnAfter;
        private ComponentCustom.ButtonCustom btnBefore;
        private ComboBox numberPage;
        private Label label7;
        private ComponentCustom.ButtonCustom btnDeleteSelect;
    }
}