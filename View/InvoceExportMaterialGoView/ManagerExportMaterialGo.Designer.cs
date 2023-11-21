
namespace FinalProject_QUANLYKHO.View.ImportMaterialView
{
    partial class ManagerExportMaterialGo
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
            dataGridViewInvoice = new DataGridView();
            maHoaDon = new DataGridViewTextBoxColumn();
            tongTien = new DataGridViewTextBoxColumn();
            soLuong = new DataGridViewTextBoxColumn();
            tenBoPhanXuat = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewImageColumn();
            Column6 = new DataGridViewImageColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel3 = new Panel();
            btnAddInvoce = new ComponentCustom.ButtonCustom();
            labelCustomerTitle = new Label();
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
            label1 = new Label();
            timerSearch = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoice).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewInvoice
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Padding = new Padding(12);
            dataGridViewInvoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewInvoice.BackgroundColor = Color.White;
            dataGridViewInvoice.BorderStyle = BorderStyle.None;
            dataGridViewInvoice.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewInvoice.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Padding = new Padding(0, 12, 0, 12);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInvoice.Columns.AddRange(new DataGridViewColumn[] { maHoaDon, tongTien, soLuong, tenBoPhanXuat, Column4, Column6 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle3.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewInvoice.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewInvoice.Dock = DockStyle.Fill;
            dataGridViewInvoice.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewInvoice.EnableHeadersVisualStyles = false;
            dataGridViewInvoice.GridColor = Color.White;
            dataGridViewInvoice.Location = new Point(0, 0);
            dataGridViewInvoice.Margin = new Padding(0);
            dataGridViewInvoice.Name = "dataGridViewInvoice";
            dataGridViewInvoice.ReadOnly = true;
            dataGridViewInvoice.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewInvoice.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewInvoice.RowHeadersWidth = 60;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(6, 0, 0, 0);
            dataGridViewInvoice.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewInvoice.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewInvoice.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dataGridViewInvoice.RowTemplate.DefaultCellStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewInvoice.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewInvoice.RowTemplate.DefaultCellStyle.Padding = new Padding(6, 0, 0, 0);
            dataGridViewInvoice.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.AliceBlue;
            dataGridViewInvoice.RowTemplate.Height = 60;
            dataGridViewInvoice.RowTemplate.ReadOnly = true;
            dataGridViewInvoice.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridViewInvoice.ShowEditingIcon = false;
            dataGridViewInvoice.Size = new Size(1219, 661);
            dataGridViewInvoice.StandardTab = true;
            dataGridViewInvoice.TabIndex = 0;
            dataGridViewInvoice.CellContentClick += dataGridViewInvoice_CellContentClick;
            // 
            // maHoaDon
            // 
            maHoaDon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maHoaDon.HeaderText = "Mã hóa đơn";
            maHoaDon.MinimumWidth = 6;
            maHoaDon.Name = "maHoaDon";
            maHoaDon.ReadOnly = true;
            // 
            // tongTien
            // 
            tongTien.HeaderText = "Tổng tiền hóa đơn";
            tongTien.MinimumWidth = 6;
            tongTien.Name = "tongTien";
            tongTien.ReadOnly = true;
            // 
            // soLuong
            // 
            soLuong.HeaderText = "Số lượng";
            soLuong.MinimumWidth = 6;
            soLuong.Name = "soLuong";
            soLuong.ReadOnly = true;
            // 
            // tenBoPhanXuat
            // 
            tenBoPhanXuat.HeaderText = "xuất cho";
            tenBoPhanXuat.MinimumWidth = 6;
            tenBoPhanXuat.Name = "tenBoPhanXuat";
            tenBoPhanXuat.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Chi tiết hóa đơn";
            Column4.Image = Properties.Resources.icons8_detail_50;
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Resizable = DataGridViewTriState.True;
            Column4.SortMode = DataGridViewColumnSortMode.Automatic;
            Column4.Width = 180;
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
            panel3.Controls.Add(dataGridViewInvoice);
            panel3.Location = new Point(27, 139);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1219, 661);
            panel3.TabIndex = 5;
            // 
            // btnAddInvoce
            // 
            btnAddInvoce.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddInvoce.BackColor = Color.LightSkyBlue;
            btnAddInvoce.BackgroundColor = Color.LightSkyBlue;
            btnAddInvoce.BorderColor = Color.PaleVioletRed;
            btnAddInvoce.BorderRadius = 0;
            btnAddInvoce.BorderSize = 0;
            btnAddInvoce.FlatAppearance.BorderSize = 0;
            btnAddInvoce.FlatStyle = FlatStyle.Flat;
            btnAddInvoce.ForeColor = Color.Black;
            btnAddInvoce.Image = Properties.Resources.add1;
            btnAddInvoce.Location = new Point(1079, 15);
            btnAddInvoce.Margin = new Padding(3, 4, 3, 4);
            btnAddInvoce.Name = "btnAddInvoce";
            btnAddInvoce.Size = new Size(128, 37);
            btnAddInvoce.TabIndex = 2;
            btnAddInvoce.Text = "Thêm";
            btnAddInvoce.TextAlign = ContentAlignment.MiddleRight;
            btnAddInvoce.TextColor = Color.Black;
            btnAddInvoce.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddInvoce.UseVisualStyleBackColor = false;
            btnAddInvoce.Click += btnAddInvoce_Click;
            // 
            // labelCustomerTitle
            // 
            labelCustomerTitle.AutoSize = true;
            labelCustomerTitle.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCustomerTitle.Location = new Point(14, 15);
            labelCustomerTitle.Name = "labelCustomerTitle";
            labelCustomerTitle.Size = new Size(268, 25);
            labelCustomerTitle.TabIndex = 0;
            labelCustomerTitle.Text = "Phiếu xuất nguyên liệu";
            labelCustomerTitle.Click += labelCustomerTitle_Click;
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
            panel1.BackColor = Color.White;
            panel1.Controls.Add(listExportDepartMent);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dateOfInvoice);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAddInvoce);
            panel1.Controls.Add(labelCustomerTitle);
            panel1.Location = new Point(27, 20);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1219, 119);
            panel1.TabIndex = 8;
            // 
            // listExportDepartMent
            // 
            listExportDepartMent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listExportDepartMent.FormattingEnabled = true;
            listExportDepartMent.Location = new Point(424, 64);
            listExportDepartMent.Margin = new Padding(3, 4, 3, 4);
            listExportDepartMent.Name = "listExportDepartMent";
            listExportDepartMent.Size = new Size(138, 36);
            listExportDepartMent.TabIndex = 6;
            listExportDepartMent.SelectedIndexChanged += listExportDepartMent_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(336, 73);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 5;
            label2.Text = "Xuất cho";
            // 
            // dateOfInvoice
            // 
            dateOfInvoice.BorderColor = Color.PaleVioletRed;
            dateOfInvoice.BorderSize = 0;
            dateOfInvoice.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dateOfInvoice.Location = new Point(72, 64);
            dateOfInvoice.Margin = new Padding(3, 4, 3, 4);
            dateOfInvoice.MinimumSize = new Size(4, 35);
            dateOfInvoice.Name = "dateOfInvoice";
            dateOfInvoice.Size = new Size(258, 35);
            dateOfInvoice.SkinColor = Color.CornflowerBlue;
            dateOfInvoice.TabIndex = 4;
            dateOfInvoice.TextColor = Color.White;
            dateOfInvoice.ValueChanged += dateOfInvoice_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 73);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 3;
            label1.Text = "Ngày";
            // 
            // timerSearch
            // 
            timerSearch.Interval = 200;
            // 
            // ManagerExportMaterialGo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 246, 249);
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoice).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel3;
        private DataGridView dataGridViewInvoice;
        private BindingSource bindingSource1;
        private Button button2;
        private Label label4;
        private ComponentCustom.RJDatePicker rjDatePicker1;
        private ComponentCustom.RJToggle rjToggle1;
        private Label label3;
        private Button button3;
        private Button button4;
        private ComponentCustom.ButtonCustom buttonCustom1;
        private Label labelCustomerTitle;
        private Button btnSearch;
        private Button button1;
        private ComponentCustom.ButtonCustom buttonCustom2;
        private ComponentCustom.ButtonCustom btnAddInvoce;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private Panel panel1;
        private System.Windows.Forms.Timer timerSearch;
        private ComponentCustom.RJDatePicker dateOfInvoice;
        private Label label1;
        private ComboBox listExportDepartMent;
        private Label label2;
        private DataGridViewTextBoxColumn maHoaDon;
        private DataGridViewTextBoxColumn tongTien;
        private DataGridViewTextBoxColumn soLuong;
        private DataGridViewTextBoxColumn tenBoPhanXuat;
        private DataGridViewImageColumn Column4;
        private DataGridViewImageColumn Column6;
    }
}
