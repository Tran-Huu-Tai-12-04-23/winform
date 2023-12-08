
namespace FinalProject_QUANLYKHO.View.ImportMaterialView
{
    partial class ManagerExportBakeGo
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel3 = new Panel();
            dataGridViewInvoice = new DataGridView();
            maKhachHang = new DataGridViewTextBoxColumn();
            tenKhachHang = new DataGridViewTextBoxColumn();
            diaChi = new DataGridViewTextBoxColumn();
            soDienThoai = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewImageColumn();
            Column6 = new DataGridViewImageColumn();
            btnAddInvoce = new ComponentCustom.ButtonCustom();
            bindingSource1 = new BindingSource(components);
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
            panel1 = new Panel();
            listExportDepartMent = new ComboBox();
            label2 = new Label();
            dateOfInvoice = new ComponentCustom.RJDatePicker();
            timerSearch = new System.Windows.Forms.Timer(components);
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            panel3.Controls.Add(dataGridViewInvoice);
            panel3.Location = new Point(17, 105);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1241, 712);
            panel3.TabIndex = 5;
            // 
            // dataGridViewInvoice
            // 
            dataGridViewInvoice.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(28, 38, 45);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(12);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(28, 38, 45);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewInvoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewInvoice.BackgroundColor = Color.FromArgb(39, 52, 62);
            dataGridViewInvoice.BorderStyle = BorderStyle.None;
            dataGridViewInvoice.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewInvoice.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewInvoice.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(63, 84, 100);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(0, 12, 0, 12);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(63, 84, 100);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInvoice.Columns.AddRange(new DataGridViewColumn[] { maKhachHang, tenKhachHang, diaChi, soDienThoai, Column4, Column6 });
            dataGridViewInvoice.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(63, 84, 100);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle3.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(63, 84, 100);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewInvoice.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewInvoice.Dock = DockStyle.Fill;
            dataGridViewInvoice.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewInvoice.EnableHeadersVisualStyles = false;
            dataGridViewInvoice.GridColor = Color.FromArgb(39, 52, 62);
            dataGridViewInvoice.ImeMode = ImeMode.On;
            dataGridViewInvoice.Location = new Point(0, 0);
            dataGridViewInvoice.Margin = new Padding(0);
            dataGridViewInvoice.Name = "dataGridViewInvoice";
            dataGridViewInvoice.ReadOnly = true;
            dataGridViewInvoice.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(39, 52, 62);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(39, 52, 62);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewInvoice.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewInvoice.RowHeadersVisible = false;
            dataGridViewInvoice.RowHeadersWidth = 60;
            dataGridViewInvoice.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(39, 52, 62);
            dataGridViewCellStyle5.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(63, 84, 100);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(51, 145, 238);
            dataGridViewInvoice.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewInvoice.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewInvoice.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(39, 52, 62);
            dataGridViewInvoice.RowTemplate.DefaultCellStyle.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewInvoice.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dataGridViewInvoice.RowTemplate.DefaultCellStyle.Padding = new Padding(6, 0, 0, 0);
            dataGridViewInvoice.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(63, 84, 100);
            dataGridViewInvoice.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(51, 145, 238);
            dataGridViewInvoice.RowTemplate.Height = 60;
            dataGridViewInvoice.RowTemplate.ReadOnly = true;
            dataGridViewInvoice.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridViewInvoice.ScrollBars = ScrollBars.Vertical;
            dataGridViewInvoice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewInvoice.ShowEditingIcon = false;
            dataGridViewInvoice.Size = new Size(1241, 712);
            dataGridViewInvoice.StandardTab = true;
            dataGridViewInvoice.TabIndex = 1;
            dataGridViewInvoice.CellContentClick += dataGridViewInvoice_CellContentClick_1;
            // 
            // maKhachHang
            // 
            maKhachHang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maKhachHang.HeaderText = "Mã hóa đơn";
            maKhachHang.MinimumWidth = 6;
            maKhachHang.Name = "maKhachHang";
            maKhachHang.ReadOnly = true;
            // 
            // tenKhachHang
            // 
            tenKhachHang.HeaderText = "Tổng tiền hóa đơn";
            tenKhachHang.MinimumWidth = 6;
            tenKhachHang.Name = "tenKhachHang";
            tenKhachHang.ReadOnly = true;
            // 
            // diaChi
            // 
            diaChi.HeaderText = "Tổng số lượng";
            diaChi.MinimumWidth = 6;
            diaChi.Name = "diaChi";
            diaChi.ReadOnly = true;
            // 
            // soDienThoai
            // 
            soDienThoai.HeaderText = "Xuất cho";
            soDienThoai.MinimumWidth = 6;
            soDienThoai.Name = "soDienThoai";
            soDienThoai.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Chi tiết";
            Column4.Image = Properties.Resources.icons8_invoice_return;
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Resizable = DataGridViewTriState.True;
            Column4.SortMode = DataGridViewColumnSortMode.Automatic;
            Column4.ToolTipText = "Xem chi tiết hóa đơn";
            Column4.Width = 92;
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
            Column6.ToolTipText = "Xóa hóa đơn";
            Column6.Width = 66;
            // 
            // btnAddInvoce
            // 
            btnAddInvoce.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddInvoce.BackColor = Color.FromArgb(51, 145, 238);
            btnAddInvoce.BackgroundColor = Color.FromArgb(51, 145, 238);
            btnAddInvoce.BorderColor = Color.PaleVioletRed;
            btnAddInvoce.BorderRadius = 6;
            btnAddInvoce.BorderSize = 0;
            btnAddInvoce.FlatAppearance.BorderSize = 0;
            btnAddInvoce.FlatStyle = FlatStyle.Flat;
            btnAddInvoce.ForeColor = Color.WhiteSmoke;
            btnAddInvoce.Image = Properties.Resources.add1;
            btnAddInvoce.Location = new Point(1202, 35);
            btnAddInvoce.Margin = new Padding(3, 4, 3, 4);
            btnAddInvoce.Name = "btnAddInvoce";
            btnAddInvoce.Size = new Size(42, 29);
            btnAddInvoce.TabIndex = 2;
            btnAddInvoce.TextAlign = ContentAlignment.MiddleRight;
            btnAddInvoce.TextColor = Color.WhiteSmoke;
            btnAddInvoce.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddInvoce.UseVisualStyleBackColor = false;
            btnAddInvoce.Click += btnAddInvoce_Click;
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(listExportDepartMent);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dateOfInvoice);
            panel1.Controls.Add(btnAddInvoce);
            panel1.Location = new Point(0, 1);
            panel1.Margin = new Padding(14, 16, 14, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(1260, 103);
            panel1.TabIndex = 8;
            // 
            // listExportDepartMent
            // 
            listExportDepartMent.BackColor = Color.FromArgb(39, 52, 62);
            listExportDepartMent.Cursor = Cursors.Hand;
            listExportDepartMent.DropDownStyle = ComboBoxStyle.DropDownList;
            listExportDepartMent.FlatStyle = FlatStyle.Flat;
            listExportDepartMent.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            listExportDepartMent.ForeColor = Color.White;
            listExportDepartMent.FormattingEnabled = true;
            listExportDepartMent.Location = new Point(395, 32);
            listExportDepartMent.Margin = new Padding(3, 4, 3, 4);
            listExportDepartMent.Name = "listExportDepartMent";
            listExportDepartMent.Size = new Size(138, 29);
            listExportDepartMent.TabIndex = 6;
            listExportDepartMent.SelectedIndexChanged += listExportDepartMent_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(296, 37);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 5;
            label2.Text = "Xuất cho";
            // 
            // dateOfInvoice
            // 
            dateOfInvoice.BorderColor = Color.PaleTurquoise;
            dateOfInvoice.BorderSize = 0;
            dateOfInvoice.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dateOfInvoice.Location = new Point(17, 27);
            dateOfInvoice.Margin = new Padding(3, 4, 3, 4);
            dateOfInvoice.MinimumSize = new Size(4, 35);
            dateOfInvoice.Name = "dateOfInvoice";
            dateOfInvoice.Size = new Size(258, 35);
            dateOfInvoice.SkinColor = Color.FromArgb(39, 52, 62);
            dateOfInvoice.TabIndex = 4;
            dateOfInvoice.TextColor = Color.White;
            dateOfInvoice.ValueChanged += dateOfInvoice_ValueChanged;
            // 
            // timerSearch
            // 
            timerSearch.Interval = 200;
            // 
            // ManagerExportMaterialGo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 38, 45);
            ClientSize = new Size(1275, 833);
            Controls.Add(panel1);
            Controls.Add(panel3);
            ForeColor = SystemColors.InactiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManagerExportMaterialGo";
            Padding = new Padding(14, 16, 14, 16);
            Text = "ManagerCustomer";
            Load += ManagerImportMaterial_Load;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel3;
        private BindingSource bindingSource1;
        private Button button2;
        private Label label4;
        private ComponentCustom.RJDatePicker rjDatePicker1;
        private ComponentCustom.RJToggle rjToggle1;
        private Label label3;
        private Button button3;
        private Button button4;
        private ComponentCustom.ButtonCustom buttonCustom1;
        private Button btnSearch;
        private Button button1;
        private ComponentCustom.ButtonCustom buttonCustom2;
        private ComponentCustom.ButtonCustom btnAddInvoce;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private Panel panel1;
        private System.Windows.Forms.Timer timerSearch;
        private ComponentCustom.RJDatePicker dateOfInvoice;
        private ComboBox listExportDepartMent;
        private Label label2;
        private DataGridView dataGridViewInvoice;
        private DataGridViewTextBoxColumn maKhachHang;
        private DataGridViewTextBoxColumn tenKhachHang;
        private DataGridViewTextBoxColumn diaChi;
        private DataGridViewTextBoxColumn soDienThoai;
        private DataGridViewImageColumn Column4;
        private DataGridViewImageColumn Column6;
    }
}
