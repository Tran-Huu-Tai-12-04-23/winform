namespace FinalProject_QUANLYKHO.View.ImportMaterialView
{
    partial class DetailInvoice
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
            lbExportDepartment = new Label();
            btnPrevInvoice = new ComponentCustom.ButtonCustom();
            btnNextInvoice = new ComponentCustom.ButtonCustom();
            lbIdInvoice = new Label();
            label3 = new Label();
            label2 = new Label();
            labelCustomerTitle = new Label();
            panel3 = new Panel();
            dataGridViewDetailInvoice = new DataGridView();
            maKhachHang = new DataGridViewTextBoxColumn();
            tenKhachHang = new DataGridViewTextBoxColumn();
            diaChi = new DataGridViewTextBoxColumn();
            soDienThoai = new DataGridViewTextBoxColumn();
            thanhTien = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewImageColumn();
            Column6 = new DataGridViewImageColumn();
            lbTotalInvoce = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetailInvoice).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lbTotalInvoce);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbExportDepartment);
            panel1.Controls.Add(btnPrevInvoice);
            panel1.Controls.Add(btnNextInvoice);
            panel1.Controls.Add(lbIdInvoice);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(labelCustomerTitle);
            panel1.Location = new Point(9, 12);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1157, 129);
            panel1.TabIndex = 10;
            // 
            // lbExportDepartment
            // 
            lbExportDepartment.AutoSize = true;
            lbExportDepartment.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbExportDepartment.ForeColor = SystemColors.HotTrack;
            lbExportDepartment.Location = new Point(547, 70);
            lbExportDepartment.Name = "lbExportDepartment";
            lbExportDepartment.Size = new Size(89, 25);
            lbExportDepartment.TabIndex = 11;
            lbExportDepartment.Text = "Tap Vu";
            // 
            // btnPrevInvoice
            // 
            btnPrevInvoice.BackColor = Color.White;
            btnPrevInvoice.BackgroundColor = Color.White;
            btnPrevInvoice.BorderColor = Color.PaleVioletRed;
            btnPrevInvoice.BorderRadius = 4;
            btnPrevInvoice.BorderSize = 0;
            btnPrevInvoice.FlatAppearance.BorderSize = 0;
            btnPrevInvoice.FlatStyle = FlatStyle.Flat;
            btnPrevInvoice.ForeColor = Color.White;
            btnPrevInvoice.Image = Properties.Resources.icon_prev1;
            btnPrevInvoice.Location = new Point(157, 67);
            btnPrevInvoice.Margin = new Padding(3, 4, 3, 4);
            btnPrevInvoice.Name = "btnPrevInvoice";
            btnPrevInvoice.Padding = new Padding(14, 16, 14, 16);
            btnPrevInvoice.Size = new Size(53, 37);
            btnPrevInvoice.TabIndex = 9;
            btnPrevInvoice.TextColor = Color.White;
            btnPrevInvoice.UseVisualStyleBackColor = false;
            btnPrevInvoice.Click += btnPrevInvoice_Click;
            // 
            // btnNextInvoice
            // 
            btnNextInvoice.BackColor = Color.White;
            btnNextInvoice.BackgroundColor = Color.White;
            btnNextInvoice.BorderColor = Color.PaleVioletRed;
            btnNextInvoice.BorderRadius = 20;
            btnNextInvoice.BorderSize = 0;
            btnNextInvoice.FlatAppearance.BorderSize = 0;
            btnNextInvoice.FlatStyle = FlatStyle.Flat;
            btnNextInvoice.ForeColor = Color.White;
            btnNextInvoice.Image = Properties.Resources.icons8_next_48;
            btnNextInvoice.Location = new Point(373, 67);
            btnNextInvoice.Margin = new Padding(3, 4, 3, 4);
            btnNextInvoice.Name = "btnNextInvoice";
            btnNextInvoice.Size = new Size(53, 37);
            btnNextInvoice.TabIndex = 1;
            btnNextInvoice.TextColor = Color.White;
            btnNextInvoice.UseVisualStyleBackColor = false;
            btnNextInvoice.Click += btnNextInvoice_Click;
            // 
            // lbIdInvoice
            // 
            lbIdInvoice.AutoSize = true;
            lbIdInvoice.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbIdInvoice.ForeColor = SystemColors.HotTrack;
            lbIdInvoice.Location = new Point(216, 73);
            lbIdInvoice.Name = "lbIdInvoice";
            lbIdInvoice.Size = new Size(167, 25);
            lbIdInvoice.TabIndex = 8;
            lbIdInvoice.Text = "mahoadon-01";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(14, 73);
            label3.Name = "label3";
            label3.Size = new Size(163, 25);
            label3.TabIndex = 7;
            label3.Text = "Mã hóa đơn : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(448, 75);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 5;
            label2.Text = "Xuất cho";
            // 
            // labelCustomerTitle
            // 
            labelCustomerTitle.AutoSize = true;
            labelCustomerTitle.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCustomerTitle.Location = new Point(14, 15);
            labelCustomerTitle.Name = "labelCustomerTitle";
            labelCustomerTitle.Size = new Size(230, 25);
            labelCustomerTitle.TabIndex = 0;
            labelCustomerTitle.Text = "Chi tiết mã hóa đơn";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.AutoSize = true;
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(dataGridViewDetailInvoice);
            panel3.Location = new Point(9, 131);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1157, 625);
            panel3.TabIndex = 9;
            // 
            // dataGridViewDetailInvoice
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Padding = new Padding(12);
            dataGridViewDetailInvoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewDetailInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDetailInvoice.BackgroundColor = Color.White;
            dataGridViewDetailInvoice.BorderStyle = BorderStyle.None;
            dataGridViewDetailInvoice.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewDetailInvoice.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.Padding = new Padding(0, 12, 0, 12);
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewDetailInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewDetailInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDetailInvoice.Columns.AddRange(new DataGridViewColumn[] { maKhachHang, tenKhachHang, diaChi, soDienThoai, thanhTien, Column5, Column6 });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle8.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridViewDetailInvoice.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewDetailInvoice.Dock = DockStyle.Fill;
            dataGridViewDetailInvoice.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewDetailInvoice.EnableHeadersVisualStyles = false;
            dataGridViewDetailInvoice.GridColor = Color.White;
            dataGridViewDetailInvoice.Location = new Point(0, 0);
            dataGridViewDetailInvoice.Margin = new Padding(0);
            dataGridViewDetailInvoice.Name = "dataGridViewDetailInvoice";
            dataGridViewDetailInvoice.ReadOnly = true;
            dataGridViewDetailInvoice.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewDetailInvoice.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewDetailInvoice.RowHeadersWidth = 60;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Padding = new Padding(6, 0, 0, 0);
            dataGridViewDetailInvoice.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewDetailInvoice.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDetailInvoice.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dataGridViewDetailInvoice.RowTemplate.DefaultCellStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewDetailInvoice.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewDetailInvoice.RowTemplate.DefaultCellStyle.Padding = new Padding(6, 0, 0, 0);
            dataGridViewDetailInvoice.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.AliceBlue;
            dataGridViewDetailInvoice.RowTemplate.Height = 60;
            dataGridViewDetailInvoice.RowTemplate.ReadOnly = true;
            dataGridViewDetailInvoice.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridViewDetailInvoice.ShowEditingIcon = false;
            dataGridViewDetailInvoice.Size = new Size(1157, 625);
            dataGridViewDetailInvoice.StandardTab = true;
            dataGridViewDetailInvoice.TabIndex = 0;
            // 
            // maKhachHang
            // 
            maKhachHang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maKhachHang.HeaderText = "Tên nguyên liệu";
            maKhachHang.MinimumWidth = 6;
            maKhachHang.Name = "maKhachHang";
            maKhachHang.ReadOnly = true;
            // 
            // tenKhachHang
            // 
            tenKhachHang.HeaderText = "Tồn";
            tenKhachHang.MinimumWidth = 6;
            tenKhachHang.Name = "tenKhachHang";
            tenKhachHang.ReadOnly = true;
            // 
            // diaChi
            // 
            diaChi.HeaderText = "Đơn vị";
            diaChi.MinimumWidth = 6;
            diaChi.Name = "diaChi";
            diaChi.ReadOnly = true;
            // 
            // soDienThoai
            // 
            soDienThoai.HeaderText = "Số lượng";
            soDienThoai.MinimumWidth = 6;
            soDienThoai.Name = "soDienThoai";
            soDienThoai.ReadOnly = true;
            // 
            // thanhTien
            // 
            thanhTien.HeaderText = "Thành tiền";
            thanhTien.MinimumWidth = 6;
            thanhTien.Name = "thanhTien";
            thanhTien.ReadOnly = true;
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
            // lbTotalInvoce
            // 
            lbTotalInvoce.AutoSize = true;
            lbTotalInvoce.BackColor = Color.LightSkyBlue;
            lbTotalInvoce.FlatStyle = FlatStyle.Flat;
            lbTotalInvoce.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTotalInvoce.ForeColor = Color.White;
            lbTotalInvoce.Location = new Point(781, 67);
            lbTotalInvoce.Name = "lbTotalInvoce";
            lbTotalInvoce.Padding = new Padding(5);
            lbTotalInvoce.Size = new Size(171, 35);
            lbTotalInvoce.TabIndex = 45;
            lbTotalInvoce.Text = "3 000 000 vnd";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(668, 75);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 44;
            label1.Text = "Tổng tiền";
            // 
            // DetailInvoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1176, 768);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DetailInvoice";
            Text = "DetailInvoce";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetailInvoice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label labelCustomerTitle;
        private Panel panel3;
        private DataGridView dataGridViewDetailInvoice;
        private ComponentCustom.ButtonCustom btnPrevInvoice;
        private ComponentCustom.ButtonCustom btnNextInvoice;
        private Label lbIdInvoice;
        private DataGridViewTextBoxColumn maKhachHang;
        private DataGridViewTextBoxColumn tenKhachHang;
        private DataGridViewTextBoxColumn diaChi;
        private DataGridViewTextBoxColumn soDienThoai;
        private DataGridViewTextBoxColumn thanhTien;
        private DataGridViewImageColumn Column5;
        private DataGridViewImageColumn Column6;
        private Label lbExportDepartment;
        private Label lbTotalInvoce;
        private Label label1;
    }
}