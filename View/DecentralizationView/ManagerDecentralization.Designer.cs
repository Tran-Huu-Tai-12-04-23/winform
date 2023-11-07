using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinalProject_QUANLYKHO.View.DecentralizationView
{
    partial class ManagerDecentralization
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
            panel1 = new Panel();
            label1 = new Label();
            dataGridViewDecentralization = new DataGridView();
            idPhanQuyen = new DataGridViewLinkColumn();
            tenTaiKhoan = new DataGridViewTextBoxColumn();
            ngayBatDau = new DataGridViewTextBoxColumn();
            ngayKetThuc = new DataGridViewTextBoxColumn();
            quyenThem = new DataGridViewTextBoxColumn();
            quyenSua = new DataGridViewTextBoxColumn();
            quyenXoa = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewImageColumn();
            Column6 = new DataGridViewImageColumn();
            xemChiTiet = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDecentralization).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(24, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(997, 36);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(264, 18);
            label1.TabIndex = 0;
            label1.Text = "Quyền đang có trên hệ thống";
            // 
            // dataGridViewDecentralization
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Padding = new Padding(12);
            dataGridViewDecentralization.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewDecentralization.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewDecentralization.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDecentralization.BackgroundColor = Color.White;
            dataGridViewDecentralization.BorderStyle = BorderStyle.None;
            dataGridViewDecentralization.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewDecentralization.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Padding = new Padding(0, 12, 0, 12);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewDecentralization.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewDecentralization.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDecentralization.Columns.AddRange(new DataGridViewColumn[] { idPhanQuyen, tenTaiKhoan, ngayBatDau, ngayKetThuc, quyenThem, quyenSua, quyenXoa, Column5, Column6, xemChiTiet });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle3.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewDecentralization.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewDecentralization.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewDecentralization.EnableHeadersVisualStyles = false;
            dataGridViewDecentralization.GridColor = Color.White;
            dataGridViewDecentralization.Location = new Point(24, 67);
            dataGridViewDecentralization.Margin = new Padding(0);
            dataGridViewDecentralization.Name = "dataGridViewDecentralization";
            dataGridViewDecentralization.ReadOnly = true;
            dataGridViewDecentralization.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewDecentralization.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewDecentralization.RowHeadersWidth = 60;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(6, 0, 0, 0);
            dataGridViewDecentralization.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewDecentralization.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDecentralization.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dataGridViewDecentralization.RowTemplate.DefaultCellStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewDecentralization.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewDecentralization.RowTemplate.DefaultCellStyle.Padding = new Padding(6, 0, 0, 0);
            dataGridViewDecentralization.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.AliceBlue;
            dataGridViewDecentralization.RowTemplate.Height = 60;
            dataGridViewDecentralization.RowTemplate.ReadOnly = true;
            dataGridViewDecentralization.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridViewDecentralization.ShowEditingIcon = false;
            dataGridViewDecentralization.Size = new Size(997, 462);
            dataGridViewDecentralization.StandardTab = true;
            dataGridViewDecentralization.TabIndex = 2;
            dataGridViewDecentralization.CellContentClick += dataGridViewDecentralization_CellContentClick;
            // 
            // idPhanQuyen
            // 
            idPhanQuyen.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            idPhanQuyen.FillWeight = 67.79661F;
            idPhanQuyen.Frozen = true;
            idPhanQuyen.HeaderText = "Mã phân quyền";
            idPhanQuyen.Name = "idPhanQuyen";
            idPhanQuyen.ReadOnly = true;
            idPhanQuyen.Resizable = DataGridViewTriState.True;
            idPhanQuyen.SortMode = DataGridViewColumnSortMode.Automatic;
            idPhanQuyen.Width = 65;
            // 
            // tenTaiKhoan
            // 
            tenTaiKhoan.FillWeight = 104.600479F;
            tenTaiKhoan.HeaderText = "Tên tài khoản";
            tenTaiKhoan.Name = "tenTaiKhoan";
            tenTaiKhoan.ReadOnly = true;
            // 
            // ngayBatDau
            // 
            ngayBatDau.FillWeight = 104.600479F;
            ngayBatDau.HeaderText = "Ngày áp dụng";
            ngayBatDau.Name = "ngayBatDau";
            ngayBatDau.ReadOnly = true;
            // 
            // ngayKetThuc
            // 
            ngayKetThuc.FillWeight = 104.600479F;
            ngayKetThuc.HeaderText = "Ngày kết thúc";
            ngayKetThuc.Name = "ngayKetThuc";
            ngayKetThuc.ReadOnly = true;
            // 
            // quyenThem
            // 
            quyenThem.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            quyenThem.FillWeight = 104.600479F;
            quyenThem.HeaderText = "Quyền thêm";
            quyenThem.Name = "quyenThem";
            quyenThem.ReadOnly = true;
            // 
            // quyenSua
            // 
            quyenSua.FillWeight = 104.600479F;
            quyenSua.HeaderText = "Quyền Sửa";
            quyenSua.Name = "quyenSua";
            quyenSua.ReadOnly = true;
            // 
            // quyenXoa
            // 
            quyenXoa.FillWeight = 104.600479F;
            quyenXoa.HeaderText = "Quyền Xóa";
            quyenXoa.Name = "quyenXoa";
            quyenXoa.ReadOnly = true;
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
            Column5.Width = 105;
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
            Column6.Width = 60;
            // 
            // xemChiTiet
            // 
            xemChiTiet.FillWeight = 104.600479F;
            xemChiTiet.HeaderText = "Xem chi tiết";
            xemChiTiet.Image = Properties.Resources.icons8_detail_50;
            xemChiTiet.Name = "xemChiTiet";
            xemChiTiet.ReadOnly = true;
            xemChiTiet.Resizable = DataGridViewTriState.True;
            xemChiTiet.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // ManagerDecentralization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 246, 249);
            ClientSize = new Size(1045, 555);
            Controls.Add(panel1);
            Controls.Add(dataGridViewDecentralization);
            ForeColor = SystemColors.InactiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManagerDecentralization";
            Padding = new Padding(12);
            Text = "ManagerBake";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDecentralization).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private DataGridView dataGridViewDecentralization;
        private DataGridViewLinkColumn idPhanQuyen;
        private DataGridViewTextBoxColumn tenTaiKhoan;
        private DataGridViewTextBoxColumn ngayBatDau;
        private DataGridViewTextBoxColumn ngayKetThuc;
        private DataGridViewTextBoxColumn quyenThem;
        private DataGridViewTextBoxColumn quyenSua;
        private DataGridViewTextBoxColumn quyenXoa;
        private DataGridViewImageColumn Column5;
        private DataGridViewImageColumn Column6;
        private DataGridViewImageColumn xemChiTiet;
    }
}
