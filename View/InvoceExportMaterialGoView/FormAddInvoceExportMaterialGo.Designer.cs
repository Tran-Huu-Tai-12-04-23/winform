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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel2 = new Panel();
            lbTotalInvoce = new Label();
            label2 = new Label();
            btnCreate = new ComponentCustom.ButtonCustom();
            exportDate = new ComponentCustom.RJDatePicker();
            createInvoce = new DataGridView();
            Column1 = new DataGridViewComboBoxColumn();
            ton = new DataGridViewTextBoxColumn();
            col2 = new DataGridViewTextBoxColumn();
            col3 = new DataGridViewTextBoxColumn();
            tong = new DataGridViewTextBoxColumn();
            remove = new DataGridViewImageColumn();
            btnSubmit = new ComponentCustom.ButtonCustom();
            listExportDepartMent = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)createInvoce).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(lbTotalInvoce);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnCreate);
            panel2.Controls.Add(exportDate);
            panel2.Controls.Add(createInvoce);
            panel2.Controls.Add(btnSubmit);
            panel2.Controls.Add(listExportDepartMent);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1254, 639);
            panel2.TabIndex = 2;
            // 
            // lbTotalInvoce
            // 
            lbTotalInvoce.AutoSize = true;
            lbTotalInvoce.BackColor = Color.FromArgb(128, 128, 255);
            lbTotalInvoce.FlatStyle = FlatStyle.Flat;
            lbTotalInvoce.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTotalInvoce.ForeColor = Color.White;
            lbTotalInvoce.Location = new Point(822, 89);
            lbTotalInvoce.Name = "lbTotalInvoce";
            lbTotalInvoce.Padding = new Padding(4);
            lbTotalInvoce.Size = new Size(133, 26);
            lbTotalInvoce.TabIndex = 43;
            lbTotalInvoce.Text = "3 000 000 vnd";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(241, 246, 249);
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(822, 62);
            label2.Name = "label2";
            label2.Size = new Size(86, 18);
            label2.TabIndex = 42;
            label2.Text = "Tổng tiền";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.MediumSlateBlue;
            btnCreate.BackgroundColor = Color.MediumSlateBlue;
            btnCreate.BorderColor = Color.PaleVioletRed;
            btnCreate.BorderRadius = 6;
            btnCreate.BorderSize = 0;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(977, 83);
            btnCreate.MaximumSize = new Size(200, 60);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(93, 32);
            btnCreate.TabIndex = 41;
            btnCreate.Text = "Tạo";
            btnCreate.TextColor = Color.White;
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // exportDate
            // 
            exportDate.BorderColor = Color.PaleVioletRed;
            exportDate.BorderSize = 0;
            exportDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            exportDate.Location = new Point(17, 83);
            exportDate.MinimumSize = new Size(4, 35);
            exportDate.Name = "exportDate";
            exportDate.Size = new Size(272, 35);
            exportDate.SkinColor = Color.MediumSlateBlue;
            exportDate.TabIndex = 40;
            exportDate.TextColor = Color.White;
            // 
            // createInvoce
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Padding = new Padding(12);
            createInvoce.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            createInvoce.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            createInvoce.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            createInvoce.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            createInvoce.BackgroundColor = Color.White;
            createInvoce.BorderStyle = BorderStyle.None;
            createInvoce.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            createInvoce.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Padding = new Padding(0, 12, 0, 12);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            createInvoce.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            createInvoce.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            createInvoce.Columns.AddRange(new DataGridViewColumn[] { Column1, ton, col2, col3, tong, remove });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle3.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            createInvoce.DefaultCellStyle = dataGridViewCellStyle3;
            createInvoce.EditMode = DataGridViewEditMode.EditOnEnter;
            createInvoce.EnableHeadersVisualStyles = false;
            createInvoce.GridColor = Color.White;
            createInvoce.Location = new Point(17, 130);
            createInvoce.Margin = new Padding(0);
            createInvoce.Name = "createInvoce";
            createInvoce.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            createInvoce.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            createInvoce.RowHeadersWidth = 60;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.Padding = new Padding(6, 0, 0, 0);
            createInvoce.RowsDefaultCellStyle = dataGridViewCellStyle5;
            createInvoce.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            createInvoce.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            createInvoce.RowTemplate.DefaultCellStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            createInvoce.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            createInvoce.RowTemplate.DefaultCellStyle.Padding = new Padding(6, 0, 0, 0);
            createInvoce.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.AliceBlue;
            createInvoce.RowTemplate.Height = 40;
            createInvoce.RowTemplate.Resizable = DataGridViewTriState.True;
            createInvoce.Size = new Size(1216, 489);
            createInvoce.StandardTab = true;
            createInvoce.TabIndex = 39;
            createInvoce.CellContentClick += createInvoce_CellContentClick_1;
            createInvoce.CellValueChanged += dataGridView1_CellValueChanged;
            createInvoce.RowsAdded += createInvoce_RowsAdded;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Nguyên liệu";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
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
            remove.Name = "remove";
            remove.Resizable = DataGridViewTriState.True;
            remove.SortMode = DataGridViewColumnSortMode.Automatic;
            remove.Width = 60;
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
            btnSubmit.Location = new Point(979, 1424);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(116, 30);
            btnSubmit.TabIndex = 38;
            btnSubmit.Text = "Tạo";
            btnSubmit.TextColor = Color.White;
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // listExportDepartMent
            // 
            listExportDepartMent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listExportDepartMent.FormattingEnabled = true;
            listExportDepartMent.Location = new Point(322, 89);
            listExportDepartMent.Name = "listExportDepartMent";
            listExportDepartMent.Size = new Size(485, 29);
            listExportDepartMent.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(241, 246, 249);
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(322, 62);
            label4.Name = "label4";
            label4.Size = new Size(80, 18);
            label4.TabIndex = 23;
            label4.Text = "Xuất cho";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(241, 246, 249);
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(17, 62);
            label3.Name = "label3";
            label3.Size = new Size(93, 18);
            label3.TabIndex = 21;
            label3.Text = "Ngày Xuất";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 19);
            label1.Name = "label1";
            label1.Size = new Size(361, 23);
            label1.TabIndex = 17;
            label1.Text = "Tạo hóa đơn xuất nguyên liệu đi";
            // 
            // FormAddInvoceExportMaterialGo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 246, 249);
            ClientSize = new Size(1254, 639);
            Controls.Add(panel2);
            HelpButton = true;
            ImeMode = ImeMode.Off;
            Name = "FormAddInvoceExportMaterialGo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModalAddCustomer";
            TopMost = true;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)createInvoce).EndInit();
            ResumeLayout(false);
        }


        #endregion
        private DataGridViewComboBoxColumn tenBanh;
        private Panel panel2;
        private ComponentCustom.ButtonCustom btnCreate;
        private ComponentCustom.RJDatePicker exportDate;
        private DataGridView createInvoce;
        private ComponentCustom.ButtonCustom btnSubmit;
        private ComboBox listExportDepartMent;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label lbTotalInvoce;
        private Label label2;
        private DataGridViewComboBoxColumn Column1;
        private DataGridViewTextBoxColumn ton;
        private DataGridViewTextBoxColumn col2;
        private DataGridViewTextBoxColumn col3;
        private DataGridViewTextBoxColumn tong;
        private DataGridViewImageColumn remove;
    }
}