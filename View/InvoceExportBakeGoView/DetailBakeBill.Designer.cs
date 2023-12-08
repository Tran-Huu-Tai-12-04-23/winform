﻿namespace FinalProject_QUANLYKHO.View.ImportMaterialView
{
    partial class DetailBakeBill
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnAddRow = new ComponentCustom.ButtonCustom();
            btnSaveEdit = new ComponentCustom.ButtonCustom();
            btnRefresh = new ComponentCustom.ButtonCustom();
            lbTotalInvoce = new Label();
            label1 = new Label();
            lbExportDepartment = new Label();
            label2 = new Label();
            labelCustomerTitle = new Label();
            panel3 = new Panel();
            dataGridViewDetailInvoice = new DataGridView();
            Column1 = new DataGridViewButtonColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ton = new DataGridViewTextBoxColumn();
            col2 = new DataGridViewTextBoxColumn();
            col3 = new DataGridViewTextBoxColumn();
            tong = new DataGridViewTextBoxColumn();
            remove = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetailInvoice).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(28, 38, 45);
            panel1.Controls.Add(btnAddRow);
            panel1.Controls.Add(btnSaveEdit);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(lbTotalInvoce);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbExportDepartment);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(labelCustomerTitle);
            panel1.Location = new Point(23, 12);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1126, 129);
            panel1.TabIndex = 10;
            // 
            // btnAddRow
            // 
            btnAddRow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddRow.BackColor = Color.FromArgb(12, 85, 255);
            btnAddRow.BackgroundColor = Color.FromArgb(12, 85, 255);
            btnAddRow.BorderColor = Color.PaleVioletRed;
            btnAddRow.BorderRadius = 6;
            btnAddRow.BorderSize = 0;
            btnAddRow.FlatAppearance.BorderSize = 0;
            btnAddRow.FlatStyle = FlatStyle.Flat;
            btnAddRow.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddRow.ForeColor = Color.White;
            btnAddRow.Image = Properties.Resources.add1;
            btnAddRow.Location = new Point(989, 77);
            btnAddRow.Margin = new Padding(3, 4, 3, 4);
            btnAddRow.MaximumSize = new Size(229, 80);
            btnAddRow.Name = "btnAddRow";
            btnAddRow.RightToLeft = RightToLeft.Yes;
            btnAddRow.Size = new Size(133, 37);
            btnAddRow.TabIndex = 48;
            btnAddRow.Text = "Thêm hàng";
            btnAddRow.TextColor = Color.White;
            btnAddRow.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAddRow.UseVisualStyleBackColor = false;
            btnAddRow.Click += btnAddRow_Click;
            // 
            // btnSaveEdit
            // 
            btnSaveEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSaveEdit.BackColor = Color.FromArgb(70, 92, 110);
            btnSaveEdit.BackgroundColor = Color.FromArgb(70, 92, 110);
            btnSaveEdit.BorderColor = Color.PaleVioletRed;
            btnSaveEdit.BorderRadius = 6;
            btnSaveEdit.BorderSize = 0;
            btnSaveEdit.FlatAppearance.BorderSize = 0;
            btnSaveEdit.FlatStyle = FlatStyle.Flat;
            btnSaveEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveEdit.ForeColor = Color.White;
            btnSaveEdit.Image = Properties.Resources.icons8_update_24;
            btnSaveEdit.Location = new Point(821, 77);
            btnSaveEdit.Margin = new Padding(3, 4, 3, 4);
            btnSaveEdit.MaximumSize = new Size(229, 80);
            btnSaveEdit.Name = "btnSaveEdit";
            btnSaveEdit.Size = new Size(162, 37);
            btnSaveEdit.TabIndex = 47;
            btnSaveEdit.Text = "Lưu thay đổi";
            btnSaveEdit.TextColor = Color.White;
            btnSaveEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSaveEdit.UseVisualStyleBackColor = false;
            btnSaveEdit.Click += btnSaveEdit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(28, 38, 45);
            btnRefresh.BackgroundColor = Color.FromArgb(28, 38, 45);
            btnRefresh.BorderColor = Color.PaleVioletRed;
            btnRefresh.BorderRadius = 6;
            btnRefresh.BorderSize = 0;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Image = Properties.Resources.icons8_refresh_24;
            btnRefresh.Location = new Point(704, 77);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.MaximumSize = new Size(229, 80);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.RightToLeft = RightToLeft.Yes;
            btnRefresh.Size = new Size(121, 37);
            btnRefresh.TabIndex = 46;
            btnRefresh.Text = "Làm mới";
            btnRefresh.TextColor = Color.White;
            btnRefresh.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lbTotalInvoce
            // 
            lbTotalInvoce.AutoSize = true;
            lbTotalInvoce.BackColor = Color.Transparent;
            lbTotalInvoce.FlatStyle = FlatStyle.Flat;
            lbTotalInvoce.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotalInvoce.ForeColor = Color.FromArgb(12, 85, 255);
            lbTotalInvoce.Location = new Point(295, 72);
            lbTotalInvoce.Name = "lbTotalInvoce";
            lbTotalInvoce.Padding = new Padding(5, 5, 5, 5);
            lbTotalInvoce.Size = new Size(156, 30);
            lbTotalInvoce.TabIndex = 45;
            lbTotalInvoce.Text = "3 000 000 vnd";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(208, 77);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 44;
            label1.Text = "Tổng tiền";
            // 
            // lbExportDepartment
            // 
            lbExportDepartment.AutoSize = true;
            lbExportDepartment.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbExportDepartment.ForeColor = SystemColors.HotTrack;
            lbExportDepartment.Location = new Point(101, 77);
            lbExportDepartment.Name = "lbExportDepartment";
            lbExportDepartment.Size = new Size(75, 20);
            lbExportDepartment.TabIndex = 11;
            lbExportDepartment.Text = "Tap Vu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(17, 77);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 5;
            label2.Text = "Xuất cho";
            // 
            // labelCustomerTitle
            // 
            labelCustomerTitle.AutoSize = true;
            labelCustomerTitle.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCustomerTitle.ForeColor = Color.White;
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
            panel3.Location = new Point(23, 141);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1126, 605);
            panel3.TabIndex = 9;
            // 
            // dataGridViewDetailInvoice
            // 
            dataGridViewDetailInvoice.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(28, 38, 45);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(12);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(28, 38, 45);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewDetailInvoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewDetailInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewDetailInvoice.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridViewDetailInvoice.BackgroundColor = Color.FromArgb(39, 52, 62);
            dataGridViewDetailInvoice.BorderStyle = BorderStyle.None;
            dataGridViewDetailInvoice.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewDetailInvoice.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(63, 84, 100);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(0, 12, 0, 12);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(63, 84, 100);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewDetailInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewDetailInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDetailInvoice.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, ton, col2, col3, tong, remove });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(63, 84, 100);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(63, 84, 100);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewDetailInvoice.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewDetailInvoice.Dock = DockStyle.Fill;
            dataGridViewDetailInvoice.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewDetailInvoice.EnableHeadersVisualStyles = false;
            dataGridViewDetailInvoice.GridColor = Color.FromArgb(28, 38, 45);
            dataGridViewDetailInvoice.Location = new Point(0, 0);
            dataGridViewDetailInvoice.Margin = new Padding(0);
            dataGridViewDetailInvoice.Name = "dataGridViewDetailInvoice";
            dataGridViewDetailInvoice.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(39, 52, 62);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(39, 52, 62);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewDetailInvoice.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewDetailInvoice.RowHeadersVisible = false;
            dataGridViewDetailInvoice.RowHeadersWidth = 60;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(39, 52, 62);
            dataGridViewCellStyle6.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.Padding = new Padding(12);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(39, 52, 62);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(51, 145, 238);
            dataGridViewDetailInvoice.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewDetailInvoice.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDetailInvoice.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(39, 52, 62);
            dataGridViewDetailInvoice.RowTemplate.DefaultCellStyle.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewDetailInvoice.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dataGridViewDetailInvoice.RowTemplate.DefaultCellStyle.Padding = new Padding(12);
            dataGridViewDetailInvoice.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(39, 52, 62);
            dataGridViewDetailInvoice.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewDetailInvoice.RowTemplate.Height = 30;
            dataGridViewDetailInvoice.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridViewDetailInvoice.ShowEditingIcon = false;
            dataGridViewDetailInvoice.Size = new Size(1126, 605);
            dataGridViewDetailInvoice.StandardTab = true;
            dataGridViewDetailInvoice.TabIndex = 40;
            dataGridViewDetailInvoice.CellContentClick += dataGridViewDetailInvoice_CellContentClick;
            dataGridViewDetailInvoice.CellValueChanged += dataGridViewDetailInvoice_CellValueChanged;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(39, 52, 62);
            dataGridViewCellStyle3.ForeColor = Color.Transparent;
            dataGridViewCellStyle3.NullValue = "Chọn nguyên liệu";
            dataGridViewCellStyle3.Padding = new Padding(12);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(39, 52, 62);
            dataGridViewCellStyle3.SelectionForeColor = Color.Transparent;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            Column1.DefaultCellStyle = dataGridViewCellStyle3;
            Column1.FlatStyle = FlatStyle.Flat;
            Column1.HeaderText = "Bánh";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Resizable = DataGridViewTriState.True;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Tên loại Bánh";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // ton
            // 
            ton.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ton.HeaderText = "Tồn";
            ton.MinimumWidth = 6;
            ton.Name = "ton";
            ton.ReadOnly = true;
            // 
            // col2
            // 
            col2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col2.HeaderText = "Đơn vị";
            col2.MinimumWidth = 6;
            col2.Name = "col2";
            col2.ReadOnly = true;
            // 
            // col3
            // 
            col3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col3.HeaderText = "Số lượng";
            col3.MinimumWidth = 6;
            col3.Name = "col3";
            // 
            // tong
            // 
            tong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tong.HeaderText = "Tổng tiền";
            tong.MinimumWidth = 6;
            tong.Name = "tong";
            tong.ReadOnly = true;
            // 
            // remove
            // 
            remove.HeaderText = "Xóa";
            remove.Image = Properties.Resources.icons8_remove_24;
            remove.MinimumWidth = 6;
            remove.Name = "remove";
            remove.Resizable = DataGridViewTriState.True;
            remove.SortMode = DataGridViewColumnSortMode.Automatic;
            remove.Width = 66;
            // 
            // DetailBakeBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 38, 45);
            ClientSize = new Size(1176, 776);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DetailBakeBill";
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
        private Label label2;
        private Label labelCustomerTitle;
        private Panel panel3;
        private Label lbExportDepartment;
        private Label lbTotalInvoce;
        private Label label1;
        private DataGridView dataGridViewDetailInvoice;
        private ComponentCustom.ButtonCustom btnRefresh;
        private ComponentCustom.ButtonCustom btnSaveEdit;
        private ComponentCustom.ButtonCustom btnAddRow;
        private DataGridViewButtonColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn ton;
        private DataGridViewTextBoxColumn col2;
        private DataGridViewTextBoxColumn col3;
        private DataGridViewTextBoxColumn tong;
        private DataGridViewImageColumn remove;
    }
}