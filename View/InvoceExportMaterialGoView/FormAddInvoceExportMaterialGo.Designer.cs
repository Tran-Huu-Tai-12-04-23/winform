using Syncfusion.Windows.Forms.Chart;

namespace FinalProject_QUANLYKHO.View.InvoceExportMaterialGoView
{
    partial class FormAddInvoceExportMaterialGo
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
            panel2 = new Panel();
            btnSelect = new ComponentCustom.ButtonCustom();
            listExportDepartMent = new ComboBox();
            lbTotalInvoce = new Label();
            label2 = new Label();
            btnCreate = new ComponentCustom.ButtonCustom();
            exportDate = new ComponentCustom.RJDatePicker();
            dataGridCreateInvoice = new DataGridView();
            Column1 = new DataGridViewButtonColumn();
            ton = new DataGridViewTextBoxColumn();
            col2 = new DataGridViewTextBoxColumn();
            col3 = new DataGridViewTextBoxColumn();
            tong = new DataGridViewTextBoxColumn();
            remove = new DataGridViewImageColumn();
            btnSubmit = new ComponentCustom.ButtonCustom();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCreateInvoice).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(28, 38, 45);
            panel2.Controls.Add(btnSelect);
            panel2.Controls.Add(listExportDepartMent);
            panel2.Controls.Add(lbTotalInvoce);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnCreate);
            panel2.Controls.Add(exportDate);
            panel2.Controls.Add(dataGridCreateInvoice);
            panel2.Controls.Add(btnSubmit);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1543, 675);
            panel2.TabIndex = 2;
            // 
            // btnSelect
            // 
            btnSelect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSelect.BackColor = Color.FromArgb(39, 52, 62);
            btnSelect.BackgroundColor = Color.FromArgb(39, 52, 62);
            btnSelect.BorderColor = Color.PaleVioletRed;
            btnSelect.BorderRadius = 6;
            btnSelect.BorderSize = 0;
            btnSelect.FlatAppearance.BorderSize = 0;
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSelect.ForeColor = Color.White;
            btnSelect.Image = Properties.Resources.add;
            btnSelect.Location = new Point(1264, 123);
            btnSelect.Margin = new Padding(3, 4, 3, 4);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(141, 37);
            btnSelect.TabIndex = 45;
            btnSelect.Text = "Thêm hàng";
            btnSelect.TextColor = Color.White;
            btnSelect.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // listExportDepartMent
            // 
            listExportDepartMent.BackColor = Color.FromArgb(39, 52, 62);
            listExportDepartMent.FlatStyle = FlatStyle.Flat;
            listExportDepartMent.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            listExportDepartMent.ForeColor = Color.White;
            listExportDepartMent.Location = new Point(368, 125);
            listExportDepartMent.Margin = new Padding(3, 4, 3, 4);
            listExportDepartMent.MinimumSize = new Size(228, 0);
            listExportDepartMent.Name = "listExportDepartMent";
            listExportDepartMent.Size = new Size(228, 31);
            listExportDepartMent.TabIndex = 44;
            listExportDepartMent.SelectedIndexChanged += listExportDepartMent_SelectedIndexChanged;
            // 
            // lbTotalInvoce
            // 
            lbTotalInvoce.AutoSize = true;
            lbTotalInvoce.BackColor = Color.Transparent;
            lbTotalInvoce.FlatStyle = FlatStyle.Flat;
            lbTotalInvoce.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotalInvoce.ForeColor = Color.FromArgb(21, 147, 255);
            lbTotalInvoce.Location = new Point(661, 125);
            lbTotalInvoce.Name = "lbTotalInvoce";
            lbTotalInvoce.Padding = new Padding(5);
            lbTotalInvoce.Size = new Size(156, 30);
            lbTotalInvoce.TabIndex = 43;
            lbTotalInvoce.Text = "3 000 000 vnd";
            lbTotalInvoce.Click += lbTotalInvoce_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(664, 83);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 42;
            label2.Text = "Tổng tiền";
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreate.BackColor = Color.FromArgb(21, 147, 255);
            btnCreate.BackgroundColor = Color.FromArgb(21, 147, 255);
            btnCreate.BorderColor = Color.PaleVioletRed;
            btnCreate.BorderRadius = 6;
            btnCreate.BorderSize = 0;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.White;
            btnCreate.Image = Properties.Resources.icons8_create_24;
            btnCreate.Location = new Point(1411, 121);
            btnCreate.Margin = new Padding(3, 4, 3, 4);
            btnCreate.MaximumSize = new Size(229, 80);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(107, 37);
            btnCreate.TabIndex = 41;
            btnCreate.Text = "Tạo";
            btnCreate.TextColor = Color.White;
            btnCreate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // exportDate
            // 
            exportDate.BorderColor = Color.PaleVioletRed;
            exportDate.BorderSize = 0;
            exportDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            exportDate.Location = new Point(19, 120);
            exportDate.Margin = new Padding(3, 4, 3, 4);
            exportDate.MinimumSize = new Size(4, 35);
            exportDate.Name = "exportDate";
            exportDate.Size = new Size(310, 35);
            exportDate.SkinColor = Color.FromArgb(39, 52, 62);
            exportDate.TabIndex = 40;
            exportDate.TextColor = Color.White;
            exportDate.ValueChanged += exportDate_ValueChanged;
            // 
            // dataGridCreateInvoice
            // 
            dataGridCreateInvoice.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(28, 38, 45);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(12);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(28, 38, 45);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridCreateInvoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridCreateInvoice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridCreateInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridCreateInvoice.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridCreateInvoice.BackgroundColor = Color.FromArgb(39, 52, 62);
            dataGridCreateInvoice.BorderStyle = BorderStyle.None;
            dataGridCreateInvoice.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridCreateInvoice.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(63, 84, 100);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(0, 12, 0, 12);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(63, 84, 100);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridCreateInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridCreateInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCreateInvoice.Columns.AddRange(new DataGridViewColumn[] { Column1, ton, col2, col3, tong, remove });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(63, 84, 100);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(63, 84, 100);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridCreateInvoice.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridCreateInvoice.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridCreateInvoice.EnableHeadersVisualStyles = false;
            dataGridCreateInvoice.GridColor = Color.FromArgb(28, 38, 45);
            dataGridCreateInvoice.Location = new Point(19, 199);
            dataGridCreateInvoice.Margin = new Padding(0);
            dataGridCreateInvoice.Name = "dataGridCreateInvoice";
            dataGridCreateInvoice.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(39, 52, 62);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(39, 52, 62);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridCreateInvoice.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridCreateInvoice.RowHeadersVisible = false;
            dataGridCreateInvoice.RowHeadersWidth = 60;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(39, 52, 62);
            dataGridViewCellStyle6.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.Padding = new Padding(12);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(39, 52, 62);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(51, 145, 238);
            dataGridCreateInvoice.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridCreateInvoice.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridCreateInvoice.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(39, 52, 62);
            dataGridCreateInvoice.RowTemplate.DefaultCellStyle.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridCreateInvoice.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dataGridCreateInvoice.RowTemplate.DefaultCellStyle.Padding = new Padding(12);
            dataGridCreateInvoice.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(63, 84, 100);
            dataGridCreateInvoice.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridCreateInvoice.RowTemplate.Height = 30;
            dataGridCreateInvoice.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridCreateInvoice.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridCreateInvoice.Size = new Size(1499, 449);
            dataGridCreateInvoice.StandardTab = true;
            dataGridCreateInvoice.TabIndex = 39;
            dataGridCreateInvoice.CellContentClick += createInvoce_CellContentClick_1;
            dataGridCreateInvoice.CellValueChanged += dataGridView1_CellValueChanged;
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
            Column1.HeaderText = "Nguyên liệu";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Resizable = DataGridViewTriState.True;
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
            col2.HeaderText = "Loại nguyên liệu";
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
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Bottom;
            btnSubmit.BackColor = Color.LightSkyBlue;
            btnSubmit.BackgroundColor = Color.LightSkyBlue;
            btnSubmit.BorderColor = Color.PaleVioletRed;
            btnSubmit.BorderRadius = 6;
            btnSubmit.BorderSize = 0;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(1174, 1721);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(133, 40);
            btnSubmit.TabIndex = 38;
            btnSubmit.Text = "Tạo";
            btnSubmit.TextColor = Color.White;
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(368, 83);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 23;
            label4.Text = "Xuất cho";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(19, 83);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 21;
            label3.Text = "Ngày Xuất";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(19, 25);
            label1.Name = "label1";
            label1.Size = new Size(442, 29);
            label1.TabIndex = 17;
            label1.Text = "Tạo hóa đơn xuất nguyên liệu đi";
            // 
            // FormAddInvoceExportMaterialGo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 246, 249);
            ClientSize = new Size(1543, 675);
            Controls.Add(panel2);
            HelpButton = true;
            ImeMode = ImeMode.Off;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAddInvoceExportMaterialGo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModalAddCustomer";
            TopMost = true;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCreateInvoice).EndInit();
            ResumeLayout(false);
        }


        #endregion
        private DataGridViewComboBoxColumn tenBanh;
        private Panel panel2;
        private ComponentCustom.ButtonCustom btnCreate;
        private ComponentCustom.RJDatePicker exportDate;
        private DataGridView dataGridCreateInvoice;
        private ComponentCustom.ButtonCustom btnSubmit;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label lbTotalInvoce;
        private Label label2;
        private ComboBox listExportDepartMent;
        private ComponentCustom.ButtonCustom btnSelect;
        private DataGridViewButtonColumn Column1;
        private DataGridViewTextBoxColumn ton;
        private DataGridViewTextBoxColumn col2;
        private DataGridViewTextBoxColumn col3;
        private DataGridViewTextBoxColumn tong;
        private DataGridViewImageColumn remove;
    }
}